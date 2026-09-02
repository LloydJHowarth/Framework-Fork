using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static int SDL_GetVersion()
        {
            return iSDL_GetVersion();
        }

        public static byte* SDL_GetRevision()
        {
            return iSDL_GetRevision();
        }
    }
}