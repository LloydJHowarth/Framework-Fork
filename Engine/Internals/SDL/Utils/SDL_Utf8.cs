using System.Runtime.InteropServices;
using System.Text;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static string SDL_Utf8ToString(byte* ptr, bool free = false)
        {
            if (ptr == null)
            {
                return string.Empty;
            }

            try
            {
                return Marshal.PtrToStringUTF8((IntPtr)ptr) ?? string.Empty;
            }
            finally
            {
                if (free)
                {
                    iSDL_free(ptr);
                }
            }
        }

        internal static byte[] SDL_StringToUtf8(string value)
        {
            return Encoding.UTF8.GetBytes((value ?? string.Empty) + '\0');
        }
    }
}