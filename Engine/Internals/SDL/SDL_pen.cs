using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_PenDeviceType SDL_GetPenDeviceType(uint instance_id)
        {
            return iSDL_GetPenDeviceType(instance_id);
        }
    }
}