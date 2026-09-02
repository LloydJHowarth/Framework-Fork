using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_SharedObject* SDL_LoadObject(byte* sofile)
        {
            return iSDL_LoadObject(sofile);
        }

        public static IntPtr SDL_LoadFunction(SDL_SharedObject* handle, byte* name)
        {
            return iSDL_LoadFunction(handle, name);
        }

        public static void SDL_UnloadObject(SDL_SharedObject* handle)
        {
            iSDL_UnloadObject(handle);
        }
    }
}