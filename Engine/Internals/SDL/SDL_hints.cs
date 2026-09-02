using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_SetHintWithPriority(byte* name, byte* value, SDL_HintPriority priority)
        {
            return iSDL_SetHintWithPriority(name, value, priority);
        }

        internal static SDL_Bool SDL_SetHint(byte* name, byte* value)
        {
            return iSDL_SetHint(name, value);
        }

        internal static SDL_Bool SDL_ResetHint(byte* name)
        {
            return iSDL_ResetHint(name);
        }

        internal static void SDL_ResetHints()
        {
            iSDL_ResetHints();
        }

        internal static byte* SDL_GetHint(byte* name)
        {
            return iSDL_GetHint(name);
        }

        internal static SDL_Bool SDL_GetHintBoolean(byte* name, SDL_Bool default_value)
        {
            return iSDL_GetHintBoolean(name, default_value);
        }

        internal static SDL_Bool SDL_AddHintCallback(byte* name, IntPtr callback, void* userdata)
        {
            return iSDL_AddHintCallback(name, callback, userdata);
        }

        internal static void SDL_RemoveHintCallback(byte* name, IntPtr callback, void* userdata)
        {
            iSDL_RemoveHintCallback(name, callback, userdata);
        }
    }
}