using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [Flags]
    internal enum SDL_KeyModifier : uint
    {
	    SDL_KMOD_NONE = 0x0000U,
	    SDL_KMOD_LSHIFT = 0x0001U,
	    SDL_KMOD_RSHIFT = 0x0002U,
	    SDL_KMOD_LEVEL5 = 0x0004U,
	    SDL_KMOD_LCTRL = 0x0040U,
	    SDL_KMOD_RCTRL = 0x0080U,
	    SDL_KMOD_LALT = 0x0100U,
	    SDL_KMOD_RALT = 0x0200U,
	    SDL_KMOD_LGUI = 0x0400U,
	    SDL_KMOD_RGUI = 0x0800U,
	    SDL_KMOD_NUM = 0x1000U,
	    SDL_KMOD_CAPS = 0x2000U,
	    SDL_KMOD_MODE = 0x4000U,
	    SDL_KMOD_SCROLL = 0x8000U,
	    SDL_KMOD_CTRL = (0x0040U | 0x0080U),
	    SDL_KMOD_SHIFT = (0x0001U | 0x0002U),
	    SDL_KMOD_ALT = (0x0100U | 0x0200U),
	    SDL_KMOD_GUI = (0x0400U | 0x0800U),
    }
}