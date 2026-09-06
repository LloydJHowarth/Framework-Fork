using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_AssertState
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }

    internal unsafe partial struct SDL_AssertData
    {
        [NativeTypeName("bool")]
        public SDL_Bool always_ignore;

        [NativeTypeName("unsigned int")]
        public uint trigger_count;

        [NativeTypeName("const char *")]
        public byte* condition;

        [NativeTypeName("const char *")]
        public byte* filename;

        public int linenum;

        [NativeTypeName("const char *")]
        public byte* function;

        [NativeTypeName("const struct SDL_AssertData *")]
        public SDL_AssertData* next;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AssertState SDL_AssertionHandler([NativeTypeName("const SDL_AssertData *")] SDL_AssertData* data, void* userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
        private static extern SDL_AssertState iSDL_ReportAssertion(SDL_AssertData* data, [NativeTypeName("const char *")] byte* func, [NativeTypeName("const char *")] byte* file, int line);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
        private static extern void iSDL_SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] IntPtr handler, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        private static extern IntPtr iSDL_GetDefaultAssertionHandler();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        private static extern IntPtr iSDL_GetAssertionHandler(void** puserdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_AssertData *")]
        private static extern SDL_AssertData* iSDL_GetAssertionReport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
        private static extern void iSDL_ResetAssertionReport();

        [NativeTypeName("#define SDL_ASSERT_LEVEL 1")]
        public const int SDL_ASSERT_LEVEL = 1;

        [NativeTypeName("#define SDL_FILE __FILE_NAME__")]
        public static string SDL_FILE => "SDL_assert.h";

        [NativeTypeName("#define SDL_ASSERT_FILE SDL_FILE")]
        public static string SDL_ASSERT_FILE => "SDL_assert.h";

        [NativeTypeName("#define SDL_LINE __LINE__")]
        public const int SDL_LINE = 713;

        [NativeTypeName("#define SDL_NULL_WHILE_LOOP_CONDITION (0)")]
        public const int SDL_NULL_WHILE_LOOP_CONDITION = (0);
    }
}
