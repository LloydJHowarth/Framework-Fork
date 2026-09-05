using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_PenFlags : uint
    {
	    SDL_PEN_INPUT_DOWN = (1U << 0),
	    SDL_PEN_INPUT_BUTTON_1 = (1U << 1),
	    SDL_PEN_INPUT_BUTTON_2 = (1U << 2),
	    SDL_PEN_INPUT_BUTTON_3 = (1U << 3),
	    SDL_PEN_INPUT_BUTTON_4 = (1U << 4),
	    SDL_PEN_INPUT_BUTTON_5 = (1U << 5),
	    SDL_PEN_INPUT_ERASER_TIP = (1U << 30),
	    SDL_PEN_INPUT_IN_PROXIMITY = (1U << 31),
    }
}