using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Bool SDL_HasMouse()
        {
            return iSDL_HasMouse();
        }

        public static uint* SDL_GetMice(int* count)
        {
            return iSDL_GetMice(count);
        }

        public static byte* SDL_GetMouseNameForID(uint instance_id)
        {
            return iSDL_GetMouseNameForID(instance_id);
        }

        public static SDL_Window* SDL_GetMouseFocus()
        {
            return iSDL_GetMouseFocus();
        }

        public static uint SDL_GetMouseState(float* x, float* y)
        {
            return iSDL_GetMouseState(x, y);
        }

        public static uint SDL_GetGlobalMouseState(float* x, float* y)
        {
            return iSDL_GetGlobalMouseState(x, y);
        }

        public static uint SDL_GetRelativeMouseState(float* x, float* y)
        {
            return iSDL_GetRelativeMouseState(x, y);
        }

        public static void SDL_WarpMouseInWindow(SDL_Window* window, float x, float y)
        {
            iSDL_WarpMouseInWindow(window, x, y);
        }

        public static SDL_Bool SDL_WarpMouseGlobal(float x, float y)
        {
            return iSDL_WarpMouseGlobal(x, y);
        }

        public static SDL_Bool SDL_SetRelativeMouseTransform(IntPtr callback, void* userdata)
        {
            return iSDL_SetRelativeMouseTransform(callback, userdata);
        }

        public static SDL_Bool SDL_SetWindowRelativeMouseMode(SDL_Window* window, SDL_Bool enabled)
        {
            return iSDL_SetWindowRelativeMouseMode(window, enabled);
        }

        public static SDL_Bool SDL_GetWindowRelativeMouseMode(SDL_Window* window)
        {
            return iSDL_GetWindowRelativeMouseMode(window);
        }

        public static SDL_Bool SDL_CaptureMouse(SDL_Bool enabled)
        {
            return iSDL_CaptureMouse(enabled);
        }

        public static SDL_Cursor* SDL_CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y)
        {
            return iSDL_CreateCursor(data, mask, w, h, hot_x, hot_y);
        }

        public static SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y)
        {
            return iSDL_CreateColorCursor(surface, hot_x, hot_y);
        }

        public static SDL_Cursor* SDL_CreateAnimatedCursor(SDL_CursorFrameInfo* frames, int frame_count, int hot_x, int hot_y)
        {
            return iSDL_CreateAnimatedCursor(frames, frame_count, hot_x, hot_y);
        }

        public static SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id)
        {
            return iSDL_CreateSystemCursor(id);
        }

        public static SDL_Bool SDL_SetCursor(SDL_Cursor* cursor)
        {
            return iSDL_SetCursor(cursor);
        }

        public static SDL_Cursor* SDL_GetCursor()
        {
            return iSDL_GetCursor();
        }

        public static SDL_Cursor* SDL_GetDefaultCursor()
        {
            return iSDL_GetDefaultCursor();
        }

        public static void SDL_DestroyCursor(SDL_Cursor* cursor)
        {
            iSDL_DestroyCursor(cursor);
        }

        public static SDL_Bool SDL_ShowCursor()
        {
            return iSDL_ShowCursor();
        }

        public static SDL_Bool SDL_HideCursor()
        {
            return iSDL_HideCursor();
        }

        public static SDL_Bool SDL_CursorVisible()
        {
            return iSDL_CursorVisible();
        }
    }
}