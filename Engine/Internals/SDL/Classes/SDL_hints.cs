using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_SetHintWithPriority(byte* name, byte* value, SDL_HintPriority priority)
        {
            return iSDL_SetHintWithPriority(name, value, priority);
        }

        public static SDL_Bool SDL_SetHint(byte* name, byte* value)
        {
            return iSDL_SetHint(name, value);
        }

        public static SDL_Bool SDL_ResetHint(byte* name)
        {
            return iSDL_ResetHint(name);
        }

        public static void SDL_ResetHints()
        {
            iSDL_ResetHints();
        }

        public static byte* SDL_GetHint(byte* name)
        {
            return iSDL_GetHint(name);
        }

        public static SDL_Bool SDL_GetHintBoolean(byte* name, SDL_Bool default_value)
        {
            return iSDL_GetHintBoolean(name, default_value);
        }

        public static SDL_Bool SDL_AddHintCallback(byte* name, IntPtr callback, void* userdata)
        {
            return iSDL_AddHintCallback(name, callback, userdata);
        }

        public static void SDL_RemoveHintCallback(byte* name, IntPtr callback, void* userdata)
        {
            iSDL_RemoveHintCallback(name, callback, userdata);
        }
    }
}