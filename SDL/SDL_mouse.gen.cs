using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_Cursor
    {
    }

    internal enum SDL_SystemCursor
    {
        SDL_SYSTEM_CURSOR_DEFAULT,
        SDL_SYSTEM_CURSOR_TEXT,
        SDL_SYSTEM_CURSOR_WAIT,
        SDL_SYSTEM_CURSOR_CROSSHAIR,
        SDL_SYSTEM_CURSOR_PROGRESS,
        SDL_SYSTEM_CURSOR_NWSE_RESIZE,
        SDL_SYSTEM_CURSOR_NESW_RESIZE,
        SDL_SYSTEM_CURSOR_EW_RESIZE,
        SDL_SYSTEM_CURSOR_NS_RESIZE,
        SDL_SYSTEM_CURSOR_MOVE,
        SDL_SYSTEM_CURSOR_NOT_ALLOWED,
        SDL_SYSTEM_CURSOR_POINTER,
        SDL_SYSTEM_CURSOR_NW_RESIZE,
        SDL_SYSTEM_CURSOR_N_RESIZE,
        SDL_SYSTEM_CURSOR_NE_RESIZE,
        SDL_SYSTEM_CURSOR_E_RESIZE,
        SDL_SYSTEM_CURSOR_SE_RESIZE,
        SDL_SYSTEM_CURSOR_S_RESIZE,
        SDL_SYSTEM_CURSOR_SW_RESIZE,
        SDL_SYSTEM_CURSOR_W_RESIZE,
        SDL_SYSTEM_CURSOR_CONTEXT_MENU,
        SDL_SYSTEM_CURSOR_HELP,
        SDL_SYSTEM_CURSOR_CELL,
        SDL_SYSTEM_CURSOR_VERTICAL_TEXT,
        SDL_SYSTEM_CURSOR_ALIAS,
        SDL_SYSTEM_CURSOR_COPY,
        SDL_SYSTEM_CURSOR_NO_DROP,
        SDL_SYSTEM_CURSOR_GRAB,
        SDL_SYSTEM_CURSOR_GRABBING,
        SDL_SYSTEM_CURSOR_COL_RESIZE,
        SDL_SYSTEM_CURSOR_ROW_RESIZE,
        SDL_SYSTEM_CURSOR_ALL_SCROLL,
        SDL_SYSTEM_CURSOR_ZOOM_IN,
        SDL_SYSTEM_CURSOR_ZOOM_OUT,
        SDL_SYSTEM_CURSOR_COUNT,
    }

    internal enum SDL_MouseWheelDirection
    {
        SDL_MOUSEWHEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED,
    }

    internal unsafe partial struct SDL_CursorFrameInfo
    {
        public SDL_Surface* surface;

        [NativeTypeName("Uint32")]
        public uint duration;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_MouseMotionTransformCallback(void* userdata, [NativeTypeName("Uint64")] ulong timestamp, SDL_Window* window, [NativeTypeName("SDL_MouseID")] uint mouseID, float* x, float* y);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMouse", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseID *")]
        private static extern uint* iSDL_GetMice(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetMouseNameForID([NativeTypeName("SDL_MouseID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseFocus", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetMouseFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        private static extern uint iSDL_GetMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalMouseState", ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        private static extern uint iSDL_GetGlobalMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRelativeMouseState", ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        private static extern uint iSDL_GetRelativeMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
        private static extern void iSDL_WarpMouseInWindow(SDL_Window* window, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseGlobal", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WarpMouseGlobal(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRelativeMouseTransform", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRelativeMouseTransform([NativeTypeName("SDL_MouseMotionTransformCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowRelativeMouseMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowRelativeMouseMode(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowRelativeMouseMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowRelativeMouseMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CaptureMouse", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CaptureMouse([NativeTypeName("bool")] SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_CreateCursor([NativeTypeName("const Uint8 *")] byte* data, [NativeTypeName("const Uint8 *")] byte* mask, int w, int h, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAnimatedCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_CreateAnimatedCursor(SDL_CursorFrameInfo* frames, int frame_count, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSystemCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_CreateSystemCursor(SDL_SystemCursor id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_GetCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iSDL_GetDefaultCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCursor", ExactSpelling = true)]
        private static extern void iSDL_DestroyCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ShowCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideCursor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HideCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CursorVisible", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CursorVisible();

        [NativeTypeName("#define SDL_BUTTON_LEFT 1")]
        public const int SDL_BUTTON_LEFT = 1;

        [NativeTypeName("#define SDL_BUTTON_MIDDLE 2")]
        public const int SDL_BUTTON_MIDDLE = 2;

        [NativeTypeName("#define SDL_BUTTON_RIGHT 3")]
        public const int SDL_BUTTON_RIGHT = 3;

        [NativeTypeName("#define SDL_BUTTON_X1 4")]
        public const int SDL_BUTTON_X1 = 4;

        [NativeTypeName("#define SDL_BUTTON_X2 5")]
        public const int SDL_BUTTON_X2 = 5;

        [NativeTypeName("#define SDL_BUTTON_LMASK SDL_BUTTON_MASK(SDL_BUTTON_LEFT)")]
        public const uint SDL_BUTTON_LMASK = (1U << ((1) - 1));

        [NativeTypeName("#define SDL_BUTTON_MMASK SDL_BUTTON_MASK(SDL_BUTTON_MIDDLE)")]
        public const uint SDL_BUTTON_MMASK = (1U << ((2) - 1));

        [NativeTypeName("#define SDL_BUTTON_RMASK SDL_BUTTON_MASK(SDL_BUTTON_RIGHT)")]
        public const uint SDL_BUTTON_RMASK = (1U << ((3) - 1));

        [NativeTypeName("#define SDL_BUTTON_X1MASK SDL_BUTTON_MASK(SDL_BUTTON_X1)")]
        public const uint SDL_BUTTON_X1MASK = (1U << ((4) - 1));

        [NativeTypeName("#define SDL_BUTTON_X2MASK SDL_BUTTON_MASK(SDL_BUTTON_X2)")]
        public const uint SDL_BUTTON_X2MASK = (1U << ((5) - 1));
    }
}
