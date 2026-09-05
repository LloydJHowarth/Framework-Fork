using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumVideoDrivers()
        {
            return iSDL_GetNumVideoDrivers();
        }

        public static byte* SDL_GetVideoDriver(int index)
        {
            return iSDL_GetVideoDriver(index);
        }

        public static byte* SDL_GetCurrentVideoDriver()
        {
            return iSDL_GetCurrentVideoDriver();
        }

        public static SDL_SystemTheme SDL_GetSystemTheme()
        {
            return iSDL_GetSystemTheme();
        }

        public static uint* SDL_GetDisplays(int* count)
        {
            return iSDL_GetDisplays(count);
        }

        public static uint SDL_GetPrimaryDisplay()
        {
            return iSDL_GetPrimaryDisplay();
        }

        public static uint SDL_GetDisplayProperties(uint displayID)
        {
            return iSDL_GetDisplayProperties(displayID);
        }

        public static byte* SDL_GetDisplayName(uint displayID)
        {
            return iSDL_GetDisplayName(displayID);
        }

        public static SDL_Bool SDL_GetDisplayBounds(uint displayID, SDL_Rect* rect)
        {
            return iSDL_GetDisplayBounds(displayID, rect);
        }

        public static SDL_Bool SDL_GetDisplayUsableBounds(uint displayID, SDL_Rect* rect)
        {
            return iSDL_GetDisplayUsableBounds(displayID, rect);
        }

        public static SDL_DisplayOrientation SDL_GetNaturalDisplayOrientation(uint displayID)
        {
            return iSDL_GetNaturalDisplayOrientation(displayID);
        }

        public static SDL_DisplayOrientation SDL_GetCurrentDisplayOrientation(uint displayID)
        {
            return iSDL_GetCurrentDisplayOrientation(displayID);
        }

        public static float SDL_GetDisplayContentScale(uint displayID)
        {
            return iSDL_GetDisplayContentScale(displayID);
        }

        public static SDL_DisplayMode** SDL_GetFullscreenDisplayModes(uint displayID, int* count)
        {
            return iSDL_GetFullscreenDisplayModes(displayID, count);
        }

        public static SDL_Bool SDL_GetClosestFullscreenDisplayMode(uint displayID, int w, int h, float refresh_rate, SDL_Bool include_high_density_modes, SDL_DisplayMode* closest)
        {
            return iSDL_GetClosestFullscreenDisplayMode(displayID, w, h, refresh_rate, include_high_density_modes, closest);
        }

        public static SDL_DisplayMode* SDL_GetDesktopDisplayMode(uint displayID)
        {
            return iSDL_GetDesktopDisplayMode(displayID);
        }

        public static SDL_DisplayMode* SDL_GetCurrentDisplayMode(uint displayID)
        {
            return iSDL_GetCurrentDisplayMode(displayID);
        }

        public static uint SDL_GetDisplayForPoint(SDL_Point* point)
        {
            return iSDL_GetDisplayForPoint(point);
        }

        public static uint SDL_GetDisplayForRect(SDL_Rect* rect)
        {
            return iSDL_GetDisplayForRect(rect);
        }

        public static uint SDL_GetDisplayForWindow(SDL_Window* window)
        {
            return iSDL_GetDisplayForWindow(window);
        }

        public static float SDL_GetWindowPixelDensity(SDL_Window* window)
        {
            return iSDL_GetWindowPixelDensity(window);
        }

        public static float SDL_GetWindowDisplayScale(SDL_Window* window)
        {
            return iSDL_GetWindowDisplayScale(window);
        }

        public static SDL_Bool SDL_SetWindowFullscreenMode(SDL_Window* window, SDL_DisplayMode* mode)
        {
            return iSDL_SetWindowFullscreenMode(window, mode);
        }

        public static SDL_DisplayMode* SDL_GetWindowFullscreenMode(SDL_Window* window)
        {
            return iSDL_GetWindowFullscreenMode(window);
        }

        public static void* SDL_GetWindowICCProfile(SDL_Window* window, nuint* size)
        {
            return iSDL_GetWindowICCProfile(window, size);
        }

        public static SDL_PixelFormat SDL_GetWindowPixelFormat(SDL_Window* window)
        {
            return iSDL_GetWindowPixelFormat(window);
        }

        public static SDL_Window** SDL_GetWindows(int* count)
        {
            return iSDL_GetWindows(count);
        }

        public static SDL_Window* SDL_CreateWindow(byte* title, int w, int h, ulong flags)
        {
            return iSDL_CreateWindow(title, w, h, flags);
        }

        public static SDL_Window* SDL_CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, ulong flags)
        {
            return iSDL_CreatePopupWindow(parent, offset_x, offset_y, w, h, flags);
        }

        public static SDL_Window* SDL_CreateWindowWithProperties(uint props)
        {
            return iSDL_CreateWindowWithProperties(props);
        }

        public static uint SDL_GetWindowID(SDL_Window* window)
        {
            return iSDL_GetWindowID(window);
        }

        public static SDL_Window* SDL_GetWindowFromID(uint id)
        {
            return iSDL_GetWindowFromID(id);
        }

        public static SDL_Window* SDL_GetWindowParent(SDL_Window* window)
        {
            return iSDL_GetWindowParent(window);
        }

        public static uint SDL_GetWindowProperties(SDL_Window* window)
        {
            return iSDL_GetWindowProperties(window);
        }

        public static ulong SDL_GetWindowFlags(SDL_Window* window)
        {
            return iSDL_GetWindowFlags(window);
        }

        public static SDL_Bool SDL_SetWindowTitle(SDL_Window* window, byte* title)
        {
            return iSDL_SetWindowTitle(window, title);
        }

        public static byte* SDL_GetWindowTitle(SDL_Window* window)
        {
            return iSDL_GetWindowTitle(window);
        }

        public static SDL_Bool SDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon)
        {
            return iSDL_SetWindowIcon(window, icon);
        }

        public static SDL_Bool SDL_SetWindowPosition(SDL_Window* window, int x, int y)
        {
            return iSDL_SetWindowPosition(window, x, y);
        }

        public static SDL_Bool SDL_GetWindowPosition(SDL_Window* window, int* x, int* y)
        {
            return iSDL_GetWindowPosition(window, x, y);
        }

        public static SDL_Bool SDL_SetWindowSize(SDL_Window* window, int w, int h)
        {
            return iSDL_SetWindowSize(window, w, h);
        }

        public static SDL_Bool SDL_GetWindowSize(SDL_Window* window, int* w, int* h)
        {
            return iSDL_GetWindowSize(window, w, h);
        }

        public static SDL_Bool SDL_GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect)
        {
            return iSDL_GetWindowSafeArea(window, rect);
        }

        public static SDL_Bool SDL_SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect)
        {
            return iSDL_SetWindowAspectRatio(window, min_aspect, max_aspect);
        }

        public static SDL_Bool SDL_GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect)
        {
            return iSDL_GetWindowAspectRatio(window, min_aspect, max_aspect);
        }

        public static SDL_Bool SDL_GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right)
        {
            return iSDL_GetWindowBordersSize(window, top, left, bottom, right);
        }

        public static SDL_Bool SDL_GetWindowSizeInPixels(SDL_Window* window, int* w, int* h)
        {
            return iSDL_GetWindowSizeInPixels(window, w, h);
        }

        public static SDL_Bool SDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h)
        {
            return iSDL_SetWindowMinimumSize(window, min_w, min_h);
        }

        public static SDL_Bool SDL_GetWindowMinimumSize(SDL_Window* window, int* w, int* h)
        {
            return iSDL_GetWindowMinimumSize(window, w, h);
        }

        public static SDL_Bool SDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h)
        {
            return iSDL_SetWindowMaximumSize(window, max_w, max_h);
        }

        public static SDL_Bool SDL_GetWindowMaximumSize(SDL_Window* window, int* w, int* h)
        {
            return iSDL_GetWindowMaximumSize(window, w, h);
        }

        public static SDL_Bool SDL_SetWindowBordered(SDL_Window* window, SDL_Bool bordered)
        {
            return iSDL_SetWindowBordered(window, bordered);
        }

        public static SDL_Bool SDL_SetWindowResizable(SDL_Window* window, SDL_Bool resizable)
        {
            return iSDL_SetWindowResizable(window, resizable);
        }

        public static SDL_Bool SDL_SetWindowAlwaysOnTop(SDL_Window* window, SDL_Bool on_top)
        {
            return iSDL_SetWindowAlwaysOnTop(window, on_top);
        }

        public static SDL_Bool SDL_SetWindowFillDocument(SDL_Window* window, SDL_Bool fill)
        {
            return iSDL_SetWindowFillDocument(window, fill);
        }

        public static SDL_Bool SDL_ShowWindow(SDL_Window* window)
        {
            return iSDL_ShowWindow(window);
        }

        public static SDL_Bool SDL_HideWindow(SDL_Window* window)
        {
            return iSDL_HideWindow(window);
        }

        public static SDL_Bool SDL_RaiseWindow(SDL_Window* window)
        {
            return iSDL_RaiseWindow(window);
        }

        public static SDL_Bool SDL_MaximizeWindow(SDL_Window* window)
        {
            return iSDL_MaximizeWindow(window);
        }

        public static SDL_Bool SDL_MinimizeWindow(SDL_Window* window)
        {
            return iSDL_MinimizeWindow(window);
        }

        public static SDL_Bool SDL_RestoreWindow(SDL_Window* window)
        {
            return iSDL_RestoreWindow(window);
        }

        public static SDL_Bool SDL_SetWindowFullscreen(SDL_Window* window, SDL_Bool fullscreen)
        {
            return iSDL_SetWindowFullscreen(window, fullscreen);
        }

        public static SDL_Bool SDL_SyncWindow(SDL_Window* window)
        {
            return iSDL_SyncWindow(window);
        }

        public static SDL_Bool SDL_WindowHasSurface(SDL_Window* window)
        {
            return iSDL_WindowHasSurface(window);
        }

        public static SDL_Surface* SDL_GetWindowSurface(SDL_Window* window)
        {
            return iSDL_GetWindowSurface(window);
        }

        public static SDL_Bool SDL_SetWindowSurfaceVSync(SDL_Window* window, int vsync)
        {
            return iSDL_SetWindowSurfaceVSync(window, vsync);
        }

        public static SDL_Bool SDL_GetWindowSurfaceVSync(SDL_Window* window, int* vsync)
        {
            return iSDL_GetWindowSurfaceVSync(window, vsync);
        }

        public static SDL_Bool SDL_UpdateWindowSurface(SDL_Window* window)
        {
            return iSDL_UpdateWindowSurface(window);
        }

        public static SDL_Bool SDL_UpdateWindowSurfaceRects(SDL_Window* window, SDL_Rect* rects, int numrects)
        {
            return iSDL_UpdateWindowSurfaceRects(window, rects, numrects);
        }

        public static SDL_Bool SDL_DestroyWindowSurface(SDL_Window* window)
        {
            return iSDL_DestroyWindowSurface(window);
        }

        public static SDL_Bool SDL_SetWindowKeyboardGrab(SDL_Window* window, SDL_Bool grabbed)
        {
            return iSDL_SetWindowKeyboardGrab(window, grabbed);
        }

        public static SDL_Bool SDL_SetWindowMouseGrab(SDL_Window* window, SDL_Bool grabbed)
        {
            return iSDL_SetWindowMouseGrab(window, grabbed);
        }

        public static SDL_Bool SDL_GetWindowKeyboardGrab(SDL_Window* window)
        {
            return iSDL_GetWindowKeyboardGrab(window);
        }

        public static SDL_Bool SDL_GetWindowMouseGrab(SDL_Window* window)
        {
            return iSDL_GetWindowMouseGrab(window);
        }

        public static SDL_Window* SDL_GetGrabbedWindow()
        {
            return iSDL_GetGrabbedWindow();
        }

        public static SDL_Bool SDL_SetWindowMouseRect(SDL_Window* window, SDL_Rect* rect)
        {
            return iSDL_SetWindowMouseRect(window, rect);
        }

        public static SDL_Rect* SDL_GetWindowMouseRect(SDL_Window* window)
        {
            return iSDL_GetWindowMouseRect(window);
        }

        public static SDL_Bool SDL_SetWindowOpacity(SDL_Window* window, float opacity)
        {
            return iSDL_SetWindowOpacity(window, opacity);
        }

        public static float SDL_GetWindowOpacity(SDL_Window* window)
        {
            return iSDL_GetWindowOpacity(window);
        }

        public static SDL_Bool SDL_SetWindowParent(SDL_Window* window, SDL_Window* parent)
        {
            return iSDL_SetWindowParent(window, parent);
        }

        public static SDL_Bool SDL_SetWindowModal(SDL_Window* window, SDL_Bool modal)
        {
            return iSDL_SetWindowModal(window, modal);
        }

        public static SDL_Bool SDL_SetWindowFocusable(SDL_Window* window, SDL_Bool focusable)
        {
            return iSDL_SetWindowFocusable(window, focusable);
        }

        public static SDL_Bool SDL_ShowWindowSystemMenu(SDL_Window* window, int x, int y)
        {
            return iSDL_ShowWindowSystemMenu(window, x, y);
        }

        public static SDL_Bool SDL_SetWindowHitTest(SDL_Window* window, IntPtr callback, void* callback_data)
        {
            return iSDL_SetWindowHitTest(window, callback, callback_data);
        }

        public static SDL_Bool SDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape)
        {
            return iSDL_SetWindowShape(window, shape);
        }

        public static SDL_Bool SDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation)
        {
            return iSDL_FlashWindow(window, operation);
        }

        public static SDL_Bool SDL_SetWindowProgressState(SDL_Window* window, SDL_ProgressState state)
        {
            return iSDL_SetWindowProgressState(window, state);
        }

        public static SDL_ProgressState SDL_GetWindowProgressState(SDL_Window* window)
        {
            return iSDL_GetWindowProgressState(window);
        }

        public static SDL_Bool SDL_SetWindowProgressValue(SDL_Window* window, float value)
        {
            return iSDL_SetWindowProgressValue(window, value);
        }

        public static float SDL_GetWindowProgressValue(SDL_Window* window)
        {
            return iSDL_GetWindowProgressValue(window);
        }

        public static void SDL_DestroyWindow(SDL_Window* window)
        {
            iSDL_DestroyWindow(window);
        }

        public static SDL_Bool SDL_ScreenSaverEnabled()
        {
            return iSDL_ScreenSaverEnabled();
        }

        public static SDL_Bool SDL_EnableScreenSaver()
        {
            return iSDL_EnableScreenSaver();
        }

        public static SDL_Bool SDL_DisableScreenSaver()
        {
            return iSDL_DisableScreenSaver();
        }

        public static SDL_Bool SDL_GL_LoadLibrary(byte* path)
        {
            return iSDL_GL_LoadLibrary(path);
        }

        public static IntPtr SDL_GL_GetProcAddress(byte* proc)
        {
            return iSDL_GL_GetProcAddress(proc);
        }

        public static IntPtr SDL_EGL_GetProcAddress(byte* proc)
        {
            return iSDL_EGL_GetProcAddress(proc);
        }

        public static void SDL_GL_UnloadLibrary()
        {
            iSDL_GL_UnloadLibrary();
        }

        public static SDL_Bool SDL_GL_ExtensionSupported(byte* extension)
        {
            return iSDL_GL_ExtensionSupported(extension);
        }

        public static void SDL_GL_ResetAttributes()
        {
            iSDL_GL_ResetAttributes();
        }

        public static SDL_Bool SDL_GL_SetAttribute(SDL_GLAttr attr, int value)
        {
            return iSDL_GL_SetAttribute(attr, value);
        }

        public static SDL_Bool SDL_GL_GetAttribute(SDL_GLAttr attr, int* value)
        {
            return iSDL_GL_GetAttribute(attr, value);
        }

        public static SDL_GLContextState* SDL_GL_CreateContext(SDL_Window* window)
        {
            return iSDL_GL_CreateContext(window);
        }

        public static SDL_Bool SDL_GL_MakeCurrent(SDL_Window* window, SDL_GLContextState* context)
        {
            return iSDL_GL_MakeCurrent(window, context);
        }

        public static SDL_Window* SDL_GL_GetCurrentWindow()
        {
            return iSDL_GL_GetCurrentWindow();
        }

        public static SDL_GLContextState* SDL_GL_GetCurrentContext()
        {
            return iSDL_GL_GetCurrentContext();
        }

        public static void* SDL_EGL_GetCurrentDisplay()
        {
            return iSDL_EGL_GetCurrentDisplay();
        }

        public static void* SDL_EGL_GetCurrentConfig()
        {
            return iSDL_EGL_GetCurrentConfig();
        }

        public static void* SDL_EGL_GetWindowSurface(SDL_Window* window)
        {
            return iSDL_EGL_GetWindowSurface(window);
        }

        public static void SDL_EGL_SetAttributeCallbacks(IntPtr platformAttribCallback, IntPtr surfaceAttribCallback, IntPtr contextAttribCallback, void* userdata)
        {
            iSDL_EGL_SetAttributeCallbacks(platformAttribCallback, surfaceAttribCallback, contextAttribCallback, userdata);
        }

        public static SDL_Bool SDL_GL_SetSwapInterval(int interval)
        {
            return iSDL_GL_SetSwapInterval(interval);
        }

        public static SDL_Bool SDL_GL_GetSwapInterval(int* interval)
        {
            return iSDL_GL_GetSwapInterval(interval);
        }

        public static SDL_Bool SDL_GL_SwapWindow(SDL_Window* window)
        {
            return iSDL_GL_SwapWindow(window);
        }

        public static SDL_Bool SDL_GL_DestroyContext(SDL_GLContextState* context)
        {
            return iSDL_GL_DestroyContext(context);
        }
    }
}