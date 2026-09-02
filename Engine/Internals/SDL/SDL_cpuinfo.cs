using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static int SDL_GetNumLogicalCPUCores()
        {
            return iSDL_GetNumLogicalCPUCores();
        }

        internal static int SDL_GetCPUCacheLineSize()
        {
            return iSDL_GetCPUCacheLineSize();
        }

        internal static SDL_Bool SDL_HasAltiVec()
        {
            return iSDL_HasAltiVec();
        }

        internal static SDL_Bool SDL_HasMMX()
        {
            return iSDL_HasMMX();
        }

        internal static SDL_Bool SDL_HasSSE()
        {
            return iSDL_HasSSE();
        }

        internal static SDL_Bool SDL_HasSSE2()
        {
            return iSDL_HasSSE2();
        }

        internal static SDL_Bool SDL_HasSSE3()
        {
            return iSDL_HasSSE3();
        }

        internal static SDL_Bool SDL_HasSSE41()
        {
            return iSDL_HasSSE41();
        }

        internal static SDL_Bool SDL_HasSSE42()
        {
            return iSDL_HasSSE42();
        }

        internal static SDL_Bool SDL_HasAVX()
        {
            return iSDL_HasAVX();
        }

        internal static SDL_Bool SDL_HasAVX2()
        {
            return iSDL_HasAVX2();
        }

        internal static SDL_Bool SDL_HasAVX512F()
        {
            return iSDL_HasAVX512F();
        }

        internal static SDL_Bool SDL_HasARMSIMD()
        {
            return iSDL_HasARMSIMD();
        }

        internal static SDL_Bool SDL_HasNEON()
        {
            return iSDL_HasNEON();
        }

        internal static SDL_Bool SDL_HasSVE2()
        {
            return iSDL_HasSVE2();
        }

        internal static SDL_Bool SDL_HasLSX()
        {
            return iSDL_HasLSX();
        }

        internal static SDL_Bool SDL_HasLASX()
        {
            return iSDL_HasLASX();
        }

        internal static int SDL_GetSystemRAM()
        {
            return iSDL_GetSystemRAM();
        }

        internal static nuint SDL_GetSIMDAlignment()
        {
            return iSDL_GetSIMDAlignment();
        }

        internal static int SDL_GetSystemPageSize()
        {
            return iSDL_GetSystemPageSize();
        }
    }
}