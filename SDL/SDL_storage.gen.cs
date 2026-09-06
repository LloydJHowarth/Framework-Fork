using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_StorageInterface
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("bool (*)(void *)")]
        public IntPtr close;

        [NativeTypeName("bool (*)(void *)")]
        public IntPtr ready;

        [NativeTypeName("bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
        public IntPtr enumerate;

        [NativeTypeName("bool (*)(void *, const char *, SDL_PathInfo *)")]
        public IntPtr info;

        [NativeTypeName("bool (*)(void *, const char *, void *, Uint64)")]
        public IntPtr read_file;

        [NativeTypeName("bool (*)(void *, const char *, const void *, Uint64)")]
        public IntPtr write_file;

        [NativeTypeName("bool (*)(void *, const char *)")]
        public IntPtr mkdir;

        [NativeTypeName("bool (*)(void *, const char *)")]
        public IntPtr remove;

        [NativeTypeName("bool (*)(void *, const char *, const char *)")]
        public IntPtr rename;

        [NativeTypeName("bool (*)(void *, const char *, const char *)")]
        public IntPtr copy;

        [NativeTypeName("Uint64 (*)(void *)")]
        public IntPtr space_remaining;
    }

    internal partial struct SDL_Storage
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenTitleStorage([NativeTypeName("const char *")] byte* @override, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenUserStorage([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenFileStorage([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("Uint64 *")] ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, void* destination, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const void *")] void* source, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CopyStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        private static extern ulong iSDL_GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        private static extern byte** iSDL_GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);
    }
}
