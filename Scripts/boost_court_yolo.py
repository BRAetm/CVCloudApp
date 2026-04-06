"""
boost_court_yolo.py — Got Next pad detector using a TRAINED YOLO model.

Requires: pad_detector.pt in the Scripts folder
          (produced by running train_pad_yolo.py on labeled frames)

This is the proper machine-learning version. No HSV hacks, no shape filters,
no false positives from nameplates — the model learned the actual visual
features of Got Next pads from your real gameplay video.
"""

import os
import time
import cv2
import numpy as np
from helios_compat import *

DIRECT_CAPTURE = False  # Cloud play uses C# screencast

# ---------------------------------------------------------------------------
# Tunables
# ---------------------------------------------------------------------------

MODEL_PATH = os.path.join(os.path.dirname(os.path.abspath(__file__)), "pad_detector.pt")
CONFIDENCE_THRESHOLD = 0.40    # YOLO detection confidence cutoff (0.0-1.0)

# Walking
WALK_FORWARD_Y = -0.95
STEER_GAIN     = 1.6
STEER_DEADZONE = 0.06
PRESS_COOLDOWN_SEC = 5.0

# Got Next prompt (still HSV — it's a fixed UI element, no model needed)
PROMPT_LOWER = np.array([55, 110, 130])
PROMPT_UPPER = np.array([95, 255, 255])
MIN_PROMPT_PIXELS = 20
MAX_PROMPT_PIXELS = 800

# Inference downscale (smaller = faster but less accurate at distance)
INFER_IMGSZ = 480

# ---------------------------------------------------------------------------
# State
# ---------------------------------------------------------------------------

_model           = None
_frame_count     = 0
_fps_start       = 0.0
_fps             = 0.0
_last_press_time = 0.0
_total_presses   = 0
_model_loaded    = False
_load_error      = None


def on_start(config: dict) -> None:
    global _model, _frame_count, _fps_start, _last_press_time, _total_presses
    global _model_loaded, _load_error

    _frame_count = 0
    _fps_start = time.monotonic()
    _last_press_time = 0.0
    _total_presses = 0
    _model_loaded = False
    _load_error = None

    print(f"[boost_court_yolo] starting on session {config['session_id']}")

    if not os.path.isfile(MODEL_PATH):
        _load_error = f"Model not found: {MODEL_PATH}"
        print(f"[boost_court_yolo] {_load_error}")
        print(f"[boost_court_yolo] Run train_pad_yolo.py first to create it.")
        return

    try:
        from ultralytics import YOLO
        _model = YOLO(MODEL_PATH)
        # Warm up so first real inference isn't slow
        _ = _model.predict(np.zeros((INFER_IMGSZ, INFER_IMGSZ, 3), dtype=np.uint8),
                           imgsz=INFER_IMGSZ, verbose=False)
        _model_loaded = True
        print(f"[boost_court_yolo] YOLO model loaded: {MODEL_PATH}")
    except Exception as e:
        _load_error = f"Failed to load YOLO: {e}"
        print(f"[boost_court_yolo] {_load_error}")


# ---------------------------------------------------------------------------
# Detection
# ---------------------------------------------------------------------------

def detect_pads_yolo(frame: np.ndarray):
    """
    Run YOLO inference on the frame.
    Returns list of detections: [(x1, y1, x2, y2, conf), ...]
    """
    if _model is None:
        return []

    results = _model.predict(
        frame,
        imgsz=INFER_IMGSZ,
        conf=CONFIDENCE_THRESHOLD,
        verbose=False,
    )

    detections = []
    if not results:
        return detections

    r = results[0]
    if r.boxes is None or len(r.boxes) == 0:
        return detections

    # Extract bounding boxes in original frame coordinates
    boxes_xyxy = r.boxes.xyxy.cpu().numpy()
    confs      = r.boxes.conf.cpu().numpy()
    for (x1, y1, x2, y2), conf in zip(boxes_xyxy, confs):
        detections.append((int(x1), int(y1), int(x2), int(y2), float(conf)))

    return detections


def detect_prompt(frame: np.ndarray) -> tuple:
    h, w = frame.shape[:2]
    y1 = int(h * 0.85); y2 = int(h * 0.99)
    x1 = int(w * 0.30); x2 = int(w * 0.70)
    roi = frame[y1:y2, x1:x2]
    if roi.size == 0:
        return False, 0
    hsv = cv2.cvtColor(roi, cv2.COLOR_BGR2HSV)
    mask = cv2.inRange(hsv, PROMPT_LOWER, PROMPT_UPPER)
    count = int(cv2.countNonZero(mask))
    return MIN_PROMPT_PIXELS <= count <= MAX_PROMPT_PIXELS, count


# ---------------------------------------------------------------------------
# Main loop
# ---------------------------------------------------------------------------

def on_frame(frame: np.ndarray, session_id: int, emit) -> None:
    global _frame_count, _fps_start, _fps, _last_press_time, _total_presses

    h, w = frame.shape[:2]
    now = time.monotonic()

    # Inference
    if _model_loaded:
        detections = detect_pads_yolo(frame)
    else:
        detections = []

    prompt_found, prompt_px = detect_prompt(frame)

    # Pick the BIGGEST detection as the target (closest pad = biggest box)
    target_box = None
    if detections:
        target_box = max(detections, key=lambda d: (d[2] - d[0]) * (d[3] - d[1]))

    # Build gamepad output
    axes = [0.0, 0.0, 0.0, 0.0]
    buttons = [False] * 17
    cooldown_ok = (now - _last_press_time) >= PRESS_COOLDOWN_SEC

    if prompt_found and cooldown_ok:
        buttons[0] = True
        _last_press_time = now
        _total_presses += 1
        print(f"[boost_court_yolo] PRESS A — pads={len(detections)} prompt={prompt_px}px")
    elif target_box is not None:
        x1, y1, x2, y2, _conf = target_box
        target_x = (x1 + x2) // 2
        axes[1] = WALK_FORWARD_Y
        target_norm = (target_x - w / 2) / (w / 2)
        if abs(target_norm) > STEER_DEADZONE:
            axes[0] = max(-1.0, min(1.0, target_norm * STEER_GAIN))

    emit({"session_id": session_id, "axes": axes, "buttons": buttons})

    # Overlay - YOLO style
    for i, (x1, y1, x2, y2, conf) in enumerate(detections):
        is_target = (target_box is not None and detections[i] is target_box)
        color = (0, 255, 0) if is_target else (255, 200, 0)
        thickness = 4 if is_target else 2
        cv2.rectangle(frame, (x1, y1), (x2, y2), color, thickness)
        label = f"{'TARGET' if is_target else 'pad'} {conf:.2f}"
        (tw, th), _ = cv2.getTextSize(label, cv2.FONT_HERSHEY_SIMPLEX, 0.5, 1)
        cv2.rectangle(frame, (x1, y1 - th - 6), (x1 + tw + 6, y1), color, -1)
        cv2.putText(frame, label, (x1 + 3, y1 - 4),
                    cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 0), 1)

    if target_box is not None:
        x1, y1, x2, y2, _ = target_box
        tx = (x1 + x2) // 2
        ty = (y1 + y2) // 2
        cv2.line(frame, (w // 2, int(h * 0.88)), (tx, ty), (0, 200, 255), 2)

    # FPS
    _frame_count += 1
    elapsed = now - _fps_start
    if elapsed >= 1.0:
        _fps = _frame_count / elapsed
        _frame_count = 0
        _fps_start = now

    # HUD
    cv2.putText(frame, f"YOLO BoostCourt | {_fps:.0f} fps", (10, 25),
                cv2.FONT_HERSHEY_SIMPLEX, 0.6, (0, 255, 0), 2)
    cv2.putText(frame, f"Pads: {len(detections)}  Prompt: {prompt_px}px {'YES' if prompt_found else 'no'}",
                (10, 50), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (255, 255, 255), 1)
    cv2.putText(frame, f"Stick X={axes[0]:+.2f} Y={axes[1]:+.2f}  Presses: {_total_presses}",
                (10, 70), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (180, 220, 255), 1)

    if _load_error:
        cv2.putText(frame, "MODEL NOT LOADED — run train_pad_yolo.py first",
                    (10, 100), cv2.FONT_HERSHEY_SIMPLEX, 0.55, (0, 0, 255), 2)

    preview = cv2.resize(frame, (960, 540)) if w > 1280 else frame
    cv2.imshow("TM Labs - Boost Court YOLO", preview)
    cv2.waitKey(1)


def on_stop() -> None:
    print(f"[boost_court_yolo] stopped. Total presses: {_total_presses}")
