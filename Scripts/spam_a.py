"""
CVCloudApp — spam_a.py

Spams the A button by alternating press/release every frame.
Web Gamepad API button index 0 = A button.
"""

import numpy as np

_frame_counter = 0


def on_start(config: dict) -> None:
    """Called once when the worker starts."""
    global _frame_counter
    _frame_counter = 0
    print(f"[spam_a] started on session {config['session_id']}")


def on_frame(frame: np.ndarray, session_id: int, emit) -> None:
    """Alternate A button press/release every frame."""
    global _frame_counter

    buttons = [False] * 17
    if _frame_counter % 2 == 0:
        buttons[0] = True  # A button pressed on even frames

    emit({
        "session_id": session_id,
        "axes": [0.0, 0.0, 0.0, 0.0],
        "buttons": buttons,
    })

    _frame_counter += 1


def on_stop() -> None:
    """Called once when the worker shuts down."""
    print("[spam_a] stopped")
