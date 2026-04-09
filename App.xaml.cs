using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows;
using LabsVision.Core;
using LabsVision.UI.ViewModels;

namespace LabsVision;

/// <summary>Application entry point — composes the dependency graph and opens MainWindow.</summary>
public partial class App : Application
{
    private SessionManager?       _sessionManager;
    private VirtualPadManager?    _padManager;
    private CvWorkerHost?         _workerHost;
    private WebViewSessionHost?   _webViewHost;
    private GamepadInputRelay?    _inputRelay;
    private FramePublisher?       _framePublisher;
    private TitanBridge?          _titanBridge;
    private GpcRunner?            _gpcRunner;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // Catch all unhandled exceptions so we can see what crashed
        AppDomain.CurrentDomain.UnhandledException += (s, args) =>
        {
            var ex = args.ExceptionObject as Exception;
            var crashLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "cvccloud", "crash.log");
            try { Directory.CreateDirectory(Path.GetDirectoryName(crashLog)!); File.WriteAllText(crashLog, $"[{DateTime.Now}] UNHANDLED:\n{ex}"); } catch { }
            Console.Error.WriteLine($"[CRASH] {ex}");
        };
        DispatcherUnhandledException += (s, args) =>
        {
            var crashLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "cvccloud", "crash.log");
            try { Directory.CreateDirectory(Path.GetDirectoryName(crashLog)!); File.AppendAllText(crashLog, $"[{DateTime.Now}] DISPATCHER:\n{args.Exception}\n\n"); } catch { }
            Console.Error.WriteLine($"[CRASH] {args.Exception}");
            // Don't set args.Handled — let non-fatal errors bubble but log them
        };

        // Helios-style performance: boost process priority + disable power throttling
        SetPerformanceOptimizations();

        // Clear stale debug logs from previous run
        var logDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "cvccloud");
        Directory.CreateDirectory(logDir);
        ClearLogFile(Path.Combine(logDir, "worker_debug.log"));
        ClearLogFile(Path.Combine(logDir, "wgc_debug.log"));

        // Kill any stale LabsVision processes that may be holding ZMQ ports
        KillStalePorts(5580, 5590);

        _sessionManager = new SessionManager();
        _padManager     = new VirtualPadManager();
        _workerHost     = new CvWorkerHost();
        _webViewHost    = new WebViewSessionHost();
        _inputRelay     = new GamepadInputRelay(_webViewHost);

        _padManager.Initialize();

        _framePublisher = new FramePublisher();
        _framePublisher.Start();
        SessionViewModel.SharedFramePublisher = _framePublisher;
        SessionViewModel.SharedWebViewHost = _webViewHost;

        // Titan/Cronus device bridge
        _titanBridge = new TitanBridge();
        var titanDevices = TitanBridge.ScanDevices();
        if (titanDevices.Count > 0)
        {
            Console.WriteLine($"[App] Found {titanDevices.Count} Titan/Cronus device(s):");
            foreach (var d in titanDevices)
                Console.WriteLine($"[App]   {d.Name} ({d.Type})");
            _titanBridge.ConnectAuto();
        }
        else
        {
            Console.WriteLine("[App] No Titan/Cronus devices found (USB output disabled).");
        }

        // GPC3 script runner
        _gpcRunner = new GpcRunner();
        Console.WriteLine($"[App] GPC3 tools available: {GpcRunner.IsAvailable()}");

        var vm     = new MainViewModel(_sessionManager, _padManager, _workerHost,
                                       _webViewHost, _inputRelay, _titanBridge, _gpcRunner);
        var window = new MainWindow(vm);
        window.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _gpcRunner?.DisposeAsync().AsTask().Wait(TimeSpan.FromSeconds(2));
        _titanBridge?.Dispose();
        _framePublisher?.Dispose();
        _inputRelay?.Dispose();
        _workerHost?.DisposeAsync().AsTask().Wait(TimeSpan.FromSeconds(3));
        _webViewHost?.DisposeAsync().AsTask().Wait(TimeSpan.FromSeconds(3));
        _padManager?.Dispose();
        _sessionManager?.Dispose();

        // Force NetMQ to release all sockets so ports are freed immediately
        NetMQ.NetMQConfig.Cleanup(block: false);

        base.OnExit(e);
    }

    /// <summary>Kills any process holding the given TCP ports to prevent AddressAlreadyInUse on restart.</summary>
    private static void KillStalePorts(params int[] ports)
    {
        try
        {
            var myPid = Environment.ProcessId;
            var listeners = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
            foreach (var port in ports)
            {
                if (!listeners.Any(ep => ep.Port == port)) continue;

                // Find PID via netstat
                var psi = new ProcessStartInfo("netstat", "-ano")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };
                var proc = Process.Start(psi);
                if (proc is null) continue;
                var output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit(3000);

                foreach (var line in output.Split('\n'))
                {
                    if (!line.Contains($":{port}") || !line.Contains("LISTENING")) continue;
                    var parts = line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 5 && int.TryParse(parts[^1], out var pid) && pid != myPid)
                    {
                        try
                        {
                            Process.GetProcessById(pid).Kill();
                            Console.WriteLine($"[App] Killed stale process {pid} holding port {port}.");
                        }
                        catch { }
                    }
                }
            }
            // Give OS time to release ports
            System.Threading.Thread.Sleep(500);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[App] KillStalePorts error: {ex.Message}");
        }
    }

    /// <summary>Boosts process priority and disables power throttling (ported from Helios GCVLauncher).</summary>
    private static void SetPerformanceOptimizations()
    {
        try
        {
            // Set process priority to Above Normal (matches Helios ABOVE_NORMAL_PRIORITY_CLASS)
            using var proc = Process.GetCurrentProcess();
            proc.PriorityClass = ProcessPriorityClass.AboveNormal;
            Console.WriteLine("[App] Process priority set to AboveNormal.");

            // Disable power throttling via SetProcessInformation (Helios pattern)
            DisablePowerThrottling();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[App] Performance optimization failed (non-fatal): {ex.Message}");
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct PROCESS_POWER_THROTTLING_STATE
    {
        public uint Version;
        public uint ControlMask;
        public uint StateMask;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetProcessInformation(
        nint hProcess, int ProcessInformationClass,
        ref PROCESS_POWER_THROTTLING_STATE info, int size);

    private static void DisablePowerThrottling()
    {
        try
        {
            const int ProcessPowerThrottling = 4;
            const uint PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1;
            const uint PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

            var state = new PROCESS_POWER_THROTTLING_STATE
            {
                Version = PROCESS_POWER_THROTTLING_CURRENT_VERSION,
                ControlMask = PROCESS_POWER_THROTTLING_EXECUTION_SPEED,
                StateMask = 0 // 0 = disable throttling
            };

            using var proc = Process.GetCurrentProcess();
            SetProcessInformation(proc.Handle, ProcessPowerThrottling, ref state, Marshal.SizeOf(state));
            Console.WriteLine("[App] Power throttling disabled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[App] DisablePowerThrottling failed (non-fatal): {ex.Message}");
        }
    }

    private static void ClearLogFile(string path)
    {
        try { File.WriteAllText(path, $"=== LabsVision started {DateTime.Now:yyyy-MM-dd HH:mm:ss} ==={Environment.NewLine}"); } catch { }
    }
}
