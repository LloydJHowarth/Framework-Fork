using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static string SDL_Utf8ToString(byte* ptr, bool free = false)
        {
            string text = Marshal.PtrToStringUTF8((IntPtr)ptr);
        
            if (free)
            {
                SDL.SDL_free(ptr);
            }
        
            return text ?? "";
        }
    
        public static byte[] SDL_StringToUtf8(string data)
        {
            if (data == null || data.Length <= 0)
            {
                return Array.Empty<byte>();
            }
        
            return System.Text.Encoding.UTF8.GetBytes(data + '\0');
        }
    }
}