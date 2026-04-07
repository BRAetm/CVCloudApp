# Zen Coder

Reverse engineering Cronus Zen Studio so we can build our own app that:
1. Connects to a Cronus Zen device
2. Compiles GPC scripts
3. Lets users run their scripts inside our app

## What we have

### Source binaries
- `ZenStudio_Setup_v1.6.1_Build_82.exe` — original NSIS installer
- `extracted/ZenStudio.exe` — main IDE (.NET, 20MB, obfuscated with Eazfuscator)
- `extracted/ZenLinkConfigurator.exe` — separate device configurator (.NET, 2.7MB)

### Decompiled output
- `decompiled/ZenStudio/` — full decompile of the IDE
- `decompiled/ZenLinkConfigurator/` — full decompile of the configurator

## Key findings

### Cronus Zen USB device
- **Vendor ID:** `0x1208` (4616 decimal)
- **Product ID:** `0x0777` (1911 decimal)
- **Protocol:** USB HID with interrupt write + read
- **Source:** `decompiled/ZenLinkConfigurator/ZenLinkConfigurator/ZenLinkHid.cs` line 85
  ```csharp
  HidDevices.Enumerate(4616, 1911)
  ```

### ZenLink protocol (configurator → device)
File: `decompiled/ZenLinkConfigurator/ZenLinkConfigurator/ZenLinkCommandData.cs`
```csharp
public enum ZenLinkCommand : byte {
    GetFwVersion = 1,
    Restart      = 3,
    GetStatus    = 4,
    SaveSlot     = 5,
    LoadSlot     = 6,
    IsProVersion = 7
}
```

### ZenLink response status codes
File: `decompiled/ZenLinkConfigurator/ZenLinkConfigurator/ZenLinkResponseData.cs`
```csharp
public enum ZenLinkStatus {
    Unknown                       = 767,
    SuccessStartup                = 1,
    SuccessHeartBeat              = 2,
    SuccessUpdateAvailable        = 15,
    SuccessNoUpdateAvailable      = 31,
    SuccessUpdateDone             = 32,
    SuccessIdle                   = 33,
    SuccessConnectedToNetwork     = 16,
    ActionConnectingToNetwork     = 161,
    ActionCheckingForUpdate       = 162,
    ActionReadingSettings         = 166,
    ActionStartFirmwareUpdate     = 167,
    ActionDownloadingFirmwareUpdate = 168,
    ActionApplyFirmwareUpdate     = 169,
    FailedUpdate                  = 240,
    FailedToLoadSettings          = 241,
    FailedToConnectToWifi         = 242,
    FailedToCheckForUpdate        = 243,
    NotConnected                  = 511
}
```

### Cronus Zen device commands (full IDE protocol)
Folder: `decompiled/ZenStudio/Cronus.Zen.Communication.Commands/`

Every operation the IDE can do — 38 commands total:

| Category | Commands |
|----------|----------|
| **Script management** | `FlashGamepackCommand`, `RunScriptCommand`, `UnloadGpcCommand`, `ReadByteCodeCommand` |
| **Slot management** | `ChangeSlotACommand`, `ChangeSlotBCommand`, `ReadSlotsCfgCommand` |
| **Firmware** | `GetFirmwareCommand`, `DfuPrepareDeviceCommand`, `DfuUpdateFirmwareCommand` |
| **Device info** | `GetSerialCommand`, `GetStatusCommand`, `RequestAttachedDevicesCommand` |
| **API mode** | `EnterApiModeCommand`, `ExitApiModeCommand`, `ApiModeCommand` |
| **Real-time I/O** | `RequestIoStatusCommand`, `StreamIoStatusCommand`, `SetVmtCtrlCommand` |
| **Diagnostics** | `CircleTestCommand`, `DeviceCleanupCommand`, `FactoryResetCommand` |
| **Mouse/Keyboard (MK)** | `RequestMkFile`, `SendMkFile`, `FinalizeMkFileCommand`, `SaveMkFinalizeConfigCommand` |
| **Bluetooth** | `ClearBtCommand` |
| **Exclusion list** | `ReadExclusionListCommand`, `WriteExclusionListCommand` |
| **Fragments** | `ReadFragmentCommand`, `WriteFragmentCommand`, `SendSingleFragmentCommand` |
| **Power** | `ResetDeviceCommand`, `TurnOffControllerCommand` |
| **Misc** | `FlashConfigCommand`, `RefreshEEPromCommand`, `ToggleVmRuns` |

### Command opcodes (numeric values)
File: `decompiled/ZenStudio/Cronus.Zen.Communication.Enums/Commands.cs`

Names are obfuscated by Eazfuscator but the **byte values are preserved**. Confirmed mappings:

| Value | Command |
|-------|---------|
| `226` | DeviceCleanup |
| `228` | FactoryReset |
| `248` | CircleTest |

Other values (need runtime dump or code-flow analysis to map names):
`2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 32, 171, 176, 177, 178, 179, 192, 222, 223, 227, 229, 230, 233, 238, 240, 241, 242, 243, 244, 246, 247, 249, 250, 251, 252, 253`

### GPC Compiler
Location: `decompiled/ZenStudio/LibCronusMAX.GPC.Compiler/`

Files (method bodies stripped by obfuscator but interfaces visible):
- `Compiler.cs` — main compiler class
- `CompilerSettings.cs`, `CompilerState.cs`, `CompilerResult.cs`
- `CompilerKeywords.cs` — GPC reserved words
- `OpCode.cs` — bytecode instruction definitions (loaded from XML at runtime)
- `BuiltInFunctions.cs` — runtime function table (loaded from XML)
- `BuiltInConstants.cs` — language constants
- `BuiltInFunctionLimit.cs` — function call limits
- `AsmToken.cs`, `InternalAsmToken.cs` — assembly-level tokens
- `ComboStatistics.cs` — combo timing statistics

Compiler backends:
- `LibCronusMAX.GPC.Compiler.CronusZen` — Cronus Zen target
- `LibCronusMAX.GPC.Compiler.CronusZen32` — 32-bit variant
- `LibCronusMAX.GPC.Compiler.CronusMAXPlus` — Cronus MAX+ legacy target
- `LibCronusMAX.GPC.Compiler.PaddlePack` — paddle pack target
- `LibCronusMAX.GPC.Compiler.XAim` — XAim mouse converter target

### GPC Parser
Location: `decompiled/ZenStudio/LibCronusMAX.GPC.Parser/`
- `GpcParser.cs` — main parser
- `IGpcParserErrorSink.cs` — error reporting interface
- `Extensions.cs`, `ErrorArgs.cs`

## Next steps
1. Extract embedded XML resources from `ZenStudio.exe` (opcode + builtin function definitions)
2. Build a Python or C# wrapper around the HID protocol
3. Write minimal "connect to device + GetFirmware" proof of concept
4. Decide whether to:
   a. Re-implement the GPC compiler from scratch (using the XML opcode table)
   b. Wrap the existing `LibCronusMAX.GPC.Compiler` DLL as a native dependency
5. Build the user-facing app (script editor, run/stop, device monitor)
