using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_InitFlags : uint
    {
	    SDL_INIT_AUDIO = 0x00000010U,
	    SDL_INIT_VIDEO = 0x00000020U,
	    SDL_INIT_JOYSTICK = 0x00000200U,
	    SDL_INIT_HAPTIC = 0x00001000U,
	    SDL_INIT_GAMEPAD = 0x00002000U,
	    SDL_INIT_EVENTS = 0x00004000U,
	    SDL_INIT_SENSOR = 0x00008000U,
	    SDL_INIT_CAMERA = 0x00010000U,
    }
}