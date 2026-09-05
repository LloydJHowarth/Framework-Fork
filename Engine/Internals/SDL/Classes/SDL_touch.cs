using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static ulong* SDL_GetTouchDevices(int* count)
        {
            return iSDL_GetTouchDevices(count);
        }

        public static byte* SDL_GetTouchDeviceName(ulong touchID)
        {
            return iSDL_GetTouchDeviceName(touchID);
        }

        public static SDL_TouchDeviceType SDL_GetTouchDeviceType(ulong touchID)
        {
            return iSDL_GetTouchDeviceType(touchID);
        }

        public static SDL_Finger** SDL_GetTouchFingers(ulong touchID, int* count)
        {
            return iSDL_GetTouchFingers(touchID, count);
        }
    }
}