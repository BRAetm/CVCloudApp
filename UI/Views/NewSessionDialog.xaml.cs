using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using LabsVision.Core;

namespace LabsVision.UI.Views;

/// <summary>Dialog for configuring a new session — name, platform/source, and device/window selection.</summary>
public partial class NewSessionDialog : Window
{
    private const string XboxCloudUrl = "https://www.xbox.com/en-US/play";
    private const string PsRemotePlayUrl = "https://remoteplay.dl.playstation.net/remoteplay/";

    private List<CaptureDeviceInfo> _captureDevices = new();
    private List<AppWindowInfo> _appWindows = new();

    public NewSessionDialog()
    {
        InitializeComponent();
        NameBox.Focus();
        NameBox.SelectAll();
    }

    // ---------------------------------------------------------------------------
    // Public properties read by MainViewModel after DialogResult = true
    // ---------------------------------------------------------------------------

    public string SessionName => NameBox.Text.Trim();

    public string Platform
    {
        get
        {
            if (PlatformXboxRP.IsChecked == true) return "Xbox Remote Play";
            if (PlatformPS.IsChecked == true) return "PS Remote Play";
            if (PlatformCapture.IsChecked == true) return "Capture Card";
            if (PlatformCustom.IsChecked == true) return "Custom";
            return "Xbox Cloud Gaming";
        }
    }

    public string Url
    {
        get
        {
            if (PlatformCustom.IsChecked == true) return UrlBox.Text.Trim();
            if (PlatformPS.IsChecked == true) return PsRemotePlayUrl;
            if (PlatformXboxRP.IsChecked == true || PlatformCapture.IsChecked == true) return "";
            return XboxCloudUrl;
        }
    }

    public InputSourceType SelectedSourceType { get; private set; } = InputSourceType.WebView2;
    public int CaptureDeviceIndex { get; private set; } = -1;
    public string CaptureDeviceName { get; private set; } = "";
    public nint CaptureWindowHandle { get; private set; }
    public string CaptureWindowTitle { get; private set; } = "";

    // ---------------------------------------------------------------------------
    // Platform switching — show/hide the right options panel
    // ---------------------------------------------------------------------------

    private void OnPlatformChanged(object sender, RoutedEventArgs e)
    {
        if (CustomUrlPanel is null) return; // Guard during InitializeComponent

        // Hide all panels
        CustomUrlPanel.Visibility = Visibility.Collapsed;
        CaptureDevicePanel.Visibility = Visibility.Collapsed;
        WindowPickerPanel.Visibility = Visibility.Collapsed;
        CloudInfoText.Visibility = Visibility.Collapsed;

        if (PlatformCustom.IsChecked == true)
        {
            CustomUrlPanel.Visibility = Visibility.Visible;
        }
        else if (PlatformCapture.IsChecked == true)
        {
            CaptureDevicePanel.Visibility = Visibility.Visible;
            if (_captureDevices.Count == 0) OnScanDevices(null, null!);
        }
        else if (PlatformXboxRP.IsChecked == true)
        {
            WindowPickerPanel.Visibility = Visibility.Visible;
            ScanForWindows("Xbox", "XboxPcApp", "ApplicationFrameHost");
        }
        else if (PlatformPS.IsChecked == true)
        {
            // PS can be either web (WebView2) or app (window capture)
            // Default to web, but show window picker if app is running
            var psWindows = WindowCaptureSource.FindPsRemotePlay();
            if (psWindows.Count > 0)
            {
                WindowPickerPanel.Visibility = Visibility.Visible;
                _appWindows = psWindows;
                WindowCombo.Items.Clear();
                foreach (var w in _appWindows)
                    WindowCombo.Items.Add($"{w.Title} ({w.ProcessName})");
                if (WindowCombo.Items.Count > 0) WindowCombo.SelectedIndex = 0;
            }
            else
            {
                CloudInfoText.Text = "PS Remote Play app not found — will open in browser";
                CloudInfoText.Visibility = Visibility.Visible;
            }
        }
        else
        {
            // Xbox Cloud — just show info
            CloudInfoText.Text = "Will open xbox.com/play in embedded browser";
            CloudInfoText.Visibility = Visibility.Visible;
        }
    }

    // ---------------------------------------------------------------------------
    // Device & Window Scanning
    // ---------------------------------------------------------------------------

    private void OnScanDevices(object? sender, RoutedEventArgs e)
    {
        DeviceCombo.Items.Clear();
        _captureDevices = CaptureCardSource.ScanDevices();

        if (_captureDevices.Count == 0)
        {
            DeviceCombo.Items.Add("No capture devices found");
            DeviceCombo.SelectedIndex = 0;
            return;
        }

        foreach (var d in _captureDevices)
            DeviceCombo.Items.Add($"{d.Index}: {d.Name}");
        DeviceCombo.SelectedIndex = 0;
    }

    private void OnScanWindows(object? sender, RoutedEventArgs e)
    {
        if (PlatformXboxRP.IsChecked == true)
            ScanForWindows("Xbox", "XboxPcApp", "ApplicationFrameHost");
        else
            ScanForWindows("PS Remote Play", "chiaki", "RemotePlay");
    }

    private void ScanForWindows(params string[] keywords)
    {
        WindowCombo.Items.Clear();

        // First try targeted search
        if (PlatformXboxRP.IsChecked == true)
            _appWindows = WindowCaptureSource.FindXboxRemotePlay();
        else if (PlatformPS.IsChecked == true)
            _appWindows = WindowCaptureSource.FindPsRemotePlay();
        else
            _appWindows = WindowCaptureSource.FindWindowsByKeywords(keywords);

        // Always show all windows below the targeted results so user can pick any
        var allWindows = WindowCaptureSource.ListAllWindows()
            .Where(w => !string.IsNullOrWhiteSpace(w.Title) && w.Title.Length > 3)
            .Where(w => !_appWindows.Any(a => a.Hwnd == w.Hwnd)) // avoid duplicates
            .ToList();

        // Add targeted matches first (highlighted)
        foreach (var w in _appWindows)
            WindowCombo.Items.Add($"* {w.Title} ({w.ProcessName})");

        // Then all other windows
        foreach (var w in allWindows.Take(40))
            WindowCombo.Items.Add($"{w.Title} ({w.ProcessName})");

        // Merge into one list for index lookup
        _appWindows = _appWindows.Concat(allWindows.Take(40)).ToList();

        if (WindowCombo.Items.Count > 0)
            WindowCombo.SelectedIndex = 0;
        else
            WindowCombo.Items.Add("No windows found");
    }

    // ---------------------------------------------------------------------------
    // Launch
    // ---------------------------------------------------------------------------

    private void OnLaunch(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(SessionName))
        {
            NameBox.Focus();
            return;
        }

        // Determine source type and gather source-specific data
        if (PlatformCapture.IsChecked == true)
        {
            if (_captureDevices.Count == 0 || DeviceCombo.SelectedIndex < 0)
                return;

            var idx = DeviceCombo.SelectedIndex;
            if (idx >= _captureDevices.Count) return;

            CaptureDeviceIndex = _captureDevices[idx].Index;
            CaptureDeviceName = _captureDevices[idx].Name;
            SelectedSourceType = InputSourceType.CaptureCard;
        }
        else if (PlatformXboxRP.IsChecked == true ||
                 (PlatformPS.IsChecked == true && WindowPickerPanel.Visibility == Visibility.Visible))
        {
            if (_appWindows.Count == 0 || WindowCombo.SelectedIndex < 0)
                return;

            var idx = WindowCombo.SelectedIndex;
            if (idx >= _appWindows.Count) return;

            CaptureWindowHandle = _appWindows[idx].Hwnd;
            CaptureWindowTitle = _appWindows[idx].Title;
            SelectedSourceType = InputSourceType.WindowCapture;
        }
        else if (PlatformCustom.IsChecked == true)
        {
            if (string.IsNullOrWhiteSpace(UrlBox.Text))
            {
                UrlBox.Focus();
                return;
            }
            SelectedSourceType = InputSourceType.WebView2;
        }
        else
        {
            // Xbox Cloud or PS Remote Play (web mode)
            SelectedSourceType = InputSourceType.WebView2;
        }

        DialogResult = true;
    }

    private void OnCancel(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }

    private void OnDragWindow(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
            DragMove();
    }
}
