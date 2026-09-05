using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_HapticDirectionType : uint
    {
	    SDL_HAPTIC_POLAR = 0,
	    SDL_HAPTIC_CARTESIAN = 1,
	    SDL_HAPTIC_SPHERICAL = 2,
	    SDL_HAPTIC_STEERING_AXIS = 3,
    }
}