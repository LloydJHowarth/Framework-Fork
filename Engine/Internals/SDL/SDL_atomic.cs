using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Bool SDL_TryLockSpinlock(int* @lock)
        {
            return iSDL_TryLockSpinlock(@lock);
        }

        public static void SDL_LockSpinlock(int* @lock)
        {
            iSDL_LockSpinlock(@lock);
        }

        public static void SDL_UnlockSpinlock(int* @lock)
        {
            iSDL_UnlockSpinlock(@lock);
        }

        public static void SDL_MemoryBarrierReleaseFunction()
        {
            iSDL_MemoryBarrierReleaseFunction();
        }

        public static void SDL_MemoryBarrierAcquireFunction()
        {
            iSDL_MemoryBarrierAcquireFunction();
        }

        public static SDL_Bool SDL_CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval)
        {
            return iSDL_CompareAndSwapAtomicInt(a, oldval, newval);
        }

        public static int SDL_SetAtomicInt(SDL_AtomicInt* a, int v)
        {
            return iSDL_SetAtomicInt(a, v);
        }

        public static int SDL_GetAtomicInt(SDL_AtomicInt* a)
        {
            return iSDL_GetAtomicInt(a);
        }

        public static int SDL_AddAtomicInt(SDL_AtomicInt* a, int v)
        {
            return iSDL_AddAtomicInt(a, v);
        }

        public static SDL_Bool SDL_CompareAndSwapAtomicU32(SDL_AtomicU32* a, uint oldval, uint newval)
        {
            return iSDL_CompareAndSwapAtomicU32(a, oldval, newval);
        }

        public static uint SDL_SetAtomicU32(SDL_AtomicU32* a, uint v)
        {
            return iSDL_SetAtomicU32(a, v);
        }

        public static uint SDL_GetAtomicU32(SDL_AtomicU32* a)
        {
            return iSDL_GetAtomicU32(a);
        }

        public static uint SDL_AddAtomicU32(SDL_AtomicU32* a, int v)
        {
            return iSDL_AddAtomicU32(a, v);
        }

        public static SDL_Bool SDL_CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval)
        {
            return iSDL_CompareAndSwapAtomicPointer(a, oldval, newval);
        }

        public static void* SDL_SetAtomicPointer(void** a, void* v)
        {
            return iSDL_SetAtomicPointer(a, v);
        }

        public static void* SDL_GetAtomicPointer(void** a)
        {
            return iSDL_GetAtomicPointer(a);
        }
    }
}