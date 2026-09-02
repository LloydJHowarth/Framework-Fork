using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Locale** SDL_GetPreferredLocales(int* count)
        {
            return iSDL_GetPreferredLocales(count);
        }
    }
}