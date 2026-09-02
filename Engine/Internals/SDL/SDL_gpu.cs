using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_GPUSupportsShaderFormats(uint format_flags, byte* name)
        {
            return iSDL_GPUSupportsShaderFormats(format_flags, name);
        }

        public static SDL_Bool SDL_GPUSupportsProperties(uint props)
        {
            return iSDL_GPUSupportsProperties(props);
        }

        public static SDL_GPUDevice* SDL_CreateGPUDevice(uint format_flags, SDL_Bool debug_mode, byte* name)
        {
            return iSDL_CreateGPUDevice(format_flags, debug_mode, name);
        }

        public static SDL_GPUDevice* SDL_CreateGPUDeviceWithProperties(uint props)
        {
            return iSDL_CreateGPUDeviceWithProperties(props);
        }

        public static void SDL_DestroyGPUDevice(SDL_GPUDevice* device)
        {
            iSDL_DestroyGPUDevice(device);
        }

        public static int SDL_GetNumGPUDrivers()
        {
            return iSDL_GetNumGPUDrivers();
        }

        public static byte* SDL_GetGPUDriver(int index)
        {
            return iSDL_GetGPUDriver(index);
        }

        public static byte* SDL_GetGPUDeviceDriver(SDL_GPUDevice* device)
        {
            return iSDL_GetGPUDeviceDriver(device);
        }

        public static uint SDL_GetGPUShaderFormats(SDL_GPUDevice* device)
        {
            return iSDL_GetGPUShaderFormats(device);
        }

        public static uint SDL_GetGPUDeviceProperties(SDL_GPUDevice* device)
        {
            return iSDL_GetGPUDeviceProperties(device);
        }

        public static SDL_GPUComputePipeline* SDL_CreateGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipelineCreateInfo* createinfo)
        {
            return iSDL_CreateGPUComputePipeline(device, createinfo);
        }

        public static SDL_GPUGraphicsPipeline* SDL_CreateGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipelineCreateInfo* createinfo)
        {
            return iSDL_CreateGPUGraphicsPipeline(device, createinfo);
        }

        public static SDL_GPUSampler* SDL_CreateGPUSampler(SDL_GPUDevice* device, SDL_GPUSamplerCreateInfo* createinfo)
        {
            return iSDL_CreateGPUSampler(device, createinfo);
        }

        public static SDL_GPUShader* SDL_CreateGPUShader(SDL_GPUDevice* device, SDL_GPUShaderCreateInfo* createinfo)
        {
            return iSDL_CreateGPUShader(device, createinfo);
        }

        public static SDL_GPUTexture* SDL_CreateGPUTexture(SDL_GPUDevice* device, SDL_GPUTextureCreateInfo* createinfo)
        {
            return iSDL_CreateGPUTexture(device, createinfo);
        }

        public static SDL_GPUBuffer* SDL_CreateGPUBuffer(SDL_GPUDevice* device, SDL_GPUBufferCreateInfo* createinfo)
        {
            return iSDL_CreateGPUBuffer(device, createinfo);
        }

        public static SDL_GPUTransferBuffer* SDL_CreateGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBufferCreateInfo* createinfo)
        {
            return iSDL_CreateGPUTransferBuffer(device, createinfo);
        }

        public static void SDL_SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer, byte* text)
        {
            iSDL_SetGPUBufferName(device, buffer, text);
        }

        public static void SDL_SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture, byte* text)
        {
            iSDL_SetGPUTextureName(device, texture, text);
        }

        public static void SDL_InsertGPUDebugLabel(SDL_GPUCommandBuffer* command_buffer, byte* text)
        {
            iSDL_InsertGPUDebugLabel(command_buffer, text);
        }

        public static void SDL_PushGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer, byte* name)
        {
            iSDL_PushGPUDebugGroup(command_buffer, name);
        }

        public static void SDL_PopGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer)
        {
            iSDL_PopGPUDebugGroup(command_buffer);
        }

        public static void SDL_ReleaseGPUTexture(SDL_GPUDevice* device, SDL_GPUTexture* texture)
        {
            iSDL_ReleaseGPUTexture(device, texture);
        }

        public static void SDL_ReleaseGPUSampler(SDL_GPUDevice* device, SDL_GPUSampler* sampler)
        {
            iSDL_ReleaseGPUSampler(device, sampler);
        }

        public static void SDL_ReleaseGPUBuffer(SDL_GPUDevice* device, SDL_GPUBuffer* buffer)
        {
            iSDL_ReleaseGPUBuffer(device, buffer);
        }

        public static void SDL_ReleaseGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer)
        {
            iSDL_ReleaseGPUTransferBuffer(device, transfer_buffer);
        }

        public static void SDL_ReleaseGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipeline* compute_pipeline)
        {
            iSDL_ReleaseGPUComputePipeline(device, compute_pipeline);
        }

        public static void SDL_ReleaseGPUShader(SDL_GPUDevice* device, SDL_GPUShader* shader)
        {
            iSDL_ReleaseGPUShader(device, shader);
        }

        public static void SDL_ReleaseGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipeline* graphics_pipeline)
        {
            iSDL_ReleaseGPUGraphicsPipeline(device, graphics_pipeline);
        }

        public static SDL_GPUCommandBuffer* SDL_AcquireGPUCommandBuffer(SDL_GPUDevice* device)
        {
            return iSDL_AcquireGPUCommandBuffer(device);
        }

        public static void SDL_PushGPUVertexUniformData(SDL_GPUCommandBuffer* command_buffer, uint slot_index, void* data, uint length)
        {
            iSDL_PushGPUVertexUniformData(command_buffer, slot_index, data, length);
        }

        public static void SDL_PushGPUFragmentUniformData(SDL_GPUCommandBuffer* command_buffer, uint slot_index, void* data, uint length)
        {
            iSDL_PushGPUFragmentUniformData(command_buffer, slot_index, data, length);
        }

        public static void SDL_PushGPUComputeUniformData(SDL_GPUCommandBuffer* command_buffer, uint slot_index, void* data, uint length)
        {
            iSDL_PushGPUComputeUniformData(command_buffer, slot_index, data, length);
        }

        public static SDL_GPURenderPass* SDL_BeginGPURenderPass(SDL_GPUCommandBuffer* command_buffer, SDL_GPUColorTargetInfo* color_target_infos, uint num_color_targets, SDL_GPUDepthStencilTargetInfo* depth_stencil_target_info)
        {
            return iSDL_BeginGPURenderPass(command_buffer, color_target_infos, num_color_targets, depth_stencil_target_info);
        }

        public static void SDL_BindGPUGraphicsPipeline(SDL_GPURenderPass* render_pass, SDL_GPUGraphicsPipeline* graphics_pipeline)
        {
            iSDL_BindGPUGraphicsPipeline(render_pass, graphics_pipeline);
        }

        public static void SDL_SetGPUViewport(SDL_GPURenderPass* render_pass, SDL_GPUViewport* viewport)
        {
            iSDL_SetGPUViewport(render_pass, viewport);
        }

        public static void SDL_SetGPUScissor(SDL_GPURenderPass* render_pass, SDL_Rect* scissor)
        {
            iSDL_SetGPUScissor(render_pass, scissor);
        }

        public static void SDL_SetGPUBlendConstants(SDL_GPURenderPass* render_pass, SDL_FColor blend_constants)
        {
            iSDL_SetGPUBlendConstants(render_pass, blend_constants);
        }

        public static void SDL_SetGPUStencilReference(SDL_GPURenderPass* render_pass, byte reference)
        {
            iSDL_SetGPUStencilReference(render_pass, reference);
        }

        public static void SDL_BindGPUVertexBuffers(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUBufferBinding* bindings, uint num_bindings)
        {
            iSDL_BindGPUVertexBuffers(render_pass, first_slot, bindings, num_bindings);
        }

        public static void SDL_BindGPUIndexBuffer(SDL_GPURenderPass* render_pass, SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize index_element_size)
        {
            iSDL_BindGPUIndexBuffer(render_pass, binding, index_element_size);
        }

        public static void SDL_BindGPUVertexSamplers(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUTextureSamplerBinding* texture_sampler_bindings, uint num_bindings)
        {
            iSDL_BindGPUVertexSamplers(render_pass, first_slot, texture_sampler_bindings, num_bindings);
        }

        public static void SDL_BindGPUVertexStorageTextures(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUTexture** storage_textures, uint num_bindings)
        {
            iSDL_BindGPUVertexStorageTextures(render_pass, first_slot, storage_textures, num_bindings);
        }

        public static void SDL_BindGPUVertexStorageBuffers(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUBuffer** storage_buffers, uint num_bindings)
        {
            iSDL_BindGPUVertexStorageBuffers(render_pass, first_slot, storage_buffers, num_bindings);
        }

        public static void SDL_BindGPUFragmentSamplers(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUTextureSamplerBinding* texture_sampler_bindings, uint num_bindings)
        {
            iSDL_BindGPUFragmentSamplers(render_pass, first_slot, texture_sampler_bindings, num_bindings);
        }

        public static void SDL_BindGPUFragmentStorageTextures(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUTexture** storage_textures, uint num_bindings)
        {
            iSDL_BindGPUFragmentStorageTextures(render_pass, first_slot, storage_textures, num_bindings);
        }

        public static void SDL_BindGPUFragmentStorageBuffers(SDL_GPURenderPass* render_pass, uint first_slot, SDL_GPUBuffer** storage_buffers, uint num_bindings)
        {
            iSDL_BindGPUFragmentStorageBuffers(render_pass, first_slot, storage_buffers, num_bindings);
        }

        public static void SDL_DrawGPUIndexedPrimitives(SDL_GPURenderPass* render_pass, uint num_indices, uint num_instances, uint first_index, int vertex_offset, uint first_instance)
        {
            iSDL_DrawGPUIndexedPrimitives(render_pass, num_indices, num_instances, first_index, vertex_offset, first_instance);
        }

        public static void SDL_DrawGPUPrimitives(SDL_GPURenderPass* render_pass, uint num_vertices, uint num_instances, uint first_vertex, uint first_instance)
        {
            iSDL_DrawGPUPrimitives(render_pass, num_vertices, num_instances, first_vertex, first_instance);
        }

        public static void SDL_DrawGPUPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, uint offset, uint draw_count)
        {
            iSDL_DrawGPUPrimitivesIndirect(render_pass, buffer, offset, draw_count);
        }

        public static void SDL_DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, uint offset, uint draw_count)
        {
            iSDL_DrawGPUIndexedPrimitivesIndirect(render_pass, buffer, offset, draw_count);
        }

        public static void SDL_EndGPURenderPass(SDL_GPURenderPass* render_pass)
        {
            iSDL_EndGPURenderPass(render_pass);
        }

        public static SDL_GPUComputePass* SDL_BeginGPUComputePass(SDL_GPUCommandBuffer* command_buffer, SDL_GPUStorageTextureReadWriteBinding* storage_texture_bindings, uint num_storage_texture_bindings, SDL_GPUStorageBufferReadWriteBinding* storage_buffer_bindings, uint num_storage_buffer_bindings)
        {
            return iSDL_BeginGPUComputePass(command_buffer, storage_texture_bindings, num_storage_texture_bindings, storage_buffer_bindings, num_storage_buffer_bindings);
        }

        public static void SDL_BindGPUComputePipeline(SDL_GPUComputePass* compute_pass, SDL_GPUComputePipeline* compute_pipeline)
        {
            iSDL_BindGPUComputePipeline(compute_pass, compute_pipeline);
        }

        public static void SDL_BindGPUComputeSamplers(SDL_GPUComputePass* compute_pass, uint first_slot, SDL_GPUTextureSamplerBinding* texture_sampler_bindings, uint num_bindings)
        {
            iSDL_BindGPUComputeSamplers(compute_pass, first_slot, texture_sampler_bindings, num_bindings);
        }

        public static void SDL_BindGPUComputeStorageTextures(SDL_GPUComputePass* compute_pass, uint first_slot, SDL_GPUTexture** storage_textures, uint num_bindings)
        {
            iSDL_BindGPUComputeStorageTextures(compute_pass, first_slot, storage_textures, num_bindings);
        }

        public static void SDL_BindGPUComputeStorageBuffers(SDL_GPUComputePass* compute_pass, uint first_slot, SDL_GPUBuffer** storage_buffers, uint num_bindings)
        {
            iSDL_BindGPUComputeStorageBuffers(compute_pass, first_slot, storage_buffers, num_bindings);
        }

        public static void SDL_DispatchGPUCompute(SDL_GPUComputePass* compute_pass, uint groupcount_x, uint groupcount_y, uint groupcount_z)
        {
            iSDL_DispatchGPUCompute(compute_pass, groupcount_x, groupcount_y, groupcount_z);
        }

        public static void SDL_DispatchGPUComputeIndirect(SDL_GPUComputePass* compute_pass, SDL_GPUBuffer* buffer, uint offset)
        {
            iSDL_DispatchGPUComputeIndirect(compute_pass, buffer, offset);
        }

        public static void SDL_EndGPUComputePass(SDL_GPUComputePass* compute_pass)
        {
            iSDL_EndGPUComputePass(compute_pass);
        }

        public static void* SDL_MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer, SDL_Bool cycle)
        {
            return iSDL_MapGPUTransferBuffer(device, transfer_buffer, cycle);
        }

        public static void SDL_UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer)
        {
            iSDL_UnmapGPUTransferBuffer(device, transfer_buffer);
        }

        public static SDL_GPUCopyPass* SDL_BeginGPUCopyPass(SDL_GPUCommandBuffer* command_buffer)
        {
            return iSDL_BeginGPUCopyPass(command_buffer);
        }

        public static void SDL_UploadToGPUTexture(SDL_GPUCopyPass* copy_pass, SDL_GPUTextureTransferInfo* source, SDL_GPUTextureRegion* destination, SDL_Bool cycle)
        {
            iSDL_UploadToGPUTexture(copy_pass, source, destination, cycle);
        }

        public static void SDL_UploadToGPUBuffer(SDL_GPUCopyPass* copy_pass, SDL_GPUTransferBufferLocation* source, SDL_GPUBufferRegion* destination, SDL_Bool cycle)
        {
            iSDL_UploadToGPUBuffer(copy_pass, source, destination, cycle);
        }

        public static void SDL_CopyGPUTextureToTexture(SDL_GPUCopyPass* copy_pass, SDL_GPUTextureLocation* source, SDL_GPUTextureLocation* destination, uint w, uint h, uint d, SDL_Bool cycle)
        {
            iSDL_CopyGPUTextureToTexture(copy_pass, source, destination, w, h, d, cycle);
        }

        public static void SDL_CopyGPUBufferToBuffer(SDL_GPUCopyPass* copy_pass, SDL_GPUBufferLocation* source, SDL_GPUBufferLocation* destination, uint size, SDL_Bool cycle)
        {
            iSDL_CopyGPUBufferToBuffer(copy_pass, source, destination, size, cycle);
        }

        public static void SDL_DownloadFromGPUTexture(SDL_GPUCopyPass* copy_pass, SDL_GPUTextureRegion* source, SDL_GPUTextureTransferInfo* destination)
        {
            iSDL_DownloadFromGPUTexture(copy_pass, source, destination);
        }

        public static void SDL_DownloadFromGPUBuffer(SDL_GPUCopyPass* copy_pass, SDL_GPUBufferRegion* source, SDL_GPUTransferBufferLocation* destination)
        {
            iSDL_DownloadFromGPUBuffer(copy_pass, source, destination);
        }

        public static void SDL_EndGPUCopyPass(SDL_GPUCopyPass* copy_pass)
        {
            iSDL_EndGPUCopyPass(copy_pass);
        }

        public static void SDL_GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUTexture* texture)
        {
            iSDL_GenerateMipmapsForGPUTexture(command_buffer, texture);
        }

        public static void SDL_BlitGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUBlitInfo* info)
        {
            iSDL_BlitGPUTexture(command_buffer, info);
        }

        public static SDL_Bool SDL_WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition)
        {
            return iSDL_WindowSupportsGPUSwapchainComposition(device, window, swapchain_composition);
        }

        public static SDL_Bool SDL_WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode present_mode)
        {
            return iSDL_WindowSupportsGPUPresentMode(device, window, present_mode);
        }

        public static SDL_Bool SDL_ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_ClaimWindowForGPUDevice(device, window);
        }

        public static void SDL_ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window)
        {
            iSDL_ReleaseWindowFromGPUDevice(device, window);
        }

        public static SDL_Bool SDL_SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition, SDL_GPUPresentMode present_mode)
        {
            return iSDL_SetGPUSwapchainParameters(device, window, swapchain_composition, present_mode);
        }

        public static SDL_Bool SDL_SetGPUAllowedFramesInFlight(SDL_GPUDevice* device, uint allowed_frames_in_flight)
        {
            return iSDL_SetGPUAllowedFramesInFlight(device, allowed_frames_in_flight);
        }

        public static SDL_GPUTextureFormat SDL_GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_GetGPUSwapchainTextureFormat(device, window);
        }

        public static SDL_Bool SDL_AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, uint* swapchain_texture_width, uint* swapchain_texture_height)
        {
            return iSDL_AcquireGPUSwapchainTexture(command_buffer, window, swapchain_texture, swapchain_texture_width, swapchain_texture_height);
        }

        public static SDL_Bool SDL_WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_WaitForGPUSwapchain(device, window);
        }

        public static SDL_Bool SDL_WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, uint* swapchain_texture_width, uint* swapchain_texture_height)
        {
            return iSDL_WaitAndAcquireGPUSwapchainTexture(command_buffer, window, swapchain_texture, swapchain_texture_width, swapchain_texture_height);
        }

        public static SDL_Bool SDL_SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer)
        {
            return iSDL_SubmitGPUCommandBuffer(command_buffer);
        }

        public static SDL_GPUFence* SDL_SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* command_buffer)
        {
            return iSDL_SubmitGPUCommandBufferAndAcquireFence(command_buffer);
        }

        public static SDL_Bool SDL_CancelGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer)
        {
            return iSDL_CancelGPUCommandBuffer(command_buffer);
        }

        public static SDL_Bool SDL_WaitForGPUIdle(SDL_GPUDevice* device)
        {
            return iSDL_WaitForGPUIdle(device);
        }

        public static SDL_Bool SDL_WaitForGPUFences(SDL_GPUDevice* device, SDL_Bool wait_all, SDL_GPUFence** fences, uint num_fences)
        {
            return iSDL_WaitForGPUFences(device, wait_all, fences, num_fences);
        }

        public static SDL_Bool SDL_QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence)
        {
            return iSDL_QueryGPUFence(device, fence);
        }

        public static void SDL_ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence)
        {
            iSDL_ReleaseGPUFence(device, fence);
        }

        public static uint SDL_GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format)
        {
            return iSDL_GPUTextureFormatTexelBlockSize(format);
        }

        public static SDL_Bool SDL_GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, uint usage)
        {
            return iSDL_GPUTextureSupportsFormat(device, format, type, usage);
        }

        public static SDL_Bool SDL_GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sample_count)
        {
            return iSDL_GPUTextureSupportsSampleCount(device, format, sample_count);
        }

        public static uint SDL_CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format, uint width, uint height, uint depth_or_layer_count)
        {
            return iSDL_CalculateGPUTextureFormatSize(format, width, height, depth_or_layer_count);
        }

        public static SDL_PixelFormat SDL_GetPixelFormatFromGPUTextureFormat(SDL_GPUTextureFormat format)
        {
            return iSDL_GetPixelFormatFromGPUTextureFormat(format);
        }

        public static SDL_GPUTextureFormat SDL_GetGPUTextureFormatFromPixelFormat(SDL_PixelFormat format)
        {
            return iSDL_GetGPUTextureFormatFromPixelFormat(format);
        }
    }
}