using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Thread* SDL_CreateThreadRuntime(IntPtr fn, byte* name, void* data, IntPtr pfnBeginThread, IntPtr pfnEndThread)
        {
            return iSDL_CreateThreadRuntime(fn, name, data, pfnBeginThread, pfnEndThread);
        }

        internal static SDL_Thread* SDL_CreateThreadWithPropertiesRuntime(uint props, IntPtr pfnBeginThread, IntPtr pfnEndThread)
        {
            return iSDL_CreateThreadWithPropertiesRuntime(props, pfnBeginThread, pfnEndThread);
        }

        internal static byte* SDL_GetThreadName(SDL_Thread* thread)
        {
            return iSDL_GetThreadName(thread);
        }

        internal static ulong SDL_GetCurrentThreadID()
        {
            return iSDL_GetCurrentThreadID();
        }

        internal static ulong SDL_GetThreadID(SDL_Thread* thread)
        {
            return iSDL_GetThreadID(thread);
        }

        internal static SDL_Bool SDL_SetCurrentThreadPriority(SDL_ThreadPriority priority)
        {
            return iSDL_SetCurrentThreadPriority(priority);
        }

        internal static void SDL_WaitThread(SDL_Thread* thread, int* status)
        {
            iSDL_WaitThread(thread, status);
        }

        internal static SDL_ThreadState SDL_GetThreadState(SDL_Thread* thread)
        {
            return iSDL_GetThreadState(thread);
        }

        internal static void SDL_DetachThread(SDL_Thread* thread)
        {
            iSDL_DetachThread(thread);
        }

        internal static void* SDL_GetTLS(SDL_AtomicInt* id)
        {
            return iSDL_GetTLS(id);
        }

        internal static SDL_Bool SDL_SetTLS(SDL_AtomicInt* id, void* value, IntPtr destructor)
        {
            return iSDL_SetTLS(id, value, destructor);
        }

        internal static void SDL_CleanupTLS()
        {
            iSDL_CleanupTLS();
        }
    }
}