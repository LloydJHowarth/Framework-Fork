using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_HasKeyboard()
        {
            return iSDL_HasKeyboard();
        }

        internal static uint* SDL_GetKeyboards(int* count)
        {
            return iSDL_GetKeyboards(count);
        }

        internal static byte* SDL_GetKeyboardNameForID(uint instance_id)
        {
            return iSDL_GetKeyboardNameForID(instance_id);
        }

        internal static SDL_Window* SDL_GetKeyboardFocus()
        {
            return iSDL_GetKeyboardFocus();
        }

        internal static SDL_Bool* SDL_GetKeyboardState(int* numkeys)
        {
            return iSDL_GetKeyboardState(numkeys);
        }

        internal static void SDL_ResetKeyboard()
        {
            iSDL_ResetKeyboard();
        }

        internal static ushort SDL_GetModState()
        {
            return iSDL_GetModState();
        }

        internal static void SDL_SetModState(ushort modstate)
        {
            iSDL_SetModState(modstate);
        }

        internal static uint SDL_GetKeyFromScancode(SDL_Scancode scancode, ushort modstate, SDL_Bool key_event)
        {
            return iSDL_GetKeyFromScancode(scancode, modstate, key_event);
        }

        internal static SDL_Scancode SDL_GetScancodeFromKey(uint key, ushort* modstate)
        {
            return iSDL_GetScancodeFromKey(key, modstate);
        }

        internal static SDL_Bool SDL_SetScancodeName(SDL_Scancode scancode, byte* name)
        {
            return iSDL_SetScancodeName(scancode, name);
        }

        internal static byte* SDL_GetScancodeName(SDL_Scancode scancode)
        {
            return iSDL_GetScancodeName(scancode);
        }

        internal static SDL_Scancode SDL_GetScancodeFromName(byte* name)
        {
            return iSDL_GetScancodeFromName(name);
        }

        internal static byte* SDL_GetKeyName(uint key)
        {
            return iSDL_GetKeyName(key);
        }

        internal static uint SDL_GetKeyFromName(byte* name)
        {
            return iSDL_GetKeyFromName(name);
        }

        internal static SDL_Bool SDL_StartTextInput(SDL_Window* window)
        {
            return iSDL_StartTextInput(window);
        }

        internal static SDL_Bool SDL_StartTextInputWithProperties(SDL_Window* window, uint props)
        {
            return iSDL_StartTextInputWithProperties(window, props);
        }

        internal static SDL_Bool SDL_TextInputActive(SDL_Window* window)
        {
            return iSDL_TextInputActive(window);
        }

        internal static SDL_Bool SDL_StopTextInput(SDL_Window* window)
        {
            return iSDL_StopTextInput(window);
        }

        internal static SDL_Bool SDL_ClearComposition(SDL_Window* window)
        {
            return iSDL_ClearComposition(window);
        }

        internal static SDL_Bool SDL_SetTextInputArea(SDL_Window* window, SDL_Rect* rect, int cursor)
        {
            return iSDL_SetTextInputArea(window, rect, cursor);
        }

        internal static SDL_Bool SDL_GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor)
        {
            return iSDL_GetTextInputArea(window, rect, cursor);
        }

        internal static SDL_Bool SDL_HasScreenKeyboardSupport()
        {
            return iSDL_HasScreenKeyboardSupport();
        }

        internal static SDL_Bool SDL_ScreenKeyboardShown(SDL_Window* window)
        {
            return iSDL_ScreenKeyboardShown(window);
        }
    }
}