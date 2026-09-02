using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static SDL_Process* SDL_CreateProcess(byte** args, SDL_Bool pipe_stdio)
        {
            return iSDL_CreateProcess(args, pipe_stdio);
        }

        public static SDL_Process* SDL_CreateProcessWithProperties(uint props)
        {
            return iSDL_CreateProcessWithProperties(props);
        }

        public static uint SDL_GetProcessProperties(SDL_Process* process)
        {
            return iSDL_GetProcessProperties(process);
        }

        public static void* SDL_ReadProcess(SDL_Process* process, nuint* datasize, int* exitcode)
        {
            return iSDL_ReadProcess(process, datasize, exitcode);
        }

        public static SDL_IOStream* SDL_GetProcessInput(SDL_Process* process)
        {
            return iSDL_GetProcessInput(process);
        }

        public static SDL_IOStream* SDL_GetProcessOutput(SDL_Process* process)
        {
            return iSDL_GetProcessOutput(process);
        }

        public static SDL_Bool SDL_KillProcess(SDL_Process* process, SDL_Bool force)
        {
            return iSDL_KillProcess(process, force);
        }

        public static SDL_Bool SDL_WaitProcess(SDL_Process* process, SDL_Bool block, int* exitcode)
        {
            return iSDL_WaitProcess(process, block, exitcode);
        }

        public static void SDL_DestroyProcess(SDL_Process* process)
        {
            iSDL_DestroyProcess(process);
        }
    }
}