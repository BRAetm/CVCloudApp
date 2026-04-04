using System;
using System.IO;
using System.Windows.Media.Imaging;
using NetMQ;
using NetMQ.Sockets;

namespace CVCloudApp.Core;

/// <summary>Publishes WGC-captured frames to Python scripts via a ZMQ PUB socket.</summary>
public sealed class FramePublisher : IDisposable
{
    /// <summary>Port for the frame PUB socket.</summary>
    public const int PubPort = 5580;

    private PublisherSocket? _pub;
    private bool _disposed;

    /// <summary>Binds the PUB socket on the configured port.</summary>
    public void Start()
    {
        _pub = new PublisherSocket();
        _pub.Bind($"tcp://127.0.0.1:{PubPort}");
        Console.WriteLine($"[FramePublisher] PUB socket bound on port {PubPort}.");
    }

    /// <summary>Publishes a frame for the given session. Topic is "frame_{sessionId}".</summary>
    public void PublishFrame(int sessionId, BitmapSource frame)
    {
        if (_pub is null || _disposed) return;

        try
        {
            var bytes = BitmapSourceToJpeg(frame);
            _pub.SendMoreFrame($"frame_{sessionId}").SendFrame(bytes);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FramePublisher] Session {sessionId}: publish failed — {ex.Message}");
        }
    }

    private int _rawFrameCount;

    /// <summary>Publishes raw JPEG bytes for the given session — skips BitmapSource encoding.</summary>
    public void PublishRawFrame(int sessionId, byte[] jpegBytes)
    {
        if (_pub is null || _disposed) return;

        try
        {
            _pub.SendMoreFrame($"frame_{sessionId}").SendFrame(jpegBytes);
            _rawFrameCount++;
            if (_rawFrameCount % 50 == 1)
                Console.WriteLine($"[FramePublisher] Session {sessionId}: published frame #{_rawFrameCount} ({jpegBytes.Length} bytes)");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FramePublisher] Session {sessionId}: raw publish failed — {ex.Message}");
        }
    }

    /// <summary>Encodes a frozen BitmapSource as JPEG bytes for efficient ZMQ transfer.</summary>
    private static byte[] BitmapSourceToJpeg(BitmapSource bmp)
    {
        var encoder = new JpegBitmapEncoder { QualityLevel = 80 };
        encoder.Frames.Add(BitmapFrame.Create(bmp));
        using var ms = new MemoryStream();
        encoder.Save(ms);
        return ms.ToArray();
    }

    /// <summary>Closes the PUB socket and releases resources.</summary>
    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        _pub?.Dispose();
        _pub = null;
        Console.WriteLine("[FramePublisher] Disposed.");
    }
}
