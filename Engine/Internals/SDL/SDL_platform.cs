using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static byte* SDL_GetPlatform()
        {
            return iSDL_GetPlatform();
        }
    }
}