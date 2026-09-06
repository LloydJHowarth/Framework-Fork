using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const void *")]
    internal unsafe delegate void* SDL_ClipboardDataCallback(void* userdata, [NativeTypeName("const char *")] byte* mime_type, [NativeTypeName("size_t *")] nuint* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_ClipboardCleanupCallback(void* userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetClipboardText([NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_GetClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetPrimarySelectionText([NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_GetPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetClipboardData([NativeTypeName("SDL_ClipboardDataCallback")] IntPtr callback, [NativeTypeName("SDL_ClipboardCleanupCallback")] IntPtr cleanup, void* userdata, [NativeTypeName("const char *const *")] byte** mime_types, [NativeTypeName("size_t")] nuint num_mime_types);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ClearClipboardData();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
        private static extern void* iSDL_GetClipboardData([NativeTypeName("const char *")] byte* mime_type, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasClipboardData([NativeTypeName("const char *")] byte* mime_type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        private static extern byte** iSDL_GetClipboardMimeTypes([NativeTypeName("size_t *")] nuint* num_mime_types);
    }
}
