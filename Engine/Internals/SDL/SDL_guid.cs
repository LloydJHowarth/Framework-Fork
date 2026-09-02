using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static void SDL_GUIDToString(SDL_GUID guid, byte* pszGUID, int cbGUID)
        {
            iSDL_GUIDToString(guid, pszGUID, cbGUID);
        }

        internal static SDL_GUID SDL_StringToGUID(byte* pchGUID)
        {
            return iSDL_StringToGUID(pchGUID);
        }
    }
}