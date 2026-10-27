# Camera Follow Scripts CSharp
A collection of Unity C# camera follow scripts for 2D and 3D.





简体中文 · [English](README.en.md)

> [!IMPORTANT]
> This repository keeps updating Unity 2D / 3D camera follow C# scripts. Hope they help you.

## 📜 Script List

| Script Name | Description | Supported Version | Advantages | Disadvantages |
| ---- | ---- | ---- | ---- | ---- |
| Simple Follow | Directly set camera position to target position with offset, no smoothing | Unity2D | Zero latency, pixel-perfect | Prone to jitter |
| Deadzone Follow | Camera stays still when target is inside the rectangle deadzone, moves only when out of bounds | Unity2D | Stable for small movements | Has lag, requires parameter tuning |

## 🚀 How to use
1. Download the script and import it into your Unity project
2. Attach it to the Camera GameObject
3. Assign the Target (follow target) in the Inspector

## 📜 License
MIT License
