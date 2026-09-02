using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_PowerState SDL_GetPowerInfo(int* seconds, int* percent)
        {
            return iSDL_GetPowerInfo(seconds, percent);
        }
    }
}