"""
CVCloudApp — Enhanced Python CV Worker (v2.0)

Supports both CVCloudApp API (on_start/on_frame/on_stop) and
Helios II API (GCVWorker class with process() method).

Usage:
    python worker.py <session_id> <zmq_port> <script_path> [--fps 30]

Performance optimizations ported from Helios GCVLauncher.py:
  - Process priority set to ABOVE_NORMAL
  - Power throttling disabled
  - Thread priority boosted
"""

import ctypes
import ctypes.wintypes as wintypes
import importlib.util
import json
import os
import signal
import sys
import time
import types

import cv2
import numpy as np
import zmq

# ---------------------------------------------------------------------------
# Constants
# ---------------------------------------------------------------------------

FRAME_PUB_PORT = 5580      # Must match FramePublisher.PubPort in C#
DEFAULT_FPS = 30           # Default frame rate cap
MIN_FPS = 1
MAX_FPS = 120

# Error codes (Helios-style)
ERR_SCRIPT_LOAD    = "SCRIPT_001"
ERR_SCRIPT_MISSING = "SCRIPT_002"
ERR_SCRIPT_API     = "SCRIPT_003"
ERR_SCRIPT_RUNTIME = "SCRIPT_004"
ERR_ZMQ_CONNECT    = "IPC_001"
ERR_FRAME_DECODE   = "IPC_002"
ERR_SYSTEM         = "SYS_999"


# ---------------------------------------------------------------------------
# Performance optimizations (ported from Helios GCVLauncher.py)
# ---------------------------------------------------------------------------

def set_performance_optimizations():
    """Boost process and thread priority, disable power throttling."""
    if sys.platform != "win32":
        return

    try:
        kernel32 = ctypes.windll.kernel32
        ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000
        THREAD_PRIORITY_ABOVE_NORMAL = 1

        handle = kernel32.GetCurrentProcess()
        kernel32.SetPriorityClass(handle, ABOVE_NORMAL_PRIORITY_CLASS)

        # Disable power throttling
        PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1
        PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1
        ProcessPowerThrottling = 4

        class PROCESS_POWER_THROTTLING_STATE(ctypes.Structure):
            _fields_ = [
                ("Version", wintypes.ULONG),
                ("ControlMask", wintypes.ULONG),
                ("StateMask", wintypes.ULONG),
            ]

        kernel32.SetProcessInformation.argtypes = [
            wintypes.HANDLE, wintypes.ULONG, ctypes.c_void_p, wintypes.DWORD
        ]
        kernel32.SetProcessInformation.restype = wintypes.BOOL

        throttling = PROCESS_POWER_THROTTLING_STATE()
        throttling.Version = PROCESS_POWER_THROTTLING_CURRENT_VERSION
        throttling.ControlMask = PROCESS_POWER_THROTTLING_EXECUTION_SPEED
        throttling.StateMask = 0  # 0 = disable throttling
        kernel32.SetProcessInformation(
            handle, ProcessPowerThrottling,
            ctypes.byref(throttling), ctypes.sizeof(throttling)
        )

        # Boost thread priority
        thread_handle = kernel32.GetCurrentThread()
        kernel32.SetThreadPriority(thread_handle, THREAD_PRIORITY_ABOVE_NORMAL)

        print(f"[worker] Performance optimized: ABOVE_NORMAL priority, power throttling disabled")
    except Exception as e:
        print(f"[worker] Performance optimization failed (non-fatal): {e}")


# ---------------------------------------------------------------------------
# Script loader (dual API: CVCloudApp + Helios)
# ---------------------------------------------------------------------------

SCRIPT_API_CVCLOUD = "cvcloud"    # on_start / on_frame / on_stop
SCRIPT_API_HELIOS  = "helios"     # GCVWorker class with process()


def detect_script_api(module: types.ModuleType) -> str:
    """Detects whether a script uses CVCloudApp or Helios API."""
    if hasattr(module, "GCVWorker"):
        return SCRIPT_API_HELIOS
    if callable(getattr(module, "on_frame", None)):
        return SCRIPT_API_CVCLOUD
    return SCRIPT_API_CVCLOUD  # fallback


def load_script(script_path: str) -> tuple[types.ModuleType, str]:
    """Loads a CV script and detects its API type. Returns (module, api_type)."""
    if not os.path.isfile(script_path):
        print(f"Error Code: {ERR_SCRIPT_MISSING} - Script not found: {script_path}")
        sys.exit(1)

    try:
        # Add script directory to path so relative imports work
        script_dir = os.path.dirname(os.path.abspath(script_path))
        if script_dir not in sys.path:
            sys.path.insert(0, script_dir)

        # Also add the Scripts folder itself (for helios_compat imports)
        scripts_dir = os.path.dirname(os.path.abspath(__file__))
        if scripts_dir not in sys.path:
            sys.path.insert(0, scripts_dir)

        spec = importlib.util.spec_from_file_location("cv_script", script_path)
        if spec is None or spec.loader is None:
            raise ImportError(f"Cannot create module spec for: {script_path}")

        module = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(module)
    except Exception as e:
        print(f"Error Code: {ERR_SCRIPT_LOAD} - Failed to load script: {e}")
        sys.exit(1)

    api_type = detect_script_api(module)

    if api_type == SCRIPT_API_CVCLOUD:
        for required in ("on_start", "on_frame", "on_stop"):
            if not callable(getattr(module, required, None)):
                print(f"Error Code: {ERR_SCRIPT_API} - Script must implement '{required}()' or GCVWorker class")
                sys.exit(1)

    elif api_type == SCRIPT_API_HELIOS:
        worker_cls = getattr(module, "GCVWorker")
        if not callable(worker_cls):
            print(f"Error Code: {ERR_SCRIPT_API} - GCVWorker must be a class")
            sys.exit(1)

    print(f"[worker] Script loaded: {os.path.basename(script_path)} (API: {api_type})")
    return module, api_type


# ---------------------------------------------------------------------------
# ZMQ emit helper
# ---------------------------------------------------------------------------

def make_emit(socket: zmq.Socket, session_id: int):
    """Returns an emit() callable that serializes and PUB-sends a GamepadEvent dict."""
    _count = [0]
    topic = f"gamepad_{session_id}"

    def emit(gamepad_event: dict) -> None:
        gamepad_event["session_id"] = session_id
        payload = json.dumps(gamepad_event)
        socket.send_string(topic, flags=zmq.SNDMORE | zmq.NOBLOCK)
        socket.send_string(payload, flags=zmq.NOBLOCK)
        _count[0] += 1
        if _count[0] <= 3 or _count[0] % 100 == 0:
            print(f"[worker:{session_id}] emitted gamepad event #{_count[0]}")
            sys.stdout.flush()

    return emit


# ---------------------------------------------------------------------------
# Helios GCVWorker adapter
# ---------------------------------------------------------------------------

class HeliosWorkerAdapter:
    """Wraps a Helios GCVWorker instance to work with CVCloudApp's pipeline."""

    def __init__(self, worker_cls, width: int = 640, height: int = 480):
        self.worker = worker_cls(width, height)

    def on_start(self, config: dict):
        pass  # GCVWorker doesn't have on_start

    def on_frame(self, frame, session_id: int, emit):
        try:
            result = self.worker.process(frame)
            if result is None:
                return

            out_frame, gcvdata = result

            # Convert gcvdata to Web Gamepad API format
            try:
                from helios_compat import gcvdata_to_gamepad_state
                gamepad = gcvdata_to_gamepad_state(bytes(gcvdata))
                emit(gamepad)
            except ImportError:
                # Fallback: emit raw gcvdata as base64 for C# to decode
                import base64
                emit({
                    "axes": [0, 0, 0, 0],
                    "buttons": [False] * 17,
                    "gcvdata_b64": base64.b64encode(bytes(gcvdata)).decode()
                })
        except Exception as e:
            print(f"Error Code: {ERR_SCRIPT_RUNTIME} - GCVWorker.process() error: {e}", file=sys.stderr)

    def on_stop(self):
        try:
            del self.worker
        except Exception:
            pass


# ---------------------------------------------------------------------------
# Frame receive loop
# ---------------------------------------------------------------------------

def frame_loop(session_id: int, script, emit, sub_socket: zmq.Socket,
               fps: int = DEFAULT_FPS) -> None:
    """
    Main loop — receives JPEG frames from C# via ZMQ SUB, decodes to numpy,
    and passes them to the script's on_frame().
    """
    frame_interval = 1.0 / fps
    print(f"[worker:{session_id}] Frame loop starting at {fps}fps ({frame_interval*1000:.1f}ms/frame)")
    sys.stdout.flush()

    frame_count = 0
    poll_miss = 0
    error_count = 0
    MAX_CONSECUTIVE_ERRORS = 10

    while True:
        frame_start = time.monotonic()

        try:
            events = sub_socket.poll(100)  # 100ms timeout
            if events:
                topic = sub_socket.recv_string()
                jpeg_bytes = sub_socket.recv()

                frame_count += 1
                poll_miss = 0
                error_count = 0
                if frame_count <= 5 or frame_count % 100 == 0:
                    print(f"[worker:{session_id}] frame #{frame_count} ({len(jpeg_bytes)} bytes)")
                    sys.stdout.flush()

                arr = np.frombuffer(jpeg_bytes, dtype=np.uint8)
                frame = cv2.imdecode(arr, cv2.IMREAD_COLOR)

                if frame is not None:
                    try:
                        script.on_frame(frame, session_id, emit)
                    except Exception as exc:
                        error_count += 1
                        print(f"Error Code: {ERR_SCRIPT_RUNTIME} - on_frame error: {exc}", file=sys.stderr)
                        sys.stderr.flush()
                        if error_count >= MAX_CONSECUTIVE_ERRORS:
                            print(f"[worker:{session_id}] Too many consecutive errors ({error_count}), stopping.", file=sys.stderr)
                            break
                else:
                    print(f"Error Code: {ERR_FRAME_DECODE} - decode failed ({len(jpeg_bytes)} bytes)", file=sys.stderr)
            else:
                poll_miss += 1
                if poll_miss == 20 or poll_miss % 200 == 0:
                    print(f"[worker:{session_id}] no frames ({poll_miss} polls missed)", file=sys.stderr)
                    sys.stderr.flush()

        except zmq.ZMQError as e:
            if e.errno != zmq.EAGAIN:
                print(f"Error Code: {ERR_ZMQ_CONNECT} - ZMQ error: {e}", file=sys.stderr)

        # FPS cap
        elapsed = time.monotonic() - frame_start
        sleep_time = frame_interval - elapsed
        if sleep_time > 0:
            time.sleep(sleep_time)


# ---------------------------------------------------------------------------
# Entry point
# ---------------------------------------------------------------------------

def main() -> None:
    if len(sys.argv) < 4:
        print("Usage: worker.py <session_id> <zmq_port> <script_path> [--fps N]", file=sys.stderr)
        sys.exit(1)

    session_id  = int(sys.argv[1])
    zmq_port    = int(sys.argv[2])
    script_path = sys.argv[3]

    # Parse optional --fps argument
    fps = DEFAULT_FPS
    if "--fps" in sys.argv:
        fps_idx = sys.argv.index("--fps")
        if fps_idx + 1 < len(sys.argv):
            try:
                fps = max(MIN_FPS, min(MAX_FPS, int(sys.argv[fps_idx + 1])))
            except ValueError:
                pass

    # Apply Helios-style performance optimizations
    set_performance_optimizations()

    config = {
        "session_id":  session_id,
        "zmq_port":    zmq_port,
        "script_path": script_path,
        "fps":         fps,
    }

    # Load script (auto-detects CVCloudApp vs Helios API)
    module, api_type = load_script(script_path)

    # Create appropriate script adapter
    if api_type == SCRIPT_API_HELIOS:
        script = HeliosWorkerAdapter(module.GCVWorker)
        print(f"[worker:{session_id}] Using Helios GCVWorker adapter")
    else:
        script = module

    # ZMQ context
    context = zmq.Context()

    # PUB socket for gamepad events
    pub_socket = context.socket(zmq.PUB)
    pub_socket.connect(f"tcp://127.0.0.1:{zmq_port}")

    # SUB socket for receiving frames from C# FramePublisher
    sub_socket = context.socket(zmq.SUB)
    sub_socket.setsockopt(zmq.RCVHWM, 5)
    sub_socket.connect(f"tcp://127.0.0.1:{FRAME_PUB_PORT}")
    sub_socket.setsockopt_string(zmq.SUBSCRIBE, f"frame_{session_id}")

    emit = make_emit(pub_socket, session_id)

    # Wire up helios_compat callbacks if available
    try:
        import helios_compat
        helios_compat._set_callbacks(
            emit_fn=emit,
            gcvdata_fn=lambda data: emit(helios_compat.gcvdata_to_gamepad_state(data))
        )
    except ImportError:
        pass

    # Graceful shutdown on SIGTERM
    def handle_sigterm(_sig, _frame):
        raise KeyboardInterrupt
    signal.signal(signal.SIGTERM, handle_sigterm)

    print(f"[worker:{session_id}] started (port={zmq_port}, fps={fps}, api={api_type}, script={os.path.basename(script_path)})")
    sys.stdout.flush()

    # Give SUB socket time to connect (ZMQ slow-joiner problem)
    time.sleep(0.3)

    try:
        script.on_start(config)
        print(f"[worker:{session_id}] on_start() complete, entering frame loop...")
        sys.stdout.flush()
        frame_loop(session_id, script, emit, sub_socket, fps=fps)

    except KeyboardInterrupt:
        print(f"[worker:{session_id}] shutting down (signal).")

    finally:
        try:
            script.on_stop()
        except Exception as exc:
            print(f"[worker:{session_id}] on_stop error: {exc}", file=sys.stderr)

        pub_socket.close()
        sub_socket.close()
        context.term()
        print(f"[worker:{session_id}] stopped.")


if __name__ == "__main__":
    main()
