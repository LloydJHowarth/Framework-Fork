using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_PropertyType
    {
        SDL_PROPERTY_TYPE_INVALID,
        SDL_PROPERTY_TYPE_POINTER,
        SDL_PROPERTY_TYPE_STRING,
        SDL_PROPERTY_TYPE_NUMBER,
        SDL_PROPERTY_TYPE_FLOAT,
        SDL_PROPERTY_TYPE_BOOLEAN,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_CleanupPropertyCallback(void* userdata, void* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_EnumeratePropertiesCallback(void* userdata, [NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetGlobalProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_CreateProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CopyProperties([NativeTypeName("SDL_PropertiesID")] uint src, [NativeTypeName("SDL_PropertiesID")] uint dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
        private static extern void iSDL_UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetPointerPropertyWithCleanup([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value, [NativeTypeName("SDL_CleanupPropertyCallback")] IntPtr cleanup, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Sint64")] long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("bool")] SDL_Bool value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_HasProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPropertyType", ExactSpelling = true)]
        private static extern SDL_PropertyType iSDL_GetPropertyType([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPointerProperty", ExactSpelling = true)]
        private static extern void* iSDL_GetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStringProperty", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumberProperty", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        private static extern long iSDL_GetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Sint64")] long default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFloatProperty", ExactSpelling = true)]
        private static extern float iSDL_GetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, float default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBooleanProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("bool")] SDL_Bool default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ClearProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumProperties", ExactSpelling = true)]
        private static extern int iSDL_GetNumProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_EnumerateProperties([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_EnumeratePropertiesCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
        private static extern void iSDL_DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeTypeName("#define SDL_PROP_NAME_STRING \"SDL.name\"")]
        public static string SDL_PROP_NAME_STRING => "SDL.name";
    }
}
