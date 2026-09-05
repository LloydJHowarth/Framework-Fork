using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_HatFlags : uint
    {
	    SDL_HAT_CENTERED = 0x00U,
	    SDL_HAT_UP = 0x01U,
	    SDL_HAT_RIGHT = 0x02U,
	    SDL_HAT_DOWN = 0x04U,
	    SDL_HAT_LEFT = 0x08U,
	    SDL_HAT_RIGHTUP = (0x02U | 0x01U),
	    SDL_HAT_RIGHTDOWN = (0x02U | 0x04U),
	    SDL_HAT_LEFTUP = (0x08U | 0x01U),
	    SDL_HAT_LEFTDOWN = (0x08U | 0x04U),
    }
}