using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static void SDL_LockJoysticks()
        {
            iSDL_LockJoysticks();
        }

        public static SDL_Bool SDL_TryLockJoysticks()
        {
            return iSDL_TryLockJoysticks();
        }

        public static void SDL_UnlockJoysticks()
        {
            iSDL_UnlockJoysticks();
        }

        public static SDL_Bool SDL_HasJoystick()
        {
            return iSDL_HasJoystick();
        }

        public static uint* SDL_GetJoysticks(int* count)
        {
            return iSDL_GetJoysticks(count);
        }

        public static byte* SDL_GetJoystickNameForID(uint instance_id)
        {
            return iSDL_GetJoystickNameForID(instance_id);
        }

        public static byte* SDL_GetJoystickPathForID(uint instance_id)
        {
            return iSDL_GetJoystickPathForID(instance_id);
        }

        public static int SDL_GetJoystickPlayerIndexForID(uint instance_id)
        {
            return iSDL_GetJoystickPlayerIndexForID(instance_id);
        }

        public static SDL_GUID SDL_GetJoystickGUIDForID(uint instance_id)
        {
            return iSDL_GetJoystickGUIDForID(instance_id);
        }

        public static ushort SDL_GetJoystickVendorForID(uint instance_id)
        {
            return iSDL_GetJoystickVendorForID(instance_id);
        }

        public static ushort SDL_GetJoystickProductForID(uint instance_id)
        {
            return iSDL_GetJoystickProductForID(instance_id);
        }

        public static ushort SDL_GetJoystickProductVersionForID(uint instance_id)
        {
            return iSDL_GetJoystickProductVersionForID(instance_id);
        }

        public static SDL_JoystickType SDL_GetJoystickTypeForID(uint instance_id)
        {
            return iSDL_GetJoystickTypeForID(instance_id);
        }

        public static SDL_Joystick* SDL_OpenJoystick(uint instance_id)
        {
            return iSDL_OpenJoystick(instance_id);
        }

        public static SDL_Joystick* SDL_GetJoystickFromID(uint instance_id)
        {
            return iSDL_GetJoystickFromID(instance_id);
        }

        public static SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int player_index)
        {
            return iSDL_GetJoystickFromPlayerIndex(player_index);
        }

        public static uint SDL_AttachVirtualJoystick(SDL_VirtualJoystickDesc* desc)
        {
            return iSDL_AttachVirtualJoystick(desc);
        }

        public static SDL_Bool SDL_DetachVirtualJoystick(uint instance_id)
        {
            return iSDL_DetachVirtualJoystick(instance_id);
        }

        public static SDL_Bool SDL_IsJoystickVirtual(uint instance_id)
        {
            return iSDL_IsJoystickVirtual(instance_id);
        }

        public static SDL_Bool SDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, short value)
        {
            return iSDL_SetJoystickVirtualAxis(joystick, axis, value);
        }

        public static SDL_Bool SDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, short xrel, short yrel)
        {
            return iSDL_SetJoystickVirtualBall(joystick, ball, xrel, yrel);
        }

        public static SDL_Bool SDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, SDL_Bool down)
        {
            return iSDL_SetJoystickVirtualButton(joystick, button, down);
        }

        public static SDL_Bool SDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, byte value)
        {
            return iSDL_SetJoystickVirtualHat(joystick, hat, value);
        }

        public static SDL_Bool SDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, SDL_Bool down, float x, float y, float pressure)
        {
            return iSDL_SetJoystickVirtualTouchpad(joystick, touchpad, finger, down, x, y, pressure);
        }

        public static SDL_Bool SDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, ulong sensor_timestamp, float* data, int num_values)
        {
            return iSDL_SendJoystickVirtualSensorData(joystick, type, sensor_timestamp, data, num_values);
        }

        public static uint SDL_GetJoystickProperties(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProperties(joystick);
        }

        public static byte* SDL_GetJoystickName(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickName(joystick);
        }

        public static byte* SDL_GetJoystickPath(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickPath(joystick);
        }

        public static int SDL_GetJoystickPlayerIndex(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickPlayerIndex(joystick);
        }

        public static SDL_Bool SDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index)
        {
            return iSDL_SetJoystickPlayerIndex(joystick, player_index);
        }

        public static SDL_GUID SDL_GetJoystickGUID(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickGUID(joystick);
        }

        public static ushort SDL_GetJoystickVendor(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickVendor(joystick);
        }

        public static ushort SDL_GetJoystickProduct(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProduct(joystick);
        }

        public static ushort SDL_GetJoystickProductVersion(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickProductVersion(joystick);
        }

        public static ushort SDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickFirmwareVersion(joystick);
        }

        public static byte* SDL_GetJoystickSerial(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickSerial(joystick);
        }

        public static SDL_JoystickType SDL_GetJoystickType(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickType(joystick);
        }

        public static void SDL_GetJoystickGUIDInfo(SDL_GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16)
        {
            iSDL_GetJoystickGUIDInfo(guid, vendor, product, version, crc16);
        }

        public static SDL_Bool SDL_JoystickConnected(SDL_Joystick* joystick)
        {
            return iSDL_JoystickConnected(joystick);
        }

        public static uint SDL_GetJoystickID(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickID(joystick);
        }

        public static int SDL_GetNumJoystickAxes(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickAxes(joystick);
        }

        public static int SDL_GetNumJoystickBalls(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickBalls(joystick);
        }

        public static int SDL_GetNumJoystickHats(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickHats(joystick);
        }

        public static int SDL_GetNumJoystickButtons(SDL_Joystick* joystick)
        {
            return iSDL_GetNumJoystickButtons(joystick);
        }

        public static void SDL_SetJoystickEventsEnabled(SDL_Bool enabled)
        {
            iSDL_SetJoystickEventsEnabled(enabled);
        }

        public static SDL_Bool SDL_JoystickEventsEnabled()
        {
            return iSDL_JoystickEventsEnabled();
        }

        public static void SDL_UpdateJoysticks()
        {
            iSDL_UpdateJoysticks();
        }

        public static short SDL_GetJoystickAxis(SDL_Joystick* joystick, int axis)
        {
            return iSDL_GetJoystickAxis(joystick, axis);
        }

        public static SDL_Bool SDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, short* state)
        {
            return iSDL_GetJoystickAxisInitialState(joystick, axis, state);
        }

        public static SDL_Bool SDL_GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy)
        {
            return iSDL_GetJoystickBall(joystick, ball, dx, dy);
        }

        public static byte SDL_GetJoystickHat(SDL_Joystick* joystick, int hat)
        {
            return iSDL_GetJoystickHat(joystick, hat);
        }

        public static SDL_Bool SDL_GetJoystickButton(SDL_Joystick* joystick, int button)
        {
            return iSDL_GetJoystickButton(joystick, button);
        }

        public static SDL_Bool SDL_JoystickHasSensor(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_JoystickHasSensor(joystick, type);
        }

        public static SDL_Bool SDL_SetJoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type, SDL_Bool enabled)
        {
            return iSDL_SetJoystickSensorEnabled(joystick, type, enabled);
        }

        public static SDL_Bool SDL_JoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_JoystickSensorEnabled(joystick, type);
        }

        public static float SDL_GetJoystickSensorDataRate(SDL_Joystick* joystick, SDL_SensorType type)
        {
            return iSDL_GetJoystickSensorDataRate(joystick, type);
        }

        public static SDL_Bool SDL_GetJoystickSensorData(SDL_Joystick* joystick, SDL_SensorType type, float* data, int num_values)
        {
            return iSDL_GetJoystickSensorData(joystick, type, data, num_values);
        }

        public static SDL_Bool SDL_RumbleJoystick(SDL_Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms)
        {
            return iSDL_RumbleJoystick(joystick, low_frequency_rumble, high_frequency_rumble, duration_ms);
        }

        public static SDL_Bool SDL_RumbleJoystickTriggers(SDL_Joystick* joystick, ushort left_rumble, ushort right_rumble, uint duration_ms)
        {
            return iSDL_RumbleJoystickTriggers(joystick, left_rumble, right_rumble, duration_ms);
        }

        public static SDL_Bool SDL_SetJoystickLED(SDL_Joystick* joystick, byte red, byte green, byte blue)
        {
            return iSDL_SetJoystickLED(joystick, red, green, blue);
        }

        public static SDL_Bool SDL_SendJoystickEffect(SDL_Joystick* joystick, void* data, int size)
        {
            return iSDL_SendJoystickEffect(joystick, data, size);
        }

        public static void SDL_CloseJoystick(SDL_Joystick* joystick)
        {
            iSDL_CloseJoystick(joystick);
        }

        public static SDL_JoystickConnectionState SDL_GetJoystickConnectionState(SDL_Joystick* joystick)
        {
            return iSDL_GetJoystickConnectionState(joystick);
        }

        public static SDL_PowerState SDL_GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent)
        {
            return iSDL_GetJoystickPowerInfo(joystick, percent);
        }
    }
}