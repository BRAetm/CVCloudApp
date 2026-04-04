using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVCloudApp.Core;

/// <summary>Info about a discovered application window.</summary>
public record AppWindowInfo(nint Hwnd, string Title, string ProcessName, int Pid);

/// <summary>
/// Captures frames from any application window using BitBlt (PrintWindow).
/// Used for Xbox Remote Play app, PS Remote Play app, or any other windowed game.
/// Similar to Helios's XboxRemotePlay.dll and PSRemotePlay.dll capture backend.
/// </summary>
public class WindowCaptureSource : IFrameSource
{
    private readonly int _sessionId;
    private readonly nint _hwnd;
    private readonly string _windowTitle;

    private CancellationTokenSource? _cts;
    private Task? _captureLoop;
    private volatile bool _isCapturing;

    public InputSourceType SourceType => InputSourceType.WindowCapture;
    public string SourceName => _windowTitle;
    public bool IsCapturing => _isCapturing;
    public int TargetFps { get; set; } = 30;

    public event Action<int, byte[]>? FrameReady;

    public WindowCaptureSource(int sessionId, nint hwnd, string windowTitle)
    {
        _sessionId = sessionId;
        _hwnd = hwnd;
        _windowTitle = windowTitle;
    }

    // ---------------------------------------------------------------------------
    // Window Discovery
    // ---------------------------------------------------------------------------

    /// <summary>Finds Xbox Remote Play (Xbox app) windows.</summary>
    public static List<AppWindowInfo> FindXboxRemotePlay()
    {
        // Xbox app runs as "XboxPcApp" or "GameBar", window title often contains "Xbox"
        var results = new List<AppWindowInfo>();
        var all = ListAllWindows();
        foreach (var w in all)
        {
            var proc = w.ProcessName.ToLowerInvariant();
            var title = w.Title.ToLowerInvariant();
            if (proc == "xboxpcapp" || proc == "xbox" || proc == "gamebar" ||
                proc == "xboxapp" || proc == "msxboxapp" ||
                title.Contains("xbox") || title.Contains("remote play"))
            {
                results.Add(w);
            }
        }
        return results;
    }

    /// <summary>Finds PS Remote Play (chiaki-ng or official app) windows.</summary>
    public static List<AppWindowInfo> FindPsRemotePlay()
    {
        var results = new List<AppWindowInfo>();
        var all = ListAllWindows();
        foreach (var w in all)
        {
            var proc = w.ProcessName.ToLowerInvariant();
            var title = w.Title.ToLowerInvariant();
            if (proc.Contains("chiaki") || proc.Contains("remoteplay") || proc.Contains("psremote") ||
                title.Contains("remote play") || title.Contains("chiaki") || title.Contains("playstation"))
            {
                results.Add(w);
            }
        }
        return results;
    }

    /// <summary>Finds any visible window matching the given keywords.</summary>
    public static List<AppWindowInfo> FindWindowsByKeywords(params string[] keywords)
    {
        var results = new List<AppWindowInfo>();

        EnumWindows((hwnd, _) =>
        {
            if (!IsWindowVisible(hwnd)) return true;

            var sb = new StringBuilder(512);
            GetWindowText(hwnd, sb, sb.Capacity);
            var title = sb.ToString();
            if (string.IsNullOrWhiteSpace(title)) return true;

            // Match against keywords
            bool match = false;
            foreach (var kw in keywords)
            {
                if (title.Contains(kw, StringComparison.OrdinalIgnoreCase))
                {
                    match = true;
                    break;
                }
            }

            if (!match)
            {
                // Also check process name
                GetWindowThreadProcessId(hwnd, out uint pid);
                try
                {
                    using var proc = Process.GetProcessById((int)pid);
                    foreach (var kw in keywords)
                    {
                        if (proc.ProcessName.Contains(kw, StringComparison.OrdinalIgnoreCase))
                        {
                            match = true;
                            break;
                        }
                    }

                    if (match)
                        results.Add(new AppWindowInfo(hwnd, title, proc.ProcessName, (int)pid));
                }
                catch { }
            }
            else
            {
                GetWindowThreadProcessId(hwnd, out uint pid);
                string procName = "";
                try { using var p = Process.GetProcessById((int)pid); procName = p.ProcessName; } catch { }
                results.Add(new AppWindowInfo(hwnd, title, procName, (int)pid));
            }

            return true;
        }, nint.Zero);

        return results;
    }

    /// <summary>Lists all visible windows with titles (for the "pick a window" UI).</summary>
    public static List<AppWindowInfo> ListAllWindows()
    {
        var results = new List<AppWindowInfo>();

        EnumWindows((hwnd, _) =>
        {
            if (!IsWindowVisible(hwnd)) return true;

            var sb = new StringBuilder(512);
            GetWindowText(hwnd, sb, sb.Capacity);
            var title = sb.ToString();
            if (string.IsNullOrWhiteSpace(title)) return true;

            GetWindowThreadProcessId(hwnd, out uint pid);
            string procName = "";
            try { using var p = Process.GetProcessById((int)pid); procName = p.ProcessName; } catch { }
            results.Add(new AppWindowInfo(hwnd, title, procName, (int)pid));
            return true;
        }, nint.Zero);

        return results;
    }

    // ---------------------------------------------------------------------------
    // IFrameSource
    // ---------------------------------------------------------------------------

    public Task StartAsync()
    {
        if (_isCapturing) return Task.CompletedTask;

        if (!IsWindow(_hwnd))
            throw new InvalidOperationException($"Window handle 0x{_hwnd:X} is no longer valid");

        _cts = new CancellationTokenSource();
        _isCapturing = true;
        _captureLoop = Task.Factory.StartNew(
            () => CaptureLoop(_cts.Token),
            _cts.Token,
            TaskCreationOptions.LongRunning,
            TaskScheduler.Default);

        Console.WriteLine($"[WindowCapture] Session {_sessionId}: Started capturing '{_windowTitle}' at {TargetFps}fps");
        return Task.CompletedTask;
    }

    public Task StopAsync()
    {
        _isCapturing = false;
        _cts?.Cancel();
        try { _captureLoop?.Wait(TimeSpan.FromSeconds(2)); } catch { }
        _cts?.Dispose();
        _cts = null;

        Console.WriteLine($"[WindowCapture] Session {_sessionId}: Stopped.");
        return Task.CompletedTask;
    }

    // ---------------------------------------------------------------------------
    // Capture Loop (BitBlt/PrintWindow)
    // ---------------------------------------------------------------------------

    private void CaptureLoop(CancellationToken ct)
    {
        int frameCount = 0;
        double frameInterval = 1000.0 / TargetFps;
        var sw = Stopwatch.StartNew();

        while (!ct.IsCancellationRequested)
        {
            var frameStart = sw.ElapsedMilliseconds;

            try
            {
                if (!IsWindow(_hwnd))
                {
                    Console.WriteLine($"[WindowCapture] Session {_sessionId}: Window closed.");
                    break;
                }

                var jpegBytes = CaptureWindowToJpeg(_hwnd);
                if (jpegBytes is not null && jpegBytes.Length > 0)
                {
                    FrameReady?.Invoke(_sessionId, jpegBytes);
                    frameCount++;
                    if (frameCount <= 3 || frameCount % 100 == 0)
                        Console.WriteLine($"[WindowCapture] Session {_sessionId}: Frame #{frameCount} ({jpegBytes.Length} bytes)");
                }
            }
            catch (Exception ex)
            {
                if (!ct.IsCancellationRequested)
                    Console.WriteLine($"[WindowCapture] Session {_sessionId}: Error: {ex.Message}");
            }

            var elapsed = sw.ElapsedMilliseconds - frameStart;
            var sleepMs = (int)(frameInterval - elapsed);
            if (sleepMs > 0) Thread.Sleep(sleepMs);
        }

        Console.WriteLine($"[WindowCapture] Session {_sessionId}: Loop ended ({frameCount} frames)");
    }

    /// <summary>Captures a window to JPEG bytes using PrintWindow + GDI.</summary>
    private static byte[]? CaptureWindowToJpeg(nint hwnd)
    {
        if (!GetClientRect(hwnd, out RECT rect)) return null;
        int width = rect.Right - rect.Left;
        int height = rect.Bottom - rect.Top;
        if (width <= 0 || height <= 0) return null;

        nint hdcWindow = GetDC(hwnd);
        nint hdcMem = CreateCompatibleDC(hdcWindow);
        nint hBitmap = CreateCompatibleBitmap(hdcWindow, width, height);
        nint hOld = SelectObject(hdcMem, hBitmap);

        // PrintWindow with PW_RENDERFULLCONTENT for DWM-composited windows
        PrintWindow(hwnd, hdcMem, 0x00000002);

        SelectObject(hdcMem, hOld);

        byte[]? result = null;
        try
        {
            using var bmp = Image.FromHbitmap(hBitmap);
            using var ms = new MemoryStream();
            var jpegEncoder = ImageCodecInfo.GetImageEncoders()[1]; // JPEG
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 70L);
            bmp.Save(ms, jpegEncoder, encoderParams);
            result = ms.ToArray();
        }
        catch { }

        DeleteObject(hBitmap);
        DeleteDC(hdcMem);
        ReleaseDC(hwnd, hdcWindow);

        return result;
    }

    public void Dispose()
    {
        StopAsync().Wait(TimeSpan.FromSeconds(2));
    }

    // ---------------------------------------------------------------------------
    // P/Invoke
    // ---------------------------------------------------------------------------

    private delegate bool EnumWindowsProc(nint hwnd, nint lParam);

    [DllImport("user32.dll")] private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, nint lParam);
    [DllImport("user32.dll", CharSet = CharSet.Unicode)] private static extern int GetWindowText(nint hWnd, StringBuilder text, int count);
    [DllImport("user32.dll")] private static extern bool IsWindowVisible(nint hWnd);
    [DllImport("user32.dll")] private static extern bool IsWindow(nint hWnd);
    [DllImport("user32.dll")] private static extern uint GetWindowThreadProcessId(nint hWnd, out uint lpdwProcessId);
    [DllImport("user32.dll")] private static extern bool GetClientRect(nint hWnd, out RECT lpRect);
    [DllImport("user32.dll")] private static extern nint GetDC(nint hWnd);
    [DllImport("user32.dll")] private static extern int ReleaseDC(nint hWnd, nint hDC);
    [DllImport("user32.dll")] private static extern bool PrintWindow(nint hWnd, nint hdcBlt, uint nFlags);
    [DllImport("gdi32.dll")] private static extern nint CreateCompatibleDC(nint hdc);
    [DllImport("gdi32.dll")] private static extern nint CreateCompatibleBitmap(nint hdc, int width, int height);
    [DllImport("gdi32.dll")] private static extern nint SelectObject(nint hdc, nint h);
    [DllImport("gdi32.dll")] private static extern bool DeleteDC(nint hdc);
    [DllImport("gdi32.dll")] private static extern bool DeleteObject(nint ho);

    [StructLayout(LayoutKind.Sequential)]
    private struct RECT { public int Left, Top, Right, Bottom; }
}
