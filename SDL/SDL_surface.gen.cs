using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_ScaleMode
    {
        SDL_SCALEMODE_INVALID = -1,
        SDL_SCALEMODE_NEAREST,
        SDL_SCALEMODE_LINEAR,
        SDL_SCALEMODE_PIXELART,
    }

    internal enum SDL_FlipMode
    {
        SDL_FLIP_NONE,
        SDL_FLIP_HORIZONTAL,
        SDL_FLIP_VERTICAL,
        SDL_FLIP_HORIZONTAL_AND_VERTICAL = (SDL_FLIP_HORIZONTAL | SDL_FLIP_VERTICAL),
    }

    internal unsafe partial struct SDL_Surface
    {
        [NativeTypeName("SDL_SurfaceFlags")]
        public uint flags;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int pitch;

        public void* pixels;

        public int refcount;

        public void* reserved;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_CreateSurface(int width, int height, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfaceFrom", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySurface", ExactSpelling = true)]
        private static extern void iSDL_DestroySurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetSurfaceProperties(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorspace", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorspace", ExactSpelling = true)]
        private static extern SDL_Colorspace iSDL_GetSurfaceColorspace(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfacePalette", ExactSpelling = true)]
        private static extern SDL_Palette* iSDL_CreateSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfacePalette", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfacePalette", ExactSpelling = true)]
        private static extern SDL_Palette* iSDL_GetSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddSurfaceAlternateImage", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasAlternateImages", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SurfaceHasAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceImages", ExactSpelling = true)]
        private static extern SDL_Surface** iSDL_GetSurfaceImages(SDL_Surface* surface, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveSurfaceAlternateImages", ExactSpelling = true)]
        private static extern void iSDL_RemoveSurfaceAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSurface", ExactSpelling = true)]
        private static extern void iSDL_UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadSurface_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadSurface_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadSurface([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadBMP_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadBMP([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP_IO", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SaveBMP(SDL_Surface* surface, [NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadPNG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadPNG_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadPNG", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadPNG([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SavePNG_IO", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SavePNG_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SavePNG", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SavePNG(SDL_Surface* surface, [NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadJPG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadJPG_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadJPG", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_LoadJPG([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceRLE", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceRLE(SDL_Surface* surface, [NativeTypeName("bool")] SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasRLE", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SurfaceHasRLE(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorKey", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("bool")] SDL_Bool enabled, [NativeTypeName("Uint32")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasColorKey", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SurfaceHasColorKey(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorKey", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceClipRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceClipRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlipSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RotateSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_RotateSurface(SDL_Surface* surface, float angle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DuplicateSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScaleSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurfaceAndColorspace", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixels", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ConvertPixels(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixelsAndColorspace", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, [NativeTypeName("SDL_PropertiesID")] uint src_properties, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, [NativeTypeName("SDL_PropertiesID")] uint dst_properties, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplyAlpha", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch, [NativeTypeName("bool")] SDL_Bool linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplySurfaceAlpha", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PremultiplySurfaceAlpha(SDL_Surface* surface, [NativeTypeName("bool")] SDL_Bool linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRects", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUnchecked", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurfaceUnchecked(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceScaled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StretchSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_StretchSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurfaceTiled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiledWithScale", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurfaceTiledWithScale(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface9Grid", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BlitSurface9Grid(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGB", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_MapSurfaceRGB(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGBA", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_MapSurfaceRGBA(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixel", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ReadSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixelFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixel", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WriteSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixelFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);

        [NativeTypeName("#define SDL_SURFACE_PREALLOCATED 0x00000001u")]
        public const uint SDL_SURFACE_PREALLOCATED = 0x00000001U;

        [NativeTypeName("#define SDL_SURFACE_LOCK_NEEDED 0x00000002u")]
        public const uint SDL_SURFACE_LOCK_NEEDED = 0x00000002U;

        [NativeTypeName("#define SDL_SURFACE_LOCKED 0x00000004u")]
        public const uint SDL_SURFACE_LOCKED = 0x00000004U;

        [NativeTypeName("#define SDL_SURFACE_SIMD_ALIGNED 0x00000008u")]
        public const uint SDL_SURFACE_SIMD_ALIGNED = 0x00000008U;

        [NativeTypeName("#define SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT \"SDL.surface.SDR_white_point\"")]
        public static string SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT => "SDL.surface.SDR_white_point";

        [NativeTypeName("#define SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT \"SDL.surface.HDR_headroom\"")]
        public static string SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT => "SDL.surface.HDR_headroom";

        [NativeTypeName("#define SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING \"SDL.surface.tonemap\"")]
        public static string SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING => "SDL.surface.tonemap";

        [NativeTypeName("#define SDL_PROP_SURFACE_HOTSPOT_X_NUMBER \"SDL.surface.hotspot.x\"")]
        public static string SDL_PROP_SURFACE_HOTSPOT_X_NUMBER => "SDL.surface.hotspot.x";

        [NativeTypeName("#define SDL_PROP_SURFACE_HOTSPOT_Y_NUMBER \"SDL.surface.hotspot.y\"")]
        public static string SDL_PROP_SURFACE_HOTSPOT_Y_NUMBER => "SDL.surface.hotspot.y";

        [NativeTypeName("#define SDL_PROP_SURFACE_ROTATION_FLOAT \"SDL.surface.rotation\"")]
        public static string SDL_PROP_SURFACE_ROTATION_FLOAT => "SDL.surface.rotation";
    }
}
