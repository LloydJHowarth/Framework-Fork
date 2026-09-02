using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Thread* SDL_CreateThreadRuntime(IntPtr fn, byte* name, void* data, IntPtr pfnBeginThread, IntPtr pfnEndThread)
        {
            return iSDL_CreateThreadRuntime(fn, name, data, pfnBeginThread, pfnEndThread);
        }

        public static SDL_Thread* SDL_CreateThreadWithPropertiesRuntime(uint props, IntPtr pfnBeginThread, IntPtr pfnEndThread)
        {
            return iSDL_CreateThreadWithPropertiesRuntime(props, pfnBeginThread, pfnEndThread);
        }

        public static byte* SDL_GetThreadName(SDL_Thread* thread)
        {
            return iSDL_GetThreadName(thread);
        }

        public static ulong SDL_GetCurrentThreadID()
        {
            return iSDL_GetCurrentThreadID();
        }

        public static ulong SDL_GetThreadID(SDL_Thread* thread)
        {
            return iSDL_GetThreadID(thread);
        }

        public static SDL_Bool SDL_SetCurrentThreadPriority(SDL_ThreadPriority priority)
        {
            return iSDL_SetCurrentThreadPriority(priority);
        }

        public static void SDL_WaitThread(SDL_Thread* thread, int* status)
        {
            iSDL_WaitThread(thread, status);
        }

        public static SDL_ThreadState SDL_GetThreadState(SDL_Thread* thread)
        {
            return iSDL_GetThreadState(thread);
        }

        public static void SDL_DetachThread(SDL_Thread* thread)
        {
            iSDL_DetachThread(thread);
        }

        public static void* SDL_GetTLS(SDL_AtomicInt* id)
        {
            return iSDL_GetTLS(id);
        }

        public static SDL_Bool SDL_SetTLS(SDL_AtomicInt* id, void* value, IntPtr destructor)
        {
            return iSDL_SetTLS(id, value, destructor);
        }

        public static void SDL_CleanupTLS()
        {
            iSDL_CleanupTLS();
        }
    }
}