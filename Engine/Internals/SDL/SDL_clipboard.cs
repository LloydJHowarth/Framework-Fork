using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Bool SDL_SetClipboardText(byte* text)
        {
            return iSDL_SetClipboardText(text);
        }

        public static byte* SDL_GetClipboardText()
        {
            return iSDL_GetClipboardText();
        }

        public static SDL_Bool SDL_HasClipboardText()
        {
            return iSDL_HasClipboardText();
        }

        public static SDL_Bool SDL_SetPrimarySelectionText(byte* text)
        {
            return iSDL_SetPrimarySelectionText(text);
        }

        public static byte* SDL_GetPrimarySelectionText()
        {
            return iSDL_GetPrimarySelectionText();
        }

        public static SDL_Bool SDL_HasPrimarySelectionText()
        {
            return iSDL_HasPrimarySelectionText();
        }

        public static SDL_Bool SDL_SetClipboardData(IntPtr callback, IntPtr cleanup, void* userdata, byte** mime_types, nuint num_mime_types)
        {
            return iSDL_SetClipboardData(callback, cleanup, userdata, mime_types, num_mime_types);
        }

        public static SDL_Bool SDL_ClearClipboardData()
        {
            return iSDL_ClearClipboardData();
        }

        public static void* SDL_GetClipboardData(byte* mime_type, nuint* size)
        {
            return iSDL_GetClipboardData(mime_type, size);
        }

        public static SDL_Bool SDL_HasClipboardData(byte* mime_type)
        {
            return iSDL_HasClipboardData(mime_type);
        }

        public static byte** SDL_GetClipboardMimeTypes(nuint* num_mime_types)
        {
            return iSDL_GetClipboardMimeTypes(num_mime_types);
        }
    }
}