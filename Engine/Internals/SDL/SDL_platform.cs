using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static byte* SDL_GetPlatform()
        {
            return iSDL_GetPlatform();
        }
    }
}