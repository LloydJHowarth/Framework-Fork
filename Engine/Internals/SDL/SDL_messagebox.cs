using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_ShowMessageBox(SDL_MessageBoxData* messageboxdata, int* buttonid)
        {
            return iSDL_ShowMessageBox(messageboxdata, buttonid);
        }

        public static SDL_Bool SDL_ShowSimpleMessageBox(uint flags, byte* title, byte* message, SDL_Window* window)
        {
            return iSDL_ShowSimpleMessageBox(flags, title, message, window);
        }
    }
}