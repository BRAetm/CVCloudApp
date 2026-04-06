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
using Microsoft.Win32;

namespace CVCloudApp.UI.Views;

/// <summary>Region marked by the user for template detection.</summary>
public class DetectionRegion : INotifyPropertyChanged
{
    private string _name = "Region";
    public string Name { get => _name; set { _name = value; OnPropertyChanged(nameof(Name)); } }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public BitmapSource? Thumbnail { get; set; }
    public string SizeText => $"{Width}x{Height} @ ({X},{Y})";
    public byte[]? TemplateBytes { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

/// <summary>Visual script creator — load screenshots, draw detection regions, generate scripts.</summary>
public partial class ScriptCreatorWindow : Window
{
    private BitmapSource? _sourceImage;
    private int _sourceWidth, _sourceHeight;
    private readonly ObservableCollection<DetectionRegion> _regions = new();

    // Drawing state
    private bool _isDrawing;
    private Point _drawStart;
    private Rectangle? _drawRect;

    public ScriptCreatorWindow()
    {
        InitializeComponent();
        RegionsList.ItemsSource = _regions;
    }

    // ---------------------------------------------------------------------------
    // Load image
    // ---------------------------------------------------------------------------

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

            _sourceImage = bmp;
            _sourceWidth = bmp.PixelWidth;
            _sourceHeight = bmp.PixelHeight;

            ScreenshotImage.Source = bmp;
            ScreenshotImage.Width = DrawCanvas.ActualWidth;
            ScreenshotImage.Height = DrawCanvas.ActualHeight;

            StatusText.Text = $"Loaded: {System.IO.Path.GetFileName(dlg.FileName)} ({_sourceWidth}x{_sourceHeight})";
            InstructionText.Text = "Click and drag to mark regions you want to detect";
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Failed: {ex.Message}";
        }
    }

    // ---------------------------------------------------------------------------
    // Drawing rectangles on canvas
    // ---------------------------------------------------------------------------

    private void OnCanvasMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (_sourceImage is null) return;

        _isDrawing = true;
        _drawStart = e.GetPosition(DrawCanvas);
        DrawCanvas.CaptureMouse();

        _drawRect = new Rectangle
        {
            Stroke = new SolidColorBrush(Color.FromRgb(0x21, 0x96, 0xF3)),
            StrokeThickness = 2,
            StrokeDashArray = new DoubleCollection { 4, 2 },
            Fill = new SolidColorBrush(Color.FromArgb(0x30, 0x21, 0x96, 0xF3)),
        };
        Canvas.SetLeft(_drawRect, _drawStart.X);
        Canvas.SetTop(_drawRect, _drawStart.Y);
        DrawCanvas.Children.Add(_drawRect);
    }

    private void OnCanvasMouseMove(object sender, MouseEventArgs e)
    {
        if (!_isDrawing || _drawRect is null) return;

        var pos = e.GetPosition(DrawCanvas);
        var x = Math.Min(pos.X, _drawStart.X);
        var y = Math.Min(pos.Y, _drawStart.Y);
        var w = Math.Abs(pos.X - _drawStart.X);
        var h = Math.Abs(pos.Y - _drawStart.Y);

        Canvas.SetLeft(_drawRect, x);
        Canvas.SetTop(_drawRect, y);
        _drawRect.Width = w;
        _drawRect.Height = h;
    }

    private void OnCanvasMouseUp(object sender, MouseButtonEventArgs e)
    {
        if (!_isDrawing || _drawRect is null || _sourceImage is null) return;

        _isDrawing = false;
        DrawCanvas.ReleaseMouseCapture();

        var w = _drawRect.Width;
        var h = _drawRect.Height;

        if (w < 10 || h < 10)
        {
            DrawCanvas.Children.Remove(_drawRect);
            _drawRect = null;
            return;
        }

        // Convert canvas coords to image coords
        var canvasW = DrawCanvas.ActualWidth;
        var canvasH = DrawCanvas.ActualHeight;
        var scaleX = _sourceWidth / canvasW;
        var scaleY = _sourceHeight / canvasH;

        var imgX = (int)(Canvas.GetLeft(_drawRect) * scaleX);
        var imgY = (int)(Canvas.GetTop(_drawRect) * scaleY);
        var imgW = (int)(w * scaleX);
        var imgH = (int)(h * scaleY);

        // Clamp
        imgX = Math.Clamp(imgX, 0, _sourceWidth - 1);
        imgY = Math.Clamp(imgY, 0, _sourceHeight - 1);
        imgW = Math.Clamp(imgW, 1, _sourceWidth - imgX);
        imgH = Math.Clamp(imgH, 1, _sourceHeight - imgY);

        // Crop template
        var cropped = new CroppedBitmap(_sourceImage, new Int32Rect(imgX, imgY, imgW, imgH));
        var frozen = BitmapFrame.Create(cropped);
        frozen.Freeze();

        // Save template as PNG bytes
        var encoder = new PngBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(cropped));
        using var ms = new MemoryStream();
        encoder.Save(ms);
        var templateBytes = ms.ToArray();

        var region = new DetectionRegion
        {
            Name = $"Target {_regions.Count + 1}",
            X = imgX, Y = imgY,
            Width = imgW, Height = imgH,
            Thumbnail = frozen,
            TemplateBytes = templateBytes,
        };

        _regions.Add(region);
        RegionCountText.Text = _regions.Count.ToString();

        // Make the drawn rect solid
        _drawRect.StrokeDashArray = null;
        _drawRect.Stroke = new SolidColorBrush(Color.FromRgb(0x00, 0xE6, 0x76));

        // Add label
        var label = new TextBlock
        {
            Text = region.Name,
            Foreground = new SolidColorBrush(Colors.White),
            FontSize = 10,
            Background = new SolidColorBrush(Color.FromArgb(0xCC, 0x0D, 0x47, 0xA1)),
            Padding = new Thickness(4, 1, 4, 1),
        };
        Canvas.SetLeft(label, Canvas.GetLeft(_drawRect));
        Canvas.SetTop(label, Canvas.GetTop(_drawRect) - 18);
        DrawCanvas.Children.Add(label);

        _drawRect = null;
        StatusText.Text = $"Added region: {region.Name} ({imgW}x{imgH})";
    }

    // ---------------------------------------------------------------------------
    // Region management
    // ---------------------------------------------------------------------------

    private void OnClearRegions(object sender, RoutedEventArgs e)
    {
        _regions.Clear();
        RegionCountText.Text = "0";
        // Remove all rectangles and labels, keep the image
        for (int i = DrawCanvas.Children.Count - 1; i >= 0; i--)
        {
            if (DrawCanvas.Children[i] is not Image)
                DrawCanvas.Children.RemoveAt(i);
        }
        StatusText.Text = "All regions cleared";
    }

    private void OnDeleteRegion(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is DetectionRegion region)
        {
            _regions.Remove(region);
            RegionCountText.Text = _regions.Count.ToString();
        }
    }

    private void OnRegionSelected(object sender, SelectionChangedEventArgs e) { }

    // ---------------------------------------------------------------------------
    // Generate script
    // ---------------------------------------------------------------------------

    private void OnGenerate(object sender, RoutedEventArgs e)
    {
        if (_regions.Count == 0)
        {
            MessageBox.Show("Draw at least one detection region first.", "No Regions", MessageBoxButton.OK);
            return;
        }

        var scriptName = ScriptNameBox.Text.Trim();
        if (string.IsNullOrEmpty(scriptName))
            scriptName = "my_detection";

        // Clean name for filename
        var safeName = string.Join("_", scriptName.Split(System.IO.Path.GetInvalidFileNameChars()));

        var scriptsDir = System.IO.Path.Combine(AppContext.BaseDirectory, "Scripts");
        var templatesDir = System.IO.Path.Combine(scriptsDir, $"{safeName}_templates");
        Directory.CreateDirectory(templatesDir);

        // Save template images
        var templateFiles = new List<string>();
        foreach (var region in _regions)
        {
            if (region.TemplateBytes is null) continue;
            var fileName = $"{string.Join("_", region.Name.Split(System.IO.Path.GetInvalidFileNameChars()))}.png";
            var path = System.IO.Path.Combine(templatesDir, fileName);
            File.WriteAllBytes(path, region.TemplateBytes);
            templateFiles.Add(fileName);
        }

        // Generate Python script
        var actionIndex = ActionCombo.SelectedIndex;
        var script = GeneratePythonScript(safeName, _regions.ToList(), actionIndex);
        var scriptPath = System.IO.Path.Combine(scriptsDir, $"{safeName}.py");
        File.WriteAllText(scriptPath, script);

        // Also save to source Scripts folder so it persists across builds
        var sourceScriptsDir = System.IO.Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Scripts");
        if (Directory.Exists(sourceScriptsDir))
        {
            try
            {
                var sourceTemplatesDir = System.IO.Path.Combine(sourceScriptsDir, $"{safeName}_templates");
                Directory.CreateDirectory(sourceTemplatesDir);
                foreach (var region in _regions)
                {
                    if (region.TemplateBytes is null) continue;
                    var fileName = $"{string.Join("_", region.Name.Split(System.IO.Path.GetInvalidFileNameChars()))}.png";
                    File.WriteAllBytes(System.IO.Path.Combine(sourceTemplatesDir, fileName), region.TemplateBytes);
                }
                File.WriteAllText(System.IO.Path.Combine(sourceScriptsDir, $"{safeName}.py"), script);
            }
            catch { }
        }

        StatusText.Text = $"Generated: {safeName}.py with {templateFiles.Count} templates";
        MessageBox.Show($"Script created!\n\n{scriptPath}\n\n{templateFiles.Count} template(s) saved.\n\nSelect '{safeName}.py' from the script dropdown to run it.",
            "Script Generated", MessageBoxButton.OK);
    }

    private static string GeneratePythonScript(string name, List<DetectionRegion> regions, int actionIndex)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"\"\"\"");
        sb.AppendLine($"TM Labs — {name}.py");
        sb.AppendLine($"Auto-generated template matching script.");
        sb.AppendLine($"Detects {regions.Count} target(s) using template matching.");
        sb.AppendLine($"\"\"\"");
        sb.AppendLine();
        sb.AppendLine("import cv2");
        sb.AppendLine("import numpy as np");
        sb.AppendLine("import os");
        sb.AppendLine("import time");
        sb.AppendLine();
        sb.AppendLine("# Detection threshold (0.0 to 1.0 — higher = stricter matching)");
        sb.AppendLine("MATCH_THRESHOLD = 0.70");
        sb.AppendLine();
        sb.AppendLine("# Template images");
        sb.AppendLine("_templates = []");
        sb.AppendLine("_frame_count = 0");
        sb.AppendLine("_fps_start = 0.0");
        sb.AppendLine("_fps = 0.0");
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendLine("def on_start(config: dict) -> None:");
        sb.AppendLine("    global _templates, _frame_count, _fps_start");
        sb.AppendLine("    _frame_count = 0");
        sb.AppendLine("    _fps_start = time.monotonic()");
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
        sb.AppendLine("                    print(f'[{name}] Loaded template: {name_str} ({tmpl.shape[1]}x{tmpl.shape[0]})')");
        sb.AppendLine($"    print(f'[{name}] started with {{len(_templates)}} templates')");
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendLine("def on_frame(frame: np.ndarray, session_id: int, emit) -> None:");
        sb.AppendLine("    global _frame_count, _fps_start, _fps");
        sb.AppendLine("    _frame_count += 1");
        sb.AppendLine("    h, w = frame.shape[:2]");
        sb.AppendLine();
        sb.AppendLine("    # FPS");
        sb.AppendLine("    elapsed = time.monotonic() - _fps_start");
        sb.AppendLine("    if elapsed >= 1.0:");
        sb.AppendLine("        _fps = _frame_count / elapsed");
        sb.AppendLine("        _frame_count = 0");
        sb.AppendLine("        _fps_start = time.monotonic()");
        sb.AppendLine();
        sb.AppendLine("    overlay = frame.copy()");
        sb.AppendLine("    detections = []");
        sb.AppendLine();
        sb.AppendLine("    # Multi-scale template matching");
        sb.AppendLine("    for tmpl_name, tmpl in _templates:");
        sb.AppendLine("        th, tw = tmpl.shape[:2]");
        sb.AppendLine("        best_val = 0");
        sb.AppendLine("        best_loc = None");
        sb.AppendLine("        best_scale = 1.0");
        sb.AppendLine();
        sb.AppendLine("        # Try multiple scales to handle distance changes");
        sb.AppendLine("        for scale in [0.5, 0.75, 1.0, 1.25, 1.5]:");
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
        sb.AppendLine("            cx = best_loc[0] + bw // 2");
        sb.AppendLine("            cy = best_loc[1] + bh // 2");
        sb.AppendLine("            detections.append((tmpl_name, best_loc, bw, bh, best_val, cx, cy))");
        sb.AppendLine("            # Draw detection box");
        sb.AppendLine("            cv2.rectangle(overlay, best_loc, (best_loc[0]+bw, best_loc[1]+bh), (0, 255, 0), 2)");
        sb.AppendLine("            cv2.putText(overlay, f'{tmpl_name} {best_val:.0%}', (best_loc[0], best_loc[1]-5),");
        sb.AppendLine("                        cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 255, 0), 1)");
        sb.AppendLine("        else:");
        sb.AppendLine("            # Show best match even if below threshold (for tuning)");
        sb.AppendLine("            if best_loc is not None:");
        sb.AppendLine("                bw = int(tw * best_scale)");
        sb.AppendLine("                bh = int(th * best_scale)");
        sb.AppendLine("                cv2.rectangle(overlay, best_loc, (best_loc[0]+bw, best_loc[1]+bh), (0, 0, 255), 1)");
        sb.AppendLine("                cv2.putText(overlay, f'{tmpl_name} {best_val:.0%}', (best_loc[0], best_loc[1]-5),");
        sb.AppendLine("                            cv2.FONT_HERSHEY_SIMPLEX, 0.4, (0, 0, 255), 1)");
        sb.AppendLine();
        sb.AppendLine("    # HUD");
        sb.AppendLine($"    cv2.putText(overlay, f'{name} | {{_fps:.0f}} fps | {{len(detections)}} found', (10, 25),");
        sb.AppendLine("                cv2.FONT_HERSHEY_SIMPLEX, 0.6, (0, 255, 0), 2)");
        sb.AppendLine();

        // Action based on selection
        sb.AppendLine("    # Action");
        sb.AppendLine("    axes = [0.0, 0.0, 0.0, 0.0]");
        sb.AppendLine("    buttons = [False] * 17");
        sb.AppendLine();

        switch (actionIndex)
        {
            case 0: // Press A
                sb.AppendLine("    if detections:");
                sb.AppendLine("        buttons[0] = True  # A button");
                break;
            case 1: // Press X
                sb.AppendLine("    if detections:");
                sb.AppendLine("        buttons[2] = True  # X button");
                break;
            case 2: // Walk toward
                sb.AppendLine("    if detections:");
                sb.AppendLine("        # Walk toward the first detection");
                sb.AppendLine("        _, _, _, _, _, cx, cy = detections[0]");
                sb.AppendLine("        dx = (cx / w) - 0.5");
                sb.AppendLine("        dy = (cy / h) - 0.5");
                sb.AppendLine("        dist = max((dx**2 + dy**2)**0.5, 0.01)");
                sb.AppendLine("        axes[0] = float(np.clip(dx / dist * 0.8, -1, 1))");
                sb.AppendLine("        axes[1] = float(np.clip(dy / dist * 0.8, -1, 1))");
                sb.AppendLine("        # Draw arrow");
                sb.AppendLine("        cv2.arrowedLine(overlay, (w//2, h//2), (cx, cy), (0, 255, 255), 2, tipLength=0.1)");
                break;
            case 3: // Visual only
                sb.AppendLine("    # Visual only — no gamepad input");
                break;
        }

        sb.AppendLine();
        sb.AppendLine("    emit({'session_id': session_id, 'axes': axes, 'buttons': buttons})");
        sb.AppendLine("    if hasattr(emit, 'cv_frame'):");
        sb.AppendLine("        emit.cv_frame(overlay)");
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendLine("def on_stop() -> None:");
        sb.AppendLine($"    print('[{name}] stopped')");

        return sb.ToString();
    }
}
