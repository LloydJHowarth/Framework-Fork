using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_HasMouse()
        {
            return iSDL_HasMouse();
        }

        internal static uint* SDL_GetMice(int* count)
        {
            return iSDL_GetMice(count);
        }

        internal static byte* SDL_GetMouseNameForID(uint instance_id)
        {
            return iSDL_GetMouseNameForID(instance_id);
        }

        internal static SDL_Window* SDL_GetMouseFocus()
        {
            return iSDL_GetMouseFocus();
        }

        internal static uint SDL_GetMouseState(float* x, float* y)
        {
            return iSDL_GetMouseState(x, y);
        }

        internal static uint SDL_GetGlobalMouseState(float* x, float* y)
        {
            return iSDL_GetGlobalMouseState(x, y);
        }

        internal static uint SDL_GetRelativeMouseState(float* x, float* y)
        {
            return iSDL_GetRelativeMouseState(x, y);
        }

        internal static void SDL_WarpMouseInWindow(SDL_Window* window, float x, float y)
        {
            iSDL_WarpMouseInWindow(window, x, y);
        }

        internal static SDL_Bool SDL_WarpMouseGlobal(float x, float y)
        {
            return iSDL_WarpMouseGlobal(x, y);
        }

        internal static SDL_Bool SDL_SetRelativeMouseTransform(IntPtr callback, void* userdata)
        {
            return iSDL_SetRelativeMouseTransform(callback, userdata);
        }

        internal static SDL_Bool SDL_SetWindowRelativeMouseMode(SDL_Window* window, SDL_Bool enabled)
        {
            return iSDL_SetWindowRelativeMouseMode(window, enabled);
        }

        internal static SDL_Bool SDL_GetWindowRelativeMouseMode(SDL_Window* window)
        {
            return iSDL_GetWindowRelativeMouseMode(window);
        }

        internal static SDL_Bool SDL_CaptureMouse(SDL_Bool enabled)
        {
            return iSDL_CaptureMouse(enabled);
        }

        internal static SDL_Cursor* SDL_CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y)
        {
            return iSDL_CreateCursor(data, mask, w, h, hot_x, hot_y);
        }

        internal static SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y)
        {
            return iSDL_CreateColorCursor(surface, hot_x, hot_y);
        }

        internal static SDL_Cursor* SDL_CreateAnimatedCursor(SDL_CursorFrameInfo* frames, int frame_count, int hot_x, int hot_y)
        {
            return iSDL_CreateAnimatedCursor(frames, frame_count, hot_x, hot_y);
        }

        internal static SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id)
        {
            return iSDL_CreateSystemCursor(id);
        }

        internal static SDL_Bool SDL_SetCursor(SDL_Cursor* cursor)
        {
            return iSDL_SetCursor(cursor);
        }

        internal static SDL_Cursor* SDL_GetCursor()
        {
            return iSDL_GetCursor();
        }

        internal static SDL_Cursor* SDL_GetDefaultCursor()
        {
            return iSDL_GetDefaultCursor();
        }

        internal static void SDL_DestroyCursor(SDL_Cursor* cursor)
        {
            iSDL_DestroyCursor(cursor);
        }

        internal static SDL_Bool SDL_ShowCursor()
        {
            return iSDL_ShowCursor();
        }

        internal static SDL_Bool SDL_HideCursor()
        {
            return iSDL_HideCursor();
        }

        internal static SDL_Bool SDL_CursorVisible()
        {
            return iSDL_CursorVisible();
        }
    }
}