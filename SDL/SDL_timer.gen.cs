using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("Uint32")]
    internal unsafe delegate uint SDL_TimerCallback(void* userdata, [NativeTypeName("SDL_TimerID")] uint timerID, [NativeTypeName("Uint32")] uint interval);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("Uint64")]
    internal unsafe delegate ulong SDL_NSTimerCallback(void* userdata, [NativeTypeName("SDL_TimerID")] uint timerID, [NativeTypeName("Uint64")] ulong interval);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        private static extern ulong iSDL_GetTicks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        private static extern ulong iSDL_GetTicksNS();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        private static extern ulong iSDL_GetPerformanceCounter();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        private static extern ulong iSDL_GetPerformanceFrequency();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
        private static extern void iSDL_Delay([NativeTypeName("Uint32")] uint ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
        private static extern void iSDL_DelayNS([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
        private static extern void iSDL_DelayPrecise([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        private static extern uint iSDL_AddTimer([NativeTypeName("Uint32")] uint interval, [NativeTypeName("SDL_TimerCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        private static extern uint iSDL_AddTimerNS([NativeTypeName("Uint64")] ulong interval, [NativeTypeName("SDL_NSTimerCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

        [NativeTypeName("#define SDL_MS_PER_SECOND 1000")]
        public const int SDL_MS_PER_SECOND = 1000;

        [NativeTypeName("#define SDL_US_PER_SECOND 1000000")]
        public const int SDL_US_PER_SECOND = 1000000;

        [NativeTypeName("#define SDL_NS_PER_SECOND 1000000000LL")]
        public const long SDL_NS_PER_SECOND = 1000000000L;

        [NativeTypeName("#define SDL_NS_PER_MS 1000000")]
        public const int SDL_NS_PER_MS = 1000000;

        [NativeTypeName("#define SDL_NS_PER_US 1000")]
        public const int SDL_NS_PER_US = 1000;
    }
}
