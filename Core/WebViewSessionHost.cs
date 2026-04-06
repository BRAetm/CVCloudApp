using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CVCloudApp.Core;

/// <summary>Manages WebView2 tiles embedded in the feed grid for cloud gaming sessions.</summary>
public class WebViewSessionHost : IGamepadSink, IAsyncDisposable
{
    private readonly Dictionary<int, IWebViewTile> _tiles = new();
    private readonly object _lock = new();

    /// <summary>Registers a feed tile for the given session ID.</summary>
    public void RegisterTile(int sessionId, IWebViewTile tile)
    {
        lock (_lock)
            _tiles[sessionId] = tile;
    }

    /// <summary>Unregisters the tile for the given session ID.</summary>
    public void UnregisterTile(int sessionId)
    {
        lock (_lock)
            _tiles.Remove(sessionId);
    }

    /// <summary>Initializes WebView2 in the registered tile and navigates to the URL.</summary>
    public async Task LaunchAsync(int sessionId, string url)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);

        if (tile is null)
        {
            Console.WriteLine($"[WebViewHost] Session {sessionId}: no tile registered.");
            return;
        }

        await tile.InitWebViewAsync(url);
        Console.WriteLine($"[WebViewHost] Session {sessionId}: WebView2 ready in tile.");
    }

    /// <summary>Returns true if a tile is registered for this session (even if WebView2 isn't ready yet).</summary>
    public bool HasTile(int sessionId)
    {
        lock (_lock)
            return _tiles.ContainsKey(sessionId);
    }

    /// <summary>Returns true if the session's tile has an active WebView2.</summary>
    public bool IsConnected(int sessionId)
    {
        lock (_lock)
            return _tiles.TryGetValue(sessionId, out var t) && t.IsWebViewReady;
    }

    /// <summary>Sends gamepad state to the tile's WebView2.</summary>
    public void SendInput(int sessionId, GamepadState state)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);

        tile?.SendGamepadInput(state);
    }

    /// <summary>Shows a CV-annotated frame overlay on the tile.</summary>
    public void ShowCvFrame(int sessionId, byte[] jpegBytes)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);
        tile?.ShowCvFrame(jpegBytes);
    }

    /// <summary>Hides the CV overlay on the tile.</summary>
    public void HideCvOverlay(int sessionId)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);
        tile?.HideCvOverlay();
    }

    /// <summary>Fired when a screencast frame arrives. (sessionId, jpegBytes)</summary>
    public event Action<int, byte[]>? ScreencastFrameReady;

    /// <summary>Starts streaming game frames from the embedded WebView2 via CDP screencast.</summary>
    public async Task StartScreencastAsync(int sessionId, int maxFps = 30, int quality = 80)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);

        if (tile is null || !tile.IsWebViewReady)
        {
            Console.WriteLine($"[WebViewHost] Session {sessionId}: no WebView2 for screencast.");
            return;
        }

        try
        {
            await tile.StartScreencastAsync(sessionId, maxFps, quality,
                (sid, jpeg) => ScreencastFrameReady?.Invoke(sid, jpeg));
            Console.WriteLine($"[WebViewHost] Session {sessionId}: screencast started (fps≈{maxFps}, q={quality})");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[WebViewHost] Session {sessionId}: screencast failed — {ex.Message}");
        }
    }

    /// <summary>Stops the screencast for a session.</summary>
    public async Task StopScreencastAsync(int sessionId)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);

        if (tile is not null && tile.IsWebViewReady)
        {
            try { await tile.StopScreencastAsync(); }
            catch (Exception ex) { Console.WriteLine($"[WebViewHost] Session {sessionId}: stop screencast failed — {ex.Message}"); }
        }
    }

    /// <summary>Destroys the WebView2 in the tile for the given session.</summary>
    public Task DisconnectAsync(int sessionId)
    {
        IWebViewTile? tile;
        lock (_lock)
            _tiles.TryGetValue(sessionId, out tile);

        tile?.DestroyWebView();
        Console.WriteLine($"[WebViewHost] Session {sessionId}: WebView2 destroyed.");
        return Task.CompletedTask;
    }

    /// <summary>Destroys all active WebView2 instances.</summary>
    public async ValueTask DisposeAsync()
    {
        List<int> ids;
        lock (_lock)
            ids = new List<int>(_tiles.Keys);

        foreach (var id in ids)
            await DisconnectAsync(id);
    }
}
