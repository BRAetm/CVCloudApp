using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using LabsVision.Core;

namespace LabsVision.UI.ViewModels;

/// <summary>ViewModel for the floating CV preview window showing the live session capture feed.</summary>
public class CvWindowViewModel : INotifyPropertyChanged, IDisposable
{
    private const double TargetFps       = 30.0;
    private const int    FpsAverageFrames = 30;

    private readonly CloudSession    _session;
    private readonly DispatcherTimer _feedTimer;

    private BitmapSource? _liveFeed;
    private string        _scriptName  = string.Empty;
    private string        _fpsDisplay  = "-- fps";
    private string        _overlayLine = string.Empty;

    // FPS tracking
    private DateTime _lastTick    = DateTime.UtcNow;
    private int      _frameCount  = 0;
    private double   _currentFps  = 0;

    // ---------------------------------------------------------------------------
    // Construction
    // ---------------------------------------------------------------------------

    public CvWindowViewModel(CloudSession session)
    {
        _session   = session;
        WindowTitle = $"Session #{session.SessionId} — {session.WindowTitle}";

        _feedTimer = new DispatcherTimer
        {
            Interval = TimeSpan.FromMilliseconds(1000.0 / TargetFps)
        };
        _feedTimer.Tick += (_, _) => OnFeedTick();
    }

    // ---------------------------------------------------------------------------
    // Bindable properties
    // ---------------------------------------------------------------------------

    /// <summary>Window title bar text: "Session #X — [tab title]".</summary>
    public string WindowTitle { get; }

    /// <summary>Session slot index, displayed in the overlay.</summary>
    public int SessionId => _session.SessionId;

    /// <summary>Full-resolution live capture feed, updated at ~30fps.</summary>
    public BitmapSource? LiveFeed
    {
        get => _liveFeed;
        private set { _liveFeed = value; OnPropertyChanged(); }
    }

    /// <summary>Script name shown in the overlay, empty when no script is running.</summary>
    public string ScriptName
    {
        get => _scriptName;
        private set { _scriptName = value; OnPropertyChanged(); UpdateOverlay(); }
    }

    /// <summary>Formatted FPS string shown in the overlay.</summary>
    public string FpsDisplay
    {
        get => _fpsDisplay;
        private set { _fpsDisplay = value; OnPropertyChanged(); UpdateOverlay(); }
    }

    /// <summary>Composite overlay line: "#{id}  {fps}  {script}".</summary>
    public string OverlayLine
    {
        get => _overlayLine;
        private set { _overlayLine = value; OnPropertyChanged(); }
    }

    // ---------------------------------------------------------------------------
    // Lifecycle
    // ---------------------------------------------------------------------------

    /// <summary>Starts the 30fps live feed timer.</summary>
    public void StartFeed() => _feedTimer.Start();

    /// <summary>Stops the live feed timer and releases capture resources.</summary>
    public void StopFeed() => _feedTimer.Stop();

    /// <summary>Updates the overlay script name (called by MainViewModel when script state changes).</summary>
    public void SetScriptName(string name) => ScriptName = name;

    /// <summary>Stops the feed timer and releases resources.</summary>
    public void Dispose() => _feedTimer.Stop();

    // ---------------------------------------------------------------------------
    // Feed tick
    // ---------------------------------------------------------------------------

    private void OnFeedTick()
    {
        GrabFullFrame();
        UpdateFps();
    }

    private void GrabFullFrame()
    {
        var region = _session.CaptureRegion;
        if (region.Width <= 0 || region.Height <= 0) return;

        try
        {
            using var bmp = new Bitmap(region.Width, region.Height);
            using var g   = Graphics.FromImage(bmp);
            var hdc       = g.GetHdc();
            PrintWindow(_session.Hwnd, hdc, PwRenderFullContent);
            g.ReleaseHdc(hdc);
            LiveFeed = ToBitmapSource(bmp);
        }
        catch
        {
            // Window may be minimised or closed — skip frame silently
        }
    }

    private void UpdateFps()
    {
        _frameCount++;
        var now     = DateTime.UtcNow;
        var elapsed = (now - _lastTick).TotalSeconds;

        if (_frameCount >= FpsAverageFrames)
        {
            _currentFps  = _frameCount / elapsed;
            FpsDisplay   = $"{_currentFps:F0} fps";
            _frameCount  = 0;
            _lastTick    = now;
        }
    }

    private void UpdateOverlay()
    {
        var script = string.IsNullOrEmpty(ScriptName) ? "no script" : ScriptName;
        OverlayLine = $"#{_session.SessionId}  {FpsDisplay}  {script}";
    }

    // ---------------------------------------------------------------------------
    // Helpers
    // ---------------------------------------------------------------------------

    private static BitmapSource ToBitmapSource(Bitmap bmp)
    {
        var handle = bmp.GetHbitmap();
        try
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                handle,
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }
        finally
        {
            DeleteObject(handle);
        }
    }

    private const uint PwRenderFullContent = 0x00000002;

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool PrintWindow(nint hwnd, IntPtr hdc, uint flags);

    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    private static extern bool DeleteObject(IntPtr hObject);

    // ---------------------------------------------------------------------------
    // INotifyPropertyChanged
    // ---------------------------------------------------------------------------

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
