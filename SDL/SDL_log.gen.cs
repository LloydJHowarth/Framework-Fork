using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_LogCategory
    {
        SDL_LOG_CATEGORY_APPLICATION,
        SDL_LOG_CATEGORY_ERROR,
        SDL_LOG_CATEGORY_ASSERT,
        SDL_LOG_CATEGORY_SYSTEM,
        SDL_LOG_CATEGORY_AUDIO,
        SDL_LOG_CATEGORY_VIDEO,
        SDL_LOG_CATEGORY_RENDER,
        SDL_LOG_CATEGORY_INPUT,
        SDL_LOG_CATEGORY_TEST,
        SDL_LOG_CATEGORY_GPU,
        SDL_LOG_CATEGORY_RESERVED2,
        SDL_LOG_CATEGORY_RESERVED3,
        SDL_LOG_CATEGORY_RESERVED4,
        SDL_LOG_CATEGORY_RESERVED5,
        SDL_LOG_CATEGORY_RESERVED6,
        SDL_LOG_CATEGORY_RESERVED7,
        SDL_LOG_CATEGORY_RESERVED8,
        SDL_LOG_CATEGORY_RESERVED9,
        SDL_LOG_CATEGORY_RESERVED10,
        SDL_LOG_CATEGORY_CUSTOM,
    }

    internal enum SDL_LogPriority
    {
        SDL_LOG_PRIORITY_INVALID,
        SDL_LOG_PRIORITY_TRACE,
        SDL_LOG_PRIORITY_VERBOSE,
        SDL_LOG_PRIORITY_DEBUG,
        SDL_LOG_PRIORITY_INFO,
        SDL_LOG_PRIORITY_WARN,
        SDL_LOG_PRIORITY_ERROR,
        SDL_LOG_PRIORITY_CRITICAL,
        SDL_LOG_PRIORITY_COUNT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_LogOutputFunction(void* userdata, int category, SDL_LogPriority priority, [NativeTypeName("const char *")] byte* message);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorities", ExactSpelling = true)]
        private static extern void iSDL_SetLogPriorities(SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriority", ExactSpelling = true)]
        private static extern void iSDL_SetLogPriority(int category, SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogPriority", ExactSpelling = true)]
        private static extern SDL_LogPriority iSDL_GetLogPriority(int category);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetLogPriorities", ExactSpelling = true)]
        private static extern void iSDL_ResetLogPriorities();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorityPrefix", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetLogPriorityPrefix(SDL_LogPriority priority, [NativeTypeName("const char *")] byte* prefix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Log", ExactSpelling = true)]
        private static extern void iSDL_Log([NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogTrace", ExactSpelling = true)]
        private static extern void iSDL_LogTrace(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogVerbose", ExactSpelling = true)]
        private static extern void iSDL_LogVerbose(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogDebug", ExactSpelling = true)]
        private static extern void iSDL_LogDebug(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogInfo", ExactSpelling = true)]
        private static extern void iSDL_LogInfo(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogWarn", ExactSpelling = true)]
        private static extern void iSDL_LogWarn(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogError", ExactSpelling = true)]
        private static extern void iSDL_LogError(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogCritical", ExactSpelling = true)]
        private static extern void iSDL_LogCritical(int category, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessage", ExactSpelling = true)]
        private static extern void iSDL_LogMessage(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessageV", ExactSpelling = true)]
        private static extern void iSDL_LogMessageV(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultLogOutputFunction", ExactSpelling = true)]
        [return: NativeTypeName("SDL_LogOutputFunction")]
        private static extern IntPtr iSDL_GetDefaultLogOutputFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogOutputFunction", ExactSpelling = true)]
        private static extern void iSDL_GetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction *")] IntPtr* callback, void** userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogOutputFunction", ExactSpelling = true)]
        private static extern void iSDL_SetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction")] IntPtr callback, void* userdata);
    }
}
