using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Mutex* SDL_CreateMutex()
        {
            return iSDL_CreateMutex();
        }

        public static void SDL_LockMutex(SDL_Mutex* mutex)
        {
            iSDL_LockMutex(mutex);
        }

        public static SDL_Bool SDL_TryLockMutex(SDL_Mutex* mutex)
        {
            return iSDL_TryLockMutex(mutex);
        }

        public static void SDL_UnlockMutex(SDL_Mutex* mutex)
        {
            iSDL_UnlockMutex(mutex);
        }

        public static void SDL_DestroyMutex(SDL_Mutex* mutex)
        {
            iSDL_DestroyMutex(mutex);
        }

        public static SDL_RWLock* SDL_CreateRWLock()
        {
            return iSDL_CreateRWLock();
        }

        public static void SDL_LockRWLockForReading(SDL_RWLock* rwlock)
        {
            iSDL_LockRWLockForReading(rwlock);
        }

        public static void SDL_LockRWLockForWriting(SDL_RWLock* rwlock)
        {
            iSDL_LockRWLockForWriting(rwlock);
        }

        public static SDL_Bool SDL_TryLockRWLockForReading(SDL_RWLock* rwlock)
        {
            return iSDL_TryLockRWLockForReading(rwlock);
        }

        public static SDL_Bool SDL_TryLockRWLockForWriting(SDL_RWLock* rwlock)
        {
            return iSDL_TryLockRWLockForWriting(rwlock);
        }

        public static void SDL_UnlockRWLock(SDL_RWLock* rwlock)
        {
            iSDL_UnlockRWLock(rwlock);
        }

        public static void SDL_DestroyRWLock(SDL_RWLock* rwlock)
        {
            iSDL_DestroyRWLock(rwlock);
        }

        public static SDL_Semaphore* SDL_CreateSemaphore(uint initial_value)
        {
            return iSDL_CreateSemaphore(initial_value);
        }

        public static void SDL_DestroySemaphore(SDL_Semaphore* sem)
        {
            iSDL_DestroySemaphore(sem);
        }

        public static void SDL_WaitSemaphore(SDL_Semaphore* sem)
        {
            iSDL_WaitSemaphore(sem);
        }

        public static SDL_Bool SDL_TryWaitSemaphore(SDL_Semaphore* sem)
        {
            return iSDL_TryWaitSemaphore(sem);
        }

        public static SDL_Bool SDL_WaitSemaphoreTimeout(SDL_Semaphore* sem, int timeoutMS)
        {
            return iSDL_WaitSemaphoreTimeout(sem, timeoutMS);
        }

        public static void SDL_SignalSemaphore(SDL_Semaphore* sem)
        {
            iSDL_SignalSemaphore(sem);
        }

        public static uint SDL_GetSemaphoreValue(SDL_Semaphore* sem)
        {
            return iSDL_GetSemaphoreValue(sem);
        }

        public static SDL_Condition* SDL_CreateCondition()
        {
            return iSDL_CreateCondition();
        }

        public static void SDL_DestroyCondition(SDL_Condition* cond)
        {
            iSDL_DestroyCondition(cond);
        }

        public static void SDL_SignalCondition(SDL_Condition* cond)
        {
            iSDL_SignalCondition(cond);
        }

        public static void SDL_BroadcastCondition(SDL_Condition* cond)
        {
            iSDL_BroadcastCondition(cond);
        }

        public static void SDL_WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex)
        {
            iSDL_WaitCondition(cond, mutex);
        }

        public static SDL_Bool SDL_WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, int timeoutMS)
        {
            return iSDL_WaitConditionTimeout(cond, mutex, timeoutMS);
        }

        public static SDL_Bool SDL_ShouldInit(SDL_InitState* state)
        {
            return iSDL_ShouldInit(state);
        }

        public static SDL_Bool SDL_ShouldQuit(SDL_InitState* state)
        {
            return iSDL_ShouldQuit(state);
        }

        public static void SDL_SetInitialized(SDL_InitState* state, SDL_Bool initialized)
        {
            iSDL_SetInitialized(state, initialized);
        }
    }
}