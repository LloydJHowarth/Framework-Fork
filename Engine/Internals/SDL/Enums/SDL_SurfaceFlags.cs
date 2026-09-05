using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_SurfaceFlags : uint
    {
	    SDL_SURFACE_PREALLOCATED = 0x00000001U,
	    SDL_SURFACE_LOCK_NEEDED = 0x00000002U,
	    SDL_SURFACE_LOCKED = 0x00000004U,
	    SDL_SURFACE_SIMD_ALIGNED = 0x00000008U,
    }
}