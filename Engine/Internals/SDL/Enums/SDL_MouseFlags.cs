using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_MouseFlags : uint
    {
	    SDL_BUTTON_LEFT = 1,
	    SDL_BUTTON_MIDDLE = 2,
	    SDL_BUTTON_RIGHT = 3,
	    SDL_BUTTON_X1 = 4,
	    SDL_BUTTON_X2 = 5,
	    SDL_BUTTON_LMASK = (1U << ((1) - 1)),
	    SDL_BUTTON_MMASK = (1U << ((2) - 1)),
	    SDL_BUTTON_RMASK = (1U << ((3) - 1)),
	    SDL_BUTTON_X1MASK = (1U << ((4) - 1)),
	    SDL_BUTTON_X2MASK = (1U << ((5) - 1)),
    }
}