# Labs Vision

CV-driven controller manager for Xbox Cloud Gaming on Windows. Supports up to 10 concurrent
cloud sessions with per-session Python CV scripts driving virtual gamepads.

## Stack

| Layer            | Tech                                                          |
|------------------|---------------------------------------------------------------|
| Shell            | C# WPF / .NET 8 (MVVM)                                        |
| Window hosting   | WebView2 (Edge runtime)                                       |
| Virtual gamepad  | ViGEmBus via `Nefarius.ViGEm.Client`                          |
| CV workers       | Python 3.11 + OpenCV + MSS (one subprocess per session)       |
| IPC              | ZeroMQ (NetMQ + pyzmq) — frame PUB/SUB + event PUSH/PULL      |
| Hardware bridge  | Cronus Zen via HID (`HidSharp`) + GPC3 VM (bundled in `Tools/`)|

## Layout

```
LabsVision/
├── App.xaml(.cs)             ← Composition root, dependency wire-up
├── MainWindow.xaml(.cs)      ← Shell window (DataContext only)
├── Core/                     ← Session orchestration, capture, IPC plumbing
├── Models/                   ← Plain data containers
├── UI/
│   ├── Views/                ← XAML windows / dialogs / controls
│   ├── ViewModels/           ← MVVM view-models
│   ├── Controls/             ← Reusable user-controls (FeedTile, CvPreview)
│   └── Converters/           ← IValueConverters
├── Scripts/                  ← Python CV scripts (hot-swappable)
├── Tools/gpc3/               ← Bundled Cronus Zen GPC3 toolchain
├── Config/                   ← Static config + reference notes
└── Assets/                   ← Branding (logo, icons)
```

## Build & run

```bash
dotnet build LabsVision.sln
dotnet run --project LabsVision
```

Requires:
- .NET 8 SDK
- Windows 10 SDK 10.0.22621
- ViGEmBus driver installed
- Microsoft Edge / WebView2 runtime
- Python 3.11 with `opencv-python`, `mss`, `pyzmq`, `numpy`, `ultralytics` (for YOLO scripts)

## Python script API

Every script in `LabsVision/Scripts/` must implement:

```python
def on_start(config):     ...   # called once when the script starts
def on_frame(frame, sid, emit): ...   # called per captured frame
def on_stop():            ...   # called once when the script stops
```

Use `emit("button", "A", True)` to drive the virtual gamepad.

## Architecture rules

- **MVVM strict** — no business logic in `.xaml.cs`. Views bind to ViewModels only.
- **One ZMQ pair per session** — never share sockets across sessions.
- **Stateless workers** — Python scripts capture → analyze → emit only.
- **Async/await** — no `.Result` / `.Wait()` blocking calls in C#.
- **No magic numbers** — config or constants only.

See [`CLAUDE.md`](CLAUDE.md) for the full ruleset Claude follows when working on this codebase.
