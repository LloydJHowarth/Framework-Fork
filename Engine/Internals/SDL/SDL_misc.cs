using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Bool SDL_OpenURL(byte* url)
        {
            return iSDL_OpenURL(url);
        }
    }
}