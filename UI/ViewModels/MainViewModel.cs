using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using CVCloudApp.Core;
using CVCloudApp.Models;
using CVCloudApp.UI.Views;


namespace CVCloudApp.UI.ViewModels;

/// <summary>File-based debug logging for WGC pipeline.</summary>
static class DebugLog
{
    private static readonly string _path = @"C:\Users\brael\Documents\cvccloud\wgc_debug.log";
    public static void Write(string msg)
    {
        var line = $"[{DateTime.Now:HH:mm:ss.fff}] {msg}";
        Console.WriteLine(line);
        try { File.AppendAllText(_path, line + Environment.NewLine); } catch { }
    }
}

/// <summary>Root ViewModel — manages 10 fixed feed slots, session lifecycle, and script controls.</summary>
public class MainViewModel : INotifyPropertyChanged
{
    private const int MaxSessions    = 10;
    private const int ZmqBasePort    = 5560;
    private readonly SessionManager        _sessionManager;
    private readonly VirtualPadManager     _padManager;
    private readonly CvWorkerHost          _workerHost;
    private readonly WebViewSessionHost    _webViewHost;
    private readonly GamepadInputRelay     _inputRelay;
    private readonly TitanBridge           _titanBridge;
    private readonly GpcRunner             _gpcRunner;
    private readonly Dispatcher            _dispatcher;

    private bool              _isAddingSession;
    private SessionViewModel? _selectedSession;
    private bool              _isCvBuilderOpen;

    // ---------------------------------------------------------------------------
    // Construction
    // ---------------------------------------------------------------------------

    public MainViewModel(SessionManager sessionManager, VirtualPadManager padManager,
                         CvWorkerHost workerHost, WebViewSessionHost webViewHost,
                         GamepadInputRelay inputRelay, TitanBridge titanBridge,
                         GpcRunner gpcRunner)
    {
        _sessionManager = sessionManager;
        _padManager     = padManager;
        _workerHost     = workerHost;
        _webViewHost    = webViewHost;
        _inputRelay     = inputRelay;
        _titanBridge    = titanBridge;
        _gpcRunner      = gpcRunner;
        _dispatcher     = Dispatcher.CurrentDispatcher;

        _workerHost.StateReceived += (sessionId, state) =>
        {
            // Send to WebView2 (cloud gaming)
            _dispatcher.BeginInvoke(() => _webViewHost.SendInput(sessionId, state));
            // Also send to Titan/Cronus if connected
            if (_titanBridge.IsConnected)
                _titanBridge.SendState(state);
        };

        _workerHost.WorkerDied += OnWorkerDied;
        _workerHost.WorkerRestarted += OnWorkerRestarted;

        // Start the ZMQ SUB socket for receiving gamepad input from Python scripts
        _inputRelay.Start();

        // Pre-populate 10 fixed feed slots
        Slots = new ObservableCollection<SessionViewModel>();
        for (int i = 0; i < MaxSessions; i++)
            Slots.Add(new SessionViewModel(i));

        AddSessionCommand = new RelayCommand(
            async () => await AddSessionAsync(),
            () => !IsAddingSession && Slots.Any(s => !s.IsOccupied));

        // Filtered view — only occupied slots appear in the feed grid
        OccupiedSlots = CollectionViewSource.GetDefaultView(Slots);
        OccupiedSlots.Filter = obj => obj is SessionViewModel vm && vm.IsOccupied;

        CvBuilder = new CvBuilderViewModel(Slots);
        ToggleCvBuilderCommand = new RelayCommand(() => IsCvBuilderOpen = !IsCvBuilderOpen);
    }

    // ---------------------------------------------------------------------------
    // Bindable properties
    // ---------------------------------------------------------------------------

    /// <summary>All 4 feed slots — always has 4 items.</summary>
    public ObservableCollection<SessionViewModel> Slots { get; }

    /// <summary>Filtered view containing only occupied slots for the feed grid.</summary>
    public System.ComponentModel.ICollectionView OccupiedSlots { get; }

    /// <summary>Number of UniformGrid columns based on occupied count.</summary>
    public int GridColumns => ActiveCount switch
    {
        <= 1 => 1,
        2    => 2,
        <= 4 => 2,
        <= 6 => 3,
        _    => 4,
    };

    /// <summary>Currently selected session.</summary>
    public SessionViewModel? SelectedSession
    {
        get => _selectedSession;
        set
        {
            if (_selectedSession == value) return;
            if (_selectedSession is not null) _selectedSession.IsSelected = false;
            _selectedSession = value;
            if (_selectedSession is not null) _selectedSession.IsSelected = true;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsSessionSelected));
        }
    }

    /// <summary>True when a session is selected.</summary>
    public bool IsSessionSelected => SelectedSession is not null;

    /// <summary>True while adding a session.</summary>
    public bool IsAddingSession
    {
        get => _isAddingSession;
        private set { _isAddingSession = value; OnPropertyChanged(); ((RelayCommand)AddSessionCommand).RaiseCanExecuteChanged(); }
    }

    /// <summary>CV Builder ViewModel for the sliding panel.</summary>
    public CvBuilderViewModel CvBuilder { get; }

    /// <summary>Whether the CV Builder panel is open.</summary>
    public bool IsCvBuilderOpen
    {
        get => _isCvBuilderOpen;
        set { _isCvBuilderOpen = value; OnPropertyChanged(); }
    }

    /// <summary>True if a Titan/Cronus device is connected.</summary>
    public bool IsTitanConnected => _titanBridge.IsConnected;

    /// <summary>Name of connected Titan device, or "None".</summary>
    public string TitanDeviceName => _titanBridge.ConnectedDevice?.Name ?? "None";

    /// <summary>True if GPC3 tools are available.</summary>
    public bool IsGpcAvailable => GpcRunner.IsAvailable();

    /// <summary>True if a GPC script is currently running.</summary>
    public bool IsGpcRunning => _gpcRunner.IsRunning;

    /// <summary>Number of occupied slots.</summary>
    public int ActiveCount => Slots.Count(s => s.IsOccupied);

    /// <summary>Number of running scripts.</summary>
    public int ScriptCount => Slots.Count(s => s.Status == Core.SessionStatus.Running);

    /// <summary>Refreshes the Active/Script counts and grid layout.</summary>
    public void RefreshCounts()
    {
        OnPropertyChanged(nameof(ActiveCount));
        OnPropertyChanged(nameof(ScriptCount));
        OnPropertyChanged(nameof(GridColumns));
    }

    /// <summary>Refreshes occupied slots view AND counts — call only when slots are added/removed.</summary>
    public void RefreshGrid()
    {
        OccupiedSlots.Refresh();
        RefreshCounts();
    }

    // ---------------------------------------------------------------------------
    // Commands
    // ---------------------------------------------------------------------------

    public ICommand AddSessionCommand { get; }

    /// <summary>Toggles the CV Builder panel open/closed.</summary>
    public ICommand ToggleCvBuilderCommand { get; }

    // ---------------------------------------------------------------------------
    // Add session — assigns to next empty slot
    // ---------------------------------------------------------------------------

    private async Task AddSessionAsync()
    {
        DebugLog.Write("[AddSession] Dialog opening...");

        var dialog = new NewSessionDialog
        {
            Owner = Application.Current.MainWindow
        };

        if (dialog.ShowDialog() != true)
        {
            DebugLog.Write("[AddSession] Dialog cancelled.");
            return;
        }

        string sessionName = dialog.SessionName;
        string platform    = dialog.Platform;
        string url         = dialog.Url;
        var sourceType     = dialog.SelectedSourceType;
        DebugLog.Write($"[AddSession] Dialog OK: name={sessionName}, platform={platform}, source={sourceType}, url={url}");

        // Find first empty slot
        var slot = Slots.FirstOrDefault(s => !s.IsOccupied);
        if (slot is null) return;

        IsAddingSession = true;
        int sessionId = slot.SlotIndex;

        var cloudSession = new CloudSession
        {
            SessionId     = sessionId,
            Hwnd          = 0,
            CaptureRegion = new CaptureRegion(0, 0, 0, 0),
            Status        = SessionStatus.Connecting,
            ZmqPort       = ZmqBasePort + sessionId,
            BrowserName   = sourceType == InputSourceType.WebView2 ? "WebView2" : platform,
            WindowTitle   = platform,
            SourceType    = sourceType,
        };

        slot.Assign(cloudSession,
            onStartScript: OnStartScript,
            onStopScript:  OnStopScript,
            onRemove:      RemoveSession,
            onSelect:      SelectSession);

        slot.SessionName = sessionName;
        slot.SetStatus(SessionStatus.Connecting);
        SelectedSession = slot;

        IsAddingSession = false;
        RefreshGrid();  // Slot became occupied — update the feed grid

        slot.LaunchUrl = url;

        // Persist session config
        SessionConfigStore.Save(sessionId, new SessionConfig
        {
            Name = sessionName,
            Platform = platform,
            Url = url,
        });

        DebugLog.Write($"[AddSession] Slot {sessionId} assigned, source={sourceType}, platform={platform}");

        if (sourceType == InputSourceType.CaptureCard)
        {
            // Capture card mode — no WebView2, direct frame capture via OpenCV
            var captureSource = new CaptureCardSource(sessionId, dialog.CaptureDeviceIndex,
                dialog.CaptureDeviceName);
            captureSource.FrameReady += (sid, jpeg) =>
                SessionViewModel.SharedFramePublisher?.PublishRawFrame(sid, jpeg);
            _ = LaunchCaptureSourceAsync(sessionId, captureSource, slot);
        }
        else if (sourceType == InputSourceType.WindowCapture)
        {
            // Window capture mode — capture Xbox/PS Remote Play app window
            var windowSource = new WindowCaptureSource(sessionId, dialog.CaptureWindowHandle,
                dialog.CaptureWindowTitle);
            windowSource.FrameReady += (sid, jpeg) =>
                SessionViewModel.SharedFramePublisher?.PublishRawFrame(sid, jpeg);
            _ = LaunchCaptureSourceAsync(sessionId, windowSource, slot);
        }
        else
        {
            // WebView2 mode — cloud gaming / web URL
            _ = LaunchAndConnectAsync(sessionId, url, slot);
        }
    }

    /// <summary>Launches a capture card or window capture source and transitions to Connected.</summary>
    private async Task LaunchCaptureSourceAsync(int sessionId, IFrameSource source, SessionViewModel vm)
    {
        try
        {
            DebugLog.Write($"[MainVM] LaunchCaptureSource START session={sessionId} ({source.SourceType}: {source.SourceName})");

            await source.StartAsync();

            _dispatcher.Invoke(() =>
            {
                vm.SetStatus(SessionStatus.Connected);
                RefreshCounts();
            });

            DebugLog.Write($"[MainVM] Session {sessionId}: {source.SourceType} connected — {source.SourceName}");
        }
        catch (Exception ex)
        {
            DebugLog.Write($"[MainVM] Session {sessionId} capture source EXCEPTION: {ex.Message}");
            _dispatcher.Invoke(() =>
            {
                vm.SetStatus(SessionStatus.Error);
                RefreshCounts();
            });
        }
    }

    /// <summary>Initializes WebView2 in the feed tile and transitions to Connected.</summary>
    private async Task LaunchAndConnectAsync(int sessionId, string url, SessionViewModel vm)
    {
        try
        {
            DebugLog.Write($"[MainVM] LaunchAndConnect START session={sessionId}");

            // Give the UI time to create and load the FeedTileControl after OccupiedSlots refresh
            await Task.Delay(300);

            // Poll until the tile registers (max 3s)
            for (int i = 0; i < 30 && !_webViewHost.HasTile(sessionId); i++)
            {
                DebugLog.Write($"[MainVM] Session {sessionId}: waiting for tile... ({i})");
                await Task.Delay(100);
            }

            if (!_webViewHost.HasTile(sessionId))
            {
                DebugLog.Write($"[MainVM] Session {sessionId}: tile never registered!");
                vm.SetStatus(SessionStatus.Error);
                RefreshCounts();
                return;
            }

            await _webViewHost.LaunchAsync(sessionId, url);

            vm.SetStatus(SessionStatus.Connected);
            RefreshCounts();
            DebugLog.Write($"[MainVM] Session {sessionId}: Connected.");
        }
        catch (Exception ex)
        {
            DebugLog.Write($"[MainVM] Session {sessionId} EXCEPTION: {ex}");
            vm.SetStatus(SessionStatus.Error);
            RefreshCounts();
        }
    }

    // ---------------------------------------------------------------------------
    // Selection
    // ---------------------------------------------------------------------------

    private void SelectSession(SessionViewModel vm)
    {
        SelectedSession = vm;
    }

    // ---------------------------------------------------------------------------
    // Script controls
    // ---------------------------------------------------------------------------

    private async void OnStartScript(SessionViewModel vm)
    {
        DebugLog.Write($"[OnStartScript] Session {vm.SessionId}: entered. SelectedScriptPath={vm.SelectedScriptPath}, CloudSession null={vm.CloudSession is null}, Status={vm.Status}");

        if (vm.SelectedScriptPath is null || vm.CloudSession is null)
        {
            DebugLog.Write($"[OnStartScript] Session {vm.SessionId}: ABORTED — SelectedScriptPath or CloudSession is null.");
            return;
        }

        var fullPath = Path.Combine(SessionViewModel.ScriptsFolder, vm.SelectedScriptPath);
        var scriptName = Path.GetFileNameWithoutExtension(vm.SelectedScriptPath);

        DebugLog.Write($"[OnStartScript] Session {vm.SessionId}: fullPath={fullPath}, exists={File.Exists(fullPath)}, zmqPort={vm.CloudSession.ZmqPort}");

        try
        {
            await Task.Run(() => _workerHost.StartAsync(vm.CloudSession, fullPath));
        }
        catch (Exception ex)
        {
            DebugLog.Write($"[OnStartScript] Session {vm.SessionId} FAILED: {ex}");
            _dispatcher.Invoke(() => { vm.SetStatus(SessionStatus.Error); RefreshCounts(); });
            return;
        }

        _dispatcher.Invoke(() =>
        {
            vm.SetStatus(SessionStatus.Running);
            vm.ActiveScriptName = scriptName;
            RefreshCounts();
        });

        // Remember last-used script in config
        var existingConfig = SessionConfigStore.Load(vm.SessionId);
        if (existingConfig is not null)
        {
            existingConfig.LastScript = vm.SelectedScriptPath;
            SessionConfigStore.Save(vm.SessionId, existingConfig);
        }

        DebugLog.Write($"[OnStartScript] Session {vm.SessionId}: script '{scriptName}' started OK, status set to Running.");
    }

    /// <summary>Handles worker process death — updates UI to show error.</summary>
    private void OnWorkerDied(int sessionId, int exitCode)
    {
        DebugLog.Write($"[WorkerDied] Session {sessionId}: worker exited with code {exitCode}.");

        _dispatcher.BeginInvoke(() =>
        {
            var vm = Slots.FirstOrDefault(s => s.SessionId == sessionId && s.IsOccupied);
            if (vm is null || vm.Status != SessionStatus.Running) return;

            vm.SetStatus(SessionStatus.Error);
            vm.ActiveScriptName = $"CRASHED (exit {exitCode})";
            RefreshCounts();
            DebugLog.Write($"[WorkerDied] Session {sessionId}: UI updated to Error.");
        });
    }

    /// <summary>Handles worker auto-restart or hot-reload — updates UI back to Running.</summary>
    private void OnWorkerRestarted(int sessionId, string reason)
    {
        DebugLog.Write($"[WorkerRestarted] Session {sessionId}: {reason}");

        _dispatcher.BeginInvoke(() =>
        {
            var vm = Slots.FirstOrDefault(s => s.SessionId == sessionId && s.IsOccupied);
            if (vm is null) return;

            vm.SetStatus(SessionStatus.Running);
            vm.ActiveScriptName = $"{vm.ActiveScriptName?.Split(' ')[0]} (restarted)";
            RefreshCounts();
        });
    }

    private void OnStopScript(SessionViewModel vm)
    {
        var sessionId = vm.SessionId;
        DebugLog.Write($"[OnStopScript] Session {sessionId}: stopping...");

        // Immediately update UI — don't wait for async cleanup
        vm.SetStatus(SessionStatus.Connected);
        vm.ActiveScriptName = string.Empty;
        RefreshCounts();

        // Fire-and-forget the worker cleanup on a background thread
        _ = Task.Run(async () =>
        {
            try
            {
                await _workerHost.StopAsync(sessionId);
                DebugLog.Write($"[OnStopScript] Session {sessionId}: worker stopped OK.");
            }
            catch (Exception ex)
            {
                DebugLog.Write($"[OnStopScript] Session {sessionId} stop cleanup error: {ex.Message}");
            }
        });
    }

    // ---------------------------------------------------------------------------
    // Remove session (clears the slot)
    // ---------------------------------------------------------------------------

    private void RemoveSession(SessionViewModel vm)
    {
        var sessionId = vm.SessionId;

        if (SelectedSession == vm)
            SelectedSession = null;

        SessionConfigStore.Delete(sessionId);
        vm.Clear();
        RefreshGrid();  // Slot became empty — update the feed grid

        // Fire-and-forget cleanup on background thread
        _ = Task.Run(async () =>
        {
            try { await _workerHost.StopAsync(sessionId); } catch { }
            try { await _webViewHost.DisconnectAsync(sessionId); } catch { }
        });

        Console.WriteLine($"[MainViewModel] Slot {vm.SlotIndex} cleared.");
    }

    // ---------------------------------------------------------------------------
    // INotifyPropertyChanged
    // ---------------------------------------------------------------------------

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
