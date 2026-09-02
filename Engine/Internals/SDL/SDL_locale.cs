using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Locale** SDL_GetPreferredLocales(int* count)
        {
            return iSDL_GetPreferredLocales(count);
        }
    }
}