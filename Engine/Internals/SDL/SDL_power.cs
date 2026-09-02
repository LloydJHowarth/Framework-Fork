using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_PowerState SDL_GetPowerInfo(int* seconds, int* percent)
        {
            return iSDL_GetPowerInfo(seconds, percent);
        }
    }
}