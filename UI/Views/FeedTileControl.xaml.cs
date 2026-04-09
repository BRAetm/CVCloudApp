using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using LabsVision.Core;
using LabsVision.UI.ViewModels;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

namespace LabsVision.UI.Views;

/// <summary>Feed tile that hosts an embedded WebView2 for cloud gaming.</summary>
public partial class FeedTileControl : System.Windows.Controls.UserControl, IWebViewTile
{
    private static readonly string UserDataRoot = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LabsVision", "WebView2");

    private const string InjectGamepadJs = @"(function() {
  if (window.__cvGamepad) { console.log('[CV] gamepad already injected'); return; }
  console.log('[CV] injecting virtual gamepad...');

  const gp = {
    axes: [0,0,0,0],
    buttons: Array(17).fill(null).map(()=>({pressed:false,value:0,touched:false})),
    connected: true,
    hapticActuators: [],
    id: 'Xbox 360 Controller (XInput STANDARD GAMEPAD)',
    index: 0,
    mapping: 'standard',
    timestamp: performance.now(),
    vibrationActuator: null
  };

  var _origGetGamepads = (navigator.getGamepads ? navigator.getGamepads.bind(navigator) : function(){return [];});
  function _cvGetGamepads() {
    var real = [];
    try { real = Array.from(_origGetGamepads()); } catch(e) {}
    var merged = [gp];
    for (var i = 0; i < real.length; i++) {
      if (real[i]) {
        var r = real[i];
        merged.push({
          axes: Array.from(r.axes),
          buttons: Array.from(r.buttons).map(function(b){return {pressed:b.pressed,value:b.value,touched:b.touched||false};}),
          connected: r.connected,
          hapticActuators: [],
          id: r.id, index: merged.length, mapping: r.mapping, timestamp: r.timestamp,
          vibrationActuator: null
        });
      }
    }
    while (merged.length < 4) merged.push(null);
    return merged;
  }

  // Override on both instance and prototype so all access patterns work
  Object.defineProperty(navigator, 'getGamepads', {
    value: _cvGetGamepads, writable: true, configurable: true
  });
  try {
    Navigator.prototype.getGamepads = _cvGetGamepads;
  } catch(e) {}

  window.__cvGamepad = gp;
  console.log('[CV] gamepad created, dispatching gamepadconnected event...');

  // Create a proper gamepadconnected event with gamepad property
  function _cvFireGamepadEvent() {
    var evt = new Event('gamepadconnected', {bubbles:true});
    Object.defineProperty(evt, 'gamepad', {value: gp, writable: false});
    window.dispatchEvent(evt);
  }
  _cvFireGamepadEvent();
  window.__cvFireGamepadEvent = _cvFireGamepadEvent;
  console.log('[CV] gamepadconnected event dispatched OK');

  // Visibility / focus spoofing
  Object.defineProperty(document, 'hidden', { get: () => false, configurable: true });
  Object.defineProperty(document, 'visibilityState', { get: () => 'visible', configurable: true });
  window.addEventListener('visibilitychange', function(e) { e.stopImmediatePropagation(); }, true);
  if (!document.hasFocus.__cv) {
    var _origHasFocus = document.hasFocus.bind(document);
    document.hasFocus = function() { return true; };
    document.hasFocus.__cv = true;
  }

  // Periodic keepalive — re-announce gamepad
  setInterval(function() {
    if (window.__cvGamepad && window.__cvFireGamepadEvent) {
      window.__cvGamepad.timestamp = performance.now();
      window.__cvFireGamepadEvent();
    }
  }, 3000);
})();";

    // Cloud play optimization JS — improves stream quality on bad connections
    private const string CloudOptimizeJs = @"(function() {
  console.log('[CV] applying cloud play optimizations...');

  // 1. Pre-set Xbox Cloud Gaming preferences for stable streaming
  try {
    // Bigger jitter buffer = more resilience to wifi spikes
    localStorage.setItem('xc.streaming.jitterBuffer', '300');
    // Prefer VP9 (better compression for low bandwidth)
    localStorage.setItem('xc.streaming.codec.preference', 'vp9');
    // Disable HDR (uses more bandwidth)
    localStorage.setItem('xc.streaming.hdr.enabled', 'false');
    // Lower max bitrate target if bandwidth is constrained
    localStorage.setItem('xc.streaming.maxBitrate', '10000000'); // 10 Mbps cap
    // Enable adaptive bitrate (reacts faster to network changes)
    localStorage.setItem('xc.streaming.abr.enabled', 'true');
    localStorage.setItem('xc.streaming.abr.aggressive', 'true');
  } catch(e) {}

  // 2. Disable resource-heavy CSS animations on the page chrome (not the game)
  try {
    var style = document.createElement('style');
    style.textContent = `
      *:not(video):not(canvas) { animation-duration: 0.01s !important; transition-duration: 0.01s !important; }
      .background-effect, .particle-effect, [class*='animation'] { display: none !important; }
    `;
    (document.head || document.documentElement).appendChild(style);
  } catch(e) {}

  // 3. Hint to browser: prioritize this tab for network resources
  try {
    if ('connection' in navigator && navigator.connection.saveData !== undefined) {
      // Pretend we're on a fast connection so streaming algorithms don't downgrade unnecessarily
      Object.defineProperty(navigator.connection, 'effectiveType', { get: function() { return '4g'; }, configurable: true });
      Object.defineProperty(navigator.connection, 'downlink', { get: function() { return 10; }, configurable: true });
      Object.defineProperty(navigator.connection, 'rtt', { get: function() { return 50; }, configurable: true });
    }
  } catch(e) {}

  // 4. Boost <video> element decode hints
  function tuneVideos() {
    document.querySelectorAll('video').forEach(function(v) {
      try {
        v.preload = 'auto';
        v.autoplay = true;
        // Hint to use hardware decode if available
        v.style.willChange = 'transform';
        // Remove any throttling
        if ('mediaSession' in navigator) {
          try { navigator.mediaSession.playbackState = 'playing'; } catch(e) {}
        }
      } catch(e) {}
    });
  }
  tuneVideos();
  setInterval(tuneVideos, 5000);

  console.log('[CV] cloud play optimizations applied');
})();";

    private int _sessionId = -1;
    private WebView2? _webView;
    private volatile bool _isReady;
    private volatile bool _isSending;
    private DispatcherTimer? _captureTimer;
    private volatile bool _isCapturing;
    private int _captureCount;
    private bool _isMuted;

    public FeedTileControl()
    {
        InitializeComponent();
    }

    /// <summary>True when WebView2 is initialized and ready for input.</summary>
    public bool IsWebViewReady => _isReady;

    /// <summary>True if WebView2 audio is currently muted.</summary>
    public bool IsMuted => _isMuted;

    /// <summary>Mutes or unmutes the WebView2 audio output.</summary>
    public void SetMuted(bool muted)
    {
        _isMuted = muted;
        if (_webView?.CoreWebView2 is null) return;

        if (!Dispatcher.CheckAccess())
        {
            Dispatcher.BeginInvoke(() => SetMuted(muted));
            return;
        }

        try
        {
            _webView.CoreWebView2.IsMuted = muted;
            Console.WriteLine($"[FeedTile] Session {_sessionId}: audio {(muted ? "MUTED" : "UNMUTED")}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FeedTile] Session {_sessionId}: SetMuted failed — {ex.Message}");
        }
    }

    /// <summary>Shows a CV frame in the floating CV preview window. WebView2 stays untouched.</summary>
    public void ShowCvFrame(byte[] jpegBytes)
    {
        if (!Dispatcher.CheckAccess())
        {
            Dispatcher.BeginInvoke(() => ShowCvFrame(jpegBytes));
            return;
        }

        try
        {
            using var ms = new MemoryStream(jpegBytes);
            var decoder = new JpegBitmapDecoder(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            var frame = BitmapFrame.Create(decoder.Frames[0]);
            frame.Freeze();

            // Show CV badge on tile
            CvBadge.Visibility = Visibility.Visible;

            // Open or update the floating CV window
            if (_cvWindow is null || !_cvWindow.IsLoaded)
            {
                _cvWindow = new CvPreviewWindow(_sessionId);
                _cvWindow.Show();
            }
            _cvWindow.UpdateFrame(frame);
        }
        catch { }
    }

    /// <summary>Closes the CV preview window.</summary>
    public void HideCvOverlay()
    {
        if (!Dispatcher.CheckAccess())
        {
            Dispatcher.BeginInvoke(HideCvOverlay);
            return;
        }
        CvBadge.Visibility = Visibility.Collapsed;
        try { _cvWindow?.Close(); } catch { }
        _cvWindow = null;
    }

    private CvPreviewWindow? _cvWindow;

    // ---------------------------------------------------------------------------
    // IWebViewTile
    // ---------------------------------------------------------------------------

    /// <summary>Creates WebView2 inside the tile, injects gamepad JS, and navigates.</summary>
    public async System.Threading.Tasks.Task InitWebViewAsync(string url)
    {
        if (_webView is not null) return;

        _webView = new WebView2();
        WebViewContainer.Children.Add(_webView);
        WaitingPanel.Visibility = Visibility.Collapsed;

        var userDataDir = Path.Combine(UserDataRoot, $"Session{_sessionId}");
        Directory.CreateDirectory(userDataDir);

        // Browser arguments optimized for low-bandwidth cloud gaming:
        // - GPU rasterization for hardware acceleration
        // - Larger network buffers for jitter resilience
        // - Disable background throttling so the stream stays smooth
        // - Force WebRTC echo cancellation off (saves CPU)
        // - DNS over HTTPS via Cloudflare (faster + more reliable on bad networks)
        var browserArgs = string.Join(" ", new[]
        {
            "--enable-gpu-rasterization",
            "--enable-zero-copy",
            "--disable-background-timer-throttling",
            "--disable-renderer-backgrounding",
            "--disable-backgrounding-occluded-windows",
            "--disable-features=CalculateNativeWinOcclusion",
            "--enable-features=NetworkService,NetworkServiceInProcess",
            "--force-effective-connection-type=4g",
            "--max-active-webgl-contexts=16",
            "--enable-webgl",
            "--ignore-gpu-blocklist",
            "--enable-accelerated-video-decode",
            "--enable-accelerated-2d-canvas",
        });

        var envOptions = new CoreWebView2EnvironmentOptions(additionalBrowserArguments: browserArgs);
        var env = await CoreWebView2Environment.CreateAsync(userDataFolder: userDataDir, options: envOptions);
        await _webView.EnsureCoreWebView2Async(env);

        // Capture console.log messages via CDP for debugging
        _webView.CoreWebView2.GetDevToolsProtocolEventReceiver("Runtime.consoleAPICalled")
            .DevToolsProtocolEventReceived += (s, args) =>
        {
            try
            {
                var obj = Newtonsoft.Json.Linq.JObject.Parse(args.ParameterObjectAsJson);
                var argsArr = obj["args"] as Newtonsoft.Json.Linq.JArray;
                if (argsArr?.Count > 0)
                {
                    var msg = argsArr[0]?["value"]?.ToString() ?? "";
                    if (msg.StartsWith("[CV]"))
                        ViewModels.DebugLog.Write($"[WebView2:{_sessionId}] {msg}");
                }
            }
            catch { }
        };
        await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Runtime.enable", "{}");

        await _webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(InjectGamepadJs);
        await _webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(CloudOptimizeJs);

        try
        {
            await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync(
                "Emulation.setFocusEmulationEnabled", "{\"enabled\":true}");
            Console.WriteLine($"[FeedTile] Session {_sessionId}: focus emulation enabled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FeedTile] Session {_sessionId}: focus emulation failed (non-fatal): {ex.Message}");
        }

        _webView.CoreWebView2.Navigate(url);
        _isReady = true;

        Console.WriteLine($"[FeedTile] Session {_sessionId}: WebView2 initialized, navigating to {url}");
    }

    /// <summary>Sends gamepad state to the injected JS gamepad.</summary>
    public void SendGamepadInput(GamepadState state)
    {
        if (!_isReady || _webView?.CoreWebView2 is null) return;
        if (_isSending) return;
        _isSending = true;

        var js = BuildGamepadStateJs(state);

        Dispatcher.BeginInvoke(async () =>
        {
            try
            {
                if (_webView?.CoreWebView2 is not null)
                    await _webView.CoreWebView2.ExecuteScriptAsync(js);
            }
            catch { }
            finally
            {
                _isSending = false;
            }
        });
    }

    /// <summary>Destroys the WebView2 and cleans up.</summary>
    // ---------------------------------------------------------------------------
    // Screencast (streaming frame capture — much faster than Page.captureScreenshot)
    // ---------------------------------------------------------------------------

    private Action<int, byte[]>? _screencastCallback;
    private int _screencastFrameCount;

    public async Task StartScreencastAsync(int sessionId, int maxFps, int quality, Action<int, byte[]> onFrame)
    {
        if (!_isReady || _webView?.CoreWebView2 is null) return;

        // Stop the old timer-based capture — screencast replaces it
        StopFrameCapture();

        _screencastCallback = onFrame;
        _screencastFrameCount = 0;

        // Subscribe to screencast frame events
        _webView.CoreWebView2.GetDevToolsProtocolEventReceiver("Page.screencastFrame")
            .DevToolsProtocolEventReceived += OnScreencastFrame;

        // Start the screencast stream
        int everyNth = Math.Max(1, 60 / maxFps);
        // 720p — sweet spot of quality vs. encode/decode speed for CV
        var paramsJson = $"{{\"format\":\"jpeg\",\"quality\":{quality},\"maxWidth\":1280,\"maxHeight\":720,\"everyNthFrame\":{everyNth}}}";
        await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.startScreencast", paramsJson);

        DebugLog.Write($"[FeedTile] Session {sessionId}: screencast started (quality={quality}, 720p, everyNth={everyNth})");
    }

    public async Task StopScreencastAsync()
    {
        if (_webView?.CoreWebView2 is null) return;

        try
        {
            _webView.CoreWebView2.GetDevToolsProtocolEventReceiver("Page.screencastFrame")
                .DevToolsProtocolEventReceived -= OnScreencastFrame;
            await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.stopScreencast", "{}");
        }
        catch { }

        _screencastCallback = null;
        DebugLog.Write($"[FeedTile] Session {_sessionId}: screencast stopped ({_screencastFrameCount} frames)");
    }

    private async void OnScreencastFrame(object? sender, CoreWebView2DevToolsProtocolEventReceivedEventArgs e)
    {
        try
        {
            var json = Newtonsoft.Json.Linq.JObject.Parse(e.ParameterObjectAsJson);
            var data = json["data"]?.ToString();
            var frameSessionId = json["sessionId"]?.ToObject<int>() ?? 0;

            if (data is not null && _screencastCallback is not null)
            {
                var jpegBytes = Convert.FromBase64String(data);
                _screencastFrameCount++;

                if (_screencastFrameCount <= 3 || _screencastFrameCount % 100 == 0)
                    DebugLog.Write($"[FeedTile] Session {_sessionId}: screencast frame #{_screencastFrameCount} ({jpegBytes.Length} bytes)");

                // Publish to Python via ZMQ
                SessionViewModel.SharedFramePublisher?.PublishRawFrame(_sessionId, jpegBytes);

                // Fire callback
                _screencastCallback.Invoke(_sessionId, jpegBytes);
            }

            // ACK the frame so Chrome sends the next one
            if (_webView?.CoreWebView2 is not null)
            {
                await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync(
                    "Page.screencastFrameAck",
                    $"{{\"sessionId\":{frameSessionId}}}");
            }
        }
        catch (Exception ex)
        {
            if (_screencastFrameCount <= 5)
                DebugLog.Write($"[FeedTile] Session {_sessionId}: screencast frame error — {ex.Message}");
        }
    }

    public void DestroyWebView()
    {
        _ = StopScreencastAsync();
        StopFrameCapture();
        _isReady = false;
        if (_webView is not null)
        {
            WebViewContainer.Children.Remove(_webView);
            try { _webView.Dispose(); } catch { }
            _webView = null;
        }
        WaitingPanel.Visibility = Visibility.Visible;
        Console.WriteLine($"[FeedTile] Session {_sessionId}: WebView2 destroyed.");
    }

    // ---------------------------------------------------------------------------
    // Frame capture for Python scripts
    // ---------------------------------------------------------------------------

    /// <summary>Starts capturing frames from WebView2 at ~30fps and publishing to Python.</summary>
    private void StartFrameCapture()
    {
        // Don't start the old timer if screencast is active — screencast handles frame publishing
        if (_screencastCallback is not null) return;
        if (_captureTimer is not null) return;
        _captureTimer = new DispatcherTimer(DispatcherPriority.Render) { Interval = TimeSpan.FromMilliseconds(33) }; // ~30fps (CDP screenshots can't sustain 60fps)
        _captureTimer.Tick += OnCaptureTimerTick;
        _captureTimer.Start();
        ViewModels.DebugLog.Write($"[FeedTile] Session {_sessionId}: frame capture started (30fps). Publisher null={SessionViewModel.SharedFramePublisher is null}");
    }

    /// <summary>Stops the frame capture timer.</summary>
    private void StopFrameCapture()
    {
        if (_captureTimer is null) return;
        _captureTimer.Stop();
        _captureTimer.Tick -= OnCaptureTimerTick;
        _captureTimer = null;
        Console.WriteLine($"[FeedTile] Session {_sessionId}: frame capture stopped.");
    }

    /// <summary>Captures a frame via CDP Page.captureScreenshot and publishes raw JPEG bytes.</summary>
    private async void OnCaptureTimerTick(object? sender, EventArgs e)
    {
        if (_isCapturing || !_isReady || _webView?.CoreWebView2 is null) return;
        _isCapturing = true;

        try
        {
            // Use CDP with lower quality for faster capture
            var result = await _webView.CoreWebView2.CallDevToolsProtocolMethodAsync(
                "Page.captureScreenshot",
                "{\"format\":\"jpeg\",\"quality\":30}");

            // CDP returns JSON: {"data":"<base64>"}
            var json = Newtonsoft.Json.Linq.JObject.Parse(result);
            var base64 = json["data"]?.ToString();
            if (base64 is null) return;

            var jpegBytes = Convert.FromBase64String(base64);

            // Publish raw JPEG bytes directly — no BitmapSource round-trip
            SessionViewModel.SharedFramePublisher?.PublishRawFrame(_sessionId, jpegBytes);
            _captureCount++;
            if (_captureCount <= 3 || _captureCount % 25 == 0)
                ViewModels.DebugLog.Write($"[FeedTile] Session {_sessionId}: captured frame #{_captureCount} ({jpegBytes.Length} bytes)");

            // Update CaptureFrame for CV Builder preview (only if needed)
            if (DataContext is SessionViewModel vm)
            {
                using var ms = new MemoryStream(jpegBytes);
                var decoder = new JpegBitmapDecoder(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                var frozen = BitmapFrame.Create(decoder.Frames[0]);
                frozen.Freeze();
                vm.CaptureFrame = frozen;
            }
        }
        catch (Exception ex)
        {
            ViewModels.DebugLog.Write($"[FeedTile] Session {_sessionId}: capture error — {ex.Message}");
        }
        finally
        {
            _isCapturing = false;
        }
    }

    // ---------------------------------------------------------------------------
    // Events
    // ---------------------------------------------------------------------------

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (DataContext is SessionViewModel vm)
        {
            _sessionId = vm.SessionId;
            SessionViewModel.SharedWebViewHost?.RegisterTile(_sessionId, this);
            vm.PropertyChanged += OnViewModelPropertyChanged;

            // Re-init WebView2 ONLY for WebView2 sessions (not capture card / window capture)
            if (vm.CloudSession?.SourceType == Core.InputSourceType.WebView2 &&
                vm.LaunchUrl is not null && _webView is null &&
                (vm.Status == SessionStatus.Connected || vm.Status == SessionStatus.Running))
            {
                ViewModels.DebugLog.Write($"[FeedTile] Session {_sessionId}: re-init WebView2 on reload (status={vm.Status})");
                _ = InitWebViewAsync(vm.LaunchUrl);

                // Resume frame capture if script was running
                if (vm.Status == SessionStatus.Running)
                    StartFrameCapture();
            }
        }
    }

    private void OnUnloaded(object sender, RoutedEventArgs e)
    {
        if (DataContext is SessionViewModel vm)
            vm.PropertyChanged -= OnViewModelPropertyChanged;

        StopFrameCapture();
        DestroyWebView();
        if (_sessionId >= 0)
            SessionViewModel.SharedWebViewHost?.UnregisterTile(_sessionId);
    }

    /// <summary>Watches for status changes to start/stop frame capture for scripts.</summary>
    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(SessionViewModel.Status)) return;
        if (sender is not SessionViewModel vm) return;

        ViewModels.DebugLog.Write($"[FeedTile] Session {_sessionId}: status changed to {vm.Status}");

        if (vm.Status == SessionStatus.Running)
            StartFrameCapture();
        else
            StopFrameCapture();
    }

    private void OnTileClicked(object sender, MouseButtonEventArgs e)
    {
        if (DataContext is SessionViewModel vm && vm.SelectCommand.CanExecute(null))
        {
            vm.SelectCommand.Execute(null);
            e.Handled = true;
        }
    }

    // ---------------------------------------------------------------------------
    // Gamepad JS builder
    // ---------------------------------------------------------------------------

    private static string BuildGamepadStateJs(GamepadState state)
    {
        static string F(float v) => v.ToString("F4", System.Globalization.CultureInfo.InvariantCulture);
        static string B(bool v) => v ? "true" : "false";

        var sb = new StringBuilder(512);
        sb.Append("(function(){var g=window.__cvGamepad;if(!g)return;");

        for (int i = 0; i < 4; i++)
            sb.Append($"g.axes[{i}]={F(state.Axes[i])};");

        for (int i = 0; i < 17; i++)
        {
            sb.Append($"g.buttons[{i}].pressed={B(state.Buttons[i])};");
            sb.Append($"g.buttons[{i}].touched={B(state.Buttons[i])};");
            sb.Append($"g.buttons[{i}].value={B(state.Buttons[i])}?1:0;");
        }

        sb.Append("g.timestamp=performance.now();})();");
        return sb.ToString();
    }
}
