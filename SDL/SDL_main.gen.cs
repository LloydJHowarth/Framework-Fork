using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int SDL_main_func(int argc, [NativeTypeName("char *[]")] byte** argv);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_main", ExactSpelling = true)]
        private static extern int iSDL_main(int argc, [NativeTypeName("char *[]")] byte** argv);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMainReady", ExactSpelling = true)]
        private static extern void iSDL_SetMainReady();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunApp", ExactSpelling = true)]
        private static extern int iSDL_RunApp(int argc, [NativeTypeName("char *[]")] byte** argv, [NativeTypeName("SDL_main_func")] IntPtr mainFunction, void* reserved);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnterAppMainCallbacks", ExactSpelling = true)]
        private static extern int iSDL_EnterAppMainCallbacks(int argc, [NativeTypeName("char *[]")] byte** argv, [NativeTypeName("SDL_AppInit_func")] IntPtr appinit, [NativeTypeName("SDL_AppIterate_func")] IntPtr appiter, [NativeTypeName("SDL_AppEvent_func")] IntPtr appevent, [NativeTypeName("SDL_AppQuit_func")] IntPtr appquit);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GDKSuspendComplete", ExactSpelling = true)]
        private static extern void iSDL_GDKSuspendComplete();
    }
}
