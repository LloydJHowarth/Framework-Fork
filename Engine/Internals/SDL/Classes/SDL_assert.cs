using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AssertState SDL_ReportAssertion(ref SDL_AssertData data, string func, string file, int line)
        {
            fixed (SDL_AssertData* ptr1 = &data)
            fixed (byte* ptr2 = SDL_StringToUtf8(func))
            fixed (byte* ptr3 = SDL_StringToUtf8(file))
            {
                return iSDL_ReportAssertion(ptr1, ptr2, ptr3, line);
            }
        }

        public static void SDL_SetAssertionHandler(SDL_AssertionHandler handler, IntPtr userdata)
        {
            iSDL_SetAssertionHandler(Marshal.GetFunctionPointerForDelegate(handler), (void*)userdata);
        }

        public static SDL_AssertionHandler SDL_GetDefaultAssertionHandler()
        {
            return Marshal.GetDelegateForFunctionPointer<SDL_AssertionHandler>(iSDL_GetDefaultAssertionHandler());
        }

        public static SDL_AssertionHandler SDL_GetAssertionHandler(out IntPtr userdata)
        {
            fixed (IntPtr* userdataPtr = &userdata)
            {
                return Marshal.GetDelegateForFunctionPointer<SDL_AssertionHandler>(iSDL_GetAssertionHandler((void**)userdataPtr));
            }
        }

        public static SDL_AssertData SDL_GetAssertionReport()
        {
            return *iSDL_GetAssertionReport();
        }

        public static void SDL_ResetAssertionReport()
        {
            iSDL_ResetAssertionReport();
        }
    }
}