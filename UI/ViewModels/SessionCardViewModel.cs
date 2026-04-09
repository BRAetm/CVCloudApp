using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using LabsVision.Core;

namespace LabsVision.UI.ViewModels;

/// <summary>ViewModel for a single session card in the left panel grid and a feed tile in the right monitor.</summary>
public class SessionCardViewModel : INotifyPropertyChanged, IDisposable
{
    private readonly Action<SessionCardViewModel> _onOpenCvWindow;
    private readonly Action<SessionCardViewModel> _onStartScript;
    private readonly Action<SessionCardViewModel> _onStopScript;
    private readonly Action<SessionCardViewModel> _onSelect;
    private readonly Action<SessionCardViewModel> _onMaximize;

    private bool          _isOccupied;
    private bool          _isSelected;
    private string        _browserName      = string.Empty;
    private string        _windowTitle      = string.Empty;
    private SessionStatus _status           = SessionStatus.Idle;
    private BitmapSource? _captureFrame;
    private string        _fpsDisplay       = string.Empty;
    private string?       _selectedScriptPath;
    private string        _activeScriptName = string.Empty;
    private CloudSession? _session;

    // WGC capture — one per session, event-driven
    private WindowCapture? _windowCapture;
    private int            _frameCount;
    private DateTime       _lastFpsTime = DateTime.UtcNow;

    // ---------------------------------------------------------------------------
    // Construction
    // ---------------------------------------------------------------------------

    public SessionCardViewModel(int sessionId,
                                Action<SessionCardViewModel> onOpenCvWindow,
                                Action<SessionCardViewModel> onStartScript,
                                Action<SessionCardViewModel> onStopScript,
                                Action<SessionCardViewModel> onSelect,
                                Action<SessionCardViewModel> onMaximize)
    {
        SessionId       = sessionId;
        _onOpenCvWindow = onOpenCvWindow;
        _onStartScript  = onStartScript;
        _onStopScript   = onStopScript;
        _onSelect       = onSelect;
        _onMaximize     = onMaximize;

        OpenCvWindowCommand = new RelayCommand(() => _onOpenCvWindow(this), () => IsOccupied);
        StartScriptCommand  = new RelayCommand(() => _onStartScript(this),
                                               () => Status == SessionStatus.Connected && SelectedScriptPath is not null);
        StopScriptCommand   = new RelayCommand(() => _onStopScript(this),  () => Status == SessionStatus.Running);
        SelectCommand       = new RelayCommand(() => _onSelect(this),       () => IsOccupied);
        MaximizeCommand     = new RelayCommand(() => _onMaximize(this),     () => IsOccupied);

        AvailableScripts = new ObservableCollection<string>(ScanScripts());
    }

    // ---------------------------------------------------------------------------
    // Bindable properties
    // ---------------------------------------------------------------------------

    /// <summary>Session slot index 0–5. Read-only after construction.</summary>
    public int SessionId { get; }

    /// <summary>True when a real CloudSession is attached to this card slot.</summary>
    public bool IsOccupied
    {
        get => _isOccupied;
        private set { _isOccupied = value; OnPropertyChanged(); RaiseAllCanExecuteChanged(); }
    }

    /// <summary>True when this tile is selected in the feed monitor.</summary>
    public bool IsSelected
    {
        get => _isSelected;
        set { _isSelected = value; OnPropertyChanged(); }
    }

    /// <summary>Friendly browser name: "Chrome", "Edge", or "Firefox".</summary>
    public string BrowserName
    {
        get => _browserName;
        private set { _browserName = value; OnPropertyChanged(); }
    }

    /// <summary>Full window title of the detected Xbox Cloud browser tab.</summary>
    public string WindowTitle
    {
        get => _windowTitle;
        private set { _windowTitle = value; OnPropertyChanged(); }
    }

    /// <summary>Current session lifecycle status.</summary>
    public SessionStatus Status
    {
        get => _status;
        private set { _status = value; OnPropertyChanged(); }
    }

    /// <summary>Most recently captured frame from WGC, updated at display refresh rate.</summary>
    public BitmapSource? CaptureFrame
    {
        get => _captureFrame;
        private set { _captureFrame = value; OnPropertyChanged(); }
    }

    /// <summary>FPS display string updated once per second, e.g. "28 fps".</summary>
    public string FpsDisplay
    {
        get => _fpsDisplay;
        private set { _fpsDisplay = value; OnPropertyChanged(); }
    }

    /// <summary>Script path selected in the ComboBox.</summary>
    public string? SelectedScriptPath
    {
        get => _selectedScriptPath;
        set { _selectedScriptPath = value; OnPropertyChanged(); RaiseAllCanExecuteChanged(); }
    }

    /// <summary>Display name of the currently running script, empty if none.</summary>
    public string ActiveScriptName
    {
        get => _activeScriptName;
        private set { _activeScriptName = value; OnPropertyChanged(); }
    }

    /// <summary>Available .py scripts from /Scripts, excluding worker.py. Live-refreshed on dropdown open.</summary>
    public ObservableCollection<string> AvailableScripts { get; }

    /// <summary>The underlying CloudSession, exposed for CvWindowViewModel construction.</summary>
    public CloudSession? Session => _session;

    // ---------------------------------------------------------------------------
    // Commands
    // ---------------------------------------------------------------------------

    /// <summary>Opens the floating CV preview window for this session. Enabled when occupied.</summary>
    public ICommand OpenCvWindowCommand { get; }

    /// <summary>Starts the selected CV script. Enabled when Connected and script selected.</summary>
    public ICommand StartScriptCommand { get; }

    /// <summary>Stops the running CV script. Enabled when Running.</summary>
    public ICommand StopScriptCommand { get; }

    /// <summary>Selects this tile in the feed monitor. Enabled when occupied.</summary>
    public ICommand SelectCommand { get; }

    /// <summary>Maximizes or restores this tile in the feed monitor. Enabled when occupied.</summary>
    public ICommand MaximizeCommand { get; }

    // ---------------------------------------------------------------------------
    // Lifecycle API (called by MainViewModel)
    // ---------------------------------------------------------------------------

    /// <summary>Attaches a discovered CloudSession to this card slot and starts WGC capture.</summary>
    public void Attach(CloudSession session)
    {
        _session    = session;
        BrowserName = session.BrowserName;
        WindowTitle = session.WindowTitle;
        SetStatus(SessionStatus.Connected);
        IsOccupied = true;

        StartCapture(session.Hwnd);
    }

    /// <summary>Detaches the session from this card slot and stops WGC capture.</summary>
    public void Detach()
    {
        StopCapture();

        _session         = null;
        BrowserName      = string.Empty;
        WindowTitle      = string.Empty;
        ActiveScriptName = string.Empty;
        CaptureFrame     = null;
        FpsDisplay       = string.Empty;
        IsSelected       = false;
        _frameCount      = 0;
        SetStatus(SessionStatus.Idle);
        IsOccupied = false;
    }

    /// <summary>Single mutation point for status — updates property and refreshes command states.</summary>
    public void SetStatus(SessionStatus status)
    {
        Status = status;
        RaiseAllCanExecuteChanged();
    }

    /// <summary>Updates the active script display name.</summary>
    public void SetActiveScriptName(string name) => ActiveScriptName = name;

    /// <summary>Disposes the WGC capture.</summary>
    public void Dispose() => StopCapture();

    // ---------------------------------------------------------------------------
    // WGC capture — event-driven, no timer needed
    // ---------------------------------------------------------------------------

    private void StartCapture(nint hwnd)
    {
        StopCapture();

        try
        {
            _windowCapture = new WindowCapture();
            _windowCapture.FrameReady += OnFrameReady;
            _frameCount  = 0;
            _lastFpsTime = DateTime.UtcNow;
            _windowCapture.Start(hwnd);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[SessionCard] Session {SessionId}: WGC capture failed — {ex.Message}");
            _windowCapture?.Dispose();
            _windowCapture = null;
        }
    }

    private void StopCapture()
    {
        if (_windowCapture is null) return;
        _windowCapture.FrameReady -= OnFrameReady;
        _windowCapture.Dispose();
        _windowCapture = null;
    }

    /// <summary>Called on the WGC capture thread — marshals the frozen BitmapSource to the UI thread.</summary>
    private void OnFrameReady(BitmapSource frame)
    {
        // frame is already Frozen (cross-thread safe) — marshal property update to UI thread
        Application.Current?.Dispatcher.BeginInvoke(() =>
        {
            CaptureFrame = frame;

            // FPS counter — update display once per second
            _frameCount++;
            double elapsed = (DateTime.UtcNow - _lastFpsTime).TotalSeconds;
            if (elapsed >= 1.0)
            {
                FpsDisplay   = $"{_frameCount / elapsed:F0} fps";
                _frameCount  = 0;
                _lastFpsTime = DateTime.UtcNow;
            }
        });
    }

    // ---------------------------------------------------------------------------
    // Helpers
    // ---------------------------------------------------------------------------

    /// <summary>Re-scans the /Scripts folder and updates AvailableScripts in place.</summary>
    public void RefreshScripts()
    {
        var fresh = ScanScripts();

        for (int i = AvailableScripts.Count - 1; i >= 0; i--)
            if (!fresh.Contains(AvailableScripts[i]))
                AvailableScripts.RemoveAt(i);

        foreach (var path in fresh)
            if (!AvailableScripts.Contains(path))
                AvailableScripts.Add(path);

        if (SelectedScriptPath is not null && !AvailableScripts.Contains(SelectedScriptPath))
            SelectedScriptPath = null;
    }

    private static List<string> ScanScripts()
    {
        const string scriptsFolder = "Scripts";
        var list = new List<string>();
        if (!Directory.Exists(scriptsFolder)) return list;

        foreach (var file in Directory.EnumerateFiles(scriptsFolder, "*.py"))
            if (!Path.GetFileName(file).Equals("worker.py", StringComparison.OrdinalIgnoreCase))
                list.Add(file);

        return list;
    }

    private void RaiseAllCanExecuteChanged()
    {
        ((RelayCommand)OpenCvWindowCommand).RaiseCanExecuteChanged();
        ((RelayCommand)StartScriptCommand).RaiseCanExecuteChanged();
        ((RelayCommand)StopScriptCommand).RaiseCanExecuteChanged();
        ((RelayCommand)SelectCommand).RaiseCanExecuteChanged();
        ((RelayCommand)MaximizeCommand).RaiseCanExecuteChanged();
    }

    // ---------------------------------------------------------------------------
    // INotifyPropertyChanged
    // ---------------------------------------------------------------------------

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
