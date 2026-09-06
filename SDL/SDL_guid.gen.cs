using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_GUID
    {
        [NativeTypeName("Uint8[16]")]
        public _data_e__FixedBuffer data;

        [InlineArray(16)]
        public partial struct _data_e__FixedBuffer
        {
            public byte e0;
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
        private static extern void iSDL_GUIDToString(SDL_GUID guid, [NativeTypeName("char *")] byte* pszGUID, int cbGUID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StringToGUID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_StringToGUID([NativeTypeName("const char *")] byte* pchGUID);
    }
}
