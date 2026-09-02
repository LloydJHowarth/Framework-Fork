using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Mutex* SDL_CreateMutex()
        {
            return iSDL_CreateMutex();
        }

        internal static void SDL_LockMutex(SDL_Mutex* mutex)
        {
            iSDL_LockMutex(mutex);
        }

        internal static SDL_Bool SDL_TryLockMutex(SDL_Mutex* mutex)
        {
            return iSDL_TryLockMutex(mutex);
        }

        internal static void SDL_UnlockMutex(SDL_Mutex* mutex)
        {
            iSDL_UnlockMutex(mutex);
        }

        internal static void SDL_DestroyMutex(SDL_Mutex* mutex)
        {
            iSDL_DestroyMutex(mutex);
        }

        internal static SDL_RWLock* SDL_CreateRWLock()
        {
            return iSDL_CreateRWLock();
        }

        internal static void SDL_LockRWLockForReading(SDL_RWLock* rwlock)
        {
            iSDL_LockRWLockForReading(rwlock);
        }

        internal static void SDL_LockRWLockForWriting(SDL_RWLock* rwlock)
        {
            iSDL_LockRWLockForWriting(rwlock);
        }

        internal static SDL_Bool SDL_TryLockRWLockForReading(SDL_RWLock* rwlock)
        {
            return iSDL_TryLockRWLockForReading(rwlock);
        }

        internal static SDL_Bool SDL_TryLockRWLockForWriting(SDL_RWLock* rwlock)
        {
            return iSDL_TryLockRWLockForWriting(rwlock);
        }

        internal static void SDL_UnlockRWLock(SDL_RWLock* rwlock)
        {
            iSDL_UnlockRWLock(rwlock);
        }

        internal static void SDL_DestroyRWLock(SDL_RWLock* rwlock)
        {
            iSDL_DestroyRWLock(rwlock);
        }

        internal static SDL_Semaphore* SDL_CreateSemaphore(uint initial_value)
        {
            return iSDL_CreateSemaphore(initial_value);
        }

        internal static void SDL_DestroySemaphore(SDL_Semaphore* sem)
        {
            iSDL_DestroySemaphore(sem);
        }

        internal static void SDL_WaitSemaphore(SDL_Semaphore* sem)
        {
            iSDL_WaitSemaphore(sem);
        }

        internal static SDL_Bool SDL_TryWaitSemaphore(SDL_Semaphore* sem)
        {
            return iSDL_TryWaitSemaphore(sem);
        }

        internal static SDL_Bool SDL_WaitSemaphoreTimeout(SDL_Semaphore* sem, int timeoutMS)
        {
            return iSDL_WaitSemaphoreTimeout(sem, timeoutMS);
        }

        internal static void SDL_SignalSemaphore(SDL_Semaphore* sem)
        {
            iSDL_SignalSemaphore(sem);
        }

        internal static uint SDL_GetSemaphoreValue(SDL_Semaphore* sem)
        {
            return iSDL_GetSemaphoreValue(sem);
        }

        internal static SDL_Condition* SDL_CreateCondition()
        {
            return iSDL_CreateCondition();
        }

        internal static void SDL_DestroyCondition(SDL_Condition* cond)
        {
            iSDL_DestroyCondition(cond);
        }

        internal static void SDL_SignalCondition(SDL_Condition* cond)
        {
            iSDL_SignalCondition(cond);
        }

        internal static void SDL_BroadcastCondition(SDL_Condition* cond)
        {
            iSDL_BroadcastCondition(cond);
        }

        internal static void SDL_WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex)
        {
            iSDL_WaitCondition(cond, mutex);
        }

        internal static SDL_Bool SDL_WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, int timeoutMS)
        {
            return iSDL_WaitConditionTimeout(cond, mutex, timeoutMS);
        }

        internal static SDL_Bool SDL_ShouldInit(SDL_InitState* state)
        {
            return iSDL_ShouldInit(state);
        }

        internal static SDL_Bool SDL_ShouldQuit(SDL_InitState* state)
        {
            return iSDL_ShouldQuit(state);
        }

        internal static void SDL_SetInitialized(SDL_InitState* state, SDL_Bool initialized)
        {
            iSDL_SetInitialized(state, initialized);
        }
    }
}