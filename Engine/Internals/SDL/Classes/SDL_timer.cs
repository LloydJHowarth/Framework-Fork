using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static ulong SDL_GetTicks()
        {
            return iSDL_GetTicks();
        }

        public static ulong SDL_GetTicksNS()
        {
            return iSDL_GetTicksNS();
        }

        public static ulong SDL_GetPerformanceCounter()
        {
            return iSDL_GetPerformanceCounter();
        }

        public static ulong SDL_GetPerformanceFrequency()
        {
            return iSDL_GetPerformanceFrequency();
        }

        public static void SDL_Delay(uint ms)
        {
            iSDL_Delay(ms);
        }

        public static void SDL_DelayNS(ulong ns)
        {
            iSDL_DelayNS(ns);
        }

        public static void SDL_DelayPrecise(ulong ns)
        {
            iSDL_DelayPrecise(ns);
        }

        public static uint SDL_AddTimer(uint interval, IntPtr callback, void* userdata)
        {
            return iSDL_AddTimer(interval, callback, userdata);
        }

        public static uint SDL_AddTimerNS(ulong interval, IntPtr callback, void* userdata)
        {
            return iSDL_AddTimerNS(interval, callback, userdata);
        }

        public static SDL_Bool SDL_RemoveTimer(uint id)
        {
            return iSDL_RemoveTimer(id);
        }
    }
}