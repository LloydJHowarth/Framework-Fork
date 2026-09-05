using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_AudioMask : uint
    {
	    SDL_AUDIO_MASK_BITSIZE = (0xFFU),
	    SDL_AUDIO_MASK_FLOAT = (1U << 8),
	    SDL_AUDIO_MASK_BIG_ENDIAN = (1U << 12),
	    SDL_AUDIO_MASK_SIGNED = (1U << 15),
    }
}