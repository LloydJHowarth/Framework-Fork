using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_HapticEffectType : uint
    {
	    SDL_HAPTIC_CONSTANT = (1U << 0),
	    SDL_HAPTIC_SINE = (1U << 1),
	    SDL_HAPTIC_SQUARE = (1U << 2),
	    SDL_HAPTIC_TRIANGLE = (1U << 3),
	    SDL_HAPTIC_SAWTOOTHUP = (1U << 4),
	    SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5),
	    SDL_HAPTIC_RAMP = (1U << 6),
	    SDL_HAPTIC_SPRING = (1U << 7),
	    SDL_HAPTIC_DAMPER = (1U << 8),
	    SDL_HAPTIC_INERTIA = (1U << 9),
	    SDL_HAPTIC_FRICTION = (1U << 10),
	    SDL_HAPTIC_LEFTRIGHT = (1U << 11),
	    SDL_HAPTIC_RESERVED1 = (1U << 12),
	    SDL_HAPTIC_RESERVED2 = (1U << 13),
	    SDL_HAPTIC_RESERVED3 = (1U << 14),
	    SDL_HAPTIC_CUSTOM = (1U << 15),
	    SDL_HAPTIC_GAIN = (1U << 16),
	    SDL_HAPTIC_AUTOCENTER = (1U << 17),
	    SDL_HAPTIC_STATUS = (1U << 18),
	    SDL_HAPTIC_PAUSE = (1U << 19),
    }
}