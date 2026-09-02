using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Storage* SDL_OpenTitleStorage(byte* @override, uint props)
        {
            return iSDL_OpenTitleStorage(@override, props);
        }

        internal static SDL_Storage* SDL_OpenUserStorage(byte* org, byte* app, uint props)
        {
            return iSDL_OpenUserStorage(org, app, props);
        }

        internal static SDL_Storage* SDL_OpenFileStorage(byte* path)
        {
            return iSDL_OpenFileStorage(path);
        }

        internal static SDL_Storage* SDL_OpenStorage(SDL_StorageInterface* iface, void* userdata)
        {
            return iSDL_OpenStorage(iface, userdata);
        }

        internal static SDL_Bool SDL_CloseStorage(SDL_Storage* storage)
        {
            return iSDL_CloseStorage(storage);
        }

        internal static SDL_Bool SDL_StorageReady(SDL_Storage* storage)
        {
            return iSDL_StorageReady(storage);
        }

        internal static SDL_Bool SDL_GetStorageFileSize(SDL_Storage* storage, byte* path, ulong* length)
        {
            return iSDL_GetStorageFileSize(storage, path, length);
        }

        internal static SDL_Bool SDL_ReadStorageFile(SDL_Storage* storage, byte* path, void* destination, ulong length)
        {
            return iSDL_ReadStorageFile(storage, path, destination, length);
        }

        internal static SDL_Bool SDL_WriteStorageFile(SDL_Storage* storage, byte* path, void* source, ulong length)
        {
            return iSDL_WriteStorageFile(storage, path, source, length);
        }

        internal static SDL_Bool SDL_CreateStorageDirectory(SDL_Storage* storage, byte* path)
        {
            return iSDL_CreateStorageDirectory(storage, path);
        }

        internal static SDL_Bool SDL_EnumerateStorageDirectory(SDL_Storage* storage, byte* path, IntPtr callback, void* userdata)
        {
            return iSDL_EnumerateStorageDirectory(storage, path, callback, userdata);
        }

        internal static SDL_Bool SDL_RemoveStoragePath(SDL_Storage* storage, byte* path)
        {
            return iSDL_RemoveStoragePath(storage, path);
        }

        internal static SDL_Bool SDL_RenameStoragePath(SDL_Storage* storage, byte* oldpath, byte* newpath)
        {
            return iSDL_RenameStoragePath(storage, oldpath, newpath);
        }

        internal static SDL_Bool SDL_CopyStorageFile(SDL_Storage* storage, byte* oldpath, byte* newpath)
        {
            return iSDL_CopyStorageFile(storage, oldpath, newpath);
        }

        internal static SDL_Bool SDL_GetStoragePathInfo(SDL_Storage* storage, byte* path, SDL_PathInfo* info)
        {
            return iSDL_GetStoragePathInfo(storage, path, info);
        }

        internal static ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage)
        {
            return iSDL_GetStorageSpaceRemaining(storage);
        }

        internal static byte** SDL_GlobStorageDirectory(SDL_Storage* storage, byte* path, byte* pattern, uint flags, int* count)
        {
            return iSDL_GlobStorageDirectory(storage, path, pattern, flags, count);
        }
    }
}