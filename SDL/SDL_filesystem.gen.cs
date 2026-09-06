using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_Folder
    {
        SDL_FOLDER_HOME,
        SDL_FOLDER_DESKTOP,
        SDL_FOLDER_DOCUMENTS,
        SDL_FOLDER_DOWNLOADS,
        SDL_FOLDER_MUSIC,
        SDL_FOLDER_PICTURES,
        SDL_FOLDER_PUBLICSHARE,
        SDL_FOLDER_SAVEDGAMES,
        SDL_FOLDER_SCREENSHOTS,
        SDL_FOLDER_TEMPLATES,
        SDL_FOLDER_VIDEOS,
        SDL_FOLDER_COUNT,
    }

    internal enum SDL_PathType
    {
        SDL_PATHTYPE_NONE,
        SDL_PATHTYPE_FILE,
        SDL_PATHTYPE_DIRECTORY,
        SDL_PATHTYPE_OTHER,
    }

    internal partial struct SDL_PathInfo
    {
        public SDL_PathType type;

        [NativeTypeName("Uint64")]
        public ulong size;

        [NativeTypeName("SDL_Time")]
        public long create_time;

        [NativeTypeName("SDL_Time")]
        public long modify_time;

        [NativeTypeName("SDL_Time")]
        public long access_time;
    }

    internal enum SDL_EnumerationResult
    {
        SDL_ENUM_CONTINUE,
        SDL_ENUM_SUCCESS,
        SDL_ENUM_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_EnumerationResult SDL_EnumerateDirectoryCallback(void* userdata, [NativeTypeName("const char *")] byte* dirname, [NativeTypeName("const char *")] byte* fname);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetBasePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_GetPrefPath([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetUserFolder", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetUserFolder(SDL_Folder folder);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateDirectory", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CreateDirectory([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateDirectory", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_EnumerateDirectory([NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemovePath", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RemovePath([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenamePath", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenamePath([NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyFile", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CopyFile([NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPathInfo", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetPathInfo([NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobDirectory", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        private static extern byte** iSDL_GlobDirectory([NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_GetCurrentDirectory();

        [NativeTypeName("#define SDL_GLOB_CASEINSENSITIVE (1u << 0)")]
        public const uint SDL_GLOB_CASEINSENSITIVE = (1U << 0);
    }
}
