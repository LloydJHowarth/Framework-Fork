using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AsyncIO* SDL_AsyncIOFromFile(byte* file, byte* mode)
        {
            return iSDL_AsyncIOFromFile(file, mode);
        }

        public static long SDL_GetAsyncIOSize(SDL_AsyncIO* asyncio)
        {
            return iSDL_GetAsyncIOSize(asyncio);
        }

        public static SDL_Bool SDL_ReadAsyncIO(SDL_AsyncIO* asyncio, void* ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, void* userdata)
        {
            return iSDL_ReadAsyncIO(asyncio, ptr, offset, size, queue, userdata);
        }

        public static SDL_Bool SDL_WriteAsyncIO(SDL_AsyncIO* asyncio, void* ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, void* userdata)
        {
            return iSDL_WriteAsyncIO(asyncio, ptr, offset, size, queue, userdata);
        }

        public static SDL_Bool SDL_CloseAsyncIO(SDL_AsyncIO* asyncio, SDL_Bool flush, SDL_AsyncIOQueue* queue, void* userdata)
        {
            return iSDL_CloseAsyncIO(asyncio, flush, queue, userdata);
        }

        public static SDL_AsyncIOQueue* SDL_CreateAsyncIOQueue()
        {
            return iSDL_CreateAsyncIOQueue();
        }

        public static void SDL_DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue)
        {
            iSDL_DestroyAsyncIOQueue(queue);
        }

        public static SDL_Bool SDL_GetAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome)
        {
            return iSDL_GetAsyncIOResult(queue, outcome);
        }

        public static SDL_Bool SDL_WaitAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome, int timeoutMS)
        {
            return iSDL_WaitAsyncIOResult(queue, outcome, timeoutMS);
        }

        public static void SDL_SignalAsyncIOQueue(SDL_AsyncIOQueue* queue)
        {
            iSDL_SignalAsyncIOQueue(queue);
        }

        public static SDL_Bool SDL_LoadFileAsync(byte* file, SDL_AsyncIOQueue* queue, void* userdata)
        {
            return iSDL_LoadFileAsync(file, queue, userdata);
        }
    }
}