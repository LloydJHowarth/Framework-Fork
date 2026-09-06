using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_AppResult
    {
        SDL_APP_CONTINUE,
        SDL_APP_SUCCESS,
        SDL_APP_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AppResult SDL_AppInit_func(void** appstate, int argc, [NativeTypeName("char *[]")] byte** argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AppResult SDL_AppIterate_func(void* appstate);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AppResult SDL_AppEvent_func(void* appstate, SDL_Event* @event);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_AppQuit_func(void* appstate, SDL_AppResult result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_MainThreadCallback(void* userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_Init([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
        private static extern void iSDL_QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        [return: NativeTypeName("SDL_InitFlags")]
        private static extern uint iSDL_WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
        private static extern void iSDL_Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_IsMainThread();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RunOnMainThread([NativeTypeName("SDL_MainThreadCallback")] IntPtr callback, void* userdata, [NativeTypeName("bool")] SDL_Bool wait_complete);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAppMetadata([NativeTypeName("const char *")] byte* appname, [NativeTypeName("const char *")] byte* appversion, [NativeTypeName("const char *")] byte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAppMetadataProperty([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetAppMetadataProperty([NativeTypeName("const char *")] byte* name);

        [NativeTypeName("#define SDL_INIT_AUDIO 0x00000010u")]
        public const uint SDL_INIT_AUDIO = 0x00000010U;

        [NativeTypeName("#define SDL_INIT_VIDEO 0x00000020u")]
        public const uint SDL_INIT_VIDEO = 0x00000020U;

        [NativeTypeName("#define SDL_INIT_JOYSTICK 0x00000200u")]
        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        [NativeTypeName("#define SDL_INIT_HAPTIC 0x00001000u")]
        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        [NativeTypeName("#define SDL_INIT_GAMEPAD 0x00002000u")]
        public const uint SDL_INIT_GAMEPAD = 0x00002000U;

        [NativeTypeName("#define SDL_INIT_EVENTS 0x00004000u")]
        public const uint SDL_INIT_EVENTS = 0x00004000U;

        [NativeTypeName("#define SDL_INIT_SENSOR 0x00008000u")]
        public const uint SDL_INIT_SENSOR = 0x00008000U;

        [NativeTypeName("#define SDL_INIT_CAMERA 0x00010000u")]
        public const uint SDL_INIT_CAMERA = 0x00010000U;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_NAME_STRING \"SDL.app.metadata.name\"")]
        public static string SDL_PROP_APP_METADATA_NAME_STRING => "SDL.app.metadata.name";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_VERSION_STRING \"SDL.app.metadata.version\"")]
        public static string SDL_PROP_APP_METADATA_VERSION_STRING => "SDL.app.metadata.version";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_IDENTIFIER_STRING \"SDL.app.metadata.identifier\"")]
        public static string SDL_PROP_APP_METADATA_IDENTIFIER_STRING => "SDL.app.metadata.identifier";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_CREATOR_STRING \"SDL.app.metadata.creator\"")]
        public static string SDL_PROP_APP_METADATA_CREATOR_STRING => "SDL.app.metadata.creator";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_COPYRIGHT_STRING \"SDL.app.metadata.copyright\"")]
        public static string SDL_PROP_APP_METADATA_COPYRIGHT_STRING => "SDL.app.metadata.copyright";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_URL_STRING \"SDL.app.metadata.url\"")]
        public static string SDL_PROP_APP_METADATA_URL_STRING => "SDL.app.metadata.url";

        [NativeTypeName("#define SDL_PROP_APP_METADATA_TYPE_STRING \"SDL.app.metadata.type\"")]
        public static string SDL_PROP_APP_METADATA_TYPE_STRING => "SDL.app.metadata.type";
    }
}
