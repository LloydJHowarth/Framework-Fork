using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        // Missing due to ClangSharp generator
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
        private static extern void* iSDL_memcpy(void* dst, void* src, nuint len);
        public static void* SDL_memcpy(void* dst, void* src, nuint len)
        {
            return iSDL_memcpy(dst, src, len);
        }
        
        public static void* SDL_malloc(nuint size)
        {
            return iSDL_malloc(size);
        }
        
        public static void SDL_free(void* mem)
        {
            iSDL_free(mem);
        }
    }
}