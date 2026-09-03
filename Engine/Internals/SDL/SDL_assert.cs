using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AssertState SDL_ReportAssertion(SDL_AssertData* data, byte* func, byte* file, int line)
        {
            return iSDL_ReportAssertion(data, func, file, line);
        }

        public static void SDL_SetAssertionHandler(IntPtr handler, void* userdata)
        {
            iSDL_SetAssertionHandler(handler, userdata);
        }

        public static IntPtr SDL_GetDefaultAssertionHandler()
        {
            return iSDL_GetDefaultAssertionHandler();
        }

        public static IntPtr SDL_GetAssertionHandler(void** puserdata)
        {
            return iSDL_GetAssertionHandler(puserdata);
        }

        public static SDL_AssertData* SDL_GetAssertionReport()
        {
            return iSDL_GetAssertionReport();
        }

        public static void SDL_ResetAssertionReport()
        {
            iSDL_ResetAssertionReport();
        }
    }
}