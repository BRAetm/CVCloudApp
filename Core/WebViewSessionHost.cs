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
