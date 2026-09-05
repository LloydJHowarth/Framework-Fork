using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_AudioDevices : uint
    {
	    SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK = ((uint)(0xFFFFFFFFU)),
	    SDL_AUDIO_DEVICE_DEFAULT_RECORDING = ((uint)(0xFFFFFFFEU)),
    }
}