# NOTICE

This folder contains research notes and decompiled source from
**Cronus Zen Studio v1.6.1** (© Collective Minds Productions AB).

## Purpose
Personal reverse-engineering / interoperability research to understand the
Cronus Zen device protocol and GPC compiler so an independent client can
communicate with the user's own Zen hardware.

## Contents
- `README.md` — research notes and protocol findings (original work)
- `decompiled/` — decompiled `.cs` source produced by ILSpy from the
  installed `ZenStudio.exe` and `ZenLinkConfigurator.exe` binaries.
  Method bodies for compiler internals are stripped by Eazfuscator.

## What is NOT included
The Cronus Zen Studio installer, the executable binaries, and any DLLs
shipped by Collective Minds are intentionally excluded from this repository
(see `.gitignore`). To reproduce the decompile, install Cronus Zen Studio
yourself from the official source.

## Trademarks
Cronus, Cronus Zen, Zen Studio, GPC, and related names are trademarks of
their respective owners. This research is not affiliated with or endorsed
by Collective Minds Productions AB.
