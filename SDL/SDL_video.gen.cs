using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_SystemTheme
    {
        SDL_SYSTEM_THEME_UNKNOWN,
        SDL_SYSTEM_THEME_LIGHT,
        SDL_SYSTEM_THEME_DARK,
    }

    internal partial struct SDL_DisplayModeData
    {
    }

    internal unsafe partial struct SDL_DisplayMode
    {
        [NativeTypeName("SDL_DisplayID")]
        public uint displayID;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public float pixel_density;

        public float refresh_rate;

        public int refresh_rate_numerator;

        public int refresh_rate_denominator;

        public SDL_DisplayModeData* @internal;
    }

    internal enum SDL_DisplayOrientation
    {
        SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,
        SDL_ORIENTATION_PORTRAIT,
        SDL_ORIENTATION_PORTRAIT_FLIPPED,
    }

    internal partial struct SDL_Window
    {
    }

    internal enum SDL_FlashOperation
    {
        SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY,
        SDL_FLASH_UNTIL_FOCUSED,
    }

    internal enum SDL_ProgressState
    {
        SDL_PROGRESS_STATE_INVALID = -1,
        SDL_PROGRESS_STATE_NONE,
        SDL_PROGRESS_STATE_INDETERMINATE,
        SDL_PROGRESS_STATE_NORMAL,
        SDL_PROGRESS_STATE_PAUSED,
        SDL_PROGRESS_STATE_ERROR,
    }

    internal partial struct SDL_GLContextState
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SDL_EGLAttrib *")]
    internal unsafe delegate nint* SDL_EGLAttribArrayCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SDL_EGLint *")]
    internal unsafe delegate int* SDL_EGLIntArrayCallback(void* userdata, [NativeTypeName("SDL_EGLDisplay")] void* display, [NativeTypeName("SDL_EGLConfig")] void* config);

    internal enum SDL_GLAttr
    {
        SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS,
        SDL_GL_EGL_PLATFORM,
    }

    internal enum SDL_HitTestResult
    {
        SDL_HITTEST_NORMAL,
        SDL_HITTEST_DRAGGABLE,
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_HitTestResult SDL_HitTest(SDL_Window* win, [NativeTypeName("const SDL_Point *")] SDL_Point* area, void* data);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumVideoDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetVideoDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetCurrentVideoDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemTheme", ExactSpelling = true)]
        private static extern SDL_SystemTheme iSDL_GetSystemTheme();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplays", ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID *")]
        private static extern uint* iSDL_GetDisplays(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimaryDisplay", ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        private static extern uint iSDL_GetPrimaryDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetDisplayProperties([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNaturalDisplayOrientation", ExactSpelling = true)]
        private static extern SDL_DisplayOrientation iSDL_GetNaturalDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayOrientation", ExactSpelling = true)]
        private static extern SDL_DisplayOrientation iSDL_GetCurrentDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayContentScale", ExactSpelling = true)]
        private static extern float iSDL_GetDisplayContentScale([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFullscreenDisplayModes", ExactSpelling = true)]
        private static extern SDL_DisplayMode** iSDL_GetFullscreenDisplayModes([NativeTypeName("SDL_DisplayID")] uint displayID, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetClosestFullscreenDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID, int w, int h, float refresh_rate, [NativeTypeName("bool")] SDL_Bool include_high_density_modes, SDL_DisplayMode* closest);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        private static extern SDL_DisplayMode* iSDL_GetDesktopDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        private static extern SDL_DisplayMode* iSDL_GetCurrentDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForPoint", ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        private static extern uint iSDL_GetDisplayForPoint([NativeTypeName("const SDL_Point *")] SDL_Point* point);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForRect", ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        private static extern uint iSDL_GetDisplayForRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForWindow", ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        private static extern uint iSDL_GetDisplayForWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelDensity", ExactSpelling = true)]
        private static extern float iSDL_GetWindowPixelDensity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayScale", ExactSpelling = true)]
        private static extern float iSDL_GetWindowDisplayScale(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreenMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowFullscreenMode(SDL_Window* window, [NativeTypeName("const SDL_DisplayMode *")] SDL_DisplayMode* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFullscreenMode", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        private static extern SDL_DisplayMode* iSDL_GetWindowFullscreenMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
        private static extern void* iSDL_GetWindowICCProfile(SDL_Window* window, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
        private static extern SDL_PixelFormat iSDL_GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindows", ExactSpelling = true)]
        private static extern SDL_Window** iSDL_GetWindows(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreateWindow([NativeTypeName("const char *")] byte* title, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePopupWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowWithProperties", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreateWindowWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_WindowID")]
        private static extern uint iSDL_GetWindowID(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowParent", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetWindowParent(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetWindowProperties(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
        [return: NativeTypeName("SDL_WindowFlags")]
        private static extern ulong iSDL_GetWindowFlags(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowTitle(SDL_Window* window, [NativeTypeName("const char *")] byte* title);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetWindowTitle(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSafeArea", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAspectRatio", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowAspectRatio", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowBordered(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool bordered);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowResizable(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool resizable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowAlwaysOnTop(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool on_top);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFillDocument", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowFillDocument(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool fill);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ShowWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HideWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RaiseWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_MaximizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_MinimizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RestoreWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowFullscreen(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool fullscreen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SyncWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SyncWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowHasSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WindowHasSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSurfaceVSync", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowSurfaceVSync(SDL_Window* window, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurfaceVSync", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UpdateWindowSurfaceRects(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int numrects);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindowSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_DestroyWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowKeyboardGrab(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowMouseGrab(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetGrabbedWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowMouseRect(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_Rect *")]
        private static extern SDL_Rect* iSDL_GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
        private static extern float iSDL_GetWindowOpacity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowParent", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowParent(SDL_Window* window, SDL_Window* parent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowModal", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowModal(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool modal);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFocusable", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowFocusable(SDL_Window* window, [NativeTypeName("bool")] SDL_Bool focusable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindowSystemMenu", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ShowWindowSystemMenu(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowHitTest(SDL_Window* window, [NativeTypeName("SDL_HitTest")] IntPtr callback, void* callback_data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowProgressState", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowProgressState(SDL_Window* window, SDL_ProgressState state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProgressState", ExactSpelling = true)]
        private static extern SDL_ProgressState iSDL_GetWindowProgressState(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowProgressValue", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetWindowProgressValue(SDL_Window* window, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProgressValue", ExactSpelling = true)]
        private static extern float iSDL_GetWindowProgressValue(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        private static extern void iSDL_DestroyWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenSaverEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ScreenSaverEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_EnableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_DisableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_LoadLibrary([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
        [return: NativeTypeName("SDL_FunctionPointer")]
        private static extern IntPtr iSDL_GL_GetProcAddress([NativeTypeName("const char *")] byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetProcAddress", ExactSpelling = true)]
        [return: NativeTypeName("SDL_FunctionPointer")]
        private static extern IntPtr iSDL_EGL_GetProcAddress([NativeTypeName("const char *")] byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
        private static extern void iSDL_GL_UnloadLibrary();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_ExtensionSupported([NativeTypeName("const char *")] byte* extension);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
        private static extern void iSDL_GL_ResetAttributes();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_SetAttribute(SDL_GLAttr attr, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_GetAttribute(SDL_GLAttr attr, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        private static extern SDL_GLContextState* iSDL_GL_CreateContext(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_MakeCurrent(SDL_Window* window, [NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GL_GetCurrentWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        private static extern SDL_GLContextState* iSDL_GL_GetCurrentContext();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentDisplay", ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLDisplay")]
        private static extern void* iSDL_EGL_GetCurrentDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentConfig", ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLConfig")]
        private static extern void* iSDL_EGL_GetCurrentConfig();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetWindowSurface", ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLSurface")]
        private static extern void* iSDL_EGL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_SetAttributeCallbacks", ExactSpelling = true)]
        private static extern void iSDL_EGL_SetAttributeCallbacks([NativeTypeName("SDL_EGLAttribArrayCallback")] IntPtr platformAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] IntPtr surfaceAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] IntPtr contextAttribCallback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_SetSwapInterval(int interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_GetSwapInterval(int* interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DestroyContext", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GL_DestroyContext([NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);

        [NativeTypeName("#define SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER \"SDL.video.wayland.wl_display\"")]
        public static string SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER => "SDL.video.wayland.wl_display";

        [NativeTypeName("#define SDL_PROP_GLOBAL_VIDEO_WAYLAND_SESSION_ID_STRING \"SDL.video.wayland.session_id\"")]
        public static string SDL_PROP_GLOBAL_VIDEO_WAYLAND_SESSION_ID_STRING => "SDL.video.wayland.session_id";

        [NativeTypeName("#define SDL_WINDOW_FULLSCREEN SDL_UINT64_C(0x0000000000000001)")]
        public const ulong SDL_WINDOW_FULLSCREEN = (0x0000000000000001UL);

        [NativeTypeName("#define SDL_WINDOW_OPENGL SDL_UINT64_C(0x0000000000000002)")]
        public const ulong SDL_WINDOW_OPENGL = (0x0000000000000002UL);

        [NativeTypeName("#define SDL_WINDOW_OCCLUDED SDL_UINT64_C(0x0000000000000004)")]
        public const ulong SDL_WINDOW_OCCLUDED = (0x0000000000000004UL);

        [NativeTypeName("#define SDL_WINDOW_HIDDEN SDL_UINT64_C(0x0000000000000008)")]
        public const ulong SDL_WINDOW_HIDDEN = (0x0000000000000008UL);

        [NativeTypeName("#define SDL_WINDOW_BORDERLESS SDL_UINT64_C(0x0000000000000010)")]
        public const ulong SDL_WINDOW_BORDERLESS = (0x0000000000000010UL);

        [NativeTypeName("#define SDL_WINDOW_RESIZABLE SDL_UINT64_C(0x0000000000000020)")]
        public const ulong SDL_WINDOW_RESIZABLE = (0x0000000000000020UL);

        [NativeTypeName("#define SDL_WINDOW_MINIMIZED SDL_UINT64_C(0x0000000000000040)")]
        public const ulong SDL_WINDOW_MINIMIZED = (0x0000000000000040UL);

        [NativeTypeName("#define SDL_WINDOW_MAXIMIZED SDL_UINT64_C(0x0000000000000080)")]
        public const ulong SDL_WINDOW_MAXIMIZED = (0x0000000000000080UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_GRABBED SDL_UINT64_C(0x0000000000000100)")]
        public const ulong SDL_WINDOW_MOUSE_GRABBED = (0x0000000000000100UL);

        [NativeTypeName("#define SDL_WINDOW_INPUT_FOCUS SDL_UINT64_C(0x0000000000000200)")]
        public const ulong SDL_WINDOW_INPUT_FOCUS = (0x0000000000000200UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_FOCUS SDL_UINT64_C(0x0000000000000400)")]
        public const ulong SDL_WINDOW_MOUSE_FOCUS = (0x0000000000000400UL);

        [NativeTypeName("#define SDL_WINDOW_EXTERNAL SDL_UINT64_C(0x0000000000000800)")]
        public const ulong SDL_WINDOW_EXTERNAL = (0x0000000000000800UL);

        [NativeTypeName("#define SDL_WINDOW_MODAL SDL_UINT64_C(0x0000000000001000)")]
        public const ulong SDL_WINDOW_MODAL = (0x0000000000001000UL);

        [NativeTypeName("#define SDL_WINDOW_HIGH_PIXEL_DENSITY SDL_UINT64_C(0x0000000000002000)")]
        public const ulong SDL_WINDOW_HIGH_PIXEL_DENSITY = (0x0000000000002000UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_CAPTURE SDL_UINT64_C(0x0000000000004000)")]
        public const ulong SDL_WINDOW_MOUSE_CAPTURE = (0x0000000000004000UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_RELATIVE_MODE SDL_UINT64_C(0x0000000000008000)")]
        public const ulong SDL_WINDOW_MOUSE_RELATIVE_MODE = (0x0000000000008000UL);

        [NativeTypeName("#define SDL_WINDOW_ALWAYS_ON_TOP SDL_UINT64_C(0x0000000000010000)")]
        public const ulong SDL_WINDOW_ALWAYS_ON_TOP = (0x0000000000010000UL);

        [NativeTypeName("#define SDL_WINDOW_UTILITY SDL_UINT64_C(0x0000000000020000)")]
        public const ulong SDL_WINDOW_UTILITY = (0x0000000000020000UL);

        [NativeTypeName("#define SDL_WINDOW_TOOLTIP SDL_UINT64_C(0x0000000000040000)")]
        public const ulong SDL_WINDOW_TOOLTIP = (0x0000000000040000UL);

        [NativeTypeName("#define SDL_WINDOW_POPUP_MENU SDL_UINT64_C(0x0000000000080000)")]
        public const ulong SDL_WINDOW_POPUP_MENU = (0x0000000000080000UL);

        [NativeTypeName("#define SDL_WINDOW_KEYBOARD_GRABBED SDL_UINT64_C(0x0000000000100000)")]
        public const ulong SDL_WINDOW_KEYBOARD_GRABBED = (0x0000000000100000UL);

        [NativeTypeName("#define SDL_WINDOW_FILL_DOCUMENT SDL_UINT64_C(0x0000000000200000)")]
        public const ulong SDL_WINDOW_FILL_DOCUMENT = (0x0000000000200000UL);

        [NativeTypeName("#define SDL_WINDOW_VULKAN SDL_UINT64_C(0x0000000010000000)")]
        public const ulong SDL_WINDOW_VULKAN = (0x0000000010000000UL);

        [NativeTypeName("#define SDL_WINDOW_METAL SDL_UINT64_C(0x0000000020000000)")]
        public const ulong SDL_WINDOW_METAL = (0x0000000020000000UL);

        [NativeTypeName("#define SDL_WINDOW_TRANSPARENT SDL_UINT64_C(0x0000000040000000)")]
        public const ulong SDL_WINDOW_TRANSPARENT = (0x0000000040000000UL);

        [NativeTypeName("#define SDL_WINDOW_NOT_FOCUSABLE SDL_UINT64_C(0x0000000080000000)")]
        public const ulong SDL_WINDOW_NOT_FOCUSABLE = (0x0000000080000000UL);

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED_MASK 0x1FFF0000u")]
        public const uint SDL_WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_UNDEFINED = (0x1FFF0000U | (0));

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED_MASK 0x2FFF0000u")]
        public const uint SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED SDL_WINDOWPOS_CENTERED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_CENTERED = (0x2FFF0000U | (0));

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_CORE 0x0001")]
        public const int SDL_GL_CONTEXT_PROFILE_CORE = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_COMPATIBILITY 0x0002")]
        public const int SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002;

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_ES 0x0004")]
        public const int SDL_GL_CONTEXT_PROFILE_ES = 0x0004;

        [NativeTypeName("#define SDL_GL_CONTEXT_DEBUG_FLAG 0x0001")]
        public const int SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG 0x0002")]
        public const int SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002;

        [NativeTypeName("#define SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG 0x0004")]
        public const int SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_ISOLATION_FLAG 0x0008")]
        public const int SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008;

        [NativeTypeName("#define SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE 0x0000")]
        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000;

        [NativeTypeName("#define SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH 0x0001")]
        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_NO_NOTIFICATION 0x0000")]
        public const int SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_LOSE_CONTEXT 0x0001")]
        public const int SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = 0x0001;

        [NativeTypeName("#define SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN \"SDL.display.HDR_enabled\"")]
        public static string SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN => "SDL.display.HDR_enabled";

        [NativeTypeName("#define SDL_PROP_DISPLAY_KMSDRM_PANEL_ORIENTATION_NUMBER \"SDL.display.KMSDRM.panel_orientation\"")]
        public static string SDL_PROP_DISPLAY_KMSDRM_PANEL_ORIENTATION_NUMBER => "SDL.display.KMSDRM.panel_orientation";

        [NativeTypeName("#define SDL_PROP_DISPLAY_WAYLAND_WL_OUTPUT_POINTER \"SDL.display.wayland.wl_output\"")]
        public static string SDL_PROP_DISPLAY_WAYLAND_WL_OUTPUT_POINTER => "SDL.display.wayland.wl_output";

        [NativeTypeName("#define SDL_PROP_DISPLAY_WINDOWS_HMONITOR_POINTER \"SDL.display.windows.hmonitor\"")]
        public static string SDL_PROP_DISPLAY_WINDOWS_HMONITOR_POINTER => "SDL.display.windows.hmonitor";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN \"SDL.window.create.always_on_top\"")]
        public static string SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN => "SDL.window.create.always_on_top";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN \"SDL.window.create.borderless\"")]
        public static string SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN => "SDL.window.create.borderless";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_CONSTRAIN_POPUP_BOOLEAN \"SDL.window.create.constrain_popup\"")]
        public static string SDL_PROP_WINDOW_CREATE_CONSTRAIN_POPUP_BOOLEAN => "SDL.window.create.constrain_popup";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN \"SDL.window.create.focusable\"")]
        public static string SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN => "SDL.window.create.focusable";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN \"SDL.window.create.external_graphics_context\"")]
        public static string SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN => "SDL.window.create.external_graphics_context";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FLAGS_NUMBER \"SDL.window.create.flags\"")]
        public static string SDL_PROP_WINDOW_CREATE_FLAGS_NUMBER => "SDL.window.create.flags";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN \"SDL.window.create.fullscreen\"")]
        public static string SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN => "SDL.window.create.fullscreen";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER \"SDL.window.create.height\"")]
        public static string SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER => "SDL.window.create.height";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN \"SDL.window.create.hidden\"")]
        public static string SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN => "SDL.window.create.hidden";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN \"SDL.window.create.high_pixel_density\"")]
        public static string SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN => "SDL.window.create.high_pixel_density";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN \"SDL.window.create.maximized\"")]
        public static string SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN => "SDL.window.create.maximized";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN \"SDL.window.create.menu\"")]
        public static string SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN => "SDL.window.create.menu";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN \"SDL.window.create.metal\"")]
        public static string SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN => "SDL.window.create.metal";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN \"SDL.window.create.minimized\"")]
        public static string SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN => "SDL.window.create.minimized";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN \"SDL.window.create.modal\"")]
        public static string SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN => "SDL.window.create.modal";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN \"SDL.window.create.mouse_grabbed\"")]
        public static string SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN => "SDL.window.create.mouse_grabbed";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN \"SDL.window.create.opengl\"")]
        public static string SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN => "SDL.window.create.opengl";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_PARENT_POINTER \"SDL.window.create.parent\"")]
        public static string SDL_PROP_WINDOW_CREATE_PARENT_POINTER => "SDL.window.create.parent";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN \"SDL.window.create.resizable\"")]
        public static string SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN => "SDL.window.create.resizable";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TITLE_STRING \"SDL.window.create.title\"")]
        public static string SDL_PROP_WINDOW_CREATE_TITLE_STRING => "SDL.window.create.title";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN \"SDL.window.create.transparent\"")]
        public static string SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN => "SDL.window.create.transparent";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN \"SDL.window.create.tooltip\"")]
        public static string SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN => "SDL.window.create.tooltip";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN \"SDL.window.create.utility\"")]
        public static string SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN => "SDL.window.create.utility";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN \"SDL.window.create.vulkan\"")]
        public static string SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN => "SDL.window.create.vulkan";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER \"SDL.window.create.width\"")]
        public static string SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER => "SDL.window.create.width";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X_NUMBER \"SDL.window.create.x\"")]
        public static string SDL_PROP_WINDOW_CREATE_X_NUMBER => "SDL.window.create.x";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_Y_NUMBER \"SDL.window.create.y\"")]
        public static string SDL_PROP_WINDOW_CREATE_Y_NUMBER => "SDL.window.create.y";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER \"SDL.window.create.cocoa.window\"")]
        public static string SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER => "SDL.window.create.cocoa.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER \"SDL.window.create.cocoa.view\"")]
        public static string SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER => "SDL.window.create.cocoa.view";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WINDOWSCENE_POINTER \"SDL.window.create.uikit.windowscene\"")]
        public static string SDL_PROP_WINDOW_CREATE_WINDOWSCENE_POINTER => "SDL.window.create.uikit.windowscene";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN \"SDL.window.create.wayland.surface_role_custom\"")]
        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN => "SDL.window.create.wayland.surface_role_custom";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN \"SDL.window.create.wayland.create_egl_window\"")]
        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN => "SDL.window.create.wayland.create_egl_window";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_WINDOW_ID_STRING \"SDL.window.create.wayland.window_id\"")]
        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_WINDOW_ID_STRING => "SDL.window.create.wayland.window_id";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER \"SDL.window.create.wayland.wl_surface\"")]
        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER => "SDL.window.create.wayland.wl_surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER \"SDL.window.create.win32.hwnd\"")]
        public static string SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER => "SDL.window.create.win32.hwnd";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER \"SDL.window.create.win32.pixel_format_hwnd\"")]
        public static string SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER => "SDL.window.create.win32.pixel_format_hwnd";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER \"SDL.window.create.x11.window\"")]
        public static string SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER => "SDL.window.create.x11.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_CANVAS_ID_STRING \"SDL.window.create.emscripten.canvas_id\"")]
        public static string SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_CANVAS_ID_STRING => "SDL.window.create.emscripten.canvas_id";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING \"SDL.window.create.emscripten.keyboard_element\"")]
        public static string SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => "SDL.window.create.emscripten.keyboard_element";

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_VISIONOS_SETTINGS_STRING \"SDL.window.create.visionos.settings\"")]
        public static string SDL_PROP_WINDOW_CREATE_VISIONOS_SETTINGS_STRING => "SDL.window.create.visionos.settings";

        [NativeTypeName("#define SDL_PROP_WINDOW_SHAPE_POINTER \"SDL.window.shape\"")]
        public static string SDL_PROP_WINDOW_SHAPE_POINTER => "SDL.window.shape";

        [NativeTypeName("#define SDL_PROP_WINDOW_HDR_ENABLED_BOOLEAN \"SDL.window.HDR_enabled\"")]
        public static string SDL_PROP_WINDOW_HDR_ENABLED_BOOLEAN => "SDL.window.HDR_enabled";

        [NativeTypeName("#define SDL_PROP_WINDOW_SDR_WHITE_LEVEL_FLOAT \"SDL.window.SDR_white_level\"")]
        public static string SDL_PROP_WINDOW_SDR_WHITE_LEVEL_FLOAT => "SDL.window.SDR_white_level";

        [NativeTypeName("#define SDL_PROP_WINDOW_HDR_HEADROOM_FLOAT \"SDL.window.HDR_headroom\"")]
        public static string SDL_PROP_WINDOW_HDR_HEADROOM_FLOAT => "SDL.window.HDR_headroom";

        [NativeTypeName("#define SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER \"SDL.window.android.window\"")]
        public static string SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER => "SDL.window.android.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER \"SDL.window.android.surface\"")]
        public static string SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER => "SDL.window.android.surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER \"SDL.window.uikit.window\"")]
        public static string SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER => "SDL.window.uikit.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER \"SDL.window.uikit.metal_view_tag\"")]
        public static string SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER => "SDL.window.uikit.metal_view_tag";

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER \"SDL.window.uikit.opengl.framebuffer\"")]
        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER => "SDL.window.uikit.opengl.framebuffer";

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER \"SDL.window.uikit.opengl.renderbuffer\"")]
        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER => "SDL.window.uikit.opengl.renderbuffer";

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER \"SDL.window.uikit.opengl.resolve_framebuffer\"")]
        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER => "SDL.window.uikit.opengl.resolve_framebuffer";

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER \"SDL.window.kmsdrm.dev_index\"")]
        public static string SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER => "SDL.window.kmsdrm.dev_index";

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER \"SDL.window.kmsdrm.drm_fd\"")]
        public static string SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER => "SDL.window.kmsdrm.drm_fd";

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER \"SDL.window.kmsdrm.gbm_dev\"")]
        public static string SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER => "SDL.window.kmsdrm.gbm_dev";

        [NativeTypeName("#define SDL_PROP_WINDOW_COCOA_WINDOW_POINTER \"SDL.window.cocoa.window\"")]
        public static string SDL_PROP_WINDOW_COCOA_WINDOW_POINTER => "SDL.window.cocoa.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER \"SDL.window.cocoa.metal_view_tag\"")]
        public static string SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER => "SDL.window.cocoa.metal_view_tag";

        [NativeTypeName("#define SDL_PROP_WINDOW_OPENVR_OVERLAY_ID_NUMBER \"SDL.window.openvr.overlay_id\"")]
        public static string SDL_PROP_WINDOW_OPENVR_OVERLAY_ID_NUMBER => "SDL.window.openvr.overlay_id";

        [NativeTypeName("#define SDL_PROP_WINDOW_QNX_WINDOW_POINTER \"SDL.window.qnx.window\"")]
        public static string SDL_PROP_WINDOW_QNX_WINDOW_POINTER => "SDL.window.qnx.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_QNX_SURFACE_POINTER \"SDL.window.qnx.surface\"")]
        public static string SDL_PROP_WINDOW_QNX_SURFACE_POINTER => "SDL.window.qnx.surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER \"SDL.window.vivante.display\"")]
        public static string SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER => "SDL.window.vivante.display";

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER \"SDL.window.vivante.window\"")]
        public static string SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER => "SDL.window.vivante.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER \"SDL.window.vivante.surface\"")]
        public static string SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER => "SDL.window.vivante.surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HWND_POINTER \"SDL.window.win32.hwnd\"")]
        public static string SDL_PROP_WINDOW_WIN32_HWND_POINTER => "SDL.window.win32.hwnd";

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HDC_POINTER \"SDL.window.win32.hdc\"")]
        public static string SDL_PROP_WINDOW_WIN32_HDC_POINTER => "SDL.window.win32.hdc";

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER \"SDL.window.win32.instance\"")]
        public static string SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER => "SDL.window.win32.instance";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER \"SDL.window.wayland.display\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER => "SDL.window.wayland.display";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER \"SDL.window.wayland.surface\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER => "SDL.window.wayland.surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_VIEWPORT_POINTER \"SDL.window.wayland.viewport\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_VIEWPORT_POINTER => "SDL.window.wayland.viewport";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER \"SDL.window.wayland.egl_window\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER => "SDL.window.wayland.egl_window";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_WINDOW_ID_STRING \"SDL.window.wayland.window_id\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_WINDOW_ID_STRING => "SDL.window.wayland.window_id";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER \"SDL.window.wayland.xdg_surface\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER => "SDL.window.wayland.xdg_surface";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER \"SDL.window.wayland.xdg_toplevel\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER => "SDL.window.wayland.xdg_toplevel";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING \"SDL.window.wayland.xdg_toplevel_export_handle\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING => "SDL.window.wayland.xdg_toplevel_export_handle";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER \"SDL.window.wayland.xdg_popup\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER => "SDL.window.wayland.xdg_popup";

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER \"SDL.window.wayland.xdg_positioner\"")]
        public static string SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER => "SDL.window.wayland.xdg_positioner";

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_DISPLAY_POINTER \"SDL.window.x11.display\"")]
        public static string SDL_PROP_WINDOW_X11_DISPLAY_POINTER => "SDL.window.x11.display";

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_SCREEN_NUMBER \"SDL.window.x11.screen\"")]
        public static string SDL_PROP_WINDOW_X11_SCREEN_NUMBER => "SDL.window.x11.screen";

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_WINDOW_NUMBER \"SDL.window.x11.window\"")]
        public static string SDL_PROP_WINDOW_X11_WINDOW_NUMBER => "SDL.window.x11.window";

        [NativeTypeName("#define SDL_PROP_WINDOW_EMSCRIPTEN_CANVAS_ID_STRING \"SDL.window.emscripten.canvas_id\"")]
        public static string SDL_PROP_WINDOW_EMSCRIPTEN_CANVAS_ID_STRING => "SDL.window.emscripten.canvas_id";

        [NativeTypeName("#define SDL_PROP_WINDOW_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING \"SDL.window.emscripten.keyboard_element\"")]
        public static string SDL_PROP_WINDOW_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => "SDL.window.emscripten.keyboard_element";

        [NativeTypeName("#define SDL_PROP_WINDOW_VISIONOS_SETTINGS_STRING \"SDL.window.visionos.settings\"")]
        public static string SDL_PROP_WINDOW_VISIONOS_SETTINGS_STRING => "SDL.window.visionos.settings";

        [NativeTypeName("#define SDL_WINDOW_SURFACE_VSYNC_DISABLED 0")]
        public const int SDL_WINDOW_SURFACE_VSYNC_DISABLED = 0;

        [NativeTypeName("#define SDL_WINDOW_SURFACE_VSYNC_ADAPTIVE (-1)")]
        public const int SDL_WINDOW_SURFACE_VSYNC_ADAPTIVE = (-1);
    }
}
