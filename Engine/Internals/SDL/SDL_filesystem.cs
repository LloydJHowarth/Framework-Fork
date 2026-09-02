using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static byte* SDL_GetBasePath()
        {
            return iSDL_GetBasePath();
        }

        public static byte* SDL_GetPrefPath(byte* org, byte* app)
        {
            return iSDL_GetPrefPath(org, app);
        }

        public static byte* SDL_GetUserFolder(SDL_Folder folder)
        {
            return iSDL_GetUserFolder(folder);
        }

        public static SDL_Bool SDL_CreateDirectory(byte* path)
        {
            return iSDL_CreateDirectory(path);
        }

        public static SDL_Bool SDL_EnumerateDirectory(byte* path, IntPtr callback, void* userdata)
        {
            return iSDL_EnumerateDirectory(path, callback, userdata);
        }

        public static SDL_Bool SDL_RemovePath(byte* path)
        {
            return iSDL_RemovePath(path);
        }

        public static SDL_Bool SDL_RenamePath(byte* oldpath, byte* newpath)
        {
            return iSDL_RenamePath(oldpath, newpath);
        }

        public static SDL_Bool SDL_CopyFile(byte* oldpath, byte* newpath)
        {
            return iSDL_CopyFile(oldpath, newpath);
        }

        public static SDL_Bool SDL_GetPathInfo(byte* path, SDL_PathInfo* info)
        {
            return iSDL_GetPathInfo(path, info);
        }

        public static byte** SDL_GlobDirectory(byte* path, byte* pattern, uint flags, int* count)
        {
            return iSDL_GlobDirectory(path, pattern, flags, count);
        }

        public static byte* SDL_GetCurrentDirectory()
        {
            return iSDL_GetCurrentDirectory();
        }
    }
}