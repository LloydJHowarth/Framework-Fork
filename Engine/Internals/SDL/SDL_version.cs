using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static int SDL_GetVersion()
        {
            return iSDL_GetVersion();
        }

        internal static byte* SDL_GetRevision()
        {
            return iSDL_GetRevision();
        }
    }
}