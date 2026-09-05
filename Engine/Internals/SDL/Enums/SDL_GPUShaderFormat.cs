using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_GPUShaderFormat : uint
    {
	    SDL_GPU_SHADERFORMAT_INVALID = 0,
	    SDL_GPU_SHADERFORMAT_PRIVATE = (1U << 0),
	    SDL_GPU_SHADERFORMAT_SPIRV = (1U << 1),
	    SDL_GPU_SHADERFORMAT_DXBC = (1U << 2),
	    SDL_GPU_SHADERFORMAT_DXIL = (1U << 3),
	    SDL_GPU_SHADERFORMAT_MSL = (1U << 4),
	    SDL_GPU_SHADERFORMAT_METALLIB = (1U << 5),
    }
}