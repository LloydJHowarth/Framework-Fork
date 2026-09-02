using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_Init(uint flags)
        {
            return iSDL_Init(flags);
        }

        internal static SDL_Bool SDL_InitSubSystem(uint flags)
        {
            return iSDL_InitSubSystem(flags);
        }

        internal static void SDL_QuitSubSystem(uint flags)
        {
            iSDL_QuitSubSystem(flags);
        }

        internal static uint SDL_WasInit(uint flags)
        {
            return iSDL_WasInit(flags);
        }

        internal static void SDL_Quit()
        {
            iSDL_Quit();
        }

        internal static SDL_Bool SDL_IsMainThread()
        {
            return iSDL_IsMainThread();
        }

        internal static SDL_Bool SDL_RunOnMainThread(IntPtr callback, void* userdata, SDL_Bool wait_complete)
        {
            return iSDL_RunOnMainThread(callback, userdata, wait_complete);
        }

        internal static SDL_Bool SDL_SetAppMetadata(byte* appname, byte* appversion, byte* appidentifier)
        {
            return iSDL_SetAppMetadata(appname, appversion, appidentifier);
        }

        internal static SDL_Bool SDL_SetAppMetadataProperty(byte* name, byte* value)
        {
            return iSDL_SetAppMetadataProperty(name, value);
        }

        internal static byte* SDL_GetAppMetadataProperty(byte* name)
        {
            return iSDL_GetAppMetadataProperty(name);
        }
    }
}