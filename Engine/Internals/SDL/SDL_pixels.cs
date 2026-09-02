using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static byte* SDL_GetPixelFormatName(SDL_PixelFormat format)
        {
            return iSDL_GetPixelFormatName(format);
        }

        public static SDL_Bool SDL_GetMasksForPixelFormat(SDL_PixelFormat format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            return iSDL_GetMasksForPixelFormat(format, bpp, Rmask, Gmask, Bmask, Amask);
        }

        public static SDL_PixelFormat SDL_GetPixelFormatForMasks(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask)
        {
            return iSDL_GetPixelFormatForMasks(bpp, Rmask, Gmask, Bmask, Amask);
        }

        public static SDL_PixelFormatDetails* SDL_GetPixelFormatDetails(SDL_PixelFormat format)
        {
            return iSDL_GetPixelFormatDetails(format);
        }

        public static SDL_Palette* SDL_CreatePalette(int ncolors)
        {
            return iSDL_CreatePalette(ncolors);
        }

        public static SDL_Bool SDL_SetPaletteColors(SDL_Palette* palette, SDL_Color* colors, int firstcolor, int ncolors)
        {
            return iSDL_SetPaletteColors(palette, colors, firstcolor, ncolors);
        }

        public static void SDL_DestroyPalette(SDL_Palette* palette)
        {
            iSDL_DestroyPalette(palette);
        }

        public static uint SDL_MapRGB(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b)
        {
            return iSDL_MapRGB(format, palette, r, g, b);
        }

        public static uint SDL_MapRGBA(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b, byte a)
        {
            return iSDL_MapRGBA(format, palette, r, g, b, a);
        }

        public static void SDL_GetRGB(uint pixelvalue, SDL_PixelFormatDetails* format, SDL_Palette* palette, byte* r, byte* g, byte* b)
        {
            iSDL_GetRGB(pixelvalue, format, palette, r, g, b);
        }

        public static void SDL_GetRGBA(uint pixelvalue, SDL_PixelFormatDetails* format, SDL_Palette* palette, byte* r, byte* g, byte* b, byte* a)
        {
            iSDL_GetRGBA(pixelvalue, format, palette, r, g, b, a);
        }
    }
}