using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static int SDL_GetNumRenderDrivers()
        {
            return iSDL_GetNumRenderDrivers();
        }

        public static byte* SDL_GetRenderDriver(int index)
        {
            return iSDL_GetRenderDriver(index);
        }

        public static SDL_Bool SDL_CreateWindowAndRenderer(byte* title, int width, int height, ulong window_flags, SDL_Window** window, SDL_Renderer** renderer)
        {
            return iSDL_CreateWindowAndRenderer(title, width, height, window_flags, window, renderer);
        }

        public static SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, byte* name)
        {
            return iSDL_CreateRenderer(window, name);
        }

        public static SDL_Renderer* SDL_CreateRendererWithProperties(uint props)
        {
            return iSDL_CreateRendererWithProperties(props);
        }

        public static SDL_Renderer* SDL_CreateGPURenderer(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_CreateGPURenderer(device, window);
        }

        public static SDL_GPUDevice* SDL_GetGPURendererDevice(SDL_Renderer* renderer)
        {
            return iSDL_GetGPURendererDevice(renderer);
        }

        public static SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface)
        {
            return iSDL_CreateSoftwareRenderer(surface);
        }

        public static SDL_Renderer* SDL_GetRenderer(SDL_Window* window)
        {
            return iSDL_GetRenderer(window);
        }

        public static SDL_Window* SDL_GetRenderWindow(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderWindow(renderer);
        }

        public static byte* SDL_GetRendererName(SDL_Renderer* renderer)
        {
            return iSDL_GetRendererName(renderer);
        }

        public static uint SDL_GetRendererProperties(SDL_Renderer* renderer)
        {
            return iSDL_GetRendererProperties(renderer);
        }

        public static SDL_Bool SDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h)
        {
            return iSDL_GetRenderOutputSize(renderer, w, h);
        }

        public static SDL_Bool SDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h)
        {
            return iSDL_GetCurrentRenderOutputSize(renderer, w, h);
        }

        public static SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h)
        {
            return iSDL_CreateTexture(renderer, format, access, w, h);
        }

        public static SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface)
        {
            return iSDL_CreateTextureFromSurface(renderer, surface);
        }

        public static SDL_Texture* SDL_CreateTextureWithProperties(SDL_Renderer* renderer, uint props)
        {
            return iSDL_CreateTextureWithProperties(renderer, props);
        }

        public static uint SDL_GetTextureProperties(SDL_Texture* texture)
        {
            return iSDL_GetTextureProperties(texture);
        }

        public static SDL_Renderer* SDL_GetRendererFromTexture(SDL_Texture* texture)
        {
            return iSDL_GetRendererFromTexture(texture);
        }

        public static SDL_Bool SDL_GetTextureSize(SDL_Texture* texture, float* w, float* h)
        {
            return iSDL_GetTextureSize(texture, w, h);
        }

        public static SDL_Bool SDL_SetTexturePalette(SDL_Texture* texture, SDL_Palette* palette)
        {
            return iSDL_SetTexturePalette(texture, palette);
        }

        public static SDL_Palette* SDL_GetTexturePalette(SDL_Texture* texture)
        {
            return iSDL_GetTexturePalette(texture);
        }

        public static SDL_Bool SDL_SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b)
        {
            return iSDL_SetTextureColorMod(texture, r, g, b);
        }

        public static SDL_Bool SDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b)
        {
            return iSDL_SetTextureColorModFloat(texture, r, g, b);
        }

        public static SDL_Bool SDL_GetTextureColorMod(SDL_Texture* texture, byte* r, byte* g, byte* b)
        {
            return iSDL_GetTextureColorMod(texture, r, g, b);
        }

        public static SDL_Bool SDL_GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b)
        {
            return iSDL_GetTextureColorModFloat(texture, r, g, b);
        }

        public static SDL_Bool SDL_SetTextureAlphaMod(SDL_Texture* texture, byte alpha)
        {
            return iSDL_SetTextureAlphaMod(texture, alpha);
        }

        public static SDL_Bool SDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha)
        {
            return iSDL_SetTextureAlphaModFloat(texture, alpha);
        }

        public static SDL_Bool SDL_GetTextureAlphaMod(SDL_Texture* texture, byte* alpha)
        {
            return iSDL_GetTextureAlphaMod(texture, alpha);
        }

        public static SDL_Bool SDL_GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha)
        {
            return iSDL_GetTextureAlphaModFloat(texture, alpha);
        }

        public static SDL_Bool SDL_SetTextureBlendMode(SDL_Texture* texture, uint blendMode)
        {
            return iSDL_SetTextureBlendMode(texture, blendMode);
        }

        public static SDL_Bool SDL_GetTextureBlendMode(SDL_Texture* texture, uint* blendMode)
        {
            return iSDL_GetTextureBlendMode(texture, blendMode);
        }

        public static SDL_Bool SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode)
        {
            return iSDL_SetTextureScaleMode(texture, scaleMode);
        }

        public static SDL_Bool SDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode)
        {
            return iSDL_GetTextureScaleMode(texture, scaleMode);
        }

        public static SDL_Bool SDL_UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, void* pixels, int pitch)
        {
            return iSDL_UpdateTexture(texture, rect, pixels, pitch);
        }

        public static SDL_Bool SDL_UpdateYUVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch)
        {
            return iSDL_UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        public static SDL_Bool SDL_UpdateNVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* UVplane, int UVpitch)
        {
            return iSDL_UpdateNVTexture(texture, rect, Yplane, Ypitch, UVplane, UVpitch);
        }

        public static SDL_Bool SDL_LockTexture(SDL_Texture* texture, SDL_Rect* rect, void** pixels, int* pitch)
        {
            return iSDL_LockTexture(texture, rect, pixels, pitch);
        }

        public static SDL_Bool SDL_LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, SDL_Surface** surface)
        {
            return iSDL_LockTextureToSurface(texture, rect, surface);
        }

        public static void SDL_UnlockTexture(SDL_Texture* texture)
        {
            iSDL_UnlockTexture(texture);
        }

        public static SDL_Bool SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture)
        {
            return iSDL_SetRenderTarget(renderer, texture);
        }

        public static SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderTarget(renderer);
        }

        public static SDL_Bool SDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode)
        {
            return iSDL_SetRenderLogicalPresentation(renderer, w, h, mode);
        }

        public static SDL_Bool SDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode)
        {
            return iSDL_GetRenderLogicalPresentation(renderer, w, h, mode);
        }

        public static SDL_Bool SDL_GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect)
        {
            return iSDL_GetRenderLogicalPresentationRect(renderer, rect);
        }

        public static SDL_Bool SDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y)
        {
            return iSDL_RenderCoordinatesFromWindow(renderer, window_x, window_y, x, y);
        }

        public static SDL_Bool SDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y)
        {
            return iSDL_RenderCoordinatesToWindow(renderer, x, y, window_x, window_y);
        }

        public static SDL_Bool SDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event)
        {
            return iSDL_ConvertEventToRenderCoordinates(renderer, @event);
        }

        public static SDL_Bool SDL_SetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_SetRenderViewport(renderer, rect);
        }

        public static SDL_Bool SDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_GetRenderViewport(renderer, rect);
        }

        public static SDL_Bool SDL_RenderViewportSet(SDL_Renderer* renderer)
        {
            return iSDL_RenderViewportSet(renderer);
        }

        public static SDL_Bool SDL_GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_GetRenderSafeArea(renderer, rect);
        }

        public static SDL_Bool SDL_SetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_SetRenderClipRect(renderer, rect);
        }

        public static SDL_Bool SDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_GetRenderClipRect(renderer, rect);
        }

        public static SDL_Bool SDL_RenderClipEnabled(SDL_Renderer* renderer)
        {
            return iSDL_RenderClipEnabled(renderer);
        }

        public static SDL_Bool SDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY)
        {
            return iSDL_SetRenderScale(renderer, scaleX, scaleY);
        }

        public static SDL_Bool SDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY)
        {
            return iSDL_GetRenderScale(renderer, scaleX, scaleY);
        }

        public static SDL_Bool SDL_SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a)
        {
            return iSDL_SetRenderDrawColor(renderer, r, g, b, a);
        }

        public static SDL_Bool SDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a)
        {
            return iSDL_SetRenderDrawColorFloat(renderer, r, g, b, a);
        }

        public static SDL_Bool SDL_GetRenderDrawColor(SDL_Renderer* renderer, byte* r, byte* g, byte* b, byte* a)
        {
            return iSDL_GetRenderDrawColor(renderer, r, g, b, a);
        }

        public static SDL_Bool SDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a)
        {
            return iSDL_GetRenderDrawColorFloat(renderer, r, g, b, a);
        }

        public static SDL_Bool SDL_SetRenderColorScale(SDL_Renderer* renderer, float scale)
        {
            return iSDL_SetRenderColorScale(renderer, scale);
        }

        public static SDL_Bool SDL_GetRenderColorScale(SDL_Renderer* renderer, float* scale)
        {
            return iSDL_GetRenderColorScale(renderer, scale);
        }

        public static SDL_Bool SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, uint blendMode)
        {
            return iSDL_SetRenderDrawBlendMode(renderer, blendMode);
        }

        public static SDL_Bool SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, uint* blendMode)
        {
            return iSDL_GetRenderDrawBlendMode(renderer, blendMode);
        }

        public static SDL_Bool SDL_RenderClear(SDL_Renderer* renderer)
        {
            return iSDL_RenderClear(renderer);
        }

        public static SDL_Bool SDL_RenderPoint(SDL_Renderer* renderer, float x, float y)
        {
            return iSDL_RenderPoint(renderer, x, y);
        }

        public static SDL_Bool SDL_RenderPoints(SDL_Renderer* renderer, SDL_FPoint* points, int count)
        {
            return iSDL_RenderPoints(renderer, points, count);
        }

        public static SDL_Bool SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2)
        {
            return iSDL_RenderLine(renderer, x1, y1, x2, y2);
        }

        public static SDL_Bool SDL_RenderLines(SDL_Renderer* renderer, SDL_FPoint* points, int count)
        {
            return iSDL_RenderLines(renderer, points, count);
        }

        public static SDL_Bool SDL_RenderRect(SDL_Renderer* renderer, SDL_FRect* rect)
        {
            return iSDL_RenderRect(renderer, rect);
        }

        public static SDL_Bool SDL_RenderRects(SDL_Renderer* renderer, SDL_FRect* rects, int count)
        {
            return iSDL_RenderRects(renderer, rects, count);
        }

        public static SDL_Bool SDL_RenderFillRect(SDL_Renderer* renderer, SDL_FRect* rect)
        {
            return iSDL_RenderFillRect(renderer, rect);
        }

        public static SDL_Bool SDL_RenderFillRects(SDL_Renderer* renderer, SDL_FRect* rects, int count)
        {
            return iSDL_RenderFillRects(renderer, rects, count);
        }

        public static SDL_Bool SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect)
        {
            return iSDL_RenderTexture(renderer, texture, srcrect, dstrect);
        }

        public static SDL_Bool SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect, double angle, SDL_FPoint* center, SDL_FlipMode flip)
        {
            return iSDL_RenderTextureRotated(renderer, texture, srcrect, dstrect, angle, center, flip);
        }

        public static SDL_Bool SDL_RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FPoint* origin, SDL_FPoint* right, SDL_FPoint* down)
        {
            return iSDL_RenderTextureAffine(renderer, texture, srcrect, origin, right, down);
        }

        public static SDL_Bool SDL_RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float scale, SDL_FRect* dstrect)
        {
            return iSDL_RenderTextureTiled(renderer, texture, srcrect, scale, dstrect);
        }

        public static SDL_Bool SDL_RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect)
        {
            return iSDL_RenderTexture9Grid(renderer, texture, srcrect, left_width, right_width, top_height, bottom_height, scale, dstrect);
        }

        public static SDL_Bool SDL_RenderTexture9GridTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect, float tileScale)
        {
            return iSDL_RenderTexture9GridTiled(renderer, texture, srcrect, left_width, right_width, top_height, bottom_height, scale, dstrect, tileScale);
        }

        public static SDL_Bool SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex* vertices, int num_vertices, int* indices, int num_indices)
        {
            return iSDL_RenderGeometry(renderer, texture, vertices, num_vertices, indices, num_indices);
        }

        public static SDL_Bool SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, float* xy, int xy_stride, SDL_FColor* color, int color_stride, float* uv, int uv_stride, int num_vertices, void* indices, int num_indices, int size_indices)
        {
            return iSDL_RenderGeometryRaw(renderer, texture, xy, xy_stride, color, color_stride, uv, uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        public static SDL_Bool SDL_SetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode u_mode, SDL_TextureAddressMode v_mode)
        {
            return iSDL_SetRenderTextureAddressMode(renderer, u_mode, v_mode);
        }

        public static SDL_Bool SDL_GetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode* u_mode, SDL_TextureAddressMode* v_mode)
        {
            return iSDL_GetRenderTextureAddressMode(renderer, u_mode, v_mode);
        }

        public static SDL_Surface* SDL_RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_RenderReadPixels(renderer, rect);
        }

        public static SDL_Bool SDL_RenderPresent(SDL_Renderer* renderer)
        {
            return iSDL_RenderPresent(renderer);
        }

        public static void SDL_DestroyTexture(SDL_Texture* texture)
        {
            iSDL_DestroyTexture(texture);
        }

        public static void SDL_DestroyRenderer(SDL_Renderer* renderer)
        {
            iSDL_DestroyRenderer(renderer);
        }

        public static SDL_Bool SDL_FlushRenderer(SDL_Renderer* renderer)
        {
            return iSDL_FlushRenderer(renderer);
        }

        public static void* SDL_GetRenderMetalLayer(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderMetalLayer(renderer);
        }

        public static void* SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderMetalCommandEncoder(renderer);
        }

        public static SDL_Bool SDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint wait_stage_mask, long wait_semaphore, long signal_semaphore)
        {
            return iSDL_AddVulkanRenderSemaphores(renderer, wait_stage_mask, wait_semaphore, signal_semaphore);
        }

        public static SDL_Bool SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync)
        {
            return iSDL_SetRenderVSync(renderer, vsync);
        }

        public static SDL_Bool SDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync)
        {
            return iSDL_GetRenderVSync(renderer, vsync);
        }

        public static SDL_Bool SDL_RenderDebugText(SDL_Renderer* renderer, float x, float y, byte* str)
        {
            return iSDL_RenderDebugText(renderer, x, y, str);
        }

        public static SDL_Bool SDL_RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, byte* fmt)
        {
            return iSDL_RenderDebugTextFormat(renderer, x, y, fmt);
        }

        public static SDL_Bool SDL_SetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode scale_mode)
        {
            return iSDL_SetDefaultTextureScaleMode(renderer, scale_mode);
        }

        public static SDL_Bool SDL_GetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode* scale_mode)
        {
            return iSDL_GetDefaultTextureScaleMode(renderer, scale_mode);
        }

        public static SDL_GPURenderState* SDL_CreateGPURenderState(SDL_Renderer* renderer, SDL_GPURenderStateCreateInfo* createinfo)
        {
            return iSDL_CreateGPURenderState(renderer, createinfo);
        }

        public static SDL_Bool SDL_SetGPURenderStateSamplerBindings(SDL_GPURenderState* state, int num_sampler_bindings, SDL_GPUTextureSamplerBinding* sampler_bindings)
        {
            return iSDL_SetGPURenderStateSamplerBindings(state, num_sampler_bindings, sampler_bindings);
        }

        public static SDL_Bool SDL_SetGPURenderStateStorageTextures(SDL_GPURenderState* state, int num_storage_textures, SDL_GPUTexture** storage_textures)
        {
            return iSDL_SetGPURenderStateStorageTextures(state, num_storage_textures, storage_textures);
        }

        public static SDL_Bool SDL_SetGPURenderStateStorageBuffers(SDL_GPURenderState* state, int num_storage_buffers, SDL_GPUBuffer** storage_buffers)
        {
            return iSDL_SetGPURenderStateStorageBuffers(state, num_storage_buffers, storage_buffers);
        }

        public static SDL_Bool SDL_SetGPURenderStateFragmentUniforms(SDL_GPURenderState* state, uint slot_index, void* data, uint length)
        {
            return iSDL_SetGPURenderStateFragmentUniforms(state, slot_index, data, length);
        }

        public static SDL_Bool SDL_SetGPURenderState(SDL_Renderer* renderer, SDL_GPURenderState* state)
        {
            return iSDL_SetGPURenderState(renderer, state);
        }

        public static void SDL_DestroyGPURenderState(SDL_GPURenderState* state)
        {
            iSDL_DestroyGPURenderState(state);
        }
    }
}