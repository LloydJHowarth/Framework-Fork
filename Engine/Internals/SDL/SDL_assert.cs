using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AssertState SDL_ReportAssertion(SDL_AssertData* data, string func, string file, int line)
        {
            var value1 = SDL_StringToUtf8(func);
            var value2 = SDL_StringToUtf8(file);
            
            fixed (byte* ptr1 = value1)
            fixed (byte* ptr2 = value2)
            {
                return iSDL_ReportAssertion(data, ptr1, ptr2, line);
            }
        }

        public static void SDL_SetAssertionHandler(IntPtr handler, void* userdata)
        {
            iSDL_SetAssertionHandler(handler, userdata);
        }

        public static IntPtr SDL_GetDefaultAssertionHandler()
        {
            return iSDL_GetDefaultAssertionHandler();
        }

        public static IntPtr SDL_GetAssertionHandler(out void* puserdata)
        {
            fixed (void** userdataPtr = &puserdata)
            {
                return iSDL_GetAssertionHandler(userdataPtr);
            }
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