using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_BlendOperation
    {
        SDL_BLENDOPERATION_ADD = 0x1,
        SDL_BLENDOPERATION_SUBTRACT = 0x2,
        SDL_BLENDOPERATION_REV_SUBTRACT = 0x3,
        SDL_BLENDOPERATION_MINIMUM = 0x4,
        SDL_BLENDOPERATION_MAXIMUM = 0x5,
    }

    internal enum SDL_BlendFactor
    {
        SDL_BLENDFACTOR_ZERO = 0x1,
        SDL_BLENDFACTOR_ONE = 0x2,
        SDL_BLENDFACTOR_SRC_COLOR = 0x3,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR = 0x4,
        SDL_BLENDFACTOR_SRC_ALPHA = 0x5,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = 0x6,
        SDL_BLENDFACTOR_DST_COLOR = 0x7,
        SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR = 0x8,
        SDL_BLENDFACTOR_DST_ALPHA = 0x9,
        SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA = 0xA,
    }

    internal static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("SDL_BlendMode")]
        private static extern uint iSDL_ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);

        [NativeTypeName("#define SDL_BLENDMODE_NONE 0x00000000u")]
        public const uint SDL_BLENDMODE_NONE = 0x00000000U;

        [NativeTypeName("#define SDL_BLENDMODE_BLEND 0x00000001u")]
        public const uint SDL_BLENDMODE_BLEND = 0x00000001U;

        [NativeTypeName("#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u")]
        public const uint SDL_BLENDMODE_BLEND_PREMULTIPLIED = 0x00000010U;

        [NativeTypeName("#define SDL_BLENDMODE_ADD 0x00000002u")]
        public const uint SDL_BLENDMODE_ADD = 0x00000002U;

        [NativeTypeName("#define SDL_BLENDMODE_ADD_PREMULTIPLIED 0x00000020u")]
        public const uint SDL_BLENDMODE_ADD_PREMULTIPLIED = 0x00000020U;

        [NativeTypeName("#define SDL_BLENDMODE_MOD 0x00000004u")]
        public const uint SDL_BLENDMODE_MOD = 0x00000004U;

        [NativeTypeName("#define SDL_BLENDMODE_MUL 0x00000008u")]
        public const uint SDL_BLENDMODE_MUL = 0x00000008U;

        [NativeTypeName("#define SDL_BLENDMODE_INVALID 0x7FFFFFFFu")]
        public const uint SDL_BLENDMODE_INVALID = 0x7FFFFFFFU;
    }
}
