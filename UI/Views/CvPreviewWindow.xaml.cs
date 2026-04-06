using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CVCloudApp.UI.Views;

/// <summary>Floating, always-on-top CV preview window. Can be minimized while CV keeps running.</summary>
public partial class CvPreviewWindow : Window
{
    private int _frameCount;
    private DateTime _fpsStart = DateTime.UtcNow;
    private bool _isMinimized;

    public CvPreviewWindow(int sessionId)
    {
        InitializeComponent();
        TitleText.Text = $"CV Preview — Session {sessionId}";
    }

    /// <summary>True when window is minimized but still receiving frames.</summary>
    public bool IsMinimized => _isMinimized;

    /// <summary>Updates the displayed frame. Skips rendering when minimized for performance.</summary>
    public void UpdateFrame(BitmapSource frame)
    {
        _frameCount++;
        var elapsed = (DateTime.UtcNow - _fpsStart).TotalSeconds;
        if (elapsed >= 1.0)
        {
            var fps = _frameCount / elapsed;
            FpsText.Text = $"{fps:F0} fps";
            _frameCount = 0;
            _fpsStart = DateTime.UtcNow;
        }

        // Skip rendering when minimized — script still runs, just no display cost
        if (_isMinimized) return;

        CvImage.Source = frame;
    }

    /// <summary>Restores from minimized state.</summary>
    public void Restore()
    {
        _isMinimized = false;
        WindowState = WindowState.Normal;
        StatusDot.Fill = new System.Windows.Media.SolidColorBrush(
            System.Windows.Media.Color.FromRgb(0x00, 0xE6, 0x76));
    }

    private void OnMinimize(object sender, RoutedEventArgs e)
    {
        _isMinimized = true;
        WindowState = WindowState.Minimized;
        // Green dot changes to yellow to indicate minimized-but-running
        StatusDot.Fill = new System.Windows.Media.SolidColorBrush(
            System.Windows.Media.Color.FromRgb(0xFF, 0xC1, 0x07));
    }

    private void OnClose(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void OnDrag(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            if (_isMinimized)
            {
                Restore();
                return;
            }
            DragMove();
        }
    }

    protected override void OnStateChanged(EventArgs e)
    {
        base.OnStateChanged(e);
        if (WindowState == WindowState.Normal && _isMinimized)
            Restore();
    }
}
