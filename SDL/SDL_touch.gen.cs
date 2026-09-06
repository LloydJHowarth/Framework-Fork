using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_TouchDeviceType
    {
        SDL_TOUCH_DEVICE_INVALID = -1,
        SDL_TOUCH_DEVICE_DIRECT,
        SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE,
        SDL_TOUCH_DEVICE_INDIRECT_RELATIVE,
    }

    internal partial struct SDL_Finger
    {
        [NativeTypeName("SDL_FingerID")]
        public ulong id;

        public float x;

        public float y;

        public float pressure;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDevices", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TouchID *")]
        private static extern ulong* iSDL_GetTouchDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetTouchDeviceName([NativeTypeName("SDL_TouchID")] ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
        private static extern SDL_TouchDeviceType iSDL_GetTouchDeviceType([NativeTypeName("SDL_TouchID")] ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchFingers", ExactSpelling = true)]
        private static extern SDL_Finger** iSDL_GetTouchFingers([NativeTypeName("SDL_TouchID")] ulong touchID, int* count);

        [NativeTypeName("#define SDL_TOUCH_MOUSEID ((SDL_MouseID)-1)")]
        public const uint SDL_TOUCH_MOUSEID = unchecked((uint)(-1));

        [NativeTypeName("#define SDL_MOUSE_TOUCHID ((SDL_TouchID)-1)")]
        public const ulong SDL_MOUSE_TOUCHID = unchecked((ulong)(-1));
    }
}
