using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_SetError(byte* fmt)
        {
            return iSDL_SetError(fmt);
        }

        internal static SDL_Bool SDL_SetErrorV(byte* fmt, byte* ap)
        {
            return iSDL_SetErrorV(fmt, ap);
        }

        internal static SDL_Bool SDL_OutOfMemory()
        {
            return iSDL_OutOfMemory();
        }

        internal static byte* SDL_GetError()
        {
            return iSDL_GetError();
        }

        internal static SDL_Bool SDL_ClearError()
        {
            return iSDL_ClearError();
        }
    }
}