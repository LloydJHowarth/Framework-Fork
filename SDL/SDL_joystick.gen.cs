using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_Joystick
    {
    }

    internal enum SDL_JoystickType
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
        SDL_JOYSTICK_TYPE_COUNT,
    }

    internal enum SDL_JoystickConnectionState
    {
        SDL_JOYSTICK_CONNECTION_INVALID = -1,
        SDL_JOYSTICK_CONNECTION_UNKNOWN,
        SDL_JOYSTICK_CONNECTION_WIRED,
        SDL_JOYSTICK_CONNECTION_WIRELESS,
    }

    internal partial struct SDL_VirtualJoystickTouchpadDesc
    {
        [NativeTypeName("Uint16")]
        public ushort nfingers;

        [NativeTypeName("Uint16[3]")]
        public _padding_e__FixedBuffer padding;

        [InlineArray(3)]
        public partial struct _padding_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    internal partial struct SDL_VirtualJoystickSensorDesc
    {
        public SDL_SensorType type;

        public float rate;
    }

    internal unsafe partial struct SDL_VirtualJoystickDesc
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint16")]
        public ushort padding;

        [NativeTypeName("Uint16")]
        public ushort vendor_id;

        [NativeTypeName("Uint16")]
        public ushort product_id;

        [NativeTypeName("Uint16")]
        public ushort naxes;

        [NativeTypeName("Uint16")]
        public ushort nbuttons;

        [NativeTypeName("Uint16")]
        public ushort nballs;

        [NativeTypeName("Uint16")]
        public ushort nhats;

        [NativeTypeName("Uint16")]
        public ushort ntouchpads;

        [NativeTypeName("Uint16")]
        public ushort nsensors;

        [NativeTypeName("Uint16[2]")]
        public _padding2_e__FixedBuffer padding2;

        [NativeTypeName("Uint32")]
        public uint button_mask;

        [NativeTypeName("Uint32")]
        public uint axis_mask;

        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const SDL_VirtualJoystickTouchpadDesc *")]
        public SDL_VirtualJoystickTouchpadDesc* touchpads;

        [NativeTypeName("const SDL_VirtualJoystickSensorDesc *")]
        public SDL_VirtualJoystickSensorDesc* sensors;

        public void* userdata;

        [NativeTypeName("void (*)(void *)")]
        public IntPtr Update;

        [NativeTypeName("void (*)(void *, int)")]
        public IntPtr SetPlayerIndex;

        [NativeTypeName("bool (*)(void *, Uint16, Uint16)")]
        public IntPtr Rumble;

        [NativeTypeName("bool (*)(void *, Uint16, Uint16)")]
        public IntPtr RumbleTriggers;

        [NativeTypeName("bool (*)(void *, Uint8, Uint8, Uint8)")]
        public IntPtr SetLED;

        [NativeTypeName("bool (*)(void *, const void *, int)")]
        public IntPtr SendEffect;

        [NativeTypeName("bool (*)(void *, bool)")]
        public IntPtr SetSensorsEnabled;

        [NativeTypeName("void (*)(void *)")]
        public IntPtr Cleanup;

        [InlineArray(2)]
        public partial struct _padding2_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
        private static extern void iSDL_LockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockJoysticks", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_TryLockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
        private static extern void iSDL_UnlockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasJoystick", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID *")]
        private static extern uint* iSDL_GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetJoystickNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetJoystickPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
        private static extern int iSDL_GetJoystickPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_GetJoystickGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
        private static extern SDL_JoystickType iSDL_GetJoystickTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_GetJoystickFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        private static extern uint iSDL_AttachVirtualJoystick([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, [NativeTypeName("Sint16")] short xrel, [NativeTypeName("Sint16")] short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("bool")] SDL_Bool down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, [NativeTypeName("bool")] SDL_Bool down, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("Uint64")] ulong sensor_timestamp, [NativeTypeName("const float *")] float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
        private static extern int iSDL_GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
        private static extern SDL_JoystickType iSDL_GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
        private static extern void iSDL_GetJoystickGUIDInfo(SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        private static extern uint iSDL_GetJoystickID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickAxes", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickAxes(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickBalls", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickBalls(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickHats", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickHats(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickButtons", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickButtons(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickEventsEnabled", ExactSpelling = true)]
        private static extern void iSDL_SetJoystickEventsEnabled([NativeTypeName("bool")] SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
        private static extern void iSDL_UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        private static extern short iSDL_GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        private static extern byte iSDL_GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickHasSensor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_JoystickHasSensor(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickSensorEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("bool")] SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSensorEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_JoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSensorDataRate", ExactSpelling = true)]
        private static extern float iSDL_GetJoystickSensorDataRate(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSensorData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetJoystickSensorData(SDL_Joystick* joystick, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
        private static extern void iSDL_CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
        private static extern SDL_JoystickConnectionState iSDL_GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
        private static extern SDL_PowerState iSDL_GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MAX 32767")]
        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MIN -32768")]
        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN \"SDL.joystick.cap.mono_led\"")]
        public static string SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led";

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN \"SDL.joystick.cap.rgb_led\"")]
        public static string SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led";

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN \"SDL.joystick.cap.player_led\"")]
        public static string SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led";

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN \"SDL.joystick.cap.rumble\"")]
        public static string SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble";

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN \"SDL.joystick.cap.trigger_rumble\"")]
        public static string SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble";

        [NativeTypeName("#define SDL_HAT_CENTERED 0x00u")]
        public const uint SDL_HAT_CENTERED = 0x00U;

        [NativeTypeName("#define SDL_HAT_UP 0x01u")]
        public const uint SDL_HAT_UP = 0x01U;

        [NativeTypeName("#define SDL_HAT_RIGHT 0x02u")]
        public const uint SDL_HAT_RIGHT = 0x02U;

        [NativeTypeName("#define SDL_HAT_DOWN 0x04u")]
        public const uint SDL_HAT_DOWN = 0x04U;

        [NativeTypeName("#define SDL_HAT_LEFT 0x08u")]
        public const uint SDL_HAT_LEFT = 0x08U;

        [NativeTypeName("#define SDL_HAT_RIGHTUP (SDL_HAT_RIGHT|SDL_HAT_UP)")]
        public const uint SDL_HAT_RIGHTUP = (0x02U | 0x01U);

        [NativeTypeName("#define SDL_HAT_RIGHTDOWN (SDL_HAT_RIGHT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_RIGHTDOWN = (0x02U | 0x04U);

        [NativeTypeName("#define SDL_HAT_LEFTUP (SDL_HAT_LEFT|SDL_HAT_UP)")]
        public const uint SDL_HAT_LEFTUP = (0x08U | 0x01U);

        [NativeTypeName("#define SDL_HAT_LEFTDOWN (SDL_HAT_LEFT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_LEFTDOWN = (0x08U | 0x04U);
    }
}
