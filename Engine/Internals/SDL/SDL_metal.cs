using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static void* SDL_Metal_CreateView(SDL_Window* window)
        {
            return iSDL_Metal_CreateView(window);
        }

        internal static void SDL_Metal_DestroyView(void* view)
        {
            iSDL_Metal_DestroyView(view);
        }

        internal static void* SDL_Metal_GetLayer(void* view)
        {
            return iSDL_Metal_GetLayer(view);
        }
    }
}