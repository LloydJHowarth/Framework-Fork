using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void* SDL_Metal_CreateView(SDL_Window* window)
        {
            return iSDL_Metal_CreateView(window);
        }

        public static void SDL_Metal_DestroyView(void* view)
        {
            iSDL_Metal_DestroyView(view);
        }

        public static void* SDL_Metal_GetLayer(void* view)
        {
            return iSDL_Metal_GetLayer(view);
        }
    }
}