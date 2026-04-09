using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using LabsVision.Core;
using LabsVision.Models;
using Microsoft.Win32;

namespace LabsVision.UI.ViewModels;

/// <summary>ViewModel for the CV rule builder — create, edit, save, and generate CV scripts.</summary>
public class CvBuilderViewModel : INotifyPropertyChanged
{
    private SessionViewModel? _selectedSession;
    private string            _scriptName = "MyScript";
    private CvRule?           _selectedRule;
    private bool              _isFullScreen;

    // ---------------------------------------------------------------------------
    // Construction
    // ---------------------------------------------------------------------------

    /// <summary>Creates a new CvBuilderViewModel bound to the given session slots.</summary>
    public CvBuilderViewModel(ObservableCollection<SessionViewModel> sessions)
    {
        Sessions = sessions;
        Rules    = new ObservableCollection<CvRule>();

        AddRuleCommand      = new RelayCommand(OnAddRule);
        DeleteRuleCommand   = new RelayCommand(OnDeleteRule, () => SelectedRule is not null);
        SaveConfigCommand   = new RelayCommand(OnSaveConfig, () => !string.IsNullOrWhiteSpace(ScriptName));
        LoadConfigCommand   = new RelayCommand(OnLoadConfig);
        GenerateScriptCommand = new RelayCommand(OnGenerateScript, () => !string.IsNullOrWhiteSpace(ScriptName) && Rules.Count > 0);
        CaptureTemplateCommand = new RelayCommand(OnCaptureTemplate, () => SelectedRule is not null && SelectedSession is not null);
        ToggleFullScreenCommand = new RelayCommand(() => IsFullScreen = !IsFullScreen);
    }

    // ---------------------------------------------------------------------------
    // Bindable properties
    // ---------------------------------------------------------------------------

    /// <summary>Available session slots from MainViewModel.</summary>
    public ObservableCollection<SessionViewModel> Sessions { get; }

    /// <summary>Currently selected session for preview/testing.</summary>
    public SessionViewModel? SelectedSession
    {
        get => _selectedSession;
        set { _selectedSession = value; OnPropertyChanged(); ((RelayCommand)CaptureTemplateCommand).RaiseCanExecuteChanged(); }
    }

    /// <summary>Name of the script being built.</summary>
    public string ScriptName
    {
        get => _scriptName;
        set
        {
            _scriptName = value;
            OnPropertyChanged();
            RaiseAllCommands();
        }
    }

    /// <summary>Ordered list of CV detection rules.</summary>
    public ObservableCollection<CvRule> Rules { get; }

    /// <summary>Currently selected rule for editing.</summary>
    public CvRule? SelectedRule
    {
        get => _selectedRule;
        set
        {
            _selectedRule = value;
            OnPropertyChanged();
            ((RelayCommand)DeleteRuleCommand).RaiseCanExecuteChanged();
            ((RelayCommand)CaptureTemplateCommand).RaiseCanExecuteChanged();
        }
    }

    /// <summary>Whether the CV Builder is in full-screen preview mode.</summary>
    public bool IsFullScreen
    {
        get => _isFullScreen;
        set { _isFullScreen = value; OnPropertyChanged(); }
    }

    // ---------------------------------------------------------------------------
    // Commands
    // ---------------------------------------------------------------------------

    /// <summary>Adds a new CvRule with sensible defaults.</summary>
    public ICommand AddRuleCommand { get; }

    /// <summary>Deletes the currently selected rule.</summary>
    public ICommand DeleteRuleCommand { get; }

    /// <summary>Saves the current rules to a JSON config file.</summary>
    public ICommand SaveConfigCommand { get; }

    /// <summary>Opens a file dialog and loads a JSON config file.</summary>
    public ICommand LoadConfigCommand { get; }

    /// <summary>Generates a Python script from the current rules.</summary>
    public ICommand GenerateScriptCommand { get; }

    /// <summary>Captures template image from the current frame and rule region.</summary>
    public ICommand CaptureTemplateCommand { get; }

    /// <summary>Toggles full-screen preview mode.</summary>
    public ICommand ToggleFullScreenCommand { get; }

    // ---------------------------------------------------------------------------
    // Command handlers
    // ---------------------------------------------------------------------------

    private void OnAddRule()
    {
        var rule = new CvRule
        {
            Name      = $"Rule {Rules.Count + 1}",
            RegionX   = 0.0,
            RegionY   = 0.0,
            RegionW   = 1.0,
            RegionH   = 1.0,
            Type      = CvRuleType.ColorRange,
            LowerH    = 0,
            LowerS    = 0,
            LowerV    = 0,
            UpperH    = 179,
            UpperS    = 255,
            UpperV    = 255,
            MinPixels = 100,
            Threshold = 0.8,
            ButtonIndex = 0,
            HoldMs    = 100,
        };

        Rules.Add(rule);
        SelectedRule = rule;
        RaiseAllCommands();
    }

    private void OnDeleteRule()
    {
        if (SelectedRule is null) return;

        Rules.Remove(SelectedRule);
        SelectedRule = Rules.LastOrDefault();
        RaiseAllCommands();
    }

    private void OnSaveConfig()
    {
        try
        {
            var config = new CvScriptConfig
            {
                ScriptName = ScriptName,
                Rules      = Rules.ToList(),
            };
            config.Save();
            Console.WriteLine($"[CvBuilder] Config saved: {ScriptName}.json");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CvBuilder] Save failed: {ex.Message}");
        }
    }

    private void OnLoadConfig()
    {
        try
        {
            var configFolder = CvScriptConfig.ConfigFolder;
            Directory.CreateDirectory(configFolder);

            var dlg = new OpenFileDialog
            {
                Title            = "Load CV Script Config",
                Filter           = "JSON Files|*.json",
                InitialDirectory = configFolder,
            };

            if (dlg.ShowDialog() != true) return;

            var config = CvScriptConfig.Load(dlg.FileName);
            ScriptName = config.ScriptName;

            Rules.Clear();
            foreach (var rule in config.Rules)
                Rules.Add(rule);

            SelectedRule = Rules.FirstOrDefault();
            RaiseAllCommands();

            Console.WriteLine($"[CvBuilder] Config loaded: {dlg.FileName} ({config.Rules.Count} rules)");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CvBuilder] Load failed: {ex.Message}");
        }
    }

    private void OnGenerateScript()
    {
        try
        {
            var config = new CvScriptConfig
            {
                ScriptName = ScriptName,
                Rules      = Rules.ToList(),
            };
            var path = PythonGenerator.Generate(config);
            Console.WriteLine($"[CvBuilder] Script generated: {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CvBuilder] Generate failed: {ex.Message}");
        }
    }

    // ---------------------------------------------------------------------------
    // Capture template from live feed
    // ---------------------------------------------------------------------------

    private void OnCaptureTemplate()
    {
        if (SelectedRule is null || SelectedSession is null) return;

        var frame = SelectedSession.CaptureFrame;
        if (frame is null)
        {
            Console.WriteLine("[CvBuilder] No capture frame available.");
            return;
        }

        try
        {
            int pw = frame.PixelWidth;
            int ph = frame.PixelHeight;
            int x = Math.Clamp((int)(SelectedRule.RegionX * pw), 0, pw - 1);
            int y = Math.Clamp((int)(SelectedRule.RegionY * ph), 0, ph - 1);
            int w = Math.Clamp((int)(SelectedRule.RegionW * pw), 1, pw - x);
            int h = Math.Clamp((int)(SelectedRule.RegionH * ph), 1, ph - y);

            var cropped = new CroppedBitmap(frame, new Int32Rect(x, y, w, h));

            var templatesFolder = Path.Combine(AppContext.BaseDirectory, "Templates");
            Directory.CreateDirectory(templatesFolder);

            var safeName = Regex.Replace($"{ScriptName}_{SelectedRule.Name}", @"[^\w\-]", "_");
            var path = Path.Combine(templatesFolder, $"{safeName}.png");

            using var fs = new FileStream(path, FileMode.Create);
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(cropped));
            encoder.Save(fs);

            SelectedRule.TemplatePath = path;
            Console.WriteLine($"[CvBuilder] Template captured: {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CvBuilder] Capture template failed: {ex.Message}");
        }
    }

    // ---------------------------------------------------------------------------
    // Region selection from CvPreviewControl
    // ---------------------------------------------------------------------------

    /// <summary>Applies a drawn region to the currently selected rule.</summary>
    public void ApplyRegion(double x, double y, double w, double h)
    {
        if (SelectedRule is null) return;
        SelectedRule.RegionX = x;
        SelectedRule.RegionY = y;
        SelectedRule.RegionW = w;
        SelectedRule.RegionH = h;
    }

    // ---------------------------------------------------------------------------
    // Helpers
    // ---------------------------------------------------------------------------

    private void RaiseAllCommands()
    {
        ((RelayCommand)AddRuleCommand).RaiseCanExecuteChanged();
        ((RelayCommand)DeleteRuleCommand).RaiseCanExecuteChanged();
        ((RelayCommand)SaveConfigCommand).RaiseCanExecuteChanged();
        ((RelayCommand)GenerateScriptCommand).RaiseCanExecuteChanged();
    }

    // ---------------------------------------------------------------------------
    // INotifyPropertyChanged
    // ---------------------------------------------------------------------------

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
