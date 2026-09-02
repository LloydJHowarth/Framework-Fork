using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static ulong SDL_GetTicks()
        {
            return iSDL_GetTicks();
        }

        internal static ulong SDL_GetTicksNS()
        {
            return iSDL_GetTicksNS();
        }

        internal static ulong SDL_GetPerformanceCounter()
        {
            return iSDL_GetPerformanceCounter();
        }

        internal static ulong SDL_GetPerformanceFrequency()
        {
            return iSDL_GetPerformanceFrequency();
        }

        internal static void SDL_Delay(uint ms)
        {
            iSDL_Delay(ms);
        }

        internal static void SDL_DelayNS(ulong ns)
        {
            iSDL_DelayNS(ns);
        }

        internal static void SDL_DelayPrecise(ulong ns)
        {
            iSDL_DelayPrecise(ns);
        }

        internal static uint SDL_AddTimer(uint interval, IntPtr callback, void* userdata)
        {
            return iSDL_AddTimer(interval, callback, userdata);
        }

        internal static uint SDL_AddTimerNS(ulong interval, IntPtr callback, void* userdata)
        {
            return iSDL_AddTimerNS(interval, callback, userdata);
        }

        internal static SDL_Bool SDL_RemoveTimer(uint id)
        {
            return iSDL_RemoveTimer(id);
        }
    }
}