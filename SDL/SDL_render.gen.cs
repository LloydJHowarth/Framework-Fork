using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_Vertex
    {
        public SDL_FPoint position;

        public SDL_FColor color;

        public SDL_FPoint tex_coord;
    }

    internal enum SDL_TextureAccess
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }

    internal enum SDL_TextureAddressMode
    {
        SDL_TEXTURE_ADDRESS_INVALID = -1,
        SDL_TEXTURE_ADDRESS_AUTO,
        SDL_TEXTURE_ADDRESS_CLAMP,
        SDL_TEXTURE_ADDRESS_WRAP,
    }

    internal enum SDL_RendererLogicalPresentation
    {
        SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE,
    }

    internal partial struct SDL_Renderer
    {
    }

    internal partial struct SDL_Texture
    {
        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int refcount;
    }

    internal unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        public SDL_GPUShader* fragment_shader;

        [NativeTypeName("Sint32")]
        public int num_sampler_bindings;

        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
        public SDL_GPUTextureSamplerBinding* sampler_bindings;

        [NativeTypeName("Sint32")]
        public int num_storage_textures;

        [NativeTypeName("SDL_GPUTexture *const *")]
        public SDL_GPUTexture** storage_textures;

        [NativeTypeName("Sint32")]
        public int num_storage_buffers;

        [NativeTypeName("SDL_GPUBuffer *const *")]
        public SDL_GPUBuffer** storage_buffers;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPURenderState
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumRenderDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetRenderDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CreateWindowAndRenderer([NativeTypeName("const char *")] byte* title, int width, int height, [NativeTypeName("SDL_WindowFlags")] ulong window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRendererWithProperties", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPURenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateGPURenderer(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPURendererDevice", ExactSpelling = true)]
        private static extern SDL_GPUDevice* iSDL_GetGPURendererDevice(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_GetRenderer(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetRenderWindow(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetRendererName(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetRendererProperties(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderOutputSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentRenderOutputSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureWithProperties", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTextureWithProperties(SDL_Renderer* renderer, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetTextureProperties(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererFromTexture", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_GetRendererFromTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureSize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureSize(SDL_Texture* texture, float* w, float* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTexturePalette", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTexturePalette(SDL_Texture* texture, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTexturePalette", ExactSpelling = true)]
        private static extern SDL_Palette* iSDL_GetTexturePalette(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorModFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorModFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaModFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaModFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
        private static extern void iSDL_UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderLogicalPresentation", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentation", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentationRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesFromWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesToWindow", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertEventToRenderCoordinates", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderViewport", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderViewport", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderViewportSet", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderViewportSet(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderSafeArea", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderClipRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderClipRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClipEnabled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderScale", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderScale", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColorFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColorFloat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderColorScale", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderColorScale(SDL_Renderer* renderer, float scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderColorScale", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderColorScale(SDL_Renderer* renderer, float* scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoint", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderPoint(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoints", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLine", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLines", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRects", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureRotated", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureAffine", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* origin, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* right, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureTiled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9Grid", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9GridTiled", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderTexture9GridTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, float tileScale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_FColor *")] SDL_FColor* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTextureAddressMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode u_mode, SDL_TextureAddressMode v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTextureAddressMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode* u_mode, SDL_TextureAddressMode* v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
        private static extern void iSDL_DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
        private static extern void iSDL_DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushRenderer", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FlushRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalLayer", ExactSpelling = true)]
        private static extern void* iSDL_GetRenderMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalCommandEncoder", ExactSpelling = true)]
        private static extern void* iSDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddVulkanRenderSemaphores", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint wait_stage_mask, [NativeTypeName("Sint64")] long wait_semaphore, [NativeTypeName("Sint64")] long signal_semaphore);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderVSync", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderVSync", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugText", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderDebugText(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugTextFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetDefaultTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode* scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPURenderState", ExactSpelling = true)]
        private static extern SDL_GPURenderState* iSDL_CreateGPURenderState(SDL_Renderer* renderer, [NativeTypeName("const SDL_GPURenderStateCreateInfo *")] SDL_GPURenderStateCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateSamplerBindings", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPURenderStateSamplerBindings(SDL_GPURenderState* state, int num_sampler_bindings, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* sampler_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateStorageTextures", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPURenderStateStorageTextures(SDL_GPURenderState* state, int num_storage_textures, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateStorageBuffers", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPURenderStateStorageBuffers(SDL_GPURenderState* state, int num_storage_buffers, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateFragmentUniforms", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPURenderStateFragmentUniforms(SDL_GPURenderState* state, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderState", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPURenderState(SDL_Renderer* renderer, SDL_GPURenderState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyGPURenderState", ExactSpelling = true)]
        private static extern void iSDL_DestroyGPURenderState(SDL_GPURenderState* state);

        [NativeTypeName("#define SDL_SOFTWARE_RENDERER \"software\"")]
        public static string SDL_SOFTWARE_RENDERER => "software";

        [NativeTypeName("#define SDL_GPU_RENDERER \"gpu\"")]
        public static string SDL_GPU_RENDERER => "gpu";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_NAME_STRING \"SDL.renderer.create.name\"")]
        public static string SDL_PROP_RENDERER_CREATE_NAME_STRING => "SDL.renderer.create.name";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_WINDOW_POINTER \"SDL.renderer.create.window\"")]
        public static string SDL_PROP_RENDERER_CREATE_WINDOW_POINTER => "SDL.renderer.create.window";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_SURFACE_POINTER \"SDL.renderer.create.surface\"")]
        public static string SDL_PROP_RENDERER_CREATE_SURFACE_POINTER => "SDL.renderer.create.surface";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.create.output_colorspace\"")]
        public static string SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER => "SDL.renderer.create.output_colorspace";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_NUMBER \"SDL.renderer.create.present_vsync\"")]
        public static string SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_NUMBER => "SDL.renderer.create.present_vsync";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_DEVICE_POINTER \"SDL.renderer.create.gpu.device\"")]
        public static string SDL_PROP_RENDERER_CREATE_GPU_DEVICE_POINTER => "SDL.renderer.create.gpu.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_SPIRV_BOOLEAN \"SDL.renderer.create.gpu.shaders_spirv\"")]
        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_SPIRV_BOOLEAN => "SDL.renderer.create.gpu.shaders_spirv";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_DXIL_BOOLEAN \"SDL.renderer.create.gpu.shaders_dxil\"")]
        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_DXIL_BOOLEAN => "SDL.renderer.create.gpu.shaders_dxil";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_MSL_BOOLEAN \"SDL.renderer.create.gpu.shaders_msl\"")]
        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_MSL_BOOLEAN => "SDL.renderer.create.gpu.shaders_msl";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_METAL_DEVICE_POINTER \"SDL.renderer.create.metal.device\"")]
        public static string SDL_PROP_RENDERER_CREATE_METAL_DEVICE_POINTER => "SDL.renderer.create.metal.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_METAL_COMMAND_QUEUE_POINTER \"SDL.renderer.create.metal.command_queue\"")]
        public static string SDL_PROP_RENDERER_CREATE_METAL_COMMAND_QUEUE_POINTER => "SDL.renderer.create.metal.command_queue";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER \"SDL.renderer.create.vulkan.instance\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER => "SDL.renderer.create.vulkan.instance";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER \"SDL.renderer.create.vulkan.surface\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER => "SDL.renderer.create.vulkan.surface";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.create.vulkan.physical_device\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER => "SDL.renderer.create.vulkan.physical_device";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER \"SDL.renderer.create.vulkan.device\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER => "SDL.renderer.create.vulkan.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.create.vulkan.graphics_queue_family_index\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.create.vulkan.graphics_queue_family_index";

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.create.vulkan.present_queue_family_index\"")]
        public static string SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.create.vulkan.present_queue_family_index";

        [NativeTypeName("#define SDL_PROP_RENDERER_NAME_STRING \"SDL.renderer.name\"")]
        public static string SDL_PROP_RENDERER_NAME_STRING => "SDL.renderer.name";

        [NativeTypeName("#define SDL_PROP_RENDERER_WINDOW_POINTER \"SDL.renderer.window\"")]
        public static string SDL_PROP_RENDERER_WINDOW_POINTER => "SDL.renderer.window";

        [NativeTypeName("#define SDL_PROP_RENDERER_SURFACE_POINTER \"SDL.renderer.surface\"")]
        public static string SDL_PROP_RENDERER_SURFACE_POINTER => "SDL.renderer.surface";

        [NativeTypeName("#define SDL_PROP_RENDERER_VSYNC_NUMBER \"SDL.renderer.vsync\"")]
        public static string SDL_PROP_RENDERER_VSYNC_NUMBER => "SDL.renderer.vsync";

        [NativeTypeName("#define SDL_PROP_RENDERER_MAX_TEXTURE_SIZE_NUMBER \"SDL.renderer.max_texture_size\"")]
        public static string SDL_PROP_RENDERER_MAX_TEXTURE_SIZE_NUMBER => "SDL.renderer.max_texture_size";

        [NativeTypeName("#define SDL_PROP_RENDERER_TEXTURE_FORMATS_POINTER \"SDL.renderer.texture_formats\"")]
        public static string SDL_PROP_RENDERER_TEXTURE_FORMATS_POINTER => "SDL.renderer.texture_formats";

        [NativeTypeName("#define SDL_PROP_RENDERER_TEXTURE_WRAPPING_BOOLEAN \"SDL.renderer.texture_wrapping\"")]
        public static string SDL_PROP_RENDERER_TEXTURE_WRAPPING_BOOLEAN => "SDL.renderer.texture_wrapping";

        [NativeTypeName("#define SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.output_colorspace\"")]
        public static string SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER => "SDL.renderer.output_colorspace";

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN \"SDL.renderer.HDR_enabled\"")]
        public static string SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN => "SDL.renderer.HDR_enabled";

        [NativeTypeName("#define SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT \"SDL.renderer.SDR_white_point\"")]
        public static string SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT => "SDL.renderer.SDR_white_point";

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT \"SDL.renderer.HDR_headroom\"")]
        public static string SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT => "SDL.renderer.HDR_headroom";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D9_DEVICE_POINTER \"SDL.renderer.d3d9.device\"")]
        public static string SDL_PROP_RENDERER_D3D9_DEVICE_POINTER => "SDL.renderer.d3d9.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_DEVICE_POINTER \"SDL.renderer.d3d11.device\"")]
        public static string SDL_PROP_RENDERER_D3D11_DEVICE_POINTER => "SDL.renderer.d3d11.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_SWAPCHAIN_POINTER \"SDL.renderer.d3d11.swap_chain\"")]
        public static string SDL_PROP_RENDERER_D3D11_SWAPCHAIN_POINTER => "SDL.renderer.d3d11.swap_chain";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_DEVICE_POINTER \"SDL.renderer.d3d12.device\"")]
        public static string SDL_PROP_RENDERER_D3D12_DEVICE_POINTER => "SDL.renderer.d3d12.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_SWAPCHAIN_POINTER \"SDL.renderer.d3d12.swap_chain\"")]
        public static string SDL_PROP_RENDERER_D3D12_SWAPCHAIN_POINTER => "SDL.renderer.d3d12.swap_chain";

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER \"SDL.renderer.d3d12.command_queue\"")]
        public static string SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER => "SDL.renderer.d3d12.command_queue";

        [NativeTypeName("#define SDL_PROP_RENDERER_METAL_DEVICE_POINTER \"SDL.renderer.metal.device\"")]
        public static string SDL_PROP_RENDERER_METAL_DEVICE_POINTER => "SDL.renderer.metal.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_METAL_COMMAND_QUEUE_POINTER \"SDL.renderer.metal.command_queue\"")]
        public static string SDL_PROP_RENDERER_METAL_COMMAND_QUEUE_POINTER => "SDL.renderer.metal.command_queue";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER \"SDL.renderer.vulkan.instance\"")]
        public static string SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER => "SDL.renderer.vulkan.instance";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER \"SDL.renderer.vulkan.surface\"")]
        public static string SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER => "SDL.renderer.vulkan.surface";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.vulkan.physical_device\"")]
        public static string SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER => "SDL.renderer.vulkan.physical_device";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER \"SDL.renderer.vulkan.device\"")]
        public static string SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER => "SDL.renderer.vulkan.device";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.graphics_queue_family_index\"")]
        public static string SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.graphics_queue_family_index";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.present_queue_family_index\"")]
        public static string SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.present_queue_family_index";

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER \"SDL.renderer.vulkan.swapchain_image_count\"")]
        public static string SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER => "SDL.renderer.vulkan.swapchain_image_count";

        [NativeTypeName("#define SDL_PROP_RENDERER_GPU_DEVICE_POINTER \"SDL.renderer.gpu.device\"")]
        public static string SDL_PROP_RENDERER_GPU_DEVICE_POINTER => "SDL.renderer.gpu.device";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER \"SDL.texture.create.colorspace\"")]
        public static string SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER => "SDL.texture.create.colorspace";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER \"SDL.texture.create.format\"")]
        public static string SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER => "SDL.texture.create.format";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER \"SDL.texture.create.access\"")]
        public static string SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER => "SDL.texture.create.access";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER \"SDL.texture.create.width\"")]
        public static string SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER => "SDL.texture.create.width";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER \"SDL.texture.create.height\"")]
        public static string SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER => "SDL.texture.create.height";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_PALETTE_POINTER \"SDL.texture.create.palette\"")]
        public static string SDL_PROP_TEXTURE_CREATE_PALETTE_POINTER => "SDL.texture.create.palette";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT \"SDL.texture.create.SDR_white_point\"")]
        public static string SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT => "SDL.texture.create.SDR_white_point";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT \"SDL.texture.create.HDR_headroom\"")]
        public static string SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT => "SDL.texture.create.HDR_headroom";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER \"SDL.texture.create.d3d11.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER => "SDL.texture.create.d3d11.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER \"SDL.texture.create.d3d11.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER => "SDL.texture.create.d3d11.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER \"SDL.texture.create.d3d11.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER => "SDL.texture.create.d3d11.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER \"SDL.texture.create.d3d12.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER => "SDL.texture.create.d3d12.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER \"SDL.texture.create.d3d12.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER => "SDL.texture.create.d3d12.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER \"SDL.texture.create.d3d12.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER => "SDL.texture.create.d3d12.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER \"SDL.texture.create.metal.pixelbuffer\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER => "SDL.texture.create.metal.pixelbuffer";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_POINTER \"SDL.texture.create.metal.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_POINTER => "SDL.texture.create.metal.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_UV_POINTER \"SDL.texture.create.metal.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_UV_POINTER => "SDL.texture.create.metal.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_U_POINTER \"SDL.texture.create.metal.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_U_POINTER => "SDL.texture.create.metal.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_V_POINTER \"SDL.texture.create.metal.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_V_POINTER => "SDL.texture.create.metal.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_USAGE_NUMBER \"SDL.texture.create.metal.texture_usage\"")]
        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_USAGE_NUMBER => "SDL.texture.create.metal.texture_usage";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER \"SDL.texture.create.opengl.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER => "SDL.texture.create.opengl.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.create.opengl.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER => "SDL.texture.create.opengl.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.create.opengl.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER => "SDL.texture.create.opengl.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.create.opengl.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER => "SDL.texture.create.opengl.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.create.opengles2.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER => "SDL.texture.create.opengles2.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.create.opengles2.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER => "SDL.texture.create.opengles2.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.create.opengles2.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER => "SDL.texture.create.opengles2.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.create.opengles2.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER => "SDL.texture.create.opengles2.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER \"SDL.texture.create.vulkan.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER => "SDL.texture.create.vulkan.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_LAYOUT_NUMBER \"SDL.texture.create.vulkan.layout\"")]
        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_LAYOUT_NUMBER => "SDL.texture.create.vulkan.layout";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_POINTER \"SDL.texture.create.gpu.texture\"")]
        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_POINTER => "SDL.texture.create.gpu.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_UV_POINTER \"SDL.texture.create.gpu.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_UV_POINTER => "SDL.texture.create.gpu.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_U_POINTER \"SDL.texture.create.gpu.texture_u\"")]
        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_U_POINTER => "SDL.texture.create.gpu.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_V_POINTER \"SDL.texture.create.gpu.texture_v\"")]
        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_V_POINTER => "SDL.texture.create.gpu.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_COLORSPACE_NUMBER \"SDL.texture.colorspace\"")]
        public static string SDL_PROP_TEXTURE_COLORSPACE_NUMBER => "SDL.texture.colorspace";

        [NativeTypeName("#define SDL_PROP_TEXTURE_FORMAT_NUMBER \"SDL.texture.format\"")]
        public static string SDL_PROP_TEXTURE_FORMAT_NUMBER => "SDL.texture.format";

        [NativeTypeName("#define SDL_PROP_TEXTURE_ACCESS_NUMBER \"SDL.texture.access\"")]
        public static string SDL_PROP_TEXTURE_ACCESS_NUMBER => "SDL.texture.access";

        [NativeTypeName("#define SDL_PROP_TEXTURE_WIDTH_NUMBER \"SDL.texture.width\"")]
        public static string SDL_PROP_TEXTURE_WIDTH_NUMBER => "SDL.texture.width";

        [NativeTypeName("#define SDL_PROP_TEXTURE_HEIGHT_NUMBER \"SDL.texture.height\"")]
        public static string SDL_PROP_TEXTURE_HEIGHT_NUMBER => "SDL.texture.height";

        [NativeTypeName("#define SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT \"SDL.texture.SDR_white_point\"")]
        public static string SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT => "SDL.texture.SDR_white_point";

        [NativeTypeName("#define SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT \"SDL.texture.HDR_headroom\"")]
        public static string SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT => "SDL.texture.HDR_headroom";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER \"SDL.texture.d3d11.texture\"")]
        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER => "SDL.texture.d3d11.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER \"SDL.texture.d3d11.texture_u\"")]
        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER => "SDL.texture.d3d11.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER \"SDL.texture.d3d11.texture_v\"")]
        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER => "SDL.texture.d3d11.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER \"SDL.texture.d3d12.texture\"")]
        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER => "SDL.texture.d3d12.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER \"SDL.texture.d3d12.texture_u\"")]
        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER => "SDL.texture.d3d12.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER \"SDL.texture.d3d12.texture_v\"")]
        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER => "SDL.texture.d3d12.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_METAL_TEXTURE_POINTER \"SDL.texture.metal.texture\"")]
        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_POINTER => "SDL.texture.metal.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_METAL_TEXTURE_UV_POINTER \"SDL.texture.metal.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_UV_POINTER => "SDL.texture.metal.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_METAL_TEXTURE_U_POINTER \"SDL.texture.metal.texture_u\"")]
        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_U_POINTER => "SDL.texture.metal.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_METAL_TEXTURE_V_POINTER \"SDL.texture.metal.texture_v\"")]
        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_V_POINTER => "SDL.texture.metal.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER \"SDL.texture.opengl.texture\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER => "SDL.texture.opengl.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.opengl.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER => "SDL.texture.opengl.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.opengl.texture_u\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER => "SDL.texture.opengl.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.opengl.texture_v\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER => "SDL.texture.opengl.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER \"SDL.texture.opengl.target\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER => "SDL.texture.opengl.target";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT \"SDL.texture.opengl.tex_w\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT => "SDL.texture.opengl.tex_w";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT \"SDL.texture.opengl.tex_h\"")]
        public static string SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT => "SDL.texture.opengl.tex_h";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.opengles2.texture\"")]
        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER => "SDL.texture.opengles2.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.opengles2.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER => "SDL.texture.opengles2.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.opengles2.texture_u\"")]
        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER => "SDL.texture.opengles2.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.opengles2.texture_v\"")]
        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER => "SDL.texture.opengles2.texture_v";

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER \"SDL.texture.opengles2.target\"")]
        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER => "SDL.texture.opengles2.target";

        [NativeTypeName("#define SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER \"SDL.texture.vulkan.texture\"")]
        public static string SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER => "SDL.texture.vulkan.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_POINTER \"SDL.texture.gpu.texture\"")]
        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_POINTER => "SDL.texture.gpu.texture";

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_UV_POINTER \"SDL.texture.gpu.texture_uv\"")]
        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_UV_POINTER => "SDL.texture.gpu.texture_uv";

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_U_POINTER \"SDL.texture.gpu.texture_u\"")]
        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_U_POINTER => "SDL.texture.gpu.texture_u";

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_V_POINTER \"SDL.texture.gpu.texture_v\"")]
        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_V_POINTER => "SDL.texture.gpu.texture_v";

        [NativeTypeName("#define SDL_RENDERER_VSYNC_DISABLED 0")]
        public const int SDL_RENDERER_VSYNC_DISABLED = 0;

        [NativeTypeName("#define SDL_RENDERER_VSYNC_ADAPTIVE (-1)")]
        public const int SDL_RENDERER_VSYNC_ADAPTIVE = (-1);

        [NativeTypeName("#define SDL_DEBUG_TEXT_FONT_CHARACTER_SIZE 8")]
        public const int SDL_DEBUG_TEXT_FONT_CHARACTER_SIZE = 8;
    }
}
