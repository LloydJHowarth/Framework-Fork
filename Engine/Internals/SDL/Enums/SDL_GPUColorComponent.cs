using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GPUColorComponent : uint
    {
	    SDL_GPU_COLORCOMPONENT_R = (1U << 0),
	    SDL_GPU_COLORCOMPONENT_G = (1U << 1),
	    SDL_GPU_COLORCOMPONENT_B = (1U << 2),
	    SDL_GPU_COLORCOMPONENT_A = (1U << 3),
    }
}