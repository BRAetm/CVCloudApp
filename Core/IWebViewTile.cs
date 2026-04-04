using System.Threading.Tasks;

namespace CVCloudApp.Core;

/// <summary>Interface for a UI tile that can host a WebView2 session.</summary>
public interface IWebViewTile
{
    /// <summary>Initializes WebView2 and navigates to the URL.</summary>
    Task InitWebViewAsync(string url);

    /// <summary>Sends gamepad state to the browser.</summary>
    void SendGamepadInput(GamepadState state);

    /// <summary>True when WebView2 is initialized and ready.</summary>
    bool IsWebViewReady { get; }

    /// <summary>Destroys the WebView2 and cleans up resources.</summary>
    void DestroyWebView();
}
