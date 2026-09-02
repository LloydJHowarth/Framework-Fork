using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static uint* SDL_GetHaptics(int* count)
        {
            return iSDL_GetHaptics(count);
        }

        public static byte* SDL_GetHapticNameForID(uint instance_id)
        {
            return iSDL_GetHapticNameForID(instance_id);
        }

        public static SDL_Haptic* SDL_OpenHaptic(uint instance_id)
        {
            return iSDL_OpenHaptic(instance_id);
        }

        public static SDL_Haptic* SDL_GetHapticFromID(uint instance_id)
        {
            return iSDL_GetHapticFromID(instance_id);
        }

        public static uint SDL_GetHapticID(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticID(haptic);
        }

        public static byte* SDL_GetHapticName(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticName(haptic);
        }

        public static SDL_Bool SDL_IsMouseHaptic()
        {
            return iSDL_IsMouseHaptic();
        }

        public static SDL_Haptic* SDL_OpenHapticFromMouse()
        {
            return iSDL_OpenHapticFromMouse();
        }

        public static SDL_Bool SDL_IsJoystickHaptic(SDL_Joystick* joystick)
        {
            return iSDL_IsJoystickHaptic(joystick);
        }

        public static SDL_Haptic* SDL_OpenHapticFromJoystick(SDL_Joystick* joystick)
        {
            return iSDL_OpenHapticFromJoystick(joystick);
        }

        public static void SDL_CloseHaptic(SDL_Haptic* haptic)
        {
            iSDL_CloseHaptic(haptic);
        }

        public static int SDL_GetMaxHapticEffects(SDL_Haptic* haptic)
        {
            return iSDL_GetMaxHapticEffects(haptic);
        }

        public static int SDL_GetMaxHapticEffectsPlaying(SDL_Haptic* haptic)
        {
            return iSDL_GetMaxHapticEffectsPlaying(haptic);
        }

        public static uint SDL_GetHapticFeatures(SDL_Haptic* haptic)
        {
            return iSDL_GetHapticFeatures(haptic);
        }

        public static int SDL_GetNumHapticAxes(SDL_Haptic* haptic)
        {
            return iSDL_GetNumHapticAxes(haptic);
        }

        public static SDL_Bool SDL_HapticEffectSupported(SDL_Haptic* haptic, SDL_HapticEffect* effect)
        {
            return iSDL_HapticEffectSupported(haptic, effect);
        }

        public static int SDL_CreateHapticEffect(SDL_Haptic* haptic, SDL_HapticEffect* effect)
        {
            return iSDL_CreateHapticEffect(haptic, effect);
        }

        public static SDL_Bool SDL_UpdateHapticEffect(SDL_Haptic* haptic, int effect, SDL_HapticEffect* data)
        {
            return iSDL_UpdateHapticEffect(haptic, effect, data);
        }

        public static SDL_Bool SDL_RunHapticEffect(SDL_Haptic* haptic, int effect, uint iterations)
        {
            return iSDL_RunHapticEffect(haptic, effect, iterations);
        }

        public static SDL_Bool SDL_StopHapticEffect(SDL_Haptic* haptic, int effect)
        {
            return iSDL_StopHapticEffect(haptic, effect);
        }

        public static void SDL_DestroyHapticEffect(SDL_Haptic* haptic, int effect)
        {
            iSDL_DestroyHapticEffect(haptic, effect);
        }

        public static SDL_Bool SDL_GetHapticEffectStatus(SDL_Haptic* haptic, int effect)
        {
            return iSDL_GetHapticEffectStatus(haptic, effect);
        }

        public static SDL_Bool SDL_SetHapticGain(SDL_Haptic* haptic, int gain)
        {
            return iSDL_SetHapticGain(haptic, gain);
        }

        public static SDL_Bool SDL_SetHapticAutocenter(SDL_Haptic* haptic, int autocenter)
        {
            return iSDL_SetHapticAutocenter(haptic, autocenter);
        }

        public static SDL_Bool SDL_PauseHaptic(SDL_Haptic* haptic)
        {
            return iSDL_PauseHaptic(haptic);
        }

        public static SDL_Bool SDL_ResumeHaptic(SDL_Haptic* haptic)
        {
            return iSDL_ResumeHaptic(haptic);
        }

        public static SDL_Bool SDL_StopHapticEffects(SDL_Haptic* haptic)
        {
            return iSDL_StopHapticEffects(haptic);
        }

        public static SDL_Bool SDL_HapticRumbleSupported(SDL_Haptic* haptic)
        {
            return iSDL_HapticRumbleSupported(haptic);
        }

        public static SDL_Bool SDL_InitHapticRumble(SDL_Haptic* haptic)
        {
            return iSDL_InitHapticRumble(haptic);
        }

        public static SDL_Bool SDL_PlayHapticRumble(SDL_Haptic* haptic, float strength, uint length)
        {
            return iSDL_PlayHapticRumble(haptic, strength, length);
        }

        public static SDL_Bool SDL_StopHapticRumble(SDL_Haptic* haptic)
        {
            return iSDL_StopHapticRumble(haptic);
        }
    }
}