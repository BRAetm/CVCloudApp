using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using LabsVision.UI.ViewModels;

namespace LabsVision.UI.Views;

// ============================================================================
// Data models
// ============================================================================

/// <summary>Region or annotation marked by the user.</summary>
public class MarkedRegion : INotifyPropertyChanged
{
    private string _name = "Region";
    public string Name { get => _name; set { _name = value; OnPropertyChanged(nameof(Name)); } }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public BitmapSource? Thumbnail { get; set; }
    public byte[]? TemplateBytes { get; set; }

    /// <summary>"region", "highlight", "arrow", "freehand"</summary>
    public string Kind { get; set; } = "region";

    /// <summary>"template", "color", "pixel"</summary>
    public string DetectionType { get; set; } = "template";

    // Color range detection data (HSV)
    public int HueLow { get; set; }
    public int HueHigh { get; set; }
    public int SatLow { get; set; }
    public int SatHigh { get; set; }
    public int ValLow { get; set; }
    public int ValHigh { get; set; }

    // Pixel check data (BGR)
    public byte PixelB { get; set; }
    public byte PixelG { get; set; }
    public byte PixelR { get; set; }
    public int PixelTolerance { get; set; } = 30;

    public string DetectionTypeLabel => DetectionType switch
    {
        "template" => "Template",
        "color" => "Color",
        "pixel" => "Pixel",
        _ => DetectionType
    };

    public string SizeText => DetectionType switch
    {
        "color" => $"HSV [{HueLow}-{HueHigh}] @ ({X},{Y})",
        "pixel" => $"Pixel ({X},{Y}) BGR({PixelB},{PixelG},{PixelR})",
        _ => Kind == "region"
            ? $"{Width}x{Height} @ ({X},{Y})"
            : $"{Kind} @ ({X},{Y})",
    };

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

/// <summary>An action to execute when a rule fires.</summary>
public class ActionItem : INotifyPropertyChanged
{
    private string _type = "press_button";
    private string _parameter = "A";

    public string Type
    {
        get => _type;
        set { _type = value; OnPropertyChanged(nameof(Type)); OnPropertyChanged(nameof(DisplayText)); OnPropertyChanged(nameof(Icon)); }
    }

    public string Parameter
    {
        get => _parameter;
        set { _parameter = value; OnPropertyChanged(nameof(Parameter)); OnPropertyChanged(nameof(DisplayText)); }
    }

    public string DisplayText => Type switch
    {
        "press_button" => $"Press {Parameter}",
        "move_stick" => $"Move {Parameter}",
        "wait" => $"Wait {Parameter}ms",
        "emit_gamepad" => "Emit Gamepad State",
        _ => Type
    };

    public string Icon => Type switch
    {
        "press_button" => "\u25CB",
        "move_stick" => "\u2B95",
        "wait" => "\u23F1",
        "emit_gamepad" => "\u25B6",
        _ => "\u2022"
    };

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

/// <summary>IF detection found with confidence >= X THEN execute action.</summary>
public class RuleItem : INotifyPropertyChanged
{
    private string _detectionName = "";
    private double _confidence = 0.70;
    private string _actionName = "";

    public string DetectionName
    {
        get => _detectionName;
        set { _detectionName = value; OnPropertyChanged(nameof(DetectionName)); }
    }

    public double Confidence
    {
        get => _confidence;
        set { _confidence = value; OnPropertyChanged(nameof(Confidence)); OnPropertyChanged(nameof(ConfidenceText)); }
    }

    public string ConfidenceText
    {
        get => _confidence.ToString("F2");
        set
        {
            if (double.TryParse(value, out var v))
            {
                _confidence = Math.Clamp(v, 0.0, 1.0);
                OnPropertyChanged(nameof(Confidence));
                OnPropertyChanged(nameof(ConfidenceText));
            }
        }
    }

    public string ActionName
    {
        get => _actionName;
        set { _actionName = value; OnPropertyChanged(nameof(ActionName)); }
    }

    // These are updated externally when detections/actions change
    public ObservableCollection<string> DetectionNames { get; set; } = new();
    public ObservableCollection<string> ActionNames { get; set; } = new();

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

// ============================================================================
// Window
// ============================================================================

/// <summary>
/// CV Script Builder — capture live frames or load screenshots, annotate with
/// regions / highlights / arrows / freehand, add color + pixel detections,
/// configure actions and rules, then generate Python CV scripts.
/// </summary>
public partial class MakeCvScriptWindow : Window
{
    private BitmapSource? _sourceImage;
    private int _sourceWidth, _sourceHeight;
    private readonly ObservableCollection<MarkedRegion> _regions = new();
    private readonly ObservableCollection<ActionItem> _actions = new();
    private readonly ObservableCollection<RuleItem> _rules = new();

    // Drawing state
    private bool _isDrawing;
    private Point _drawStart;
    private Shape? _drawShape;
    private readonly List<Point> _freehandPoints = new();
    private Polyline? _freehandLine;

    // Track canvas labels so they update when regions are renamed
    private readonly Dictionary<MarkedRegion, TextBlock> _regionLabels = new();
    // Tracks ALL canvas UIElements for each region so they can be cleaned up on delete
    private readonly Dictionary<MarkedRegion, List<UIElement>> _regionShapes = new();

    private void TrackShape(MarkedRegion region, UIElement element)
    {
        if (!_regionShapes.TryGetValue(region, out var list))
        {
            list = new List<UIElement>();
            _regionShapes[region] = list;
        }
        list.Add(element);
    }

    // Reference to main VM for live capture
    private readonly MainViewModel? _mainVm;

    // Save folder
    private string _saveFolder = "";

    public MakeCvScriptWindow(MainViewModel? mainVm = null)
    {
        InitializeComponent();
        _mainVm = mainVm;
        RegionsList.ItemsSource = _regions;
        ActionsList.ItemsSource = _actions;
        RulesList.ItemsSource = _rules;

        // Default save folder to Scripts directory
        _saveFolder = System.IO.Path.Combine(AppContext.BaseDirectory, "Scripts");
        SaveFolderBox.Text = _saveFolder;

        // Update rule dropdowns when collections change
        _regions.CollectionChanged += (_, __) => RefreshRuleDropdowns();
        _actions.CollectionChanged += (_, __) => RefreshRuleDropdowns();

        // Clipboard paste support — Ctrl+V to paste a screenshot
        var pasteCmd = new RoutedCommand();
        pasteCmd.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Control));
        CommandBindings.Add(new CommandBinding(pasteCmd, OnPasteImage));

        // Drag-drop support for image files
        AllowDrop = true;
        Drop += OnDropImage;
        DragOver += (s, e) =>
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Bitmap)
                ? DragDropEffects.Copy : DragDropEffects.None;
            e.Handled = true;
        };
    }

    // =========================================================================
    // Clipboard paste / drag-drop
    // =========================================================================

    private void OnPasteImage(object sender, ExecutedRoutedEventArgs e)
    {
        try
        {
            if (Clipboard.ContainsImage())
            {
                var bmp = Clipboard.GetImage();
                if (bmp is not null)
                {
                    BitmapSource frozen;
                    if (bmp.IsFrozen) frozen = bmp;
                    else { frozen = bmp.Clone(); frozen.Freeze(); }
                    SetImage(frozen, "Pasted from clipboard");
                    return;
                }
            }

            if (Clipboard.ContainsFileDropList())
            {
                var files = Clipboard.GetFileDropList();
                foreach (var file in files)
                {
                    if (file is not null && IsImageFile(file))
                    {
                        LoadImageFromFile(file);
                        return;
                    }
                }
            }

            StatusText.Text = "No image in clipboard. Copy a screenshot first (Win+Shift+S or Print Screen).";
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Paste failed: {ex.Message}";
        }
    }

    private void OnDropImage(object sender, DragEventArgs e)
    {
        try
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                {
                    if (IsImageFile(file))
                    {
                        LoadImageFromFile(file);
                        return;
                    }
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                var bmp = e.Data.GetData(DataFormats.Bitmap) as BitmapSource;
                if (bmp is not null)
                {
                    BitmapSource frozen;
                    if (bmp.IsFrozen) frozen = bmp;
                    else { frozen = bmp.Clone(); frozen.Freeze(); }
                    SetImage(frozen, "Dropped image");
                }
            }
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Drop failed: {ex.Message}";
        }
    }

    private static bool IsImageFile(string path)
    {
        var ext = System.IO.Path.GetExtension(path).ToLowerInvariant();
        return ext is ".png" or ".jpg" or ".jpeg" or ".bmp" or ".gif" or ".webp";
    }

    private void LoadImageFromFile(string path)
    {
        try
        {
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(path);
            bmp.CacheOption = BitmapCacheOption.OnLoad;
            bmp.EndInit();
            bmp.Freeze();
            SetImage(bmp, System.IO.Path.GetFileName(path));
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Failed to load image: {ex.Message}";
        }
    }

    // =========================================================================
    // Capture from live feed
    // =========================================================================

    private void OnCaptureFeed(object sender, RoutedEventArgs e)
    {
        if (_mainVm is null)
        {
            StatusText.Text = "No session manager available";
            return;
        }

        // Find the first occupied session with a frame
        var session = _mainVm.Slots.FirstOrDefault(s => s.IsOccupied && s.CaptureFrame is not null);
        if (session is null)
        {
            StatusText.Text = "No active session with a frame — start a session first";
            return;
        }

        var frame = session.CaptureFrame;
        if (frame is null)
        {
            StatusText.Text = "Frame not available yet — try again in a moment";
            return;
        }

        // Freeze a copy for thread safety
        BitmapSource frozen;
        if (frame.IsFrozen)
        {
            frozen = frame;
        }
        else
        {
            frozen = frame.Clone();
            frozen.Freeze();
        }

        SetImage(frozen, $"Live capture from Session {session.SlotIndex}");

        // Auto-save the screenshot to the save folder
        try
        {
            Directory.CreateDirectory(_saveFolder);
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var savePath = System.IO.Path.Combine(_saveFolder, $"capture_{timestamp}.png");
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(frozen));
            using var fs = new FileStream(savePath, FileMode.Create);
            encoder.Save(fs);
            StatusText.Text += $" | Saved: {System.IO.Path.GetFileName(savePath)}";
        }
        catch (Exception ex)
        {
            StatusText.Text += $" | Save failed: {ex.Message}";
        }
    }

    // =========================================================================
    // Load image from file
    // =========================================================================

    private void OnLoadImage(object sender, RoutedEventArgs e)
    {
        var dlg = new OpenFileDialog
        {
            Title = "Load Screenshot",
            Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp|All|*.*",
        };
        if (dlg.ShowDialog() != true) return;

        try
        {
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(dlg.FileName);
            bmp.CacheOption = BitmapCacheOption.OnLoad;
            bmp.EndInit();
            bmp.Freeze();

            SetImage(bmp, System.IO.Path.GetFileName(dlg.FileName));
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Failed: {ex.Message}";
        }
    }

    private void SetImage(BitmapSource bmp, string label)
    {
        _sourceImage = bmp;
        _sourceWidth = bmp.PixelWidth;
        _sourceHeight = bmp.PixelHeight;

        ScreenshotImage.Source = bmp;
        ScreenshotImage.Width = DrawCanvas.ActualWidth;
        ScreenshotImage.Height = DrawCanvas.ActualHeight;

        StatusText.Text = $"Loaded: {label} ({_sourceWidth}x{_sourceHeight})";
        InstructionText.Text = "Use the tools above to mark regions and annotate";
    }

    private void OnCanvasSizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (_sourceImage is not null)
        {
            ScreenshotImage.Width = DrawCanvas.ActualWidth;
            ScreenshotImage.Height = DrawCanvas.ActualHeight;
        }
    }

    // =========================================================================
    // Drawing — Region / Highlight / Arrow / Freehand / Color Picker / Pixel
    // =========================================================================

    private string CurrentTool
    {
        get
        {
            if (ToolColorPicker.IsChecked == true) return "colorpicker";
            if (ToolPixelSampler.IsChecked == true) return "pixelsampler";
            if (ToolHighlight.IsChecked == true) return "highlight";
            if (ToolArrow.IsChecked == true) return "arrow";
            if (ToolFreehand.IsChecked == true) return "freehand";
            return "region";
        }
    }

    private (Brush stroke, Brush fill) ToolColors => CurrentTool switch
    {
        "colorpicker" => (new SolidColorBrush(Color.FromRgb(0xFF, 0x98, 0x00)),
                          Brushes.Transparent),
        "pixelsampler" => (new SolidColorBrush(Color.FromRgb(0xCE, 0x93, 0xD8)),
                           Brushes.Transparent),
        "highlight" => (new SolidColorBrush(Color.FromRgb(0xFF, 0xD7, 0x40)),
                        new SolidColorBrush(Color.FromArgb(0x40, 0xFF, 0xD7, 0x40))),
        "arrow"     => (new SolidColorBrush(Color.FromRgb(0xFF, 0x52, 0x52)),
                        Brushes.Transparent),
        "freehand"  => (new SolidColorBrush(Color.FromRgb(0xE0, 0x40, 0xFB)),
                        Brushes.Transparent),
        _           => (new SolidColorBrush(Color.FromRgb(0x21, 0x96, 0xF3)),
                        new SolidColorBrush(Color.FromArgb(0x30, 0x21, 0x96, 0xF3))),
    };

    private void OnCanvasMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (_sourceImage is null) return;

        var tool = CurrentTool;

        // ------ Single-click tools (color picker / pixel sampler) ------
        if (tool == "colorpicker")
        {
            HandleColorPick(e.GetPosition(DrawCanvas));
            return;
        }
        if (tool == "pixelsampler")
        {
            HandlePixelSample(e.GetPosition(DrawCanvas));
            return;
        }

        // ------ Drag-based tools ------
        _isDrawing = true;
        _drawStart = e.GetPosition(DrawCanvas);
        DrawCanvas.CaptureMouse();

        var (stroke, fill) = ToolColors;

        if (tool == "freehand")
        {
            _freehandPoints.Clear();
            _freehandPoints.Add(_drawStart);
            _freehandLine = new Polyline
            {
                Stroke = stroke,
                StrokeThickness = 3,
                StrokeLineJoin = PenLineJoin.Round,
            };
            _freehandLine.Points.Add(_drawStart);
            DrawCanvas.Children.Add(_freehandLine);
        }
        else if (tool == "arrow")
        {
            _drawShape = new Line
            {
                Stroke = stroke,
                StrokeThickness = 3,
                X1 = _drawStart.X,
                Y1 = _drawStart.Y,
                X2 = _drawStart.X,
                Y2 = _drawStart.Y,
            };
            DrawCanvas.Children.Add(_drawShape);
        }
        else
        {
            _drawShape = new Rectangle
            {
                Stroke = stroke,
                StrokeThickness = 2,
                StrokeDashArray = new DoubleCollection { 4, 2 },
                Fill = fill,
            };
            Canvas.SetLeft(_drawShape, _drawStart.X);
            Canvas.SetTop(_drawShape, _drawStart.Y);
            DrawCanvas.Children.Add(_drawShape);
        }
    }

    private void OnCanvasMouseMove(object sender, MouseEventArgs e)
    {
        if (!_isDrawing) return;

        var pos = e.GetPosition(DrawCanvas);
        var tool = CurrentTool;

        if (tool == "freehand" && _freehandLine is not null)
        {
            _freehandPoints.Add(pos);
            _freehandLine.Points.Add(pos);
        }
        else if (tool == "arrow" && _drawShape is Line line)
        {
            line.X2 = pos.X;
            line.Y2 = pos.Y;
        }
        else if (_drawShape is Rectangle rect)
        {
            var x = Math.Min(pos.X, _drawStart.X);
            var y = Math.Min(pos.Y, _drawStart.Y);
            var w = Math.Abs(pos.X - _drawStart.X);
            var h = Math.Abs(pos.Y - _drawStart.Y);

            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            rect.Width = w;
            rect.Height = h;
        }
    }

    private void OnCanvasMouseUp(object sender, MouseButtonEventArgs e)
    {
        if (!_isDrawing || _sourceImage is null) return;

        _isDrawing = false;
        DrawCanvas.ReleaseMouseCapture();

        var tool = CurrentTool;
        var canvasW = DrawCanvas.ActualWidth;
        var canvasH = DrawCanvas.ActualHeight;
        var scaleX = _sourceWidth / canvasW;
        var scaleY = _sourceHeight / canvasH;

        if (tool == "freehand")
        {
            // Just keep the polyline as-is, add as annotation
            if (_freehandPoints.Count > 5)
            {
                var bounds = GetPointsBounds(_freehandPoints);
                var region = new MarkedRegion
                {
                    Name = $"Freehand {_regions.Count + 1}",
                    Kind = "freehand",
                    DetectionType = "template",
                    X = (int)(bounds.X * scaleX),
                    Y = (int)(bounds.Y * scaleY),
                    Width = (int)(bounds.Width * scaleX),
                    Height = (int)(bounds.Height * scaleY),
                };
                _regions.Add(region);
                if (_freehandLine is not null) TrackShape(region, _freehandLine);
                RegionCountText.Text = _regions.Count.ToString();
                StatusText.Text = $"Added freehand annotation";
            }
            _freehandLine = null;
            return;
        }

        if (tool == "arrow" && _drawShape is Line arrowLine)
        {
            var region = new MarkedRegion
            {
                Name = $"Arrow {_regions.Count + 1}",
                Kind = "arrow",
                DetectionType = "template",
                X = (int)(Math.Min(arrowLine.X1, arrowLine.X2) * scaleX),
                Y = (int)(Math.Min(arrowLine.Y1, arrowLine.Y2) * scaleY),
                Width = (int)(Math.Abs(arrowLine.X2 - arrowLine.X1) * scaleX),
                Height = (int)(Math.Abs(arrowLine.Y2 - arrowLine.Y1) * scaleY),
            };
            _regions.Add(region);
            TrackShape(region, arrowLine);

            // Add arrowhead and track it
            var arrowHead = AddArrowHead(arrowLine);
            if (arrowHead is not null) TrackShape(region, arrowHead);

            RegionCountText.Text = _regions.Count.ToString();
            _drawShape = null;
            StatusText.Text = $"Added arrow annotation";
            return;
        }

        // Rectangle-based tools (region or highlight)
        if (_drawShape is not Rectangle rect) return;

        var w = rect.Width;
        var h = rect.Height;

        if (w < 10 || h < 10)
        {
            DrawCanvas.Children.Remove(rect);
            _drawShape = null;
            return;
        }

        var imgX = (int)(Canvas.GetLeft(rect) * scaleX);
        var imgY = (int)(Canvas.GetTop(rect) * scaleY);
        var imgW = (int)(w * scaleX);
        var imgH = (int)(h * scaleY);

        imgX = Math.Clamp(imgX, 0, _sourceWidth - 1);
        imgY = Math.Clamp(imgY, 0, _sourceHeight - 1);
        imgW = Math.Clamp(imgW, 1, _sourceWidth - imgX);
        imgH = Math.Clamp(imgH, 1, _sourceHeight - imgY);

        BitmapSource? thumbnail = null;
        byte[]? templateBytes = null;

        // Only crop templates for detection regions
        if (tool == "region")
        {
            var cropped = new CroppedBitmap(_sourceImage, new Int32Rect(imgX, imgY, imgW, imgH));
            thumbnail = BitmapFrame.Create(cropped);
            ((BitmapFrame)thumbnail).Freeze();

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(cropped));
            using var ms = new MemoryStream();
            encoder.Save(ms);
            templateBytes = ms.ToArray();
        }

        var markedRegion = new MarkedRegion
        {
            Name = tool == "region"
                ? $"Target {_regions.Count(r => r.Kind == "region") + 1}"
                : $"Highlight {_regions.Count(r => r.Kind == "highlight") + 1}",
            Kind = tool,
            DetectionType = "template",
            X = imgX, Y = imgY,
            Width = imgW, Height = imgH,
            Thumbnail = thumbnail,
            TemplateBytes = templateBytes,
        };

        _regions.Add(markedRegion);
        RegionCountText.Text = _regions.Count.ToString();

        // Make drawn rect solid
        rect.StrokeDashArray = null;
        if (tool == "region")
            rect.Stroke = new SolidColorBrush(Color.FromRgb(0x00, 0xE6, 0x76));

        // Track the rectangle for cleanup on delete
        TrackShape(markedRegion, rect);

        // Add label — tracked so it updates when the region is renamed
        var label = new TextBlock
        {
            Text = markedRegion.Name,
            Foreground = new SolidColorBrush(Colors.White),
            FontSize = 10,
            Background = new SolidColorBrush(Color.FromArgb(0xCC, 0x0D, 0x47, 0xA1)),
            Padding = new Thickness(4, 1, 4, 1),
        };
        Canvas.SetLeft(label, Canvas.GetLeft(rect));
        Canvas.SetTop(label, Canvas.GetTop(rect) - 18);
        DrawCanvas.Children.Add(label);
        TrackShape(markedRegion, label);

        _regionLabels[markedRegion] = label;
        markedRegion.PropertyChanged += (s, args) =>
        {
            if (args.PropertyName == nameof(MarkedRegion.Name) && s is MarkedRegion r && _regionLabels.TryGetValue(r, out var lbl))
                lbl.Text = r.Name;
        };

        _drawShape = null;
        StatusText.Text = $"Added {tool}: {markedRegion.Name} ({imgW}x{imgH})";
    }

    // =========================================================================
    // Color Picker tool
    // =========================================================================

    private void HandleColorPick(Point canvasPos)
    {
        if (_sourceImage is null) return;

        var canvasW = DrawCanvas.ActualWidth;
        var canvasH = DrawCanvas.ActualHeight;
        var scaleX = _sourceWidth / canvasW;
        var scaleY = _sourceHeight / canvasH;

        var imgX = (int)(canvasPos.X * scaleX);
        var imgY = (int)(canvasPos.Y * scaleY);

        imgX = Math.Clamp(imgX, 0, _sourceWidth - 1);
        imgY = Math.Clamp(imgY, 0, _sourceHeight - 1);

        // Sample the pixel color from the source image
        var (b, g, r) = SamplePixel(imgX, imgY);

        // Convert BGR to HSV
        var (hue, sat, val) = BgrToHsv(b, g, r);

        // Build HSV range with tolerance
        int hueLow = Math.Clamp(hue - 15, 0, 179);
        int hueHigh = Math.Clamp(hue + 15, 0, 179);
        int satLow = Math.Clamp(sat - 50, 0, 255);
        int satHigh = Math.Clamp(sat + 50, 0, 255);
        int valLow = Math.Clamp(val - 50, 0, 255);
        int valHigh = Math.Clamp(val + 50, 0, 255);

        // Create a small color swatch thumbnail
        var swatch = CreateColorSwatch(r, g, b, 40, 40);

        var region = new MarkedRegion
        {
            Name = $"Color {_regions.Count(rr => rr.DetectionType == "color") + 1}",
            Kind = "region",
            DetectionType = "color",
            X = imgX, Y = imgY,
            Width = 1, Height = 1,
            Thumbnail = swatch,
            HueLow = hueLow, HueHigh = hueHigh,
            SatLow = satLow, SatHigh = satHigh,
            ValLow = valLow, ValHigh = valHigh,
        };

        _regions.Add(region);
        RegionCountText.Text = _regions.Count.ToString();

        // Draw a small circle on the canvas at the clicked position
        var circle = new Ellipse
        {
            Width = 16, Height = 16,
            Stroke = new SolidColorBrush(Color.FromRgb(0xFF, 0x98, 0x00)),
            StrokeThickness = 2,
            Fill = new SolidColorBrush(Color.FromRgb(r, g, b)),
        };
        Canvas.SetLeft(circle, canvasPos.X - 8);
        Canvas.SetTop(circle, canvasPos.Y - 8);
        DrawCanvas.Children.Add(circle);
        TrackShape(region, circle);

        // Show popup info
        var label = new TextBlock
        {
            Text = $"BGR({b},{g},{r}) HSV({hue},{sat},{val})",
            Foreground = Brushes.White,
            FontSize = 9,
            Background = new SolidColorBrush(Color.FromArgb(0xDD, 0x0D, 0x15, 0x25)),
            Padding = new Thickness(4, 2, 4, 2),
        };
        Canvas.SetLeft(label, canvasPos.X + 12);
        Canvas.SetTop(label, canvasPos.Y - 8);
        DrawCanvas.Children.Add(label);
        TrackShape(region, label);

        _regionLabels[region] = label;
        region.PropertyChanged += (s, args) =>
        {
            if (args.PropertyName == nameof(MarkedRegion.Name) && s is MarkedRegion rr && _regionLabels.TryGetValue(rr, out var lbl))
                lbl.Text = $"{rr.Name} BGR({b},{g},{r})";
        };

        StatusText.Text = $"Color sampled @ ({imgX},{imgY}): BGR({b},{g},{r}) HSV({hue},{sat},{val}) range +/-15H +/-50S +/-50V";
    }

    // =========================================================================
    // Pixel Sampler tool
    // =========================================================================

    private void HandlePixelSample(Point canvasPos)
    {
        if (_sourceImage is null) return;

        var canvasW = DrawCanvas.ActualWidth;
        var canvasH = DrawCanvas.ActualHeight;
        var scaleX = _sourceWidth / canvasW;
        var scaleY = _sourceHeight / canvasH;

        var imgX = (int)(canvasPos.X * scaleX);
        var imgY = (int)(canvasPos.Y * scaleY);

        imgX = Math.Clamp(imgX, 0, _sourceWidth - 1);
        imgY = Math.Clamp(imgY, 0, _sourceHeight - 1);

        var (b, g, r) = SamplePixel(imgX, imgY);

        var swatch = CreateColorSwatch(r, g, b, 40, 40);

        var region = new MarkedRegion
        {
            Name = $"Pixel {_regions.Count(rr => rr.DetectionType == "pixel") + 1}",
            Kind = "region",
            DetectionType = "pixel",
            X = imgX, Y = imgY,
            Width = 1, Height = 1,
            Thumbnail = swatch,
            PixelB = b, PixelG = g, PixelR = r,
        };

        _regions.Add(region);
        RegionCountText.Text = _regions.Count.ToString();

        // Draw a crosshair on the canvas
        var size = 12.0;
        var hLine = new Line
        {
            X1 = canvasPos.X - size, Y1 = canvasPos.Y,
            X2 = canvasPos.X + size, Y2 = canvasPos.Y,
            Stroke = new SolidColorBrush(Color.FromRgb(0xCE, 0x93, 0xD8)),
            StrokeThickness = 2,
        };
        var vLine = new Line
        {
            X1 = canvasPos.X, Y1 = canvasPos.Y - size,
            X2 = canvasPos.X, Y2 = canvasPos.Y + size,
            Stroke = new SolidColorBrush(Color.FromRgb(0xCE, 0x93, 0xD8)),
            StrokeThickness = 2,
        };
        DrawCanvas.Children.Add(hLine);
        DrawCanvas.Children.Add(vLine);
        TrackShape(region, hLine);
        TrackShape(region, vLine);

        var label = new TextBlock
        {
            Text = $"({imgX},{imgY}) BGR({b},{g},{r})",
            Foreground = Brushes.White,
            FontSize = 9,
            Background = new SolidColorBrush(Color.FromArgb(0xDD, 0x6A, 0x1B, 0x9A)),
            Padding = new Thickness(4, 2, 4, 2),
        };
        Canvas.SetLeft(label, canvasPos.X + 14);
        Canvas.SetTop(label, canvasPos.Y - 8);
        DrawCanvas.Children.Add(label);
        TrackShape(region, label);

        _regionLabels[region] = label;

        StatusText.Text = $"Pixel sampled @ ({imgX},{imgY}): BGR({b},{g},{r})";
    }

    // =========================================================================
    // Pixel helper methods
    // =========================================================================

    private (byte b, byte g, byte r) SamplePixel(int imgX, int imgY)
    {
        if (_sourceImage is null) return (0, 0, 0);

        // Convert to Bgra32 for easy pixel access
        var formatted = new FormatConvertedBitmap(_sourceImage, PixelFormats.Bgra32, null, 0);
        var stride = formatted.PixelWidth * 4;
        var pixels = new byte[stride];
        formatted.CopyPixels(new Int32Rect(imgX, imgY, 1, 1), pixels, stride, 0);
        return (pixels[0], pixels[1], pixels[2]); // B, G, R
    }

    private static (int h, int s, int v) BgrToHsv(byte b, byte g, byte r)
    {
        // OpenCV-style HSV: H 0-179, S 0-255, V 0-255
        double rf = r / 255.0, gf = g / 255.0, bf = b / 255.0;
        double max = Math.Max(rf, Math.Max(gf, bf));
        double min = Math.Min(rf, Math.Min(gf, bf));
        double delta = max - min;

        double hue = 0;
        if (delta > 0.0001)
        {
            if (max == rf) hue = 60 * (((gf - bf) / delta) % 6);
            else if (max == gf) hue = 60 * (((bf - rf) / delta) + 2);
            else hue = 60 * (((rf - gf) / delta) + 4);
        }
        if (hue < 0) hue += 360;

        double sat = max > 0.0001 ? (delta / max) : 0;

        // Convert to OpenCV scale
        int h = (int)Math.Round(hue / 2.0); // 0-179
        int s = (int)Math.Round(sat * 255);
        int v = (int)Math.Round(max * 255);

        return (Math.Clamp(h, 0, 179), Math.Clamp(s, 0, 255), Math.Clamp(v, 0, 255));
    }

    private static BitmapSource CreateColorSwatch(byte r, byte g, byte b, int w, int h)
    {
        var pixels = new byte[w * h * 4];
        for (int i = 0; i < w * h; i++)
        {
            pixels[i * 4 + 0] = b;
            pixels[i * 4 + 1] = g;
            pixels[i * 4 + 2] = r;
            pixels[i * 4 + 3] = 255;
        }
        var bmp = BitmapSource.Create(w, h, 96, 96, PixelFormats.Bgra32, null, pixels, w * 4);
        bmp.Freeze();
        return bmp;
    }

    // =========================================================================
    // Arrow head helper
    // =========================================================================

    private Polygon? AddArrowHead(Line line)
    {
        var angle = Math.Atan2(line.Y2 - line.Y1, line.X2 - line.X1);
        var headLen = 14.0;
        var headAngle = Math.PI / 6;

        var p1 = new Point(
            line.X2 - headLen * Math.Cos(angle - headAngle),
            line.Y2 - headLen * Math.Sin(angle - headAngle));
        var p2 = new Point(
            line.X2 - headLen * Math.Cos(angle + headAngle),
            line.Y2 - headLen * Math.Sin(angle + headAngle));

        var head = new Polygon
        {
            Points = new PointCollection { new Point(line.X2, line.Y2), p1, p2 },
            Fill = line.Stroke,
        };
        DrawCanvas.Children.Add(head);
        return head;
    }

    private static Rect GetPointsBounds(List<Point> points)
    {
        var minX = points.Min(p => p.X);
        var minY = points.Min(p => p.Y);
        var maxX = points.Max(p => p.X);
        var maxY = points.Max(p => p.Y);
        return new Rect(minX, minY, maxX - minX, maxY - minY);
    }

    // =========================================================================
    // Region management
    // =========================================================================

    private void OnClearAll(object sender, RoutedEventArgs e)
    {
        _regions.Clear();
        _regionLabels.Clear();
        _regionShapes.Clear();
        RegionCountText.Text = "0";
        for (int i = DrawCanvas.Children.Count - 1; i >= 0; i--)
        {
            if (DrawCanvas.Children[i] is not Image)
                DrawCanvas.Children.RemoveAt(i);
        }
        StatusText.Text = "All regions and annotations cleared";
    }

    private void OnDeleteRegion(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is MarkedRegion region)
        {
            // Remove all visual shapes belonging to this region
            if (_regionShapes.TryGetValue(region, out var shapes))
            {
                foreach (var shape in shapes)
                    DrawCanvas.Children.Remove(shape);
                _regionShapes.Remove(region);
            }

            _regions.Remove(region);
            _regionLabels.Remove(region);
            RegionCountText.Text = _regions.Count.ToString();
            StatusText.Text = $"Removed: {region.Name}";
        }
    }

    private void OnRegionSelected(object sender, SelectionChangedEventArgs e) { }

    // =========================================================================
    // Add Detection shortcuts (center panel buttons)
    // =========================================================================

    private void OnAddTemplateRegion(object sender, RoutedEventArgs e)
    {
        ToolRegion.IsChecked = true;
        InstructionText.Text = "Draw a box around the target to create a template detection";
        StatusText.Text = "Region tool selected — draw a box on the image";
    }

    private void OnAddColorRange(object sender, RoutedEventArgs e)
    {
        ToolColorPicker.IsChecked = true;
        InstructionText.Text = "Click a pixel to sample its color and create an HSV range detection";
        StatusText.Text = "Color picker active — click on the image to sample a color";
    }

    private void OnAddPixelCheck(object sender, RoutedEventArgs e)
    {
        ToolPixelSampler.IsChecked = true;
        InstructionText.Text = "Click a pixel to record its position and expected color";
        StatusText.Text = "Pixel sampler active — click on the image to record a pixel check";
    }

    // =========================================================================
    // Action management
    // =========================================================================

    private void OnAddPressButton(object sender, RoutedEventArgs e)
    {
        var selected = (ButtonPickerCombo.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "A";
        _actions.Add(new ActionItem { Type = "press_button", Parameter = selected });
        ActionCountText.Text = _actions.Count.ToString();
        StatusText.Text = $"Added action: Press {selected}";
    }

    private void OnAddMoveStick(object sender, RoutedEventArgs e)
    {
        var selected = (StickPickerCombo.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Left Stick Up";
        _actions.Add(new ActionItem { Type = "move_stick", Parameter = selected });
        ActionCountText.Text = _actions.Count.ToString();
        StatusText.Text = $"Added action: Move {selected}";
    }

    private void OnAddWait(object sender, RoutedEventArgs e)
    {
        _actions.Add(new ActionItem { Type = "wait", Parameter = "500" });
        ActionCountText.Text = _actions.Count.ToString();
        StatusText.Text = "Added action: Wait 500ms";
    }

    private void OnAddEmitGamepad(object sender, RoutedEventArgs e)
    {
        _actions.Add(new ActionItem { Type = "emit_gamepad", Parameter = "" });
        ActionCountText.Text = _actions.Count.ToString();
        StatusText.Text = "Added action: Emit Gamepad State";
    }

    private void OnDeleteAction(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is ActionItem action)
        {
            _actions.Remove(action);
            ActionCountText.Text = _actions.Count.ToString();
        }
    }

    // =========================================================================
    // Rule management
    // =========================================================================

    private void OnAddRule(object sender, RoutedEventArgs e)
    {
        var rule = new RuleItem
        {
            Confidence = ThresholdSlider.Value,
        };

        // Populate dropdowns
        foreach (var r in _regions)
            rule.DetectionNames.Add(r.Name);
        foreach (var a in _actions)
            rule.ActionNames.Add(a.DisplayText);

        if (rule.DetectionNames.Count > 0)
            rule.DetectionName = rule.DetectionNames[0];
        if (rule.ActionNames.Count > 0)
            rule.ActionName = rule.ActionNames[0];

        _rules.Add(rule);
        RuleCountText.Text = _rules.Count.ToString();
        StatusText.Text = "Added new rule — configure detection and action";
    }

    private void OnDeleteRule(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is RuleItem rule)
        {
            _rules.Remove(rule);
            RuleCountText.Text = _rules.Count.ToString();
        }
    }

    private void RefreshRuleDropdowns()
    {
        var detNames = _regions.Select(r => r.Name).ToList();
        var actNames = _actions.Select(a => a.DisplayText).ToList();

        foreach (var rule in _rules)
        {
            rule.DetectionNames.Clear();
            foreach (var n in detNames) rule.DetectionNames.Add(n);

            rule.ActionNames.Clear();
            foreach (var n in actNames) rule.ActionNames.Add(n);
        }
    }

    // =========================================================================
    // Slider changed handlers
    // =========================================================================

    private void OnThresholdChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (ThresholdValueText is not null)
            ThresholdValueText.Text = e.NewValue.ToString("F2");
    }

    private void OnFpsChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (FpsValueText is not null)
            FpsValueText.Text = ((int)e.NewValue).ToString();
    }

    // =========================================================================
    // Folder selection
    // =========================================================================

    private void OnBrowseFolder(object sender, RoutedEventArgs e)
    {
        var folder = PickFolder(_saveFolder);
        if (folder is not null)
        {
            _saveFolder = folder;
            SaveFolderBox.Text = _saveFolder;
        }
    }

    /// <summary>Opens a native Windows folder picker dialog.</summary>
    private static string? PickFolder(string? initialDir = null)
    {
        var dialog = (IFileDialog)new FileOpenDialogRCW();
        dialog.GetOptions(out var options);
        dialog.SetOptions(options | FOS.FOS_PICKFOLDERS | FOS.FOS_FORCEFILESYSTEM);

        if (!string.IsNullOrEmpty(initialDir) && Directory.Exists(initialDir))
        {
            var riid = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"); // IShellItem
            SHCreateItemFromParsingName(initialDir, IntPtr.Zero, ref riid, out var folderItem);
            if (folderItem is not null)
                dialog.SetFolder(folderItem);
        }

        if (dialog.Show(IntPtr.Zero) != 0) return null;

        dialog.GetResult(out var resultItem);
        resultItem.GetDisplayName(SIGDN.SIGDN_FILESYSPATH, out var path);
        return path;
    }

    // COM interop for folder picker
    [DllImport("shell32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
    private static extern void SHCreateItemFromParsingName(
        string pszPath, IntPtr pbc, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out IShellItem ppv);

    [ComImport, Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")]
    private class FileOpenDialogRCW { }

    [ComImport, Guid("42F85136-DB7E-439C-85F1-E4075D135FC8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    private interface IFileDialog
    {
        [PreserveSig] int Show(IntPtr hwndOwner);
        void SetFileTypes(uint cFileTypes, IntPtr rgFilterSpec);
        void SetFileTypeIndex(uint iFileType);
        void GetFileTypeIndex(out uint piFileType);
        void Advise(IntPtr pfde, out uint pdwCookie);
        void Unadvise(uint dwCookie);
        void SetOptions(FOS fos);
        void GetOptions(out FOS pfos);
        void SetDefaultFolder(IShellItem psi);
        void SetFolder(IShellItem psi);
        void GetFolder(out IShellItem ppsi);
        void GetCurrentSelection(out IShellItem ppsi);
        void SetFileName([MarshalAs(UnmanagedType.LPWStr)] string pszName);
        void GetFileName([MarshalAs(UnmanagedType.LPWStr)] out string pszName);
        void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string pszTitle);
        void SetOkButtonLabel([MarshalAs(UnmanagedType.LPWStr)] string pszText);
        void SetFileNameLabel([MarshalAs(UnmanagedType.LPWStr)] string pszLabel);
        void GetResult(out IShellItem ppsi);
        void AddPlace(IShellItem psi, int fdap);
        void SetDefaultExtension([MarshalAs(UnmanagedType.LPWStr)] string pszDefaultExtension);
        void Close(int hr);
        void SetClientGuid(ref Guid guid);
        void ClearClientData();
        void SetFilter(IntPtr pFilter);
    }

    [ComImport, Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    private interface IShellItem
    {
        void BindToHandler(IntPtr pbc, ref Guid bhid, ref Guid riid, out IntPtr ppv);
        void GetParent(out IShellItem ppsi);
        void GetDisplayName(SIGDN sigdnName, [MarshalAs(UnmanagedType.LPWStr)] out string ppszName);
        void GetAttributes(uint sfgaoMask, out uint psfgaoAttribs);
        void Compare(IShellItem psi, uint hint, out int piOrder);
    }

    [Flags]
    private enum FOS : uint
    {
        FOS_PICKFOLDERS = 0x00000020,
        FOS_FORCEFILESYSTEM = 0x00000040,
    }

    private enum SIGDN : uint
    {
        SIGDN_FILESYSPATH = 0x80058000,
    }

    // =========================================================================
    // Test against frame
    // =========================================================================

    private void OnTestAgainstFrame(object sender, RoutedEventArgs e)
    {
        if (_sourceImage is null)
        {
            MessageBox.Show("Load or capture a screenshot first.", "No Image", MessageBoxButton.OK);
            return;
        }

        var templateRegions = _regions.Where(r => r.DetectionType == "template" && r.Kind == "region").ToList();
        var colorRegions = _regions.Where(r => r.DetectionType == "color").ToList();
        var pixelRegions = _regions.Where(r => r.DetectionType == "pixel").ToList();

        if (templateRegions.Count == 0 && colorRegions.Count == 0 && pixelRegions.Count == 0)
        {
            MessageBox.Show("Add at least one detection (template, color, or pixel) first.", "No Detections", MessageBoxButton.OK);
            return;
        }

        int matches = 0;
        var results = new StringBuilder();

        // Template matching: since we're testing the template against the same source image
        // it should always match, but it confirms the template extraction works
        foreach (var tmpl in templateRegions)
        {
            if (tmpl.TemplateBytes is not null)
            {
                results.AppendLine($"[Template] {tmpl.Name}: Extracted {tmpl.Width}x{tmpl.Height} @ ({tmpl.X},{tmpl.Y}) — will match at source location");
                matches++;
            }
        }

        // Color check: verify that the sampled pixel still has the expected color in range
        foreach (var cr in colorRegions)
        {
            var (b, g, r2) = SamplePixel(cr.X, cr.Y);
            var (h, s, v) = BgrToHsv(b, g, r2);
            bool inRange = h >= cr.HueLow && h <= cr.HueHigh
                        && s >= cr.SatLow && s <= cr.SatHigh
                        && v >= cr.ValLow && v <= cr.ValHigh;
            results.AppendLine($"[Color] {cr.Name}: HSV({h},{s},{v}) {(inRange ? "IN RANGE" : "OUT OF RANGE")} [{cr.HueLow}-{cr.HueHigh}]");
            if (inRange) matches++;
        }

        // Pixel check: verify color at position
        foreach (var px in pixelRegions)
        {
            var (b, g, r2) = SamplePixel(px.X, px.Y);
            int diff = Math.Abs(b - px.PixelB) + Math.Abs(g - px.PixelG) + Math.Abs(r2 - px.PixelR);
            bool pass = diff <= px.PixelTolerance * 3;
            results.AppendLine($"[Pixel] {px.Name}: BGR({b},{g},{r2}) vs expected ({px.PixelB},{px.PixelG},{px.PixelR}) diff={diff} {(pass ? "PASS" : "FAIL")}");
            if (pass) matches++;
        }

        int total = templateRegions.Count + colorRegions.Count + pixelRegions.Count;
        StatusText.Text = $"Test complete: {matches}/{total} detections matched";

        MessageBox.Show(
            $"Test Results: {matches}/{total} matched\n\n{results}",
            "Test Against Frame", MessageBoxButton.OK);
    }

    // =========================================================================
    // Save annotated screenshot
    // =========================================================================

    private void OnSaveScreenshot(object sender, RoutedEventArgs e)
    {
        if (_sourceImage is null)
        {
            MessageBox.Show("Load or capture a screenshot first.", "No Image", MessageBoxButton.OK);
            return;
        }

        try
        {
            var width = (int)DrawCanvas.ActualWidth;
            var height = (int)DrawCanvas.ActualHeight;
            if (width <= 0 || height <= 0) return;

            var rtb = new RenderTargetBitmap(width, height, 96, 96, PixelFormats.Pbgra32);
            rtb.Render(DrawCanvas);
            rtb.Freeze();

            Directory.CreateDirectory(_saveFolder);
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var savePath = System.IO.Path.Combine(_saveFolder, $"annotated_{timestamp}.png");

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            using var fs = new FileStream(savePath, FileMode.Create);
            encoder.Save(fs);

            StatusText.Text = $"Saved annotated screenshot: {savePath}";
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Save failed: {ex.Message}";
        }
    }

    // =========================================================================
    // Script generation
    // =========================================================================

    private void OnManualGenerate(object sender, RoutedEventArgs e)
    {
        var templateRegions = _regions.Where(r => r.DetectionType == "template" && r.Kind == "region").ToList();
        var colorRegions = _regions.Where(r => r.DetectionType == "color").ToList();
        var pixelRegions = _regions.Where(r => r.DetectionType == "pixel").ToList();

        int totalDetections = templateRegions.Count + colorRegions.Count + pixelRegions.Count;

        if (totalDetections == 0)
        {
            MessageBox.Show("Add at least one detection first.\n\nUse '+ Template Region', '+ Color Range', or '+ Pixel Check' to add detections.",
                "No Detections", MessageBoxButton.OK);
            return;
        }

        var scriptName = ScriptNameBox.Text.Trim();
        if (string.IsNullOrEmpty(scriptName)) scriptName = "my_cv_script";
        var safeName = string.Join("_", scriptName.Split(System.IO.Path.GetInvalidFileNameChars()));

        var outputDir = string.IsNullOrEmpty(_saveFolder)
            ? System.IO.Path.Combine(AppContext.BaseDirectory, "Scripts")
            : _saveFolder;

        var templatesDir = System.IO.Path.Combine(outputDir, $"{safeName}_templates");

        // Save template images
        var templateFiles = new List<string>();
        if (templateRegions.Count > 0)
        {
            Directory.CreateDirectory(templatesDir);
            foreach (var region in templateRegions)
            {
                if (region.TemplateBytes is null) continue;
                var fileName = $"{string.Join("_", region.Name.Split(System.IO.Path.GetInvalidFileNameChars()))}.png";
                var path = System.IO.Path.Combine(templatesDir, fileName);
                File.WriteAllBytes(path, region.TemplateBytes);
                templateFiles.Add(fileName);
            }
        }

        // Generate Python script
        var script = GenerateFullScript(safeName, templateRegions, colorRegions, pixelRegions);
        var scriptPath = System.IO.Path.Combine(outputDir, $"{safeName}.py");
        File.WriteAllText(scriptPath, script);

        // Also copy to Scripts folder for the dropdown
        var scriptsDir = System.IO.Path.Combine(AppContext.BaseDirectory, "Scripts");
        if (outputDir != scriptsDir)
        {
            try
            {
                Directory.CreateDirectory(scriptsDir);
                File.Copy(scriptPath, System.IO.Path.Combine(scriptsDir, $"{safeName}.py"), overwrite: true);
            }
            catch { }
        }

        StatusText.Text = $"Generated: {safeName}.py with {totalDetections} detections, {_actions.Count} actions, {_rules.Count} rules";
        MessageBox.Show(
            $"Script created!\n\n{scriptPath}\n\n{templateFiles.Count} template(s), {colorRegions.Count} color detection(s), {pixelRegions.Count} pixel check(s).\n{_actions.Count} action(s), {_rules.Count} rule(s).\n\nSelect '{safeName}.py' from the script dropdown to run it.",
            "Script Generated", MessageBoxButton.OK);
    }

    // =========================================================================
    // Full script generation with all detection types, actions, rules
    // =========================================================================

    private string GenerateFullScript(string name, List<MarkedRegion> templates,
        List<MarkedRegion> colors, List<MarkedRegion> pixels)
    {
        int totalDetections = templates.Count + colors.Count + pixels.Count;
        bool directCapture = ChkDirectCapture.IsChecked == true;
        bool drawOverlay = ChkDrawOverlay.IsChecked == true;
        bool multiScale = ChkMultiScale.IsChecked == true;
        double threshold = ThresholdSlider.Value;
        int fpsTarget = (int)FpsSlider.Value;

        var sb = new StringBuilder();

        // Header
        sb.AppendLine($"\"\"\"");
        sb.AppendLine($"TM Labs — {name}.py");
        sb.AppendLine($"Auto-generated CV script with {totalDetections} detections, {_actions.Count} actions, {_rules.Count} rules.");
        sb.AppendLine($"\"\"\"");
        sb.AppendLine();
        sb.AppendLine("import cv2");
        sb.AppendLine("import numpy as np");
        sb.AppendLine("import os");
        sb.AppendLine("import time");
        sb.AppendLine("from helios_compat import *");
        sb.AppendLine();

        // Constants
        sb.AppendLine($"DIRECT_CAPTURE = {(directCapture ? "True" : "False")}");
        sb.AppendLine($"MATCH_THRESHOLD = {threshold:F2}");
        sb.AppendLine($"FPS_TARGET = {fpsTarget}");
        sb.AppendLine($"DRAW_OVERLAY = {(drawOverlay ? "True" : "False")}");
        sb.AppendLine($"MULTI_SCALE = {(multiScale ? "True" : "False")}");
        sb.AppendLine();
        sb.AppendLine("_templates = []");
        sb.AppendLine("_frame_count = 0");
        sb.AppendLine("_fps_start = 0.0");
        sb.AppendLine("_fps = 0.0");
        sb.AppendLine();

        // Color range definitions
        if (colors.Count > 0)
        {
            sb.AppendLine("# Color range detections (HSV lower, HSV upper)");
            sb.AppendLine("_color_ranges = [");
            foreach (var c in colors)
            {
                var safeCName = c.Name.Replace("'", "\\'");
                sb.AppendLine($"    ('{safeCName}', np.array([{c.HueLow}, {c.SatLow}, {c.ValLow}]), np.array([{c.HueHigh}, {c.SatHigh}, {c.ValHigh}])),");
            }
            sb.AppendLine("]");
            sb.AppendLine();
        }

        // Pixel check definitions
        if (pixels.Count > 0)
        {
            sb.AppendLine("# Pixel check detections (name, x, y, expected_b, expected_g, expected_r, tolerance)");
            sb.AppendLine("_pixel_checks = [");
            foreach (var p in pixels)
            {
                var safePName = p.Name.Replace("'", "\\'");
                sb.AppendLine($"    ('{safePName}', {p.X}, {p.Y}, {p.PixelB}, {p.PixelG}, {p.PixelR}, {p.PixelTolerance}),");
            }
            sb.AppendLine("]");
            sb.AppendLine();
        }

        // Button mapping
        sb.AppendLine("# Button index mapping for gcvdata");
        sb.AppendLine("_BUTTON_MAP = {");
        sb.AppendLine("    'A': 0, 'B': 1, 'X': 2, 'Y': 3,");
        sb.AppendLine("    'LB': 4, 'RB': 5, 'LT': 6, 'RT': 7,");
        sb.AppendLine("    'Select': 8, 'Start': 9,");
        sb.AppendLine("    'DPad Up': 10, 'DPad Down': 11, 'DPad Left': 12, 'DPad Right': 13,");
        sb.AppendLine("}");
        sb.AppendLine();

        // on_start
        sb.AppendLine();
        sb.AppendLine("def on_start(config: dict) -> None:");
        sb.AppendLine("    global _templates, _frame_count, _fps_start");
        sb.AppendLine("    _frame_count = 0");
        sb.AppendLine("    _fps_start = time.monotonic()");

        if (templates.Count > 0)
        {
            sb.AppendLine($"    templates_dir = os.path.join(os.path.dirname(os.path.abspath(__file__)), '{name}_templates')");
            sb.AppendLine("    _templates = []");
            sb.AppendLine("    if os.path.isdir(templates_dir):");
            sb.AppendLine("        for f in sorted(os.listdir(templates_dir)):");
            sb.AppendLine("            if f.endswith('.png'):");
            sb.AppendLine("                path = os.path.join(templates_dir, f)");
            sb.AppendLine("                tmpl = cv2.imread(path)");
            sb.AppendLine("                if tmpl is not None:");
            sb.AppendLine("                    name_str = os.path.splitext(f)[0]");
            sb.AppendLine("                    _templates.append((name_str, tmpl))");
            sb.AppendLine($"                    print(f'[{name}] Loaded template: {{name_str}} ({{tmpl.shape[1]}}x{{tmpl.shape[0]}})')");
        }

        sb.AppendLine($"    print(f'[{name}] started with {{len(_templates)}} templates, {colors.Count} color ranges, {pixels.Count} pixel checks')");
        sb.AppendLine();

        // Action helper functions
        if (_actions.Count > 0)
        {
            sb.AppendLine();
            sb.AppendLine("def _do_action(action_name, axes, buttons):");
            sb.AppendLine("    \"\"\"Execute a named action, modifying axes/buttons in place.\"\"\"");

            int actionIdx = 0;
            foreach (var action in _actions)
            {
                string condition = actionIdx == 0 ? "if" : "elif";
                var safeDisplay = action.DisplayText.Replace("'", "\\'");

                if (action.Type == "press_button")
                {
                    sb.AppendLine($"    {condition} action_name == '{safeDisplay}':");
                    sb.AppendLine($"        idx = _BUTTON_MAP.get('{action.Parameter}', -1)");
                    sb.AppendLine("        if idx >= 0 and idx < len(buttons):");
                    sb.AppendLine("            buttons[idx] = True");
                }
                else if (action.Type == "move_stick")
                {
                    sb.AppendLine($"    {condition} action_name == '{safeDisplay}':");
                    // Parse stick direction
                    var param = action.Parameter;
                    string axisCode = "pass";
                    if (param.Contains("Left") && param.Contains("Up")) axisCode = "axes[1] = -1.0";
                    else if (param.Contains("Left") && param.Contains("Down")) axisCode = "axes[1] = 1.0";
                    else if (param.Contains("Left") && param.Contains("Left")) axisCode = "axes[0] = -1.0";
                    else if (param.Contains("Left") && param.Contains("Right")) axisCode = "axes[0] = 1.0";
                    else if (param.Contains("Right") && param.Contains("Up")) axisCode = "axes[3] = -1.0";
                    else if (param.Contains("Right") && param.Contains("Down")) axisCode = "axes[3] = 1.0";
                    else if (param.StartsWith("Right") && param.Contains("Left")) axisCode = "axes[2] = -1.0";
                    else if (param.StartsWith("Right") && param.EndsWith("Right")) axisCode = "axes[2] = 1.0";
                    sb.AppendLine($"        {axisCode}");
                }
                else if (action.Type == "wait")
                {
                    sb.AppendLine($"    {condition} action_name == '{safeDisplay}':");
                    sb.AppendLine($"        time.sleep({action.Parameter} / 1000.0)");
                }
                else if (action.Type == "emit_gamepad")
                {
                    sb.AppendLine($"    {condition} action_name == '{safeDisplay}':");
                    sb.AppendLine("        pass  # gamepad state emitted at end of frame");
                }

                actionIdx++;
            }
            sb.AppendLine();
        }

        // on_frame
        sb.AppendLine();
        sb.AppendLine("def on_frame(frame: np.ndarray, session_id: int, emit) -> None:");
        sb.AppendLine("    global _frame_count, _fps_start, _fps");
        sb.AppendLine("    _frame_count += 1");
        sb.AppendLine("    h, w = frame.shape[:2]");
        sb.AppendLine();
        sb.AppendLine("    # FPS tracking");
        sb.AppendLine("    elapsed = time.monotonic() - _fps_start");
        sb.AppendLine("    if elapsed >= 1.0:");
        sb.AppendLine("        _fps = _frame_count / elapsed");
        sb.AppendLine("        _frame_count = 0");
        sb.AppendLine("        _fps_start = time.monotonic()");
        sb.AppendLine();
        sb.AppendLine("    overlay = frame.copy() if DRAW_OVERLAY else None");
        sb.AppendLine("    detections = {}  # name -> confidence");
        sb.AppendLine();

        // Template matching
        if (templates.Count > 0)
        {
            sb.AppendLine("    # --- Template matching ---");
            sb.AppendLine("    for tmpl_name, tmpl in _templates:");
            sb.AppendLine("        th, tw = tmpl.shape[:2]");
            sb.AppendLine("        best_val = 0");
            sb.AppendLine("        best_loc = None");
            sb.AppendLine("        best_scale = 1.0");
            sb.AppendLine();
            sb.AppendLine("        scales = [0.5, 0.75, 1.0, 1.25, 1.5] if MULTI_SCALE else [1.0]");
            sb.AppendLine("        for scale in scales:");
            sb.AppendLine("            scaled_w = int(tw * scale)");
            sb.AppendLine("            scaled_h = int(th * scale)");
            sb.AppendLine("            if scaled_w >= w or scaled_h >= h or scaled_w < 10 or scaled_h < 10:");
            sb.AppendLine("                continue");
            sb.AppendLine("            resized = cv2.resize(tmpl, (scaled_w, scaled_h))");
            sb.AppendLine("            result = cv2.matchTemplate(frame, resized, cv2.TM_CCOEFF_NORMED)");
            sb.AppendLine("            _, max_val, _, max_loc = cv2.minMaxLoc(result)");
            sb.AppendLine("            if max_val > best_val:");
            sb.AppendLine("                best_val = max_val");
            sb.AppendLine("                best_loc = max_loc");
            sb.AppendLine("                best_scale = scale");
            sb.AppendLine();
            sb.AppendLine("        if best_val >= MATCH_THRESHOLD and best_loc is not None:");
            sb.AppendLine("            bw = int(tw * best_scale)");
            sb.AppendLine("            bh = int(th * best_scale)");
            sb.AppendLine("            detections[tmpl_name] = best_val");
            sb.AppendLine("            if DRAW_OVERLAY and overlay is not None:");
            sb.AppendLine("                cv2.rectangle(overlay, best_loc, (best_loc[0]+bw, best_loc[1]+bh), (0, 255, 0), 2)");
            sb.AppendLine("                cv2.putText(overlay, f'{tmpl_name} {best_val:.0%}', (best_loc[0], best_loc[1]-5),");
            sb.AppendLine("                            cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 255, 0), 1)");
            sb.AppendLine();
        }

        // Color range detection
        if (colors.Count > 0)
        {
            sb.AppendLine("    # --- Color range detection ---");
            sb.AppendLine("    hsv_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)");
            sb.AppendLine("    for cr_name, lower, upper in _color_ranges:");
            sb.AppendLine("        mask = cv2.inRange(hsv_frame, lower, upper)");
            sb.AppendLine("        pixel_count = cv2.countNonZero(mask)");
            sb.AppendLine("        total_pixels = h * w");
            sb.AppendLine("        ratio = pixel_count / total_pixels if total_pixels > 0 else 0");
            sb.AppendLine("        if pixel_count > 50:  # minimum pixel threshold");
            sb.AppendLine("            detections[cr_name] = min(1.0, ratio * 100)  # scale up for confidence");
            sb.AppendLine("            if DRAW_OVERLAY and overlay is not None:");
            sb.AppendLine("                contours, _ = cv2.findContours(mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)");
            sb.AppendLine("                if contours:");
            sb.AppendLine("                    largest = max(contours, key=cv2.contourArea)");
            sb.AppendLine("                    x, y, cw, ch = cv2.boundingRect(largest)");
            sb.AppendLine("                    cv2.rectangle(overlay, (x, y), (x+cw, y+ch), (0, 165, 255), 2)");
            sb.AppendLine("                    cv2.putText(overlay, f'{cr_name} {pixel_count}px', (x, y-5),");
            sb.AppendLine("                                cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 165, 255), 1)");
            sb.AppendLine();
        }

        // Pixel check detection
        if (pixels.Count > 0)
        {
            sb.AppendLine("    # --- Pixel check detection ---");
            sb.AppendLine("    for px_name, px, py, exp_b, exp_g, exp_r, tol in _pixel_checks:");
            sb.AppendLine("        if py < h and px < w:");
            sb.AppendLine("            actual = frame[py, px]");
            sb.AppendLine("            diff = abs(int(actual[0]) - exp_b) + abs(int(actual[1]) - exp_g) + abs(int(actual[2]) - exp_r)");
            sb.AppendLine("            if diff <= tol * 3:");
            sb.AppendLine("                confidence = 1.0 - (diff / (tol * 3.0))");
            sb.AppendLine("                detections[px_name] = confidence");
            sb.AppendLine("                if DRAW_OVERLAY and overlay is not None:");
            sb.AppendLine("                    cv2.circle(overlay, (px, py), 8, (208, 147, 206), 2)");
            sb.AppendLine("                    cv2.putText(overlay, f'{px_name} OK', (px+10, py+4),");
            sb.AppendLine("                                cv2.FONT_HERSHEY_SIMPLEX, 0.4, (208, 147, 206), 1)");
            sb.AppendLine();
        }

        // Rule evaluation
        sb.AppendLine("    # --- Rule evaluation ---");
        sb.AppendLine("    axes = [0.0, 0.0, 0.0, 0.0]");
        sb.AppendLine("    buttons = [False] * 17");
        sb.AppendLine();

        if (_rules.Count > 0)
        {
            foreach (var rule in _rules)
            {
                var safeDet = rule.DetectionName.Replace("'", "\\'");
                var safeAct = rule.ActionName.Replace("'", "\\'");
                sb.AppendLine($"    # Rule: IF {safeDet} >= {rule.Confidence:F2} THEN {safeAct}");
                sb.AppendLine($"    if detections.get('{safeDet}', 0) >= {rule.Confidence:F2}:");
                if (_actions.Count > 0)
                {
                    sb.AppendLine($"        _do_action('{safeAct}', axes, buttons)");
                }
                else
                {
                    sb.AppendLine($"        pass  # action '{safeAct}' not defined");
                }
                sb.AppendLine();
            }
        }

        // Overlay HUD
        sb.AppendLine("    # --- HUD overlay ---");
        sb.AppendLine("    if DRAW_OVERLAY and overlay is not None:");
        sb.AppendLine($"        cv2.putText(overlay, f'{name} | {{_fps:.0f}} fps | {{len(detections)}} found', (10, 25),");
        sb.AppendLine("                    cv2.FONT_HERSHEY_SIMPLEX, 0.6, (0, 255, 0), 2)");
        sb.AppendLine();

        // Emit
        sb.AppendLine("    emit({'session_id': session_id, 'axes': axes, 'buttons': buttons})");
        sb.AppendLine("    if DRAW_OVERLAY and overlay is not None and hasattr(emit, 'cv_frame'):");
        sb.AppendLine("        emit.cv_frame(overlay)");
        sb.AppendLine();

        // on_stop
        sb.AppendLine();
        sb.AppendLine("def on_stop() -> None:");
        sb.AppendLine($"    print('[{name}] stopped')");

        return sb.ToString();
    }
}
