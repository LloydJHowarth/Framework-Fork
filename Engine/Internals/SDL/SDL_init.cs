using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_Init(uint flags)
        {
            return iSDL_Init(flags);
        }

        public static SDL_Bool SDL_InitSubSystem(uint flags)
        {
            return iSDL_InitSubSystem(flags);
        }

        public static void SDL_QuitSubSystem(uint flags)
        {
            iSDL_QuitSubSystem(flags);
        }

        public static uint SDL_WasInit(uint flags)
        {
            return iSDL_WasInit(flags);
        }

        public static void SDL_Quit()
        {
            iSDL_Quit();
        }

        public static SDL_Bool SDL_IsMainThread()
        {
            return iSDL_IsMainThread();
        }

        public static SDL_Bool SDL_RunOnMainThread(IntPtr callback, void* userdata, SDL_Bool wait_complete)
        {
            return iSDL_RunOnMainThread(callback, userdata, wait_complete);
        }

        public static SDL_Bool SDL_SetAppMetadata(byte* appname, byte* appversion, byte* appidentifier)
        {
            return iSDL_SetAppMetadata(appname, appversion, appidentifier);
        }

        public static SDL_Bool SDL_SetAppMetadataProperty(byte* name, byte* value)
        {
            return iSDL_SetAppMetadataProperty(name, value);
        }

        public static byte* SDL_GetAppMetadataProperty(byte* name)
        {
            return iSDL_GetAppMetadataProperty(name);
        }
    }
}