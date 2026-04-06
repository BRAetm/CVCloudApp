using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CVCloudApp.Core;

namespace CVCloudApp.UI.ViewModels;

/// <summary>ViewModel for one of 10 fixed feed slots. Can be empty or occupied by an active session.</summary>
public class SessionViewModel : INotifyPropertyChanged, IDisposable
{
    /// <summary>Base ZMQ port for Python scripts — each session gets ScriptZmqBasePort + SessionId.</summary>
    public const int ScriptZmqBasePort = 5556;

    /// <summary>Absolute path to the Scripts folder next to the exe.</summary>
    public static readonly string ScriptsFolder = Path.Combine(AppContext.BaseDirectory, "Scripts");

    /// <summary>Shared frame publisher — set by MainViewModel at startup.</summary>
    public static FramePublisher? SharedFramePublisher { get; set; }

    /// <summary>Shared WebView host — set by App at startup for tile registration.</summary>
    public static WebViewSessionHost? SharedWebViewHost { get; set; }

    private Process? _scriptProcess;

    private Action<SessionViewModel>? _onStartScript;
    private Action<SessionViewModel>? _onStopScript;
    private Action<SessionViewModel>? _onRemove;
    private Action<SessionViewModel>? _onSelect;

    private SessionStatus    _status           = SessionStatus.Idle;
    private bool             _isSelected;
    private bool             _isOccupied;
    private string           _activeScriptName = string.Empty;
    private string?          _selectedScriptPath;
    private SolidColorBrush  _statusColor      = new(Color.FromRgb(0x33, 0x33, 0x33));
    private string           _sessionName      = string.Empty;

    // ---------------------------------------------------------------------------
    // Construction (creates an empty slot)
    // ---------------------------------------------------------------------------

    /// <summary>Creates an empty feed slot at the given index.</summary>
    public SessionViewModel(int slotIndex)
    {
        SlotIndex   = slotIndex;
        SessionId   = slotIndex;

        StartScriptCommand = new RelayCommand(
            () => _onStartScript?.Invoke(this),
            () => IsOccupied && (Status == SessionStatus.Connected || Status == SessionStatus.Error) && SelectedScriptPath is not null);

        StopScriptCommand = new RelayCommand(
            () => _onStopScript?.Invoke(this),
            () => IsOccupied && Status == SessionStatus.Running);

        RemoveCommand = new RelayCommand(
            () => _onRemove?.Invoke(this),
            () => IsOccupied);

        SelectCommand = new RelayCommand(
            () => _onSelect?.Invoke(this),
            () => IsOccupied);

        AvailableScripts = new ObservableCollection<string>(ScanScripts());
    }

    // ---------------------------------------------------------------------------
    // Slot assignment
    // ---------------------------------------------------------------------------

    /// <summary>Assigns an active session to this slot.</summary>
    public void Assign(CloudSession cloudSession,
                       Action<SessionViewModel> onStartScript,
                       Action<SessionViewModel> onStopScript,
                       Action<SessionViewModel> onRemove,
                       Action<SessionViewModel> onSelect)
    {
        CloudSession   = cloudSession;
        _onStartScript = onStartScript;
        _onStopScript  = onStopScript;
        _onRemove      = onRemove;
        _onSelect      = onSelect;
        IsOccupied     = true;
        RaiseCommandStates();
    }

    /// <summary>Clears this slot back to empty placeholder state.</summary>
    public void Clear()
    {
        KillScript();
        CloudSession       = null;
        _onStartScript     = null;
        _onStopScript      = null;
        _onRemove          = null;
        _onSelect          = null;
        SessionName        = string.Empty;
        ActiveScriptName   = string.Empty;
        SelectedScriptPath = null;
        LaunchUrl          = null;
        Status             = SessionStatus.Idle;
        IsOccupied         = false;
        IsSelected         = false;
        RaiseCommandStates();
    }

    // ---------------------------------------------------------------------------
    // Properties
    // ---------------------------------------------------------------------------

    /// <summary>Fixed grid position (0-9).</summary>
    public int SlotIndex { get; }

    /// <summary>Session ID — same as SlotIndex.</summary>
    public int SessionId { get; }

    /// <summary>True when this slot has an active session.</summary>
    public bool IsOccupied
    {
        get => _isOccupied;
        private set { _isOccupied = value; OnPropertyChanged(); OnPropertyChanged(nameof(Label)); OnPropertyChanged(nameof(SlotLabel)); }
    }

    /// <summary>Display label for occupied slots.</summary>
    public string Label => string.IsNullOrEmpty(_sessionName)
        ? $"#{SlotIndex + 1}"
        : $"#{SlotIndex + 1} {_sessionName}";

    /// <summary>Display label for empty slots.</summary>
    public string SlotLabel => $"{SlotIndex + 1}";

    /// <summary>User-defined session name.</summary>
    public string SessionName
    {
        get => _sessionName;
        set { _sessionName = value; OnPropertyChanged(); OnPropertyChanged(nameof(Label)); }
    }

    /// <summary>The underlying CloudSession data — null for empty slots.</summary>
    public CloudSession? CloudSession { get; private set; }

    /// <summary>Latest captured frame (used by CV Builder for template capture).</summary>
    public BitmapSource? CaptureFrame { get; set; }

    /// <summary>Current lifecycle status.</summary>
    public SessionStatus Status
    {
        get => _status;
        private set
        {
            _status = value;
            OnPropertyChanged();
            UpdateStatusColor();
            RaiseCommandStates();
        }
    }

    /// <summary>Brush derived from Status.</summary>
    public SolidColorBrush StatusColor
    {
        get => _statusColor;
        private set { _statusColor = value; OnPropertyChanged(); }
    }

    /// <summary>True when this slot is selected.</summary>
    public bool IsSelected
    {
        get => _isSelected;
        set { _isSelected = value; OnPropertyChanged(); }
    }

    /// <summary>Current gamepad input state — updated by GamepadInputRelay from ZMQ.</summary>
    public GamepadState CurrentInput { get; } = new();

    /// <summary>URL this session was launched with — used for WebView2 re-init on tile reload.</summary>
    public string? LaunchUrl { get; set; }

    /// <summary>Display name of the currently running script.</summary>
    public string ActiveScriptName
    {
        get => _activeScriptName;
        set { _activeScriptName = value; OnPropertyChanged(); }
    }

    /// <summary>Script path selected in the dropdown.</summary>
    public string? SelectedScriptPath
    {
        get => _selectedScriptPath;
        set { _selectedScriptPath = value; OnPropertyChanged(); RaiseCommandStates(); }
    }

    /// <summary>Available .py scripts from /Scripts.</summary>
    public ObservableCollection<string> AvailableScripts { get; }

    // ---------------------------------------------------------------------------
    // Commands
    // ---------------------------------------------------------------------------

    public ICommand StartScriptCommand { get; }
    public ICommand StopScriptCommand { get; }
    public ICommand RemoveCommand { get; }
    public ICommand SelectCommand { get; }

    // ---------------------------------------------------------------------------
    // Lifecycle
    // ---------------------------------------------------------------------------

    /// <summary>Applies a status transition.</summary>
    public void SetStatus(SessionStatus status)
    {
        Status = status;
    }

    /// <summary>Launches a Python script as a subprocess for this session.</summary>
    public void LaunchScript(string scriptPath, int zmqPort)
    {
        KillScript();
        var psi = new ProcessStartInfo
        {
            FileName        = "python",
            Arguments       = $"\"{scriptPath}\" --session {SessionId} --port {zmqPort}",
            UseShellExecute = false,
            CreateNoWindow  = true,
        };
        _scriptProcess = Process.Start(psi);
        Console.WriteLine($"[SessionVM] Slot {SlotIndex}: script launched (PID {_scriptProcess?.Id}, port {zmqPort}).");
    }

    /// <summary>Kills the running script process if any.</summary>
    public void KillScript()
    {
        if (_scriptProcess is null) return;
        try
        {
            if (!_scriptProcess.HasExited)
            {
                _scriptProcess.Kill();
                Console.WriteLine($"[SessionVM] Slot {SlotIndex}: script process killed.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[SessionVM] Slot {SlotIndex}: kill failed — {ex.Message}");
        }
        _scriptProcess.Dispose();
        _scriptProcess = null;
    }

    /// <summary>Disposes script process resources.</summary>
    public void Dispose()
    {
        KillScript();
    }

    // ---------------------------------------------------------------------------
    // Script helpers
    // ---------------------------------------------------------------------------

    /// <summary>Re-scans the /Scripts folder.</summary>
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
        var list = new List<string>();
        if (!Directory.Exists(ScriptsFolder)) return list;

        foreach (var file in Directory.EnumerateFiles(ScriptsFolder, "*.py"))
        {
            var name = Path.GetFileName(file);
            if (!name.Equals("worker.py", StringComparison.OrdinalIgnoreCase))
                list.Add(name);
        }

        return list;
    }

    // ---------------------------------------------------------------------------
    // Internal helpers
    // ---------------------------------------------------------------------------

    private void UpdateStatusColor()
    {
        StatusColor = Status switch
        {
            SessionStatus.Idle       => new SolidColorBrush(Color.FromRgb(0x1E, 0x3A, 0x5F)),
            SessionStatus.Connecting => new SolidColorBrush(Color.FromRgb(0x42, 0xA5, 0xF5)),
            SessionStatus.Connected  => new SolidColorBrush(Color.FromRgb(0x21, 0x96, 0xF3)),
            SessionStatus.Running    => new SolidColorBrush(Color.FromRgb(0x00, 0xE6, 0x76)),
            SessionStatus.Error      => new SolidColorBrush(Color.FromRgb(0xEF, 0x53, 0x50)),
            _                        => new SolidColorBrush(Color.FromRgb(0x1E, 0x3A, 0x5F)),
        };
    }

    private void RaiseCommandStates()
    {
        ((RelayCommand)StartScriptCommand).RaiseCanExecuteChanged();
        ((RelayCommand)StopScriptCommand).RaiseCanExecuteChanged();
        ((RelayCommand)RemoveCommand).RaiseCanExecuteChanged();
        ((RelayCommand)SelectCommand).RaiseCanExecuteChanged();
    }

    // ---------------------------------------------------------------------------
    // INotifyPropertyChanged
    // ---------------------------------------------------------------------------

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
