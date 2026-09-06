using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_alignment_test
    {
        [NativeTypeName("Uint8")]
        public byte a;

        public void* b;
    }

    internal enum SDL_DUMMY_ENUM
    {
        DUMMY_ENUM_VALUE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void* SDL_malloc_func([NativeTypeName("size_t")] nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void* SDL_calloc_func([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void* SDL_realloc_func(void* mem, [NativeTypeName("size_t")] nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_free_func(void* mem);

    internal partial struct SDL_Environment
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int SDL_CompareCallback([NativeTypeName("const void *")] void* a, [NativeTypeName("const void *")] void* b);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int SDL_CompareCallback_r(void* userdata, [NativeTypeName("const void *")] void* a, [NativeTypeName("const void *")] void* b);

    internal partial struct SDL_iconv_data_t
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_FunctionPointer();

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_malloc", ExactSpelling = true)]
        private static extern void* iSDL_malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_calloc", ExactSpelling = true)]
        private static extern void* iSDL_calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_realloc", ExactSpelling = true)]
        private static extern void* iSDL_realloc(void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_free", ExactSpelling = true)]
        private static extern void iSDL_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
        private static extern void iSDL_GetOriginalMemoryFunctions([NativeTypeName("SDL_malloc_func *")] IntPtr* malloc_func, [NativeTypeName("SDL_calloc_func *")] IntPtr* calloc_func, [NativeTypeName("SDL_realloc_func *")] IntPtr* realloc_func, [NativeTypeName("SDL_free_func *")] IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
        private static extern void iSDL_GetMemoryFunctions([NativeTypeName("SDL_malloc_func *")] IntPtr* malloc_func, [NativeTypeName("SDL_calloc_func *")] IntPtr* calloc_func, [NativeTypeName("SDL_realloc_func *")] IntPtr* realloc_func, [NativeTypeName("SDL_free_func *")] IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] IntPtr malloc_func, [NativeTypeName("SDL_calloc_func")] IntPtr calloc_func, [NativeTypeName("SDL_realloc_func")] IntPtr realloc_func, [NativeTypeName("SDL_free_func")] IntPtr free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
        private static extern void* iSDL_aligned_alloc([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc_zero", ExactSpelling = true)]
        private static extern void* iSDL_aligned_alloc_zero([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
        private static extern void iSDL_aligned_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
        private static extern int iSDL_GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
        private static extern SDL_Environment* iSDL_GetEnvironment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
        private static extern SDL_Environment* iSDL_CreateEnvironment([NativeTypeName("bool")] SDL_Bool populated);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        private static extern byte** iSDL_GetEnvironmentVariables(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, [NativeTypeName("bool")] SDL_Bool overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UnsetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyEnvironment", ExactSpelling = true)]
        private static extern void iSDL_DestroyEnvironment(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_getenv([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv_unsafe", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_getenv_unsafe([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_setenv_unsafe", ExactSpelling = true)]
        private static extern int iSDL_setenv_unsafe([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_unsetenv_unsafe", ExactSpelling = true)]
        private static extern int iSDL_unsetenv_unsafe([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort", ExactSpelling = true)]
        private static extern void iSDL_qsort(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback")] IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
        private static extern void* iSDL_bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback")] IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort_r", ExactSpelling = true)]
        private static extern void iSDL_qsort_r(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback_r")] IntPtr compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch_r", ExactSpelling = true)]
        private static extern void* iSDL_bsearch_r([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback_r")] IntPtr compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_abs", ExactSpelling = true)]
        private static extern int iSDL_abs(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalpha", ExactSpelling = true)]
        private static extern int iSDL_isalpha(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalnum", ExactSpelling = true)]
        private static extern int iSDL_isalnum(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isblank", ExactSpelling = true)]
        private static extern int iSDL_isblank(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iscntrl", ExactSpelling = true)]
        private static extern int iSDL_iscntrl(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isdigit", ExactSpelling = true)]
        private static extern int iSDL_isdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isxdigit", ExactSpelling = true)]
        private static extern int iSDL_isxdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ispunct", ExactSpelling = true)]
        private static extern int iSDL_ispunct(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isspace", ExactSpelling = true)]
        private static extern int iSDL_isspace(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isupper", ExactSpelling = true)]
        private static extern int iSDL_isupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_islower", ExactSpelling = true)]
        private static extern int iSDL_islower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isprint", ExactSpelling = true)]
        private static extern int iSDL_isprint(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isgraph", ExactSpelling = true)]
        private static extern int iSDL_isgraph(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_toupper", ExactSpelling = true)]
        private static extern int iSDL_toupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tolower", ExactSpelling = true)]
        private static extern int iSDL_tolower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc16", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        private static extern ushort iSDL_crc16([NativeTypeName("Uint16")] ushort crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_crc32([NativeTypeName("Uint32")] uint crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_murmur3_32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_murmur3_32([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len, [NativeTypeName("Uint32")] uint seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset4", ExactSpelling = true)]
        private static extern void* iSDL_memset4(void* dst, [NativeTypeName("Uint32")] uint val, [NativeTypeName("size_t")] nuint dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
        private static extern int iSDL_memcmp([NativeTypeName("const void *")] void* s1, [NativeTypeName("const void *")] void* s2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_wcslen([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_wcsnlen([NativeTypeName("const wchar_t *")] ushort* wstr, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_wcslcpy([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_wcslcat([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        private static extern ushort* iSDL_wcsdup([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        private static extern ushort* iSDL_wcsstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnstr", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        private static extern ushort* iSDL_wcsnstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
        private static extern int iSDL_wcscmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
        private static extern int iSDL_wcsncmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
        private static extern int iSDL_wcscasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
        private static extern int iSDL_wcsncasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstol", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        private static extern int iSDL_wcstol([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoul", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        private static extern uint iSDL_wcstoul([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoll", ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        private static extern long iSDL_wcstoll([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoull", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        private static extern ulong iSDL_wcstoull([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_strlen([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_strnlen([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_strlcpy([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_utf8strlcpy([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_strlcat([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strdup", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strdup([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strndup", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strndup([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrev", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strrev([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strupr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strupr([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strlwr([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strchr([NativeTypeName("const char *")] byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strrchr([NativeTypeName("const char *")] byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strstr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strstr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnstr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strnstr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strcasestr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtok_r", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strtok_r([NativeTypeName("char *")] byte* str, [NativeTypeName("const char *")] byte* delim, [NativeTypeName("char **")] byte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_utf8strlen([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_utf8strnlen([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_itoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_itoa(int value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_uitoa([NativeTypeName("unsigned int")] uint value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_ltoa([NativeTypeName("long")] int value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_ultoa([NativeTypeName("unsigned long")] uint value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_lltoa([NativeTypeName("long long")] long value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_ulltoa([NativeTypeName("unsigned long long")] ulong value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atoi", ExactSpelling = true)]
        private static extern int iSDL_atoi([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atof", ExactSpelling = true)]
        private static extern double iSDL_atof([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtol", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        private static extern int iSDL_strtol([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        private static extern uint iSDL_strtoul([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        private static extern long iSDL_strtoll([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        private static extern ulong iSDL_strtoull([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtod", ExactSpelling = true)]
        private static extern double iSDL_strtod([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
        private static extern int iSDL_strcmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
        private static extern int iSDL_strncmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
        private static extern int iSDL_strcasecmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
        private static extern int iSDL_strncasecmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strpbrk", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_strpbrk([NativeTypeName("const char *")] byte* str, [NativeTypeName("const char *")] byte* breakset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepUTF8", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_StepUTF8([NativeTypeName("const char **")] byte** pstr, [NativeTypeName("size_t *")] nuint* pslen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepBackUTF8", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_StepBackUTF8([NativeTypeName("const char *")] byte* start, [NativeTypeName("const char **")] byte** pstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UCS4ToUTF8", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_UCS4ToUTF8([NativeTypeName("Uint32")] uint codepoint, [NativeTypeName("char *")] byte* dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
        private static extern int iSDL_sscanf([NativeTypeName("const char *")] byte* text, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsscanf", ExactSpelling = true)]
        private static extern int iSDL_vsscanf([NativeTypeName("const char *")] byte* text, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
        private static extern int iSDL_snprintf([NativeTypeName("char *")] byte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_swprintf", ExactSpelling = true)]
        private static extern int iSDL_swprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsnprintf", ExactSpelling = true)]
        private static extern int iSDL_vsnprintf([NativeTypeName("char *")] byte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vswprintf", ExactSpelling = true)]
        private static extern int iSDL_vswprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
        private static extern int iSDL_asprintf([NativeTypeName("char **")] byte** strp, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vasprintf", ExactSpelling = true)]
        private static extern int iSDL_vasprintf([NativeTypeName("char **")] byte** strp, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_srand", ExactSpelling = true)]
        private static extern void iSDL_srand([NativeTypeName("Uint64")] ulong seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand", ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        private static extern int iSDL_rand([NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf", ExactSpelling = true)]
        private static extern float iSDL_randf();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_rand_bits();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_r", ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        private static extern int iSDL_rand_r([NativeTypeName("Uint64 *")] ulong* state, [NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf_r", ExactSpelling = true)]
        private static extern float iSDL_randf_r([NativeTypeName("Uint64 *")] ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits_r", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_rand_bits_r([NativeTypeName("Uint64 *")] ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acos", ExactSpelling = true)]
        private static extern double iSDL_acos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acosf", ExactSpelling = true)]
        private static extern float iSDL_acosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asin", ExactSpelling = true)]
        private static extern double iSDL_asin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asinf", ExactSpelling = true)]
        private static extern float iSDL_asinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan", ExactSpelling = true)]
        private static extern double iSDL_atan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atanf", ExactSpelling = true)]
        private static extern float iSDL_atanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2", ExactSpelling = true)]
        private static extern double iSDL_atan2(double y, double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2f", ExactSpelling = true)]
        private static extern float iSDL_atan2f(float y, float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceil", ExactSpelling = true)]
        private static extern double iSDL_ceil(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceilf", ExactSpelling = true)]
        private static extern float iSDL_ceilf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysign", ExactSpelling = true)]
        private static extern double iSDL_copysign(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysignf", ExactSpelling = true)]
        private static extern float iSDL_copysignf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cos", ExactSpelling = true)]
        private static extern double iSDL_cos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cosf", ExactSpelling = true)]
        private static extern float iSDL_cosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_exp", ExactSpelling = true)]
        private static extern double iSDL_exp(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_expf", ExactSpelling = true)]
        private static extern float iSDL_expf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabs", ExactSpelling = true)]
        private static extern double iSDL_fabs(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabsf", ExactSpelling = true)]
        private static extern float iSDL_fabsf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floor", ExactSpelling = true)]
        private static extern double iSDL_floor(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floorf", ExactSpelling = true)]
        private static extern float iSDL_floorf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_trunc", ExactSpelling = true)]
        private static extern double iSDL_trunc(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_truncf", ExactSpelling = true)]
        private static extern float iSDL_truncf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmod", ExactSpelling = true)]
        private static extern double iSDL_fmod(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmodf", ExactSpelling = true)]
        private static extern float iSDL_fmodf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinf", ExactSpelling = true)]
        private static extern int iSDL_isinf(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinff", ExactSpelling = true)]
        private static extern int iSDL_isinff(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnan", ExactSpelling = true)]
        private static extern int iSDL_isnan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnanf", ExactSpelling = true)]
        private static extern int iSDL_isnanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log", ExactSpelling = true)]
        private static extern double iSDL_log(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_logf", ExactSpelling = true)]
        private static extern float iSDL_logf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10", ExactSpelling = true)]
        private static extern double iSDL_log10(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10f", ExactSpelling = true)]
        private static extern float iSDL_log10f(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modf", ExactSpelling = true)]
        private static extern double iSDL_modf(double x, double* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modff", ExactSpelling = true)]
        private static extern float iSDL_modff(float x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_pow", ExactSpelling = true)]
        private static extern double iSDL_pow(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_powf", ExactSpelling = true)]
        private static extern float iSDL_powf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_round", ExactSpelling = true)]
        private static extern double iSDL_round(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_roundf", ExactSpelling = true)]
        private static extern float iSDL_roundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lround", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        private static extern int iSDL_lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        private static extern int iSDL_lroundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbn", ExactSpelling = true)]
        private static extern double iSDL_scalbn(double x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbnf", ExactSpelling = true)]
        private static extern float iSDL_scalbnf(float x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sin", ExactSpelling = true)]
        private static extern double iSDL_sin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sinf", ExactSpelling = true)]
        private static extern float iSDL_sinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrt", ExactSpelling = true)]
        private static extern double iSDL_sqrt(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrtf", ExactSpelling = true)]
        private static extern float iSDL_sqrtf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tan", ExactSpelling = true)]
        private static extern double iSDL_tan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tanf", ExactSpelling = true)]
        private static extern float iSDL_tanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_open", ExactSpelling = true)]
        [return: NativeTypeName("SDL_iconv_t")]
        private static extern SDL_iconv_data_t* iSDL_iconv_open([NativeTypeName("const char *")] byte* tocode, [NativeTypeName("const char *")] byte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
        private static extern int iSDL_iconv_close([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        private static extern nuint iSDL_iconv([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd, [NativeTypeName("const char **")] byte** inbuf, [NativeTypeName("size_t *")] nuint* inbytesleft, [NativeTypeName("char **")] byte** outbuf, [NativeTypeName("size_t *")] nuint* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        private static extern byte* iSDL_iconv_string([NativeTypeName("const char *")] byte* tocode, [NativeTypeName("const char *")] byte* fromcode, [NativeTypeName("const char *")] byte* inbuf, [NativeTypeName("size_t")] nuint inbytesleft);

        [NativeTypeName("#define SDL_SIZE_MAX SIZE_MAX")]
        public const ulong SDL_SIZE_MAX = 0xffffffffffffffffUL;

        [NativeTypeName("#define SDL_MAX_SINT8 ((Sint8)0x7F)")]
        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        [NativeTypeName("#define SDL_MIN_SINT8 ((Sint8)(~0x7F))")]
        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        [NativeTypeName("#define SDL_MAX_UINT8 ((Uint8)0xFF)")]
        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        [NativeTypeName("#define SDL_MIN_UINT8 ((Uint8)0x00)")]
        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        [NativeTypeName("#define SDL_MAX_SINT16 ((Sint16)0x7FFF)")]
        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        [NativeTypeName("#define SDL_MIN_SINT16 ((Sint16)(~0x7FFF))")]
        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        [NativeTypeName("#define SDL_MAX_UINT16 ((Uint16)0xFFFF)")]
        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        [NativeTypeName("#define SDL_MIN_UINT16 ((Uint16)0x0000)")]
        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        [NativeTypeName("#define SDL_MAX_SINT32 ((Sint32)0x7FFFFFFF)")]
        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        [NativeTypeName("#define SDL_MIN_SINT32 ((Sint32)(~0x7FFFFFFF))")]
        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        [NativeTypeName("#define SDL_MAX_UINT32 ((Uint32)0xFFFFFFFFu)")]
        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_MIN_UINT32 ((Uint32)0x00000000)")]
        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));

        [NativeTypeName("#define SDL_MAX_SINT64 SDL_SINT64_C(0x7FFFFFFFFFFFFFFF)")]
        public const long SDL_MAX_SINT64 = (0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MIN_SINT64 ~SDL_SINT64_C(0x7FFFFFFFFFFFFFFF)")]
        public const long SDL_MIN_SINT64 = ~(0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MAX_UINT64 SDL_UINT64_C(0xFFFFFFFFFFFFFFFF)")]
        public const ulong SDL_MAX_UINT64 = (0xFFFFFFFFFFFFFFFFUL);

        [NativeTypeName("#define SDL_MIN_UINT64 SDL_UINT64_C(0x0000000000000000)")]
        public const ulong SDL_MIN_UINT64 = (0x0000000000000000UL);

        [NativeTypeName("#define SDL_MAX_TIME SDL_MAX_SINT64")]
        public const long SDL_MAX_TIME = (0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MIN_TIME SDL_MIN_SINT64")]
        public const long SDL_MIN_TIME = ~(0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_FLT_EPSILON 1.1920928955078125e-07F")]
        public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

        [NativeTypeName("#define SDL_PRIs64 \"lld\"")]
        public static string SDL_PRIs64 => "lld";

        [NativeTypeName("#define SDL_PRIu64 \"llu\"")]
        public static string SDL_PRIu64 => "llu";

        [NativeTypeName("#define SDL_PRIx64 \"llx\"")]
        public static string SDL_PRIx64 => "llx";

        [NativeTypeName("#define SDL_PRIX64 \"llX\"")]
        public static string SDL_PRIX64 => "llX";

        [NativeTypeName("#define SDL_PRIs32 \"d\"")]
        public static string SDL_PRIs32 => "d";

        [NativeTypeName("#define SDL_PRIu32 \"u\"")]
        public static string SDL_PRIu32 => "u";

        [NativeTypeName("#define SDL_PRIx32 \"x\"")]
        public static string SDL_PRIx32 => "x";

        [NativeTypeName("#define SDL_PRIX32 \"X\"")]
        public static string SDL_PRIX32 => "X";

        [NativeTypeName("#define SDL_PRILL_PREFIX \"ll\"")]
        public static string SDL_PRILL_PREFIX => "ll";

        [NativeTypeName("#define SDL_PRILLd SDL_PRILL_PREFIX \"d\"")]
        public static string SDL_PRILLd => "lld";

        [NativeTypeName("#define SDL_PRILLu SDL_PRILL_PREFIX \"u\"")]
        public static string SDL_PRILLu => "llu";

        [NativeTypeName("#define SDL_PRILLx SDL_PRILL_PREFIX \"x\"")]
        public static string SDL_PRILLx => "llx";

        [NativeTypeName("#define SDL_PRILLX SDL_PRILL_PREFIX \"X\"")]
        public static string SDL_PRILLX => "llX";

        [NativeTypeName("#define SDL_PRISZ_PREFIX \"I64\"")]
        public static string SDL_PRISZ_PREFIX => "I64";

        [NativeTypeName("#define SDL_PRISZu SDL_PRISZ_PREFIX \"u\"")]
        public static string SDL_PRISZu => "I64u";

        [NativeTypeName("#define SDL_PRISZx SDL_PRISZ_PREFIX \"x\"")]
        public static string SDL_PRISZx => "I64x";

        [NativeTypeName("#define SDL_PRISZX SDL_PRISZ_PREFIX \"X\"")]
        public static string SDL_PRISZX => "I64X";

        [NativeTypeName("#define SDL_INVALID_UNICODE_CODEPOINT 0xFFFD")]
        public const int SDL_INVALID_UNICODE_CODEPOINT = 0xFFFD;

        [NativeTypeName("#define SDL_PI_D 3.141592653589793238462643383279502884")]
        public const double SDL_PI_D = 3.141592653589793238462643383279502884;

        [NativeTypeName("#define SDL_PI_F 3.141592653589793238462643383279502884F")]
        public const float SDL_PI_F = 3.141592653589793238462643383279502884F;

        [NativeTypeName("#define SDL_ICONV_ERROR (size_t)-1")]
        public static readonly nuint SDL_ICONV_ERROR = unchecked((nuint)(-1));

        [NativeTypeName("#define SDL_ICONV_E2BIG (size_t)-2")]
        public static readonly nuint SDL_ICONV_E2BIG = unchecked((nuint)(-2));

        [NativeTypeName("#define SDL_ICONV_EILSEQ (size_t)-3")]
        public static readonly nuint SDL_ICONV_EILSEQ = unchecked((nuint)(-3));

        [NativeTypeName("#define SDL_ICONV_EINVAL (size_t)-4")]
        public static readonly nuint SDL_ICONV_EINVAL = unchecked((nuint)(-4));
    }
}
