using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Bool SDL_SetError(byte* fmt)
        {
            return iSDL_SetError(fmt);
        }

        public static SDL_Bool SDL_SetErrorV(byte* fmt, byte* ap)
        {
            return iSDL_SetErrorV(fmt, ap);
        }

        public static SDL_Bool SDL_OutOfMemory()
        {
            return iSDL_OutOfMemory();
        }

        public static byte* SDL_GetError()
        {
            return iSDL_GetError();
        }

        public static SDL_Bool SDL_ClearError()
        {
            return iSDL_ClearError();
        }
    }
}