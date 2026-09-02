using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static int SDL_AddGamepadMapping(byte* mapping)
        {
            return iSDL_AddGamepadMapping(mapping);
        }

        internal static int SDL_AddGamepadMappingsFromIO(SDL_IOStream* src, SDL_Bool closeio)
        {
            return iSDL_AddGamepadMappingsFromIO(src, closeio);
        }

        internal static int SDL_AddGamepadMappingsFromFile(byte* file)
        {
            return iSDL_AddGamepadMappingsFromFile(file);
        }

        internal static SDL_Bool SDL_ReloadGamepadMappings()
        {
            return iSDL_ReloadGamepadMappings();
        }

        internal static byte** SDL_GetGamepadMappings(int* count)
        {
            return iSDL_GetGamepadMappings(count);
        }

        internal static byte* SDL_GetGamepadMappingForGUID(SDL_GUID guid)
        {
            return iSDL_GetGamepadMappingForGUID(guid);
        }

        internal static byte* SDL_GetGamepadMapping(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadMapping(gamepad);
        }

        internal static SDL_Bool SDL_SetGamepadMapping(uint instance_id, byte* mapping)
        {
            return iSDL_SetGamepadMapping(instance_id, mapping);
        }

        internal static SDL_Bool SDL_HasGamepad()
        {
            return iSDL_HasGamepad();
        }

        internal static uint* SDL_GetGamepads(int* count)
        {
            return iSDL_GetGamepads(count);
        }

        internal static SDL_Bool SDL_IsGamepad(uint instance_id)
        {
            return iSDL_IsGamepad(instance_id);
        }

        internal static byte* SDL_GetGamepadNameForID(uint instance_id)
        {
            return iSDL_GetGamepadNameForID(instance_id);
        }

        internal static byte* SDL_GetGamepadPathForID(uint instance_id)
        {
            return iSDL_GetGamepadPathForID(instance_id);
        }

        internal static int SDL_GetGamepadPlayerIndexForID(uint instance_id)
        {
            return iSDL_GetGamepadPlayerIndexForID(instance_id);
        }

        internal static SDL_GUID SDL_GetGamepadGUIDForID(uint instance_id)
        {
            return iSDL_GetGamepadGUIDForID(instance_id);
        }

        internal static ushort SDL_GetGamepadVendorForID(uint instance_id)
        {
            return iSDL_GetGamepadVendorForID(instance_id);
        }

        internal static ushort SDL_GetGamepadProductForID(uint instance_id)
        {
            return iSDL_GetGamepadProductForID(instance_id);
        }

        internal static ushort SDL_GetGamepadProductVersionForID(uint instance_id)
        {
            return iSDL_GetGamepadProductVersionForID(instance_id);
        }

        internal static SDL_GamepadType SDL_GetGamepadTypeForID(uint instance_id)
        {
            return iSDL_GetGamepadTypeForID(instance_id);
        }

        internal static SDL_GamepadType SDL_GetRealGamepadTypeForID(uint instance_id)
        {
            return iSDL_GetRealGamepadTypeForID(instance_id);
        }

        internal static byte* SDL_GetGamepadMappingForID(uint instance_id)
        {
            return iSDL_GetGamepadMappingForID(instance_id);
        }

        internal static SDL_Gamepad* SDL_OpenGamepad(uint instance_id)
        {
            return iSDL_OpenGamepad(instance_id);
        }

        internal static SDL_Gamepad* SDL_GetGamepadFromID(uint instance_id)
        {
            return iSDL_GetGamepadFromID(instance_id);
        }

        internal static SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int player_index)
        {
            return iSDL_GetGamepadFromPlayerIndex(player_index);
        }

        internal static uint SDL_GetGamepadProperties(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProperties(gamepad);
        }

        internal static uint SDL_GetGamepadID(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadID(gamepad);
        }

        internal static byte* SDL_GetGamepadName(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadName(gamepad);
        }

        internal static byte* SDL_GetGamepadPath(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadPath(gamepad);
        }

        internal static SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadType(gamepad);
        }

        internal static SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad* gamepad)
        {
            return iSDL_GetRealGamepadType(gamepad);
        }

        internal static int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadPlayerIndex(gamepad);
        }

        internal static SDL_Bool SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index)
        {
            return iSDL_SetGamepadPlayerIndex(gamepad, player_index);
        }

        internal static ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadVendor(gamepad);
        }

        internal static ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProduct(gamepad);
        }

        internal static ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadProductVersion(gamepad);
        }

        internal static ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadFirmwareVersion(gamepad);
        }

        internal static byte* SDL_GetGamepadSerial(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadSerial(gamepad);
        }

        internal static ulong SDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadSteamHandle(gamepad);
        }

        internal static SDL_JoystickConnectionState SDL_GetGamepadConnectionState(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadConnectionState(gamepad);
        }

        internal static SDL_PowerState SDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent)
        {
            return iSDL_GetGamepadPowerInfo(gamepad, percent);
        }

        internal static SDL_Bool SDL_GamepadConnected(SDL_Gamepad* gamepad)
        {
            return iSDL_GamepadConnected(gamepad);
        }

        internal static SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad)
        {
            return iSDL_GetGamepadJoystick(gamepad);
        }

        internal static void SDL_SetGamepadEventsEnabled(SDL_Bool enabled)
        {
            iSDL_SetGamepadEventsEnabled(enabled);
        }

        internal static SDL_Bool SDL_GamepadEventsEnabled()
        {
            return iSDL_GamepadEventsEnabled();
        }

        internal static SDL_GamepadBinding** SDL_GetGamepadBindings(SDL_Gamepad* gamepad, int* count)
        {
            return iSDL_GetGamepadBindings(gamepad, count);
        }

        internal static void SDL_UpdateGamepads()
        {
            iSDL_UpdateGamepads();
        }

        internal static SDL_GamepadType SDL_GetGamepadTypeFromString(byte* str)
        {
            return iSDL_GetGamepadTypeFromString(str);
        }

        internal static byte* SDL_GetGamepadStringForType(SDL_GamepadType type)
        {
            return iSDL_GetGamepadStringForType(type);
        }

        internal static SDL_GamepadAxis SDL_GetGamepadAxisFromString(byte* str)
        {
            return iSDL_GetGamepadAxisFromString(str);
        }

        internal static byte* SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis)
        {
            return iSDL_GetGamepadStringForAxis(axis);
        }

        internal static SDL_Bool SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return iSDL_GamepadHasAxis(gamepad, axis);
        }

        internal static short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return iSDL_GetGamepadAxis(gamepad, axis);
        }

        internal static SDL_GamepadButton SDL_GetGamepadButtonFromString(byte* str)
        {
            return iSDL_GetGamepadButtonFromString(str);
        }

        internal static byte* SDL_GetGamepadStringForButton(SDL_GamepadButton button)
        {
            return iSDL_GetGamepadStringForButton(button);
        }

        internal static SDL_Bool SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GamepadHasButton(gamepad, button);
        }

        internal static SDL_Bool SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButton(gamepad, button);
        }

        internal static SDL_GamepadButtonLabel SDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButtonLabelForType(type, button);
        }

        internal static SDL_GamepadButtonLabel SDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadButtonLabel(gamepad, button);
        }

        internal static int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad)
        {
            return iSDL_GetNumGamepadTouchpads(gamepad);
        }

        internal static int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad)
        {
            return iSDL_GetNumGamepadTouchpadFingers(gamepad, touchpad);
        }

        internal static SDL_Bool SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, SDL_Bool* down, float* x, float* y, float* pressure)
        {
            return iSDL_GetGamepadTouchpadFinger(gamepad, touchpad, finger, down, x, y, pressure);
        }

        internal static SDL_Bool SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GamepadHasSensor(gamepad, type);
        }

        internal static SDL_Bool SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, SDL_Bool enabled)
        {
            return iSDL_SetGamepadSensorEnabled(gamepad, type, enabled);
        }

        internal static SDL_Bool SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GamepadSensorEnabled(gamepad, type);
        }

        internal static float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type)
        {
            return iSDL_GetGamepadSensorDataRate(gamepad, type);
        }

        internal static SDL_Bool SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values)
        {
            return iSDL_GetGamepadSensorData(gamepad, type, data, num_values);
        }

        internal static SDL_Bool SDL_GamepadHasCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type)
        {
            return iSDL_GamepadHasCapSense(gamepad, type);
        }

        internal static SDL_Bool SDL_GetGamepadCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type)
        {
            return iSDL_GetGamepadCapSense(gamepad, type);
        }

        internal static SDL_Bool SDL_RumbleGamepad(SDL_Gamepad* gamepad, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms)
        {
            return iSDL_RumbleGamepad(gamepad, low_frequency_rumble, high_frequency_rumble, duration_ms);
        }

        internal static SDL_Bool SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, ushort left_rumble, ushort right_rumble, uint duration_ms)
        {
            return iSDL_RumbleGamepadTriggers(gamepad, left_rumble, right_rumble, duration_ms);
        }

        internal static SDL_Bool SDL_SetGamepadLED(SDL_Gamepad* gamepad, byte red, byte green, byte blue)
        {
            return iSDL_SetGamepadLED(gamepad, red, green, blue);
        }

        internal static SDL_Bool SDL_SendGamepadEffect(SDL_Gamepad* gamepad, void* data, int size)
        {
            return iSDL_SendGamepadEffect(gamepad, data, size);
        }

        internal static void SDL_CloseGamepad(SDL_Gamepad* gamepad)
        {
            iSDL_CloseGamepad(gamepad);
        }

        internal static byte* SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
        {
            return iSDL_GetGamepadAppleSFSymbolsNameForButton(gamepad, button);
        }

        internal static byte* SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
        {
            return iSDL_GetGamepadAppleSFSymbolsNameForAxis(gamepad, axis);
        }
    }
}