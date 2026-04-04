# Helios II Decompiled API Reference
## Extracted from .pyd files via Python introspection + binary string analysis

---

## Core Modules (lib/py/)

### GCVWrapper (172 KB) — Main CV Pipeline Orchestrator
```
main(script_path, process_id_param, video_ring_buffer_name_param,
     gcv_data_name_param, controller_input_name_param,
     controller_report_name_param, shutdown_event_name_param=None,
     shutdown_flag_func=None)

class GCVWorkerLocator:
    find(script_path: str, module_name: str = '__gcv_mod__')
    _direct_import_names(script_path: str)
    _ast_cache: dict

class PerformanceTracker:
    update_fps(self, current_time_ns)
    update_latency_average(self, new_latency_ms)
```

### gtuner (168 KB) — Controller Input/Output Bridge
```
# Constants: BUTTON_1..21, STICK_1/2_X/Y, ACCEL/GYRO/POINT/PADDLE

class GtunerController:
    get_actual(self, int button) -> float  # Physical input 0-100 / -100..+100
    get_val(self, int button) -> float     # Virtual output
    set_script_path(self, script_path)
    cleanup(self)

# Module-level functions:
init_gtuner(controller_input_name, controller_report_name, gcv_data_name=None)
get_actual(int button) -> float
get_val(int button) -> float
send_gcvdata(gcvdata: bytes)
set_script_path(script_path)
cleanup_gtuner()
list_identifiers()
```

### inference_core (482 KB) — Neural Network Inference Engine
```
class InferenceSession:
    start(ring_buffer_name: str, helios_pid: int)
    stop()
    load_model(uuid: str, use_tensorrt: bool = True)
    unload_model()
    trigger_frame(sequence: int)
    wait_for_results(timeout_ms: int = 35) -> ndarray
    pause() / resume()
    destroy()

    # Detection config:
    set_roi(center_x, center_y, width_pct, height_pct)
    set_confidence_threshold(threshold, class_ids=None)
    set_nms_threshold(threshold)
    set_sort_method(method)  # SORT_DISTANCE=0, SORT_CONFIDENCE=1
    set_anchor_point(pct_x=0.5, pct_y=0.5)
    set_polar_origin(pct_x=0.5, pct_y=0.5)
    set_tracking(max_age_ms, confirm_ms=50, gating=?)
    set_search_mode(mode)
    set_class_priority(priority_spec)
    set_ignore_region(x1, y1, x2, y2)

    # Zoom:
    set_zoom_enabled(bool) / set_zoom_max(pct) / set_zoom_step(pct)

    # Draw overlays:
    set_draw_detections(bool) / set_draw_keypoints(bool)
    set_draw_skeleton(bool) / set_draw_roi(bool)
    set_draw_anchor_point(bool) / set_draw_origin_cross(bool)

    # Properties:
    model_loaded: bool
    is_paused: bool
    last_wfr_total_ms / last_wfr_wait_ms / last_wfr_copy_ms: int

class Detection (ctypes.Structure):
    x1, y1, x2, y2: float       # Bounding box
    center_x, center_y: float   # Center point
    anchor_x, anchor_y: float   # Anchor point
    width, height, area: float  # Dimensions
    class_id: int               # Detection class
    confidence: float           # 0-1
    polar_angle, polar_distance: float
    keypoints: array            # Pose keypoints

class InferenceResultsBlock:
    num_detections: int
    frame_sequence, write_sequence: int
    frame_width, frame_height: int
    inference_time_ms: int
    model_type: int  # MODEL_DETECTION=0, MODEL_POSE=1
    detections: Detection[]

# Error codes: OK, FILE_NOT_FOUND, INVALID_FORMAT, NOT_LOGGED_IN,
#              SESSION_EXPIRED, NETWORK, ACCESS_DENIED, DECRYPT_FAILED,
#              ONNX_LOAD, DEBUGGER, MEMORY, INVALID_SALT, NOT_ENCRYPTED,
#              ENCRYPT_FAILED, ENGINE_BUILD, RATE_LIMITED

create_inference_engine(uuid: str, use_tensorrt: bool = True) -> InferenceSession
list_models() -> List[Dict]
set_session(token: str, username='', globalname='', avatar='')
trigger_inference_for_frame(sequence: int)
get_debug_log() -> str
```

### ring_buffer_reader (164 KB) — Zero-Copy Frame IPC
```
class RingBufferReader:
    wait_for_frame() -> frame_data
    mark_frame_processed(slot_index, sequence)
    finish_frame(slot_index, fps_value, latency_ms, ...)
    write_metadata(slot_index, fps_value, latency_ms, ...)
    close()
```

---

## NBA 2K Modules (scripts/_nba2k_main/)

### nba2k_helper (217 KB) — Main Orchestrator
```
class Helper:
    __init__(self)
    run(self, frame) -> (frame, gcvdata)   # Main entry point
    meter_run(self)    # Shot meter detection pipeline
    skele_run(self)    # Skeleton/player detection
    icon_run(self)     # Icon detection (3pt, dunk, star)
    oop_run(self)      # Out-of-play detection
    img_send_run(self) # Frame forwarding

# Internal references: inference_engine, meter_handler, meters,
#   skele_shooter, skele_releaser, releaser, settings, nba2k_settings
```

### shot (460 KB) — Shot Meter Detection (ALL 7 METER TYPES)
```
class Straight:
    __init__, search, train, verify
    find_bar()
    find_meter_edges()
    is_gray_or_green_region() / is_gray_pixels() / is_green_shade()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Arrow:
    __init__, search, train
    find_arrow_by_color()
    get_two_matching_grays()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Arrow2:
    __init__, search, train, verify
    find_white_bar()
    is_gray_shade()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Pill:
    __init__, search, train, batch_verify
    find_bar()
    is_column_mostly_gray()
    is_gray_or_green_region() / is_gray_pixels() / is_green_shade()
    passes_dimensional_check()
    verify_contour_sides()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Sword:
    __init__, search, train, verify
    find_bar()
    is_gray_or_green_region() / is_gray_pixels() / is_green_shade()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Dial:
    __init__, search, train
    find_dial_by_color()
    find_side_anchor_point()
    measure_contour_length() / measure_partial_arc_via_contour()
    reorder_contour() / verify_contour()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class _2kOL2:
    __init__, search, train, verify
    find_white_bar()
    is_gray_shade()
    speed_condition_met() / distance_condition_met() / ztrig_condition_met()

class Oop:
    __init__, search, find
    get_donut_pixels()

# Key detection variables found in binary:
# searchArea, meter_region, meter_column, meter_x_center
# color_contour, gray_contour, white_mask, green_mask, combined_mask
# contour_height, color_height, color_width
# findContours, boundingRect, morphologyEx, contourArea
# green_threshold, intensity_threshold, size_threshold
# top_of_meter, top_of_meter_to_green
# user_timing, user_timing_offset
```

### skele (70 KB) — Skeleton/Player Detection
```
class Parser:
    __init__

class Shooter:
    __init__
    run(self)
    ball_intersects_player_top(self)
    ball_released(self)

# Key variables: player_box, ball_box, player_height, player_top,
#   ball_top, ball_bottom, in_shooting_pose, TOP_REGION_FRAC
#   inference_engine, loaded_model, detected
```

### bot (476 KB) — Full Game AI Bot
```
class Bot:
    __init__
    run(self)
    _execute_shoot(self)
    _execute_pass(self)
    _execute_dribble(self)
    _draw_debug_info(self)
    add_custom_dribble(self)

class GameState:
    from_tracked_objects(cls, tracked_objects)
    # Props: balls, player_box, court_zone, game_phase, shot_clock

class DecisionEngine:
    __init__
    update(self)  # AI decision loop

class Action / ShootAction / PassAction / MoveAction / DefendAction:
    evaluate(self) -> score
    is_valid(self) -> bool

class DribbleMove:
    __init__
    evaluate(self) / get_current_input(self) / is_complete(self)

class AIConfig:
    get_role_modifiers(self)

# Game phases: OFFENSE, DEFENSE, TRANSITION_OFFENSE, TRANSITION_DEFENSE,
#              DEAD_BALL, BACKCOURT, DRIBBLE, SHOOT
# Key: tracked_objects, controlled_player, court_position, shot_selection
#      dribble_threshold, sprint_threshold, passing_tendency
```

### gym (274 KB) — Training Gym Automation
```
class Workout:
    __init__, run
    get_green() / grab_areas() / templateMatch()

class BoxJump / MedicineBall:
    __init__, iterate

class BenchPress / Pullup / Squats / Treadmill / ExerciseBike:
    __init__

class AgilityHurdles / AgilityLadder / Sprints:
    __init__

class Reaction:
    __init__, grab_areas(), templateMatch()
```

### icon (120 KB) — Game Icon Detection
```
class X:
    __init__
    run(self)
    find_3pt_contour(self)    # 3-point line icon
    find_dunk_contour(self)   # Dunk icon
    find_star_contour(self)   # Star icon
    is_gray_pixels(self)
    verify_contour_region(self)
    verify_pixel_line(self)
```

### extra (174 KB) — Shot Release & Dribble Moves
```
class Releaser:
    __init__
    begin_release(self)
    run(self)

class Skeleaser:
    __init__
    begin_release(self)
    run(self)

class Dunk:
    __init__

class Rhythm:
    __init__
    increment_stick_position(self)

# Key: meter_object, release_timer, temp_shooting_stick, rhythm_settings
#      frame_duration_ms, per_frame_percentage
```
