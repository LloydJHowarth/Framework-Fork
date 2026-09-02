using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumLogicalCPUCores()
        {
            return iSDL_GetNumLogicalCPUCores();
        }

        public static int SDL_GetCPUCacheLineSize()
        {
            return iSDL_GetCPUCacheLineSize();
        }

        public static SDL_Bool SDL_HasAltiVec()
        {
            return iSDL_HasAltiVec();
        }

        public static SDL_Bool SDL_HasMMX()
        {
            return iSDL_HasMMX();
        }

        public static SDL_Bool SDL_HasSSE()
        {
            return iSDL_HasSSE();
        }

        public static SDL_Bool SDL_HasSSE2()
        {
            return iSDL_HasSSE2();
        }

        public static SDL_Bool SDL_HasSSE3()
        {
            return iSDL_HasSSE3();
        }

        public static SDL_Bool SDL_HasSSE41()
        {
            return iSDL_HasSSE41();
        }

        public static SDL_Bool SDL_HasSSE42()
        {
            return iSDL_HasSSE42();
        }

        public static SDL_Bool SDL_HasAVX()
        {
            return iSDL_HasAVX();
        }

        public static SDL_Bool SDL_HasAVX2()
        {
            return iSDL_HasAVX2();
        }

        public static SDL_Bool SDL_HasAVX512F()
        {
            return iSDL_HasAVX512F();
        }

        public static SDL_Bool SDL_HasARMSIMD()
        {
            return iSDL_HasARMSIMD();
        }

        public static SDL_Bool SDL_HasNEON()
        {
            return iSDL_HasNEON();
        }

        public static SDL_Bool SDL_HasSVE2()
        {
            return iSDL_HasSVE2();
        }

        public static SDL_Bool SDL_HasLSX()
        {
            return iSDL_HasLSX();
        }

        public static SDL_Bool SDL_HasLASX()
        {
            return iSDL_HasLASX();
        }

        public static int SDL_GetSystemRAM()
        {
            return iSDL_GetSystemRAM();
        }

        public static nuint SDL_GetSIMDAlignment()
        {
            return iSDL_GetSIMDAlignment();
        }

        public static int SDL_GetSystemPageSize()
        {
            return iSDL_GetSystemPageSize();
        }
    }
}