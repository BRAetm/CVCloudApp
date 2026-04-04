using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CVCloudApp.Models;

namespace CVCloudApp.UI.Controls;

/// <summary>Live feed preview with interactive region drawing and rule overlay.</summary>
public partial class CvPreviewControl : UserControl
{
    // ---------------------------------------------------------------------------
    // Dependency properties
    // ---------------------------------------------------------------------------

    /// <summary>Collection of CvRules to render as overlay rectangles.</summary>
    public static readonly DependencyProperty RulesProperty =
        DependencyProperty.Register(nameof(Rules), typeof(ObservableCollection<CvRule>), typeof(CvPreviewControl),
            new PropertyMetadata(null, OnRulesChanged));

    /// <summary>Currently selected rule — drawn with cyan border.</summary>
    public static readonly DependencyProperty SelectedRuleProperty =
        DependencyProperty.Register(nameof(SelectedRule), typeof(CvRule), typeof(CvPreviewControl),
            new PropertyMetadata(null, (d, _) => ((CvPreviewControl)d).RedrawOverlay()));

    /// <summary>Frame source to display in the preview image.</summary>
    public static readonly DependencyProperty FrameSourceProperty =
        DependencyProperty.Register(nameof(FrameSource), typeof(BitmapSource), typeof(CvPreviewControl),
            new PropertyMetadata(null));

    /// <summary>Frame source to display in the preview image.</summary>
    public BitmapSource? FrameSource
    {
        get => (BitmapSource?)GetValue(FrameSourceProperty);
        set => SetValue(FrameSourceProperty, value);
    }

    /// <summary>Collection of CvRules to render as overlay rectangles.</summary>
    public ObservableCollection<CvRule>? Rules
    {
        get => (ObservableCollection<CvRule>?)GetValue(RulesProperty);
        set => SetValue(RulesProperty, value);
    }

    /// <summary>Currently selected rule — drawn with cyan border.</summary>
    public CvRule? SelectedRule
    {
        get => (CvRule?)GetValue(SelectedRuleProperty);
        set => SetValue(SelectedRuleProperty, value);
    }

    // ---------------------------------------------------------------------------
    // Events
    // ---------------------------------------------------------------------------

    /// <summary>Fired when the user finishes drawing a selection rectangle. Args are normalized X,Y,W,H.</summary>
    public event EventHandler<RegionSelectedEventArgs>? RegionSelected;

    // ---------------------------------------------------------------------------
    // Drawing state
    // ---------------------------------------------------------------------------

    private bool   _isDragging;
    private Point  _dragStart;
    private Rectangle? _selectionRect;

    // ---------------------------------------------------------------------------
    // Construction
    // ---------------------------------------------------------------------------

    public CvPreviewControl()
    {
        InitializeComponent();
        SizeChanged += (_, _) => RedrawOverlay();
    }

    // ---------------------------------------------------------------------------
    // Collection change wiring
    // ---------------------------------------------------------------------------

    private static void OnRulesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var ctrl = (CvPreviewControl)d;

        if (e.OldValue is ObservableCollection<CvRule> oldCol)
            oldCol.CollectionChanged -= ctrl.OnRulesCollectionChanged;

        if (e.NewValue is ObservableCollection<CvRule> newCol)
            newCol.CollectionChanged += ctrl.OnRulesCollectionChanged;

        ctrl.RedrawOverlay();
    }

    private void OnRulesCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) => RedrawOverlay();

    // ---------------------------------------------------------------------------
    // Mouse handlers — draw selection rectangle
    // ---------------------------------------------------------------------------

    private void OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        _isDragging = true;
        _dragStart = e.GetPosition(OverlayCanvas);
        OverlayCanvas.CaptureMouse();

        // Create the selection rectangle visual
        _selectionRect = new Rectangle
        {
            Stroke          = Brushes.Yellow,
            StrokeThickness = 2,
            StrokeDashArray = new DoubleCollection { 4, 2 },
            Fill            = new SolidColorBrush(Color.FromArgb(40, 255, 255, 0)),
        };
        Canvas.SetLeft(_selectionRect, _dragStart.X);
        Canvas.SetTop(_selectionRect, _dragStart.Y);
        _selectionRect.Width  = 0;
        _selectionRect.Height = 0;
        OverlayCanvas.Children.Add(_selectionRect);

        e.Handled = true;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        var pos = e.GetPosition(OverlayCanvas);

        if (_isDragging && _selectionRect is not null)
        {
            var x = Math.Min(pos.X, _dragStart.X);
            var y = Math.Min(pos.Y, _dragStart.Y);
            var w = Math.Abs(pos.X - _dragStart.X);
            var h = Math.Abs(pos.Y - _dragStart.Y);

            Canvas.SetLeft(_selectionRect, x);
            Canvas.SetTop(_selectionRect, y);
            _selectionRect.Width  = w;
            _selectionRect.Height = h;
            return;
        }

        // HSV tooltip — sample pixel under cursor
        UpdateHsvTooltip(pos);
    }

    /// <summary>Samples the pixel under the cursor and shows H/S/V as a tooltip.</summary>
    private void UpdateHsvTooltip(Point canvasPos)
    {
        var source = FrameSource;
        if (source is null) { OverlayCanvas.ToolTip = null; return; }

        var pixel = CanvasToImagePixel(canvasPos, source);
        if (pixel is null) { OverlayCanvas.ToolTip = null; return; }

        var (px, py) = pixel.Value;
        var (r, g, b) = SamplePixel(source, px, py);
        var (h, s, v) = RgbToHsv(r, g, b);

        OverlayCanvas.ToolTip = $"H:{h}  S:{s}  V:{v}";
    }

    /// <summary>Maps a canvas position to an image pixel coordinate accounting for Uniform stretch.</summary>
    private (int px, int py)? CanvasToImagePixel(Point canvasPos, BitmapSource source)
    {
        double imgW = source.PixelWidth;
        double imgH = source.PixelHeight;
        double ctrlW = FeedImage.ActualWidth;
        double ctrlH = FeedImage.ActualHeight;
        if (ctrlW <= 0 || ctrlH <= 0 || imgW <= 0 || imgH <= 0) return null;

        double scale = Math.Min(ctrlW / imgW, ctrlH / imgH);
        double renderW = imgW * scale;
        double renderH = imgH * scale;
        double offsetX = (ctrlW - renderW) / 2;
        double offsetY = (ctrlH - renderH) / 2;

        int px = (int)((canvasPos.X - offsetX) / scale);
        int py = (int)((canvasPos.Y - offsetY) / scale);

        if (px < 0 || px >= (int)imgW || py < 0 || py >= (int)imgH) return null;
        return (px, py);
    }

    /// <summary>Reads a single pixel's RGB from a BitmapSource.</summary>
    private static (byte R, byte G, byte B) SamplePixel(BitmapSource source, int x, int y)
    {
        var pixel = new byte[4];
        var cb = new CroppedBitmap(source, new Int32Rect(x, y, 1, 1));
        var converted = new FormatConvertedBitmap(cb, PixelFormats.Bgra32, null, 0);
        converted.CopyPixels(pixel, 4, 0);
        return (pixel[2], pixel[1], pixel[0]); // BGRA → RGB
    }

    /// <summary>Converts RGB (0–255) to OpenCV-style HSV (H:0–179, S:0–255, V:0–255).</summary>
    private static (int H, int S, int V) RgbToHsv(byte r, byte g, byte b)
    {
        double rd = r / 255.0, gd = g / 255.0, bd = b / 255.0;
        double max = Math.Max(rd, Math.Max(gd, bd));
        double min = Math.Min(rd, Math.Min(gd, bd));
        double diff = max - min;

        double h = 0;
        if (diff > 0)
        {
            if (max == rd)      h = 60 * (((gd - bd) / diff) % 6);
            else if (max == gd) h = 60 * (((bd - rd) / diff) + 2);
            else                h = 60 * (((rd - gd) / diff) + 4);
        }
        if (h < 0) h += 360;

        double s = max == 0 ? 0 : diff / max;
        return ((int)(h / 2), (int)(s * 255), (int)(max * 255));
    }

    private void OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        if (!_isDragging) return;
        _isDragging = false;
        OverlayCanvas.ReleaseMouseCapture();

        // Remove the selection rectangle visual
        if (_selectionRect is not null)
            OverlayCanvas.Children.Remove(_selectionRect);

        var pos  = e.GetPosition(OverlayCanvas);
        var canW = OverlayCanvas.ActualWidth;
        var canH = OverlayCanvas.ActualHeight;
        if (canW <= 0 || canH <= 0) return;

        // Calculate normalized region
        double x1 = Math.Clamp(Math.Min(pos.X, _dragStart.X) / canW, 0, 1);
        double y1 = Math.Clamp(Math.Min(pos.Y, _dragStart.Y) / canH, 0, 1);
        double x2 = Math.Clamp(Math.Max(pos.X, _dragStart.X) / canW, 0, 1);
        double y2 = Math.Clamp(Math.Max(pos.Y, _dragStart.Y) / canH, 0, 1);

        double rw = x2 - x1;
        double rh = y2 - y1;

        // Ignore tiny accidental clicks
        if (rw < 0.01 || rh < 0.01) return;

        RegionSelected?.Invoke(this, new RegionSelectedEventArgs(x1, y1, rw, rh));
        _selectionRect = null;

        RedrawOverlay();
        e.Handled = true;
    }

    // ---------------------------------------------------------------------------
    // Overlay rendering — draw existing rules as semi-transparent rectangles
    // ---------------------------------------------------------------------------

    /// <summary>Redraws all rule overlay rectangles on the canvas.</summary>
    private void RedrawOverlay()
    {
        // Remove all rule visuals (keep only the active selection rect if dragging)
        for (int i = OverlayCanvas.Children.Count - 1; i >= 0; i--)
        {
            if (OverlayCanvas.Children[i] != _selectionRect)
                OverlayCanvas.Children.RemoveAt(i);
        }

        if (Rules is null) return;

        var canW = OverlayCanvas.ActualWidth;
        var canH = OverlayCanvas.ActualHeight;
        if (canW <= 0 || canH <= 0) return;

        foreach (var rule in Rules)
        {
            double x = rule.RegionX * canW;
            double y = rule.RegionY * canH;
            double w = rule.RegionW * canW;
            double h = rule.RegionH * canH;

            bool isSelected = rule == SelectedRule;

            // Rule rectangle
            var rect = new Rectangle
            {
                Width           = w,
                Height          = h,
                Stroke          = isSelected ? Brushes.Cyan : new SolidColorBrush(Color.FromRgb(0x7C, 0x3A, 0xED)),
                StrokeThickness = isSelected ? 2.5 : 1.5,
                Fill            = new SolidColorBrush(isSelected
                    ? Color.FromArgb(30, 0, 255, 255)
                    : Color.FromArgb(20, 124, 58, 237)),
            };
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            OverlayCanvas.Children.Add(rect);

            // Name label
            var label = new TextBlock
            {
                Text       = rule.Name,
                Foreground = isSelected ? Brushes.Cyan : new SolidColorBrush(Color.FromRgb(0xC0, 0x84, 0xFC)),
                FontSize   = 10,
                FontFamily = new FontFamily("Segoe UI"),
                FontWeight = FontWeights.SemiBold,
            };
            Canvas.SetLeft(label, x + 3);
            Canvas.SetTop(label, y + 2);
            OverlayCanvas.Children.Add(label);
        }
    }
}

// ---------------------------------------------------------------------------
// Event args
// ---------------------------------------------------------------------------

/// <summary>Event args for a region selection — normalized coordinates 0.0–1.0.</summary>
public class RegionSelectedEventArgs : EventArgs
{
    /// <summary>Normalized X origin.</summary>
    public double X { get; }

    /// <summary>Normalized Y origin.</summary>
    public double Y { get; }

    /// <summary>Normalized width.</summary>
    public double W { get; }

    /// <summary>Normalized height.</summary>
    public double H { get; }

    public RegionSelectedEventArgs(double x, double y, double w, double h)
    {
        X = x; Y = y; W = w; H = h;
    }
}
