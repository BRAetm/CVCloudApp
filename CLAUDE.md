# Labs Vision — Claude Context File

## Project Goal
A CV-driven controller manager for Xbox Cloud Gaming on Windows.
Supports up to 10 simultaneous cloud sessions with per-window script start/stop controls.
Modeled after InputSense Helios functionality.

## Stack
- Main App: C# WPF (.NET 8)
- Virtual Gamepad: ViGEmBus via Nefarius.ViGEm.Client NuGet
- CV Engine: Python 3.11 workers using OpenCV + MSS
- IPC Bridge: ZeroMQ (C# NetMQ + Python pyzmq)
- IDE: VS Code / Cursor with Claude Code

## Folder Structure
/LabsVision
  /UI           → WPF views, viewmodels (MVVM pattern)
  /Core         → SessionManager.cs, VirtualPadManager.cs, CvWorkerHost.cs
  /Scripts      → Hot-swappable Python CV scripts
  /Config       → Per-session JSON config files
  /Tools/gpc3   → Bundled Cronus Zen GPC3 toolchain

## Architecture Overview
- SessionManager discovers Xbox Cloud windows via EnumWindows (P/Invoke)
- Each session gets a session_id, HWND, capture region, and ViGEm virtual pad
- CvWorkerHost spawns a Python subprocess per session
- Python worker captures frames with MSS, runs OpenCV logic, emits gamepad events via ZMQ PUSH socket
- C# pulls events via ZMQ PULL socket and maps them to ViGEm inputs

## Python Script API (every script must implement)
- on_start(config) — called when script starts
- on_frame(frame, session_id, emit) — called per captured frame
- on_stop() — called when script stops

## Key Rules for Claude
- Always use MVVM pattern in WPF — no logic in code-behind
- Python workers must be stateless — capture → analyze → emit only
- One ZMQ socket pair per session, never shared across sessions
- All session state lives in SessionManager, never scattered across UI
- Use async/await in C# for all IPC and session operations
- When generating Python scripts, always include all three API methods

## Current Build Phase
Phase 4 — WPF UI redesign (card grid + CV windows)

## Skills

### Skill: C# WPF MVVM
- Always separate View, ViewModel, and Model strictly
- Use RelayCommand for all button bindings
- Use ObservableCollection<T> for session lists
- Never put business logic in .xaml.cs code-behind
- Inject dependencies via constructor, never use statics

### Skill: Python CV Worker
- Always use MSS for screen capture (faster than PIL)
- Capture loop must run in a separate thread, never block main
- Frame rate should be capped at 30fps using time.sleep()
- Use numpy for all frame processing before OpenCV calls
- Always release resources in on_stop()

### Skill: ZeroMQ IPC Bridge
- Always use PUSH/PULL pattern for one-way event streams
- One socket pair per session — never share across sessions
- C# side uses NetMQ PullSocket in a background Task
- Python side uses zmq.PUSH socket, connects (does not bind)
- C# side binds the PULL socket on a unique port per session
- All messages must be JSON serialized

### Skill: ViGEm Virtual Gamepad
- Always check ViGEmBus driver is installed before connecting
- Create one IXbox360Controller per session
- Map CV events to gamepad state then call Update() — never call Update() per-button
- Always disconnect and dispose pads on session close
- Use try/catch around all ViGEm calls — driver can disconnect

### Skill: Session Management
- session_id is always an int 0-9 (max 10 sessions)
- Every session object must track: HWND, capture_region, pad, worker_process, zmq_port, status
- Status enum: Idle, Connecting, Connected, Running, Error
- All session mutations must go through SessionManager methods only
- Log every state transition for debugging

### Skill: General Code Rules
- All async operations use async/await — no .Result or .Wait() blocking calls
- All errors are caught, logged, and surface to the UI status field
- No magic numbers — use constants or config values
- Every public method gets a one-line XML doc comment
