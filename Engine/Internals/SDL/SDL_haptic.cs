using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static uint* SDL_GetHaptics(int* count)
        {
            return iSDL_GetHaptics(count);
        }

        internal static byte* SDL_GetHapticNameForID(uint instance_id)
        {
            return iSDL_GetHapticNameForID(instance_id);
        }

        internal static SDL_Haptic* SDL_OpenHaptic(uint instance_id)
        {
            return iSDL_OpenHaptic(instance_id);
        }

        internal static SDL_Haptic* SDL_GetHapticFromID(uint instance_id)
        {
            return iSDL_GetHapticFromID(instance_id);
        }

        internal static uint SDL_GetHapticID(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticID(haptic);
        }

        internal static byte* SDL_GetHapticName(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticName(haptic);
        }

        internal static SDL_Bool SDL_IsMouseHaptic()
        {
            return iSDL_IsMouseHaptic();
        }

        internal static SDL_Haptic* SDL_OpenHapticFromMouse()
        {
            return iSDL_OpenHapticFromMouse();
        }

        internal static SDL_Bool SDL_IsJoystickHaptic(SDL_Joystick* joystick)
        {
            return iSDL_IsJoystickHaptic(joystick);
        }

        internal static SDL_Haptic* SDL_OpenHapticFromJoystick(SDL_Joystick* joystick)
        {
            return iSDL_OpenHapticFromJoystick(joystick);
        }

        internal static void SDL_CloseHaptic(SDL_Haptic* haptic)
        {
            iSDL_CloseHaptic(haptic);
        }

        internal static int SDL_GetMaxHapticEffects(SDL_Haptic* haptic)
        {
            return iSDL_GetMaxHapticEffects(haptic);
        }

        internal static int SDL_GetMaxHapticEffectsPlaying(SDL_Haptic* haptic)
        {
            return iSDL_GetMaxHapticEffectsPlaying(haptic);
        }

        internal static uint SDL_GetHapticFeatures(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticFeatures(haptic);
        }

        internal static int SDL_GetNumHapticAxes(SDL_Haptic* haptic)
        {
            return iSDL_GetNumHapticAxes(haptic);
        }

        internal static SDL_Bool SDL_HapticEffectSupported(SDL_Haptic* haptic, SDL_HapticEffect* effect)
        {
            return iSDL_HapticEffectSupported(haptic, effect);
        }

        internal static int SDL_CreateHapticEffect(SDL_Haptic* haptic, SDL_HapticEffect* effect)
        {
            return iSDL_CreateHapticEffect(haptic, effect);
        }

        internal static SDL_Bool SDL_UpdateHapticEffect(SDL_Haptic* haptic, int effect, SDL_HapticEffect* data)
        {
            return iSDL_UpdateHapticEffect(haptic, effect, data);
        }

        internal static SDL_Bool SDL_RunHapticEffect(SDL_Haptic* haptic, int effect, uint iterations)
        {
            return iSDL_RunHapticEffect(haptic, effect, iterations);
        }

        internal static SDL_Bool SDL_StopHapticEffect(SDL_Haptic* haptic, int effect)
        {
            return iSDL_StopHapticEffect(haptic, effect);
        }

        internal static void SDL_DestroyHapticEffect(SDL_Haptic* haptic, int effect)
        {
            iSDL_DestroyHapticEffect(haptic, effect);
        }

        internal static SDL_Bool SDL_GetHapticEffectStatus(SDL_Haptic* haptic, int effect)
        {
            return iSDL_GetHapticEffectStatus(haptic, effect);
        }

        internal static SDL_Bool SDL_SetHapticGain(SDL_Haptic* haptic, int gain)
        {
            return iSDL_SetHapticGain(haptic, gain);
        }

        internal static SDL_Bool SDL_SetHapticAutocenter(SDL_Haptic* haptic, int autocenter)
        {
            return iSDL_SetHapticAutocenter(haptic, autocenter);
        }

        internal static SDL_Bool SDL_PauseHaptic(SDL_Haptic* haptic)
        {
            return iSDL_PauseHaptic(haptic);
        }

        internal static SDL_Bool SDL_ResumeHaptic(SDL_Haptic* haptic)
        {
            return iSDL_ResumeHaptic(haptic);
        }

        internal static SDL_Bool SDL_StopHapticEffects(SDL_Haptic* haptic)
        {
            return iSDL_StopHapticEffects(haptic);
        }

        internal static SDL_Bool SDL_HapticRumbleSupported(SDL_Haptic* haptic)
        {
            return iSDL_HapticRumbleSupported(haptic);
        }

        internal static SDL_Bool SDL_InitHapticRumble(SDL_Haptic* haptic)
        {
            return iSDL_InitHapticRumble(haptic);
        }

        internal static SDL_Bool SDL_PlayHapticRumble(SDL_Haptic* haptic, float strength, uint length)
        {
            return iSDL_PlayHapticRumble(haptic, strength, length);
        }

        internal static SDL_Bool SDL_StopHapticRumble(SDL_Haptic* haptic)
        {
            return iSDL_StopHapticRumble(haptic);
        }
    }
}