using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static byte* SDL_GetBasePath()
        {
            return iSDL_GetBasePath();
        }

        internal static byte* SDL_GetPrefPath(byte* org, byte* app)
        {
            return iSDL_GetPrefPath(org, app);
        }

        internal static byte* SDL_GetUserFolder(SDL_Folder folder)
        {
            return iSDL_GetUserFolder(folder);
        }

        internal static SDL_Bool SDL_CreateDirectory(byte* path)
        {
            return iSDL_CreateDirectory(path);
        }

        internal static SDL_Bool SDL_EnumerateDirectory(byte* path, IntPtr callback, void* userdata)
        {
            return iSDL_EnumerateDirectory(path, callback, userdata);
        }

        internal static SDL_Bool SDL_RemovePath(byte* path)
        {
            return iSDL_RemovePath(path);
        }

        internal static SDL_Bool SDL_RenamePath(byte* oldpath, byte* newpath)
        {
            return iSDL_RenamePath(oldpath, newpath);
        }

        internal static SDL_Bool SDL_CopyFile(byte* oldpath, byte* newpath)
        {
            return iSDL_CopyFile(oldpath, newpath);
        }

        internal static SDL_Bool SDL_GetPathInfo(byte* path, SDL_PathInfo* info)
        {
            return iSDL_GetPathInfo(path, info);
        }

        internal static byte** SDL_GlobDirectory(byte* path, byte* pattern, uint flags, int* count)
        {
            return iSDL_GlobDirectory(path, pattern, flags, count);
        }

        internal static byte* SDL_GetCurrentDirectory()
        {
            return iSDL_GetCurrentDirectory();
        }
    }
}