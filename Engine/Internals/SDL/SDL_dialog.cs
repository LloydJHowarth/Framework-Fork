using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static void SDL_ShowOpenFileDialog(IntPtr callback, void* userdata, SDL_Window* window, SDL_DialogFileFilter* filters, int nfilters, byte* default_location, SDL_Bool allow_many)
        {
            iSDL_ShowOpenFileDialog(callback, userdata, window, filters, nfilters, default_location, allow_many);
        }

        internal static void SDL_ShowSaveFileDialog(IntPtr callback, void* userdata, SDL_Window* window, SDL_DialogFileFilter* filters, int nfilters, byte* default_location)
        {
            iSDL_ShowSaveFileDialog(callback, userdata, window, filters, nfilters, default_location);
        }

        internal static void SDL_ShowOpenFolderDialog(IntPtr callback, void* userdata, SDL_Window* window, byte* default_location, SDL_Bool allow_many)
        {
            iSDL_ShowOpenFolderDialog(callback, userdata, window, default_location, allow_many);
        }

        internal static void SDL_ShowFileDialogWithProperties(SDL_FileDialogType type, IntPtr callback, void* userdata, uint props)
        {
            iSDL_ShowFileDialogWithProperties(type, callback, userdata, props);
        }
    }
}