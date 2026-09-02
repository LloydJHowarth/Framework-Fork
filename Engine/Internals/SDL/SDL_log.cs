using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static void SDL_SetLogPriorities(SDL_LogPriority priority)
        {
            iSDL_SetLogPriorities(priority);
        }

        internal static void SDL_SetLogPriority(int category, SDL_LogPriority priority)
        {
            iSDL_SetLogPriority(category, priority);
        }

        internal static SDL_LogPriority SDL_GetLogPriority(int category)
        {
            return iSDL_GetLogPriority(category);
        }

        internal static void SDL_ResetLogPriorities()
        {
            iSDL_ResetLogPriorities();
        }

        internal static SDL_Bool SDL_SetLogPriorityPrefix(SDL_LogPriority priority, byte* prefix)
        {
            return iSDL_SetLogPriorityPrefix(priority, prefix);
        }

        internal static void SDL_Log(byte* fmt)
        {
            iSDL_Log(fmt);
        }

        internal static void SDL_LogTrace(int category, byte* fmt)
        {
            iSDL_LogTrace(category, fmt);
        }

        internal static void SDL_LogVerbose(int category, byte* fmt)
        {
            iSDL_LogVerbose(category, fmt);
        }

        internal static void SDL_LogDebug(int category, byte* fmt)
        {
            iSDL_LogDebug(category, fmt);
        }

        internal static void SDL_LogInfo(int category, byte* fmt)
        {
            iSDL_LogInfo(category, fmt);
        }

        internal static void SDL_LogWarn(int category, byte* fmt)
        {
            iSDL_LogWarn(category, fmt);
        }

        internal static void SDL_LogError(int category, byte* fmt)
        {
            iSDL_LogError(category, fmt);
        }

        internal static void SDL_LogCritical(int category, byte* fmt)
        {
            iSDL_LogCritical(category, fmt);
        }

        internal static void SDL_LogMessage(int category, SDL_LogPriority priority, byte* fmt)
        {
            iSDL_LogMessage(category, priority, fmt);
        }

        internal static void SDL_LogMessageV(int category, SDL_LogPriority priority, byte* fmt, byte* ap)
        {
            iSDL_LogMessageV(category, priority, fmt, ap);
        }

        internal static IntPtr SDL_GetDefaultLogOutputFunction()
        {
            return iSDL_GetDefaultLogOutputFunction();
        }

        internal static void SDL_GetLogOutputFunction(IntPtr* callback, void** userdata)
        {
            iSDL_GetLogOutputFunction(callback, userdata);
        }

        internal static void SDL_SetLogOutputFunction(IntPtr callback, void* userdata)
        {
            iSDL_SetLogOutputFunction(callback, userdata);
        }
    }
}