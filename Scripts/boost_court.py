"""
boost_court.py — NBA 2K Park Got Next finder

Real CV demo style — every detection is highlighted and labeled so you can
SEE exactly what the script thinks each thing is and why.

Color legend:
  GREEN  box  = "GOT NEXT PAD" — accepted, targeted
  CYAN   box  = "PAD CANDIDATE" — accepted as a pad (smaller, not target)
  RED    box  = "NAMEPLATE"  — rejected (wide-thin shape)
  ORANGE box  = "OWN PLAYER" — rejected (in self-exclusion zone)
  PURPLE box  = "TOO SMALL"  — rejected (below area threshold)
"""

import cv2
import numpy as np
import time

DIRECT_CAPTURE = False  # Cloud play uses C# screencast

# ---------------------------------------------------------------------------
# HSV — Got Next pads' bright cyan-green color
# ---------------------------------------------------------------------------

PAD_LOWER = np.array([55, 130, 160])
PAD_UPPER = np.array([95, 255, 255])

PROMPT_LOWER = np.array([55, 110, 130])
PROMPT_UPPER = np.array([95, 255, 255])
MIN_PROMPT_PIXELS = 20
MAX_PROMPT_PIXELS = 800

# ---------------------------------------------------------------------------
# Detection thresholds
# ---------------------------------------------------------------------------

MIN_PAD_AREA   = 200      # smaller = "TOO SMALL"
MAX_PAD_AREA   = 60000

# Aspect ratio: width / height
PAD_ASPECT_MIN = 0.5      # narrower than this = nameplate
PAD_ASPECT_MAX = 1.8      # wider  than this = nameplate

# Self exclusion column (own player + own nameplate)
SELF_LEFT  = 0.30
SELF_RIGHT = 0.70

# Search ROI
ROI_TOP    = 0.35
ROI_BOTTOM = 0.92
ROI_LEFT   = 0.02
ROI_RIGHT  = 0.98

# Walking
WALK_FORWARD_Y = -0.95
STEER_GAIN     = 1.6
STEER_DEADZONE = 0.06
PRESS_COOLDOWN_SEC = 5.0

# ---------------------------------------------------------------------------
# Color legend (BGR) for the labels and boxes
# ---------------------------------------------------------------------------

CLR_PAD_TARGET    = (0, 255, 0)      # bright green — the chosen target
CLR_PAD_CANDIDATE = (255, 200, 0)    # cyan — other pad candidates
CLR_NAMEPLATE     = (0, 0, 255)      # red — rejected nameplate
CLR_OWN_PLAYER    = (0, 165, 255)    # orange — rejected (self zone)
CLR_TOO_SMALL     = (200, 0, 200)    # purple — rejected (too small)
CLR_HUD           = (255, 255, 255)
CLR_BLACK         = (0, 0, 0)

# ---------------------------------------------------------------------------
# State
# ---------------------------------------------------------------------------

_frame_count     = 0
_fps_start       = 0.0
_fps             = 0.0
_last_press_time = 0.0
_total_presses   = 0


def on_start(config: dict) -> None:
    global _frame_count, _fps_start, _last_press_time, _total_presses
    _frame_count = 0
    _fps_start = time.monotonic()
    _last_press_time = 0.0
    _total_presses = 0
    print(f"[boost_court] started on session {config['session_id']}")


# ---------------------------------------------------------------------------
# Detection — returns CLASSIFIED detections (each with a label + reason)
# ---------------------------------------------------------------------------

def classify_detections(frame: np.ndarray) -> list:
    """
    Run color detection over the search ROI, then classify EVERY contour
    we find into one of these categories:
        "pad"          — accepted as a Got Next pad
        "nameplate"    — rejected (wrong shape — too wide, too thin)
        "own_player"   — rejected (inside self-exclusion column)
        "too_small"    — rejected (below MIN_PAD_AREA)
    Returns a list of dicts: {x, y, w, h, area, label, color, accepted}
    """
    h, w = frame.shape[:2]

    # ROI rect (full-frame coords)
    rx1 = int(w * ROI_LEFT);  ry1 = int(h * ROI_TOP)
    rx2 = int(w * ROI_RIGHT); ry2 = int(h * ROI_BOTTOM)
    roi = frame[ry1:ry2, rx1:rx2]
    if roi.size == 0:
        return []

    hsv = cv2.cvtColor(roi, cv2.COLOR_BGR2HSV)
    mask = cv2.inRange(hsv, PAD_LOWER, PAD_UPPER)

    # Light morph cleanup so noise doesn't fragment a pad into 5 contours
    kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (5, 5))
    mask = cv2.morphologyEx(mask, cv2.MORPH_CLOSE, kernel, iterations=1)

    contours, _ = cv2.findContours(mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    # Self-exclusion bounds (full-frame coords)
    sx1 = int(w * SELF_LEFT)
    sx2 = int(w * SELF_RIGHT)

    detections = []
    for cnt in contours:
        area = cv2.contourArea(cnt)
        x, y, bw, bh = cv2.boundingRect(cnt)
        # Convert to full-frame coords
        fx = x + rx1
        fy = y + ry1

        # Skip near-zero junk so we don't draw thousands of dots
        if bw < 4 or bh < 4 or area < 30:
            continue

        # Default classification
        label    = ""
        color    = CLR_TOO_SMALL
        accepted = False

        # CHECK 1: Inside self-exclusion column?
        contour_cx = fx + bw // 2
        if sx1 <= contour_cx <= sx2:
            label = "OWN PLAYER"
            color = CLR_OWN_PLAYER
            detections.append({
                "x": fx, "y": fy, "w": bw, "h": bh, "area": int(area),
                "label": label, "color": color, "accepted": False,
            })
            continue

        # CHECK 2: Too small?
        if area < MIN_PAD_AREA:
            label = "TOO SMALL"
            color = CLR_TOO_SMALL
            detections.append({
                "x": fx, "y": fy, "w": bw, "h": bh, "area": int(area),
                "label": label, "color": color, "accepted": False,
            })
            continue

        # CHECK 3: Aspect ratio — nameplate?
        aspect = bw / max(bh, 1)
        if aspect > PAD_ASPECT_MAX or aspect < PAD_ASPECT_MIN:
            label = "NAMEPLATE"
            color = CLR_NAMEPLATE
            detections.append({
                "x": fx, "y": fy, "w": bw, "h": bh, "area": int(area),
                "label": label, "color": color, "accepted": False,
            })
            continue

        # PASSED — it's a pad
        label    = "GOT NEXT PAD"
        color    = CLR_PAD_CANDIDATE
        accepted = True
        detections.append({
            "x": fx, "y": fy, "w": bw, "h": bh, "area": int(area),
            "label": label, "color": color, "accepted": True,
        })

    return detections


def detect_prompt(frame: np.ndarray) -> tuple:
    """Got Next 'A' prompt at bottom-center."""
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
# Drawing helpers
# ---------------------------------------------------------------------------

def _draw_label(frame, text, x, y, color):
    """Draw a colored box with the label name above the detection."""
    (tw, th), _ = cv2.getTextSize(text, cv2.FONT_HERSHEY_SIMPLEX, 0.45, 1)
    pad = 3
    bx1 = x
    by1 = max(0, y - th - pad * 2)
    bx2 = x + tw + pad * 2
    by2 = by1 + th + pad * 2
    cv2.rectangle(frame, (bx1, by1), (bx2, by2), color, -1)
    cv2.putText(frame, text, (bx1 + pad, by2 - pad - 1),
                cv2.FONT_HERSHEY_SIMPLEX, 0.45, CLR_BLACK, 1)


def draw_detections(frame, detections, target_idx):
    """Draw all detections with their labels — like nba2k_players.py style."""
    for i, det in enumerate(detections):
        x, y, w, h = det["x"], det["y"], det["w"], det["h"]
        color = det["color"]
        label = det["label"]
        thickness = 2

        # Highlight the target with extra thick green box
        if i == target_idx:
            color = CLR_PAD_TARGET
            thickness = 4
            label = "TARGET"

        cv2.rectangle(frame, (x, y), (x + w, y + h), color, thickness)
        # Label with size info
        text = f"{label} {det['area']}px"
        _draw_label(frame, text, x, y, color)


# ---------------------------------------------------------------------------
# Main loop
# ---------------------------------------------------------------------------

def on_frame(frame: np.ndarray, session_id: int, emit) -> None:
    global _frame_count, _fps_start, _fps, _last_press_time, _total_presses

    h, w = frame.shape[:2]
    now = time.monotonic()

    # ── Run all detections (classified) ──
    detections = classify_detections(frame)
    prompt_found, prompt_px = detect_prompt(frame)

    # ── Pick the BIGGEST accepted pad as the target ──
    accepted = [(i, d) for i, d in enumerate(detections) if d["accepted"]]
    target_idx = -1
    target_x = None
    target_y = None
    if accepted:
        i, biggest = max(accepted, key=lambda kv: kv[1]["area"])
        target_idx = i
        target_x = biggest["x"] + biggest["w"] // 2
        target_y = biggest["y"] + biggest["h"] // 2

    # ── Build gamepad output ──
    axes = [0.0, 0.0, 0.0, 0.0]
    buttons = [False] * 17
    cooldown_ok = (now - _last_press_time) >= PRESS_COOLDOWN_SEC

    if prompt_found and cooldown_ok:
        buttons[0] = True
        _last_press_time = now
        _total_presses += 1
        print(f"[boost_court] PRESS A — pads={len(accepted)} prompt={prompt_px}px")
    elif target_x is not None:
        axes[1] = WALK_FORWARD_Y
        target_norm = (target_x - w / 2) / (w / 2)
        if abs(target_norm) > STEER_DEADZONE:
            axes[0] = max(-1.0, min(1.0, target_norm * STEER_GAIN))

    emit({"session_id": session_id, "axes": axes, "buttons": buttons})

    # ── Overlay ──
    # Faint ROI guide
    rx1 = int(w * ROI_LEFT);  ry1 = int(h * ROI_TOP)
    rx2 = int(w * ROI_RIGHT); ry2 = int(h * ROI_BOTTOM)
    cv2.rectangle(frame, (rx1, ry1), (rx2, ry2), (40, 80, 40), 1)

    # Self-exclusion guide
    sx1 = int(w * SELF_LEFT); sx2 = int(w * SELF_RIGHT)
    cv2.rectangle(frame, (sx1, ry1), (sx2, ry2), (50, 0, 80), 1)
    cv2.putText(frame, "SELF EXCL", (sx1 + 6, ry1 + 16),
                cv2.FONT_HERSHEY_SIMPLEX, 0.45, (140, 100, 200), 1)

    # Draw all classified detections with labels
    draw_detections(frame, detections, target_idx)

    # Big target crosshair
    if target_x is not None:
        cv2.circle(frame, (target_x, target_y), 32, CLR_PAD_TARGET, 3)
        cv2.line(frame, (target_x - 50, target_y), (target_x + 50, target_y), CLR_PAD_TARGET, 2)
        cv2.line(frame, (target_x, target_y - 50), (target_x, target_y + 50), CLR_PAD_TARGET, 2)
        cv2.line(frame, (w // 2, int(h * 0.88)), (target_x, target_y), (0, 200, 255), 2)

    # FPS
    _frame_count += 1
    elapsed = now - _fps_start
    if elapsed >= 1.0:
        _fps = _frame_count / elapsed
        _frame_count = 0
        _fps_start = now

    # Counts per category
    n_pads = sum(1 for d in detections if d["accepted"])
    n_nameplates = sum(1 for d in detections if d["label"] == "NAMEPLATE")
    n_own = sum(1 for d in detections if d["label"] == "OWN PLAYER")
    n_small = sum(1 for d in detections if d["label"] == "TOO SMALL")

    # ── Legend / HUD ──
    cv2.rectangle(frame, (5, 5), (390, 175), (0, 0, 0), -1)
    cv2.rectangle(frame, (5, 5), (390, 175), (60, 60, 60), 1)
    cv2.putText(frame, f"BoostCourt | {_fps:.0f} fps", (12, 28),
                cv2.FONT_HERSHEY_SIMPLEX, 0.6, CLR_HUD, 2)
    cv2.putText(frame, f"Pads: {n_pads}  Prompt: {prompt_px}px {'YES' if prompt_found else 'no'}",
                (12, 50), cv2.FONT_HERSHEY_SIMPLEX, 0.5, CLR_HUD, 1)
    cv2.putText(frame, f"Stick X={axes[0]:+.2f} Y={axes[1]:+.2f}  Presses: {_total_presses}",
                (12, 68), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (180, 220, 255), 1)

    # Color legend
    cv2.putText(frame, "LEGEND:", (12, 92),
                cv2.FONT_HERSHEY_SIMPLEX, 0.45, CLR_HUD, 1)
    legend_items = [
        (f"GOT NEXT PAD ({n_pads})",  CLR_PAD_TARGET, 108),
        (f"NAMEPLATE ({n_nameplates})", CLR_NAMEPLATE,    124),
        (f"OWN PLAYER ({n_own})",     CLR_OWN_PLAYER,   140),
        (f"TOO SMALL ({n_small})",    CLR_TOO_SMALL,    156),
    ]
    for txt, col, ypos in legend_items:
        cv2.rectangle(frame, (12, ypos - 10), (24, ypos), col, -1)
        cv2.putText(frame, txt, (30, ypos),
                    cv2.FONT_HERSHEY_SIMPLEX, 0.42, col, 1)

    preview = cv2.resize(frame, (960, 540)) if w > 1280 else frame
    cv2.imshow("TM Labs - Boost Court", preview)
    cv2.waitKey(1)


def on_stop() -> None:
    print(f"[boost_court] stopped. Total presses: {_total_presses}")
