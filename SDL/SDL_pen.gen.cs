using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_PenAxis
    {
        SDL_PEN_AXIS_PRESSURE,
        SDL_PEN_AXIS_XTILT,
        SDL_PEN_AXIS_YTILT,
        SDL_PEN_AXIS_DISTANCE,
        SDL_PEN_AXIS_ROTATION,
        SDL_PEN_AXIS_SLIDER,
        SDL_PEN_AXIS_TANGENTIAL_PRESSURE,
        SDL_PEN_AXIS_COUNT,
    }

    internal enum SDL_PenDeviceType
    {
        SDL_PEN_DEVICE_TYPE_INVALID = -1,
        SDL_PEN_DEVICE_TYPE_UNKNOWN,
        SDL_PEN_DEVICE_TYPE_DIRECT,
        SDL_PEN_DEVICE_TYPE_INDIRECT,
    }

    internal static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPenDeviceType", ExactSpelling = true)]
        private static extern SDL_PenDeviceType iSDL_GetPenDeviceType([NativeTypeName("SDL_PenID")] uint instance_id);

        [NativeTypeName("#define SDL_PEN_MOUSEID ((SDL_MouseID)-2)")]
        public const uint SDL_PEN_MOUSEID = unchecked((uint)(-2));

        [NativeTypeName("#define SDL_PEN_TOUCHID ((SDL_TouchID)-2)")]
        public const ulong SDL_PEN_TOUCHID = unchecked((ulong)(-2));

        [NativeTypeName("#define SDL_PEN_INPUT_DOWN (1u << 0)")]
        public const uint SDL_PEN_INPUT_DOWN = (1U << 0);

        [NativeTypeName("#define SDL_PEN_INPUT_BUTTON_1 (1u << 1)")]
        public const uint SDL_PEN_INPUT_BUTTON_1 = (1U << 1);

        [NativeTypeName("#define SDL_PEN_INPUT_BUTTON_2 (1u << 2)")]
        public const uint SDL_PEN_INPUT_BUTTON_2 = (1U << 2);

        [NativeTypeName("#define SDL_PEN_INPUT_BUTTON_3 (1u << 3)")]
        public const uint SDL_PEN_INPUT_BUTTON_3 = (1U << 3);

        [NativeTypeName("#define SDL_PEN_INPUT_BUTTON_4 (1u << 4)")]
        public const uint SDL_PEN_INPUT_BUTTON_4 = (1U << 4);

        [NativeTypeName("#define SDL_PEN_INPUT_BUTTON_5 (1u << 5)")]
        public const uint SDL_PEN_INPUT_BUTTON_5 = (1U << 5);

        [NativeTypeName("#define SDL_PEN_INPUT_ERASER_TIP (1u << 30)")]
        public const uint SDL_PEN_INPUT_ERASER_TIP = (1U << 30);

        [NativeTypeName("#define SDL_PEN_INPUT_IN_PROXIMITY (1u << 31)")]
        public const uint SDL_PEN_INPUT_IN_PROXIMITY = (1U << 31);
    }
}
