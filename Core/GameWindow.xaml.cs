using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using Microsoft.Web.WebView2.Core;

namespace CVCloudApp.Core;

/// <summary>Borderless WPF window hosting a WebView2 control for Xbox Cloud Gaming.</summary>
public partial class GameWindow : Window
{
    private static readonly string UserDataRoot = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CVCloudApp", "WebView2");

    // Same JS as CdpGamepadInjector — installs fake gamepad + visibility overrides
    private const string InjectGamepadJs = @"(function() {
  const gp = {
    axes: [0,0,0,0],
    buttons: Array(17).fill(null).map(()=>({pressed:false,value:0})),
    connected: true,
    id: 'Xbox 360 Controller (XInput STANDARD GAMEPAD)',
    index: 0,
    mapping: 'standard',
    timestamp: performance.now()
  };
  var _origGetGamepads = navigator.getGamepads.bind(navigator);
  Object.defineProperty(navigator, 'getGamepads', {
    value: function() {
      var real = [];
      try { real = Array.from(_origGetGamepads()); } catch(e) {}
      var merged = [gp];
      for (var i = 0; i < real.length; i++) {
        if (real[i]) {
          var r = real[i];
          merged.push({
            axes: r.axes, buttons: r.buttons, connected: r.connected,
            id: r.id, index: merged.length, mapping: r.mapping, timestamp: r.timestamp
          });
        }
      }
      while (merged.length < 4) merged.push(null);
      return merged;
    },
    writable: true
  });
  window.__cvGamepad = gp;
  window.dispatchEvent(new Event('gamepadconnected', {bubbles:true}));

  Object.defineProperty(document, 'hidden', { get: () => false, configurable: true });
  Object.defineProperty(document, 'visibilityState', { get: () => 'visible', configurable: true });
  window.addEventListener('visibilitychange', function(e) { e.stopImmediatePropagation(); }, true);

  setInterval(function() {
    if (window.__cvGamepad) {
      window.__cvGamepad.timestamp = performance.now();
      window.dispatchEvent(new Event('gamepadconnected', {bubbles:true}));
    }
  }, 25000);
})();";

    private readonly int _sessionId;
    private volatile bool _isReady;
    private volatile bool _isSending;

    /// <summary>Creates a new GameWindow for the given session.</summary>
    public GameWindow(int sessionId)
    {
        _sessionId = sessionId;
        InitializeComponent();
        Title = $"CVCloud Session {sessionId}";
    }

    /// <summary>Returns the Win32 HWND for WGC capture.</summary>
    public nint Hwnd => new WindowInteropHelper(this).EnsureHandle();

    /// <summary>True when WebView2 is initialized and ready for input.</summary>
    public bool IsReady => _isReady;

    /// <summary>Initializes WebView2 and navigates to the given URL with gamepad injection.</summary>
    public async System.Threading.Tasks.Task InitializeAsync(string url)
    {
        var userDataDir = Path.Combine(UserDataRoot, $"Session{_sessionId}");
        Directory.CreateDirectory(userDataDir);

        var env = await CoreWebView2Environment.CreateAsync(userDataFolder: userDataDir);
        await WebView.EnsureCoreWebView2Async(env);

        // Inject gamepad JS on every page navigation
        await WebView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(InjectGamepadJs);

        // Enable focus emulation so game stays active when window is backgrounded
        try
        {
            await WebView.CoreWebView2.CallDevToolsProtocolMethodAsync(
                "Emulation.setFocusEmulationEnabled", "{\"enabled\":true}");
            Console.WriteLine($"[GameWindow] Session {_sessionId}: focus emulation enabled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[GameWindow] Session {_sessionId}: focus emulation failed (non-fatal): {ex.Message}");
        }

        WebView.CoreWebView2.Navigate(url);
        _isReady = true;

        Console.WriteLine($"[GameWindow] Session {_sessionId}: WebView2 initialized, navigating to {url}");
    }

    /// <summary>Sends gamepad state to the injected JS gamepad. Fire-and-forget; drops frames when busy.</summary>
    public void SendInput(GamepadState state)
    {
        if (!_isReady || WebView.CoreWebView2 is null) return;
        if (_isSending) return; // drop frame
        _isSending = true;

        var js = BuildGamepadStateJs(state);

        Dispatcher.BeginInvoke(async () =>
        {
            try
            {
                if (WebView.CoreWebView2 is not null)
                    await WebView.CoreWebView2.ExecuteScriptAsync(js);
            }
            catch { /* swallow — window may be closing */ }
            finally
            {
                _isSending = false;
            }
        });
    }

    /// <summary>Builds compact JS that updates window.__cvGamepad from a GamepadState.</summary>
    private static string BuildGamepadStateJs(GamepadState state)
    {
        static string F(float v) => v.ToString("F4", System.Globalization.CultureInfo.InvariantCulture);
        static string B(bool v)  => v ? "true" : "false";

        var sb = new StringBuilder(512);
        sb.Append("(function(){var g=window.__cvGamepad;if(!g)return;");

        for (int i = 0; i < 4; i++)
            sb.Append($"g.axes[{i}]={F(state.Axes[i])};");

        for (int i = 0; i < 17; i++)
        {
            sb.Append($"g.buttons[{i}].pressed={B(state.Buttons[i])};");
            sb.Append($"g.buttons[{i}].value={B(state.Buttons[i])}|0;");
        }

        sb.Append("g.timestamp=performance.now();})();");
        return sb.ToString();
    }

    /// <summary>Allows dragging the window from the thin top bar.</summary>
    private void OnDragBar(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
            DragMove();
    }

    /// <summary>Cleans up WebView2 resources.</summary>
    protected override void OnClosed(EventArgs e)
    {
        _isReady = false;
        try { WebView.Dispose(); } catch { }
        base.OnClosed(e);
    }
}
