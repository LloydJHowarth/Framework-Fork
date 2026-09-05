using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GPUBufferUsage : uint
    {
	    SDL_GPU_BUFFERUSAGE_VERTEX = (1U << 0),
	    SDL_GPU_BUFFERUSAGE_INDEX = (1U << 1),
	    SDL_GPU_BUFFERUSAGE_INDIRECT = (1U << 2),
	    SDL_GPU_BUFFERUSAGE_GRAPHICS_STORAGE_READ = (1U << 3),
	    SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_READ = (1U << 4),
	    SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_WRITE = (1U << 5),
    }
}