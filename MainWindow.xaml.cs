using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using LabsVision.UI.Controls;
using LabsVision.UI.ViewModels;

namespace LabsVision;

/// <summary>Shell window — sets DataContext only, no business logic.</summary>
public partial class MainWindow : Window
{
    private readonly DispatcherTimer _logTimer;
    private int _logLineCount;

    public MainWindow(MainViewModel vm)
    {
        InitializeComponent();
        DataContext = vm;

        // Poll worker output for the log panel
        _logTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(500) };
        _logTimer.Tick += OnLogTimerTick;
        _logTimer.Start();
    }

    /// <summary>Appends a line to the output log panel.</summary>
    public void AppendLog(string message)
    {
        if (_logLineCount > 500)
        {
            // Trim old lines to prevent memory bloat
            var text = OutputLog.Text;
            var cutoff = text.IndexOf('\n', text.Length / 2);
            if (cutoff > 0)
            {
                OutputLog.Text = text[(cutoff + 1)..];
                _logLineCount /= 2;
            }
        }

        OutputLog.Text += $"\n[{DateTime.Now:HH:mm:ss}] {message}";
        _logLineCount++;
        OutputScroller.ScrollToEnd();
    }

    private void OnLogTimerTick(object? sender, EventArgs e)
    {
        // Read recent entries from the debug log file
        try
        {
            var logPath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "cvccloud", "worker_debug.log");
            if (!System.IO.File.Exists(logPath)) return;

            var lines = System.IO.File.ReadAllLines(logPath);
            // Show only new lines since last check
            var newStart = Math.Max(0, lines.Length - 5);
            for (int i = newStart; i < lines.Length; i++)
            {
                var line = lines[i];
                if (!string.IsNullOrWhiteSpace(line) && !OutputLog.Text.Contains(line))
                    AppendLog(line.TrimStart('[').TrimEnd());
            }
        }
        catch { }
    }

    private void OnClearOutput(object sender, RoutedEventArgs e)
    {
        OutputLog.Text = "Output cleared.";
        _logLineCount = 1;
    }

    private void OnMenuExit(object sender, RoutedEventArgs e) => Close();

    private void OnOpenScriptCreator(object sender, RoutedEventArgs e)
    {
        var vm = DataContext as UI.ViewModels.MainViewModel;
        var creator = new UI.Views.MakeCvScriptWindow(vm) { Owner = this };
        creator.Show();
    }

    /// <summary>Refreshes the script list when the floating pill ComboBox opens.</summary>
    private void OnScriptDropDownOpened(object? sender, EventArgs e)
    {
        if (DataContext is MainViewModel main && main.SelectedSession is not null)
            main.SelectedSession.RefreshScripts();
    }

    /// <summary>Refreshes the script list when a row's inline ComboBox opens.</summary>
    private void OnRowScriptDropDownOpened(object? sender, EventArgs e)
    {
        if (sender is ComboBox cb && cb.DataContext is SessionViewModel vm)
            vm.RefreshScripts();
    }

    /// <summary>Routes CvPreviewControl region selection to CvBuilderViewModel.</summary>
    private void OnCvBuilderRegionSelected(object? sender, RegionSelectedEventArgs e)
    {
        if (DataContext is MainViewModel main)
            main.CvBuilder.ApplyRegion(e.X, e.Y, e.W, e.H);
    }
}
