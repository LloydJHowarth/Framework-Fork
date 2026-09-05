using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_main(int argc, byte** argv)
        {
            return iSDL_main(argc, argv);
        }

        public static void SDL_SetMainReady()
        {
            iSDL_SetMainReady();
        }

        public static int SDL_RunApp(int argc, byte** argv, IntPtr mainFunction, void* reserved)
        {
            return iSDL_RunApp(argc, argv, mainFunction, reserved);
        }

        public static int SDL_EnterAppMainCallbacks(int argc, byte** argv, IntPtr appinit, IntPtr appiter, IntPtr appevent, IntPtr appquit)
        {
            return iSDL_EnterAppMainCallbacks(argc, argv, appinit, appiter, appevent, appquit);
        }

        public static void SDL_GDKSuspendComplete()
        {
            iSDL_GDKSuspendComplete();
        }
    }
}