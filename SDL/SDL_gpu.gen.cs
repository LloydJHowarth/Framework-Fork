using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_GPUDevice
    {
    }

    internal partial struct SDL_GPUBuffer
    {
    }

    internal partial struct SDL_GPUTransferBuffer
    {
    }

    internal partial struct SDL_GPUTexture
    {
    }

    internal partial struct SDL_GPUSampler
    {
    }

    internal partial struct SDL_GPUShader
    {
    }

    internal partial struct SDL_GPUComputePipeline
    {
    }

    internal partial struct SDL_GPUGraphicsPipeline
    {
    }

    internal partial struct SDL_GPUCommandBuffer
    {
    }

    internal partial struct SDL_GPURenderPass
    {
    }

    internal partial struct SDL_GPUComputePass
    {
    }

    internal partial struct SDL_GPUCopyPass
    {
    }

    internal partial struct SDL_GPUFence
    {
    }

    internal enum SDL_GPUPrimitiveType
    {
        SDL_GPU_PRIMITIVETYPE_TRIANGLELIST,
        SDL_GPU_PRIMITIVETYPE_TRIANGLESTRIP,
        SDL_GPU_PRIMITIVETYPE_LINELIST,
        SDL_GPU_PRIMITIVETYPE_LINESTRIP,
        SDL_GPU_PRIMITIVETYPE_POINTLIST,
    }

    internal enum SDL_GPULoadOp
    {
        SDL_GPU_LOADOP_LOAD,
        SDL_GPU_LOADOP_CLEAR,
        SDL_GPU_LOADOP_DONT_CARE,
    }

    internal enum SDL_GPUStoreOp
    {
        SDL_GPU_STOREOP_STORE,
        SDL_GPU_STOREOP_DONT_CARE,
        SDL_GPU_STOREOP_RESOLVE,
        SDL_GPU_STOREOP_RESOLVE_AND_STORE,
    }

    internal enum SDL_GPUIndexElementSize
    {
        SDL_GPU_INDEXELEMENTSIZE_16BIT,
        SDL_GPU_INDEXELEMENTSIZE_32BIT,
    }

    internal enum SDL_GPUTextureFormat
    {
        SDL_GPU_TEXTUREFORMAT_INVALID,
        SDL_GPU_TEXTUREFORMAT_A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R10G10B10A2_UNORM,
        SDL_GPU_TEXTUREFORMAT_B5G6R5_UNORM,
        SDL_GPU_TEXTUREFORMAT_B5G5R5A1_UNORM,
        SDL_GPU_TEXTUREFORMAT_B4G4R4A4_UNORM,
        SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC4_R_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC5_RG_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC6H_RGB_FLOAT,
        SDL_GPU_TEXTUREFORMAT_BC6H_RGB_UFLOAT,
        SDL_GPU_TEXTUREFORMAT_R8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R16G16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32G32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R11G11B10_UFLOAT,
        SDL_GPU_TEXTUREFORMAT_R8_UINT,
        SDL_GPU_TEXTUREFORMAT_R8G8_UINT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UINT,
        SDL_GPU_TEXTUREFORMAT_R16_UINT,
        SDL_GPU_TEXTUREFORMAT_R16G16_UINT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UINT,
        SDL_GPU_TEXTUREFORMAT_R32_UINT,
        SDL_GPU_TEXTUREFORMAT_R32G32_UINT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_UINT,
        SDL_GPU_TEXTUREFORMAT_R8_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_INT,
        SDL_GPU_TEXTUREFORMAT_R16_INT,
        SDL_GPU_TEXTUREFORMAT_R16G16_INT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_INT,
        SDL_GPU_TEXTUREFORMAT_R32_INT,
        SDL_GPU_TEXTUREFORMAT_R32G32_INT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_D16_UNORM,
        SDL_GPU_TEXTUREFORMAT_D24_UNORM,
        SDL_GPU_TEXTUREFORMAT_D32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_D24_UNORM_S8_UINT,
        SDL_GPU_TEXTUREFORMAT_D32_FLOAT_S8_UINT,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_FLOAT,
    }

    internal enum SDL_GPUTextureType
    {
        SDL_GPU_TEXTURETYPE_2D,
        SDL_GPU_TEXTURETYPE_2D_ARRAY,
        SDL_GPU_TEXTURETYPE_3D,
        SDL_GPU_TEXTURETYPE_CUBE,
        SDL_GPU_TEXTURETYPE_CUBE_ARRAY,
    }

    internal enum SDL_GPUSampleCount
    {
        SDL_GPU_SAMPLECOUNT_1,
        SDL_GPU_SAMPLECOUNT_2,
        SDL_GPU_SAMPLECOUNT_4,
        SDL_GPU_SAMPLECOUNT_8,
    }

    internal enum SDL_GPUCubeMapFace
    {
        SDL_GPU_CUBEMAPFACE_POSITIVEX,
        SDL_GPU_CUBEMAPFACE_NEGATIVEX,
        SDL_GPU_CUBEMAPFACE_POSITIVEY,
        SDL_GPU_CUBEMAPFACE_NEGATIVEY,
        SDL_GPU_CUBEMAPFACE_POSITIVEZ,
        SDL_GPU_CUBEMAPFACE_NEGATIVEZ,
    }

    internal enum SDL_GPUTransferBufferUsage
    {
        SDL_GPU_TRANSFERBUFFERUSAGE_UPLOAD,
        SDL_GPU_TRANSFERBUFFERUSAGE_DOWNLOAD,
    }

    internal enum SDL_GPUShaderStage
    {
        SDL_GPU_SHADERSTAGE_VERTEX,
        SDL_GPU_SHADERSTAGE_FRAGMENT,
    }

    internal enum SDL_GPUVertexElementFormat
    {
        SDL_GPU_VERTEXELEMENTFORMAT_INVALID,
        SDL_GPU_VERTEXELEMENTFORMAT_INT,
        SDL_GPU_VERTEXELEMENTFORMAT_INT2,
        SDL_GPU_VERTEXELEMENTFORMAT_INT3,
        SDL_GPU_VERTEXELEMENTFORMAT_INT4,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT2,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT3,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT4,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT2,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT3,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT4,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE2,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE4,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT2,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT4,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT2,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT4,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_HALF2,
        SDL_GPU_VERTEXELEMENTFORMAT_HALF4,
    }

    internal enum SDL_GPUVertexInputRate
    {
        SDL_GPU_VERTEXINPUTRATE_VERTEX,
        SDL_GPU_VERTEXINPUTRATE_INSTANCE,
    }

    internal enum SDL_GPUFillMode
    {
        SDL_GPU_FILLMODE_FILL,
        SDL_GPU_FILLMODE_LINE,
    }

    internal enum SDL_GPUCullMode
    {
        SDL_GPU_CULLMODE_NONE,
        SDL_GPU_CULLMODE_FRONT,
        SDL_GPU_CULLMODE_BACK,
    }

    internal enum SDL_GPUFrontFace
    {
        SDL_GPU_FRONTFACE_COUNTER_CLOCKWISE,
        SDL_GPU_FRONTFACE_CLOCKWISE,
    }

    internal enum SDL_GPUCompareOp
    {
        SDL_GPU_COMPAREOP_INVALID,
        SDL_GPU_COMPAREOP_NEVER,
        SDL_GPU_COMPAREOP_LESS,
        SDL_GPU_COMPAREOP_EQUAL,
        SDL_GPU_COMPAREOP_LESS_OR_EQUAL,
        SDL_GPU_COMPAREOP_GREATER,
        SDL_GPU_COMPAREOP_NOT_EQUAL,
        SDL_GPU_COMPAREOP_GREATER_OR_EQUAL,
        SDL_GPU_COMPAREOP_ALWAYS,
    }

    internal enum SDL_GPUStencilOp
    {
        SDL_GPU_STENCILOP_INVALID,
        SDL_GPU_STENCILOP_KEEP,
        SDL_GPU_STENCILOP_ZERO,
        SDL_GPU_STENCILOP_REPLACE,
        SDL_GPU_STENCILOP_INCREMENT_AND_CLAMP,
        SDL_GPU_STENCILOP_DECREMENT_AND_CLAMP,
        SDL_GPU_STENCILOP_INVERT,
        SDL_GPU_STENCILOP_INCREMENT_AND_WRAP,
        SDL_GPU_STENCILOP_DECREMENT_AND_WRAP,
    }

    internal enum SDL_GPUBlendOp
    {
        SDL_GPU_BLENDOP_INVALID,
        SDL_GPU_BLENDOP_ADD,
        SDL_GPU_BLENDOP_SUBTRACT,
        SDL_GPU_BLENDOP_REVERSE_SUBTRACT,
        SDL_GPU_BLENDOP_MIN,
        SDL_GPU_BLENDOP_MAX,
    }

    internal enum SDL_GPUBlendFactor
    {
        SDL_GPU_BLENDFACTOR_INVALID,
        SDL_GPU_BLENDFACTOR_ZERO,
        SDL_GPU_BLENDFACTOR_ONE,
        SDL_GPU_BLENDFACTOR_SRC_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_COLOR,
        SDL_GPU_BLENDFACTOR_DST_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_COLOR,
        SDL_GPU_BLENDFACTOR_SRC_ALPHA,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_ALPHA,
        SDL_GPU_BLENDFACTOR_DST_ALPHA,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_ALPHA,
        SDL_GPU_BLENDFACTOR_CONSTANT_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_CONSTANT_COLOR,
        SDL_GPU_BLENDFACTOR_SRC_ALPHA_SATURATE,
    }

    internal enum SDL_GPUFilter
    {
        SDL_GPU_FILTER_NEAREST,
        SDL_GPU_FILTER_LINEAR,
    }

    internal enum SDL_GPUSamplerMipmapMode
    {
        SDL_GPU_SAMPLERMIPMAPMODE_NEAREST,
        SDL_GPU_SAMPLERMIPMAPMODE_LINEAR,
    }

    internal enum SDL_GPUSamplerAddressMode
    {
        SDL_GPU_SAMPLERADDRESSMODE_REPEAT,
        SDL_GPU_SAMPLERADDRESSMODE_MIRRORED_REPEAT,
        SDL_GPU_SAMPLERADDRESSMODE_CLAMP_TO_EDGE,
    }

    internal enum SDL_GPUPresentMode
    {
        SDL_GPU_PRESENTMODE_VSYNC,
        SDL_GPU_PRESENTMODE_IMMEDIATE,
        SDL_GPU_PRESENTMODE_MAILBOX,
    }

    internal enum SDL_GPUSwapchainComposition
    {
        SDL_GPU_SWAPCHAINCOMPOSITION_SDR,
        SDL_GPU_SWAPCHAINCOMPOSITION_SDR_LINEAR,
        SDL_GPU_SWAPCHAINCOMPOSITION_HDR_EXTENDED_LINEAR,
        SDL_GPU_SWAPCHAINCOMPOSITION_HDR10_ST2084,
    }

    internal partial struct SDL_GPUViewport
    {
        public float x;

        public float y;

        public float w;

        public float h;

        public float min_depth;

        public float max_depth;
    }

    internal unsafe partial struct SDL_GPUTextureTransferInfo
    {
        public SDL_GPUTransferBuffer* transfer_buffer;

        [NativeTypeName("Uint32")]
        public uint offset;

        [NativeTypeName("Uint32")]
        public uint pixels_per_row;

        [NativeTypeName("Uint32")]
        public uint rows_per_layer;
    }

    internal unsafe partial struct SDL_GPUTransferBufferLocation
    {
        public SDL_GPUTransferBuffer* transfer_buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    internal unsafe partial struct SDL_GPUTextureLocation
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint z;
    }

    internal unsafe partial struct SDL_GPUTextureRegion
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint z;

        [NativeTypeName("Uint32")]
        public uint w;

        [NativeTypeName("Uint32")]
        public uint h;

        [NativeTypeName("Uint32")]
        public uint d;
    }

    internal unsafe partial struct SDL_GPUBlitRegion
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer_or_depth_plane;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint w;

        [NativeTypeName("Uint32")]
        public uint h;
    }

    internal unsafe partial struct SDL_GPUBufferLocation
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    internal unsafe partial struct SDL_GPUBufferRegion
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;

        [NativeTypeName("Uint32")]
        public uint size;
    }

    internal partial struct SDL_GPUIndirectDrawCommand
    {
        [NativeTypeName("Uint32")]
        public uint num_vertices;

        [NativeTypeName("Uint32")]
        public uint num_instances;

        [NativeTypeName("Uint32")]
        public uint first_vertex;

        [NativeTypeName("Uint32")]
        public uint first_instance;
    }

    internal partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        [NativeTypeName("Uint32")]
        public uint num_indices;

        [NativeTypeName("Uint32")]
        public uint num_instances;

        [NativeTypeName("Uint32")]
        public uint first_index;

        [NativeTypeName("Sint32")]
        public int vertex_offset;

        [NativeTypeName("Uint32")]
        public uint first_instance;
    }

    internal partial struct SDL_GPUIndirectDispatchCommand
    {
        [NativeTypeName("Uint32")]
        public uint groupcount_x;

        [NativeTypeName("Uint32")]
        public uint groupcount_y;

        [NativeTypeName("Uint32")]
        public uint groupcount_z;
    }

    internal partial struct SDL_GPUSamplerCreateInfo
    {
        public SDL_GPUFilter min_filter;

        public SDL_GPUFilter mag_filter;

        public SDL_GPUSamplerMipmapMode mipmap_mode;

        public SDL_GPUSamplerAddressMode address_mode_u;

        public SDL_GPUSamplerAddressMode address_mode_v;

        public SDL_GPUSamplerAddressMode address_mode_w;

        public float mip_lod_bias;

        public float max_anisotropy;

        public SDL_GPUCompareOp compare_op;

        public float min_lod;

        public float max_lod;

        [NativeTypeName("bool")]
        public SDL_Bool enable_anisotropy;

        [NativeTypeName("bool")]
        public SDL_Bool enable_compare;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPUVertexBufferDescription
    {
        [NativeTypeName("Uint32")]
        public uint slot;

        [NativeTypeName("Uint32")]
        public uint pitch;

        public SDL_GPUVertexInputRate input_rate;

        [NativeTypeName("Uint32")]
        public uint instance_step_rate;
    }

    internal partial struct SDL_GPUVertexAttribute
    {
        [NativeTypeName("Uint32")]
        public uint location;

        [NativeTypeName("Uint32")]
        public uint buffer_slot;

        public SDL_GPUVertexElementFormat format;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    internal unsafe partial struct SDL_GPUVertexInputState
    {
        [NativeTypeName("const SDL_GPUVertexBufferDescription *")]
        public SDL_GPUVertexBufferDescription* vertex_buffer_descriptions;

        [NativeTypeName("Uint32")]
        public uint num_vertex_buffers;

        [NativeTypeName("const SDL_GPUVertexAttribute *")]
        public SDL_GPUVertexAttribute* vertex_attributes;

        [NativeTypeName("Uint32")]
        public uint num_vertex_attributes;
    }

    internal partial struct SDL_GPUStencilOpState
    {
        public SDL_GPUStencilOp fail_op;

        public SDL_GPUStencilOp pass_op;

        public SDL_GPUStencilOp depth_fail_op;

        public SDL_GPUCompareOp compare_op;
    }

    internal partial struct SDL_GPUColorTargetBlendState
    {
        public SDL_GPUBlendFactor src_color_blendfactor;

        public SDL_GPUBlendFactor dst_color_blendfactor;

        public SDL_GPUBlendOp color_blend_op;

        public SDL_GPUBlendFactor src_alpha_blendfactor;

        public SDL_GPUBlendFactor dst_alpha_blendfactor;

        public SDL_GPUBlendOp alpha_blend_op;

        [NativeTypeName("SDL_GPUColorComponentFlags")]
        public byte color_write_mask;

        [NativeTypeName("bool")]
        public SDL_Bool enable_blend;

        [NativeTypeName("bool")]
        public SDL_Bool enable_color_write_mask;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    internal unsafe partial struct SDL_GPUShaderCreateInfo
    {
        [NativeTypeName("size_t")]
        public nuint code_size;

        [NativeTypeName("const Uint8 *")]
        public byte* code;

        [NativeTypeName("const char *")]
        public byte* entrypoint;

        [NativeTypeName("SDL_GPUShaderFormat")]
        public uint format;

        public SDL_GPUShaderStage stage;

        [NativeTypeName("Uint32")]
        public uint num_samplers;

        [NativeTypeName("Uint32")]
        public uint num_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_uniform_buffers;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPUTextureCreateInfo
    {
        public SDL_GPUTextureType type;

        public SDL_GPUTextureFormat format;

        [NativeTypeName("SDL_GPUTextureUsageFlags")]
        public uint usage;

        [NativeTypeName("Uint32")]
        public uint width;

        [NativeTypeName("Uint32")]
        public uint height;

        [NativeTypeName("Uint32")]
        public uint layer_count_or_depth;

        [NativeTypeName("Uint32")]
        public uint num_levels;

        public SDL_GPUSampleCount sample_count;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPUBufferCreateInfo
    {
        [NativeTypeName("SDL_GPUBufferUsageFlags")]
        public uint usage;

        [NativeTypeName("Uint32")]
        public uint size;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPUTransferBufferCreateInfo
    {
        public SDL_GPUTransferBufferUsage usage;

        [NativeTypeName("Uint32")]
        public uint size;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal partial struct SDL_GPURasterizerState
    {
        public SDL_GPUFillMode fill_mode;

        public SDL_GPUCullMode cull_mode;

        public SDL_GPUFrontFace front_face;

        public float depth_bias_constant_factor;

        public float depth_bias_clamp;

        public float depth_bias_slope_factor;

        [NativeTypeName("bool")]
        public SDL_Bool enable_depth_bias;

        [NativeTypeName("bool")]
        public SDL_Bool enable_depth_clip;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    internal partial struct SDL_GPUMultisampleState
    {
        public SDL_GPUSampleCount sample_count;

        [NativeTypeName("Uint32")]
        public uint sample_mask;

        [NativeTypeName("bool")]
        public SDL_Bool enable_mask;

        [NativeTypeName("bool")]
        public SDL_Bool enable_alpha_to_coverage;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal partial struct SDL_GPUDepthStencilState
    {
        public SDL_GPUCompareOp compare_op;

        public SDL_GPUStencilOpState back_stencil_state;

        public SDL_GPUStencilOpState front_stencil_state;

        [NativeTypeName("Uint8")]
        public byte compare_mask;

        [NativeTypeName("Uint8")]
        public byte write_mask;

        [NativeTypeName("bool")]
        public SDL_Bool enable_depth_test;

        [NativeTypeName("bool")]
        public SDL_Bool enable_depth_write;

        [NativeTypeName("bool")]
        public SDL_Bool enable_stencil_test;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal partial struct SDL_GPUColorTargetDescription
    {
        public SDL_GPUTextureFormat format;

        public SDL_GPUColorTargetBlendState blend_state;
    }

    internal unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        [NativeTypeName("const SDL_GPUColorTargetDescription *")]
        public SDL_GPUColorTargetDescription* color_target_descriptions;

        [NativeTypeName("Uint32")]
        public uint num_color_targets;

        public SDL_GPUTextureFormat depth_stencil_format;

        [NativeTypeName("bool")]
        public SDL_Bool has_depth_stencil_target;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        public SDL_GPUShader* vertex_shader;

        public SDL_GPUShader* fragment_shader;

        public SDL_GPUVertexInputState vertex_input_state;

        public SDL_GPUPrimitiveType primitive_type;

        public SDL_GPURasterizerState rasterizer_state;

        public SDL_GPUMultisampleState multisample_state;

        public SDL_GPUDepthStencilState depth_stencil_state;

        public SDL_GPUGraphicsPipelineTargetInfo target_info;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal unsafe partial struct SDL_GPUComputePipelineCreateInfo
    {
        [NativeTypeName("size_t")]
        public nuint code_size;

        [NativeTypeName("const Uint8 *")]
        public byte* code;

        [NativeTypeName("const char *")]
        public byte* entrypoint;

        [NativeTypeName("SDL_GPUShaderFormat")]
        public uint format;

        [NativeTypeName("Uint32")]
        public uint num_samplers;

        [NativeTypeName("Uint32")]
        public uint num_readonly_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_readonly_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_readwrite_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_readwrite_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_uniform_buffers;

        [NativeTypeName("Uint32")]
        public uint threadcount_x;

        [NativeTypeName("Uint32")]
        public uint threadcount_y;

        [NativeTypeName("Uint32")]
        public uint threadcount_z;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    internal unsafe partial struct SDL_GPUColorTargetInfo
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer_or_depth_plane;

        public SDL_FColor clear_color;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPUTexture* resolve_texture;

        [NativeTypeName("Uint32")]
        public uint resolve_mip_level;

        [NativeTypeName("Uint32")]
        public uint resolve_layer;

        [NativeTypeName("bool")]
        public SDL_Bool cycle;

        [NativeTypeName("bool")]
        public SDL_Bool cycle_resolve_texture;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    internal unsafe partial struct SDL_GPUDepthStencilTargetInfo
    {
        public SDL_GPUTexture* texture;

        public float clear_depth;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPULoadOp stencil_load_op;

        public SDL_GPUStoreOp stencil_store_op;

        [NativeTypeName("bool")]
        public SDL_Bool cycle;

        [NativeTypeName("Uint8")]
        public byte clear_stencil;

        [NativeTypeName("Uint8")]
        public byte mip_level;

        [NativeTypeName("Uint8")]
        public byte layer;
    }

    internal partial struct SDL_GPUBlitInfo
    {
        public SDL_GPUBlitRegion source;

        public SDL_GPUBlitRegion destination;

        public SDL_GPULoadOp load_op;

        public SDL_FColor clear_color;

        public SDL_FlipMode flip_mode;

        public SDL_GPUFilter filter;

        [NativeTypeName("bool")]
        public SDL_Bool cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal unsafe partial struct SDL_GPUBufferBinding
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    internal unsafe partial struct SDL_GPUTextureSamplerBinding
    {
        public SDL_GPUTexture* texture;

        public SDL_GPUSampler* sampler;
    }

    internal unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("bool")]
        public SDL_Bool cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("bool")]
        public SDL_Bool cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    internal unsafe partial struct SDL_GPUVulkanOptions
    {
        [NativeTypeName("Uint32")]
        public uint vulkan_api_version;

        public void* feature_list;

        public void* vulkan_10_physical_device_features;

        [NativeTypeName("Uint32")]
        public uint device_extension_count;

        [NativeTypeName("const char **")]
        public byte** device_extension_names;

        [NativeTypeName("Uint32")]
        public uint instance_extension_count;

        [NativeTypeName("const char **")]
        public byte** instance_extension_names;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsShaderFormats", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GPUSupportsShaderFormats([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsProperties", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GPUSupportsProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDevice", ExactSpelling = true)]
        private static extern SDL_GPUDevice* iSDL_CreateGPUDevice([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("bool")] SDL_Bool debug_mode, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDeviceWithProperties", ExactSpelling = true)]
        private static extern SDL_GPUDevice* iSDL_CreateGPUDeviceWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyGPUDevice", ExactSpelling = true)]
        private static extern void iSDL_DestroyGPUDevice(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGPUDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumGPUDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetGPUDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDeviceDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetGPUDeviceDriver(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUShaderFormats", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GPUShaderFormat")]
        private static extern uint iSDL_GetGPUShaderFormats(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDeviceProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetGPUDeviceProperties(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUComputePipeline", ExactSpelling = true)]
        private static extern SDL_GPUComputePipeline* iSDL_CreateGPUComputePipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")] SDL_GPUComputePipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUGraphicsPipeline", ExactSpelling = true)]
        private static extern SDL_GPUGraphicsPipeline* iSDL_CreateGPUGraphicsPipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")] SDL_GPUGraphicsPipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUSampler", ExactSpelling = true)]
        private static extern SDL_GPUSampler* iSDL_CreateGPUSampler(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] SDL_GPUSamplerCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUShader", ExactSpelling = true)]
        private static extern SDL_GPUShader* iSDL_CreateGPUShader(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUShaderCreateInfo *")] SDL_GPUShaderCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTexture", ExactSpelling = true)]
        private static extern SDL_GPUTexture* iSDL_CreateGPUTexture(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTextureCreateInfo *")] SDL_GPUTextureCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUBuffer", ExactSpelling = true)]
        private static extern SDL_GPUBuffer* iSDL_CreateGPUBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUBufferCreateInfo *")] SDL_GPUBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTransferBuffer", ExactSpelling = true)]
        private static extern SDL_GPUTransferBuffer* iSDL_CreateGPUTransferBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")] SDL_GPUTransferBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBufferName", ExactSpelling = true)]
        private static extern void iSDL_SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer, [NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUTextureName", ExactSpelling = true)]
        private static extern void iSDL_SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture, [NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InsertGPUDebugLabel", ExactSpelling = true)]
        private static extern void iSDL_InsertGPUDebugLabel(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUDebugGroup", ExactSpelling = true)]
        private static extern void iSDL_PushGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PopGPUDebugGroup", ExactSpelling = true)]
        private static extern void iSDL_PopGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUTexture", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUTexture(SDL_GPUDevice* device, SDL_GPUTexture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUSampler", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUSampler(SDL_GPUDevice* device, SDL_GPUSampler* sampler);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUBuffer", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUBuffer(SDL_GPUDevice* device, SDL_GPUBuffer* buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUTransferBuffer", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUComputePipeline", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipeline* compute_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUShader", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUShader(SDL_GPUDevice* device, SDL_GPUShader* shader);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUGraphicsPipeline", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipeline* graphics_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireGPUCommandBuffer", ExactSpelling = true)]
        private static extern SDL_GPUCommandBuffer* iSDL_AcquireGPUCommandBuffer(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUVertexUniformData", ExactSpelling = true)]
        private static extern void iSDL_PushGPUVertexUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUFragmentUniformData", ExactSpelling = true)]
        private static extern void iSDL_PushGPUFragmentUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUComputeUniformData", ExactSpelling = true)]
        private static extern void iSDL_PushGPUComputeUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPURenderPass", ExactSpelling = true)]
        private static extern SDL_GPURenderPass* iSDL_BeginGPURenderPass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUColorTargetInfo *")] SDL_GPUColorTargetInfo* color_target_infos, [NativeTypeName("Uint32")] uint num_color_targets, [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")] SDL_GPUDepthStencilTargetInfo* depth_stencil_target_info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUGraphicsPipeline", ExactSpelling = true)]
        private static extern void iSDL_BindGPUGraphicsPipeline(SDL_GPURenderPass* render_pass, SDL_GPUGraphicsPipeline* graphics_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUViewport", ExactSpelling = true)]
        private static extern void iSDL_SetGPUViewport(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUViewport *")] SDL_GPUViewport* viewport);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUScissor", ExactSpelling = true)]
        private static extern void iSDL_SetGPUScissor(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_Rect *")] SDL_Rect* scissor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBlendConstants", ExactSpelling = true)]
        private static extern void iSDL_SetGPUBlendConstants(SDL_GPURenderPass* render_pass, SDL_FColor blend_constants);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUStencilReference", ExactSpelling = true)]
        private static extern void iSDL_SetGPUStencilReference(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint8")] byte reference);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexBuffers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUVertexBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUIndexBuffer", ExactSpelling = true)]
        private static extern void iSDL_BindGPUIndexBuffer(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize index_element_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexSamplers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUVertexSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageTextures", ExactSpelling = true)]
        private static extern void iSDL_BindGPUVertexStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageBuffers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUVertexStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentSamplers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUFragmentSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageTextures", ExactSpelling = true)]
        private static extern void iSDL_BindGPUFragmentStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageBuffers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUFragmentStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitives", ExactSpelling = true)]
        private static extern void iSDL_DrawGPUIndexedPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_indices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_index, [NativeTypeName("Sint32")] int vertex_offset, [NativeTypeName("Uint32")] uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitives", ExactSpelling = true)]
        private static extern void iSDL_DrawGPUPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_vertices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_vertex, [NativeTypeName("Uint32")] uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitivesIndirect", ExactSpelling = true)]
        private static extern void iSDL_DrawGPUPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect", ExactSpelling = true)]
        private static extern void iSDL_DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPURenderPass", ExactSpelling = true)]
        private static extern void iSDL_EndGPURenderPass(SDL_GPURenderPass* render_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUComputePass", ExactSpelling = true)]
        private static extern SDL_GPUComputePass* iSDL_BeginGPUComputePass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")] SDL_GPUStorageTextureReadWriteBinding* storage_texture_bindings, [NativeTypeName("Uint32")] uint num_storage_texture_bindings, [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")] SDL_GPUStorageBufferReadWriteBinding* storage_buffer_bindings, [NativeTypeName("Uint32")] uint num_storage_buffer_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputePipeline", ExactSpelling = true)]
        private static extern void iSDL_BindGPUComputePipeline(SDL_GPUComputePass* compute_pass, SDL_GPUComputePipeline* compute_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeSamplers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUComputeSamplers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageTextures", ExactSpelling = true)]
        private static extern void iSDL_BindGPUComputeStorageTextures(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageBuffers", ExactSpelling = true)]
        private static extern void iSDL_BindGPUComputeStorageBuffers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUCompute", ExactSpelling = true)]
        private static extern void iSDL_DispatchGPUCompute(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint groupcount_x, [NativeTypeName("Uint32")] uint groupcount_y, [NativeTypeName("Uint32")] uint groupcount_z);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUComputeIndirect", ExactSpelling = true)]
        private static extern void iSDL_DispatchGPUComputeIndirect(SDL_GPUComputePass* compute_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUComputePass", ExactSpelling = true)]
        private static extern void iSDL_EndGPUComputePass(SDL_GPUComputePass* compute_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapGPUTransferBuffer", ExactSpelling = true)]
        private static extern void* iSDL_MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer, [NativeTypeName("bool")] SDL_Bool cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnmapGPUTransferBuffer", ExactSpelling = true)]
        private static extern void iSDL_UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUCopyPass", ExactSpelling = true)]
        private static extern SDL_GPUCopyPass* iSDL_BeginGPUCopyPass(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUTexture", ExactSpelling = true)]
        private static extern void iSDL_UploadToGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* source, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* destination, [NativeTypeName("bool")] SDL_Bool cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUBuffer", ExactSpelling = true)]
        private static extern void iSDL_UploadToGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* source, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* destination, [NativeTypeName("bool")] SDL_Bool cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUTextureToTexture", ExactSpelling = true)]
        private static extern void iSDL_CopyGPUTextureToTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* source, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* destination, [NativeTypeName("Uint32")] uint w, [NativeTypeName("Uint32")] uint h, [NativeTypeName("Uint32")] uint d, [NativeTypeName("bool")] SDL_Bool cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUBufferToBuffer", ExactSpelling = true)]
        private static extern void iSDL_CopyGPUBufferToBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* source, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* destination, [NativeTypeName("Uint32")] uint size, [NativeTypeName("bool")] SDL_Bool cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUTexture", ExactSpelling = true)]
        private static extern void iSDL_DownloadFromGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* source, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUBuffer", ExactSpelling = true)]
        private static extern void iSDL_DownloadFromGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* source, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUCopyPass", ExactSpelling = true)]
        private static extern void iSDL_EndGPUCopyPass(SDL_GPUCopyPass* copy_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GenerateMipmapsForGPUTexture", ExactSpelling = true)]
        private static extern void iSDL_GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUTexture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitGPUTexture", ExactSpelling = true)]
        private static extern void iSDL_BlitGPUTexture(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUBlitInfo *")] SDL_GPUBlitInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUPresentMode", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClaimWindowForGPUDevice", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseWindowFromGPUDevice", ExactSpelling = true)]
        private static extern void iSDL_ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUSwapchainParameters", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUAllowedFramesInFlight", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetGPUAllowedFramesInFlight(SDL_GPUDevice* device, [NativeTypeName("Uint32")] uint allowed_frames_in_flight);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUSwapchainTextureFormat", ExactSpelling = true)]
        private static extern SDL_GPUTextureFormat iSDL_GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireGPUSwapchainTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUSwapchain", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBuffer", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence", ExactSpelling = true)]
        private static extern SDL_GPUFence* iSDL_SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CancelGPUCommandBuffer", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_CancelGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUIdle", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WaitForGPUIdle(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUFences", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_WaitForGPUFences(SDL_GPUDevice* device, [NativeTypeName("bool")] SDL_Bool wait_all, [NativeTypeName("SDL_GPUFence *const *")] SDL_GPUFence** fences, [NativeTypeName("Uint32")] uint num_fences);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QueryGPUFence", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUFence", ExactSpelling = true)]
        private static extern void iSDL_ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureFormatTexelBlockSize", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsSampleCount", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sample_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CalculateGPUTextureFormatSize", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        private static extern uint iSDL_CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format, [NativeTypeName("Uint32")] uint width, [NativeTypeName("Uint32")] uint height, [NativeTypeName("Uint32")] uint depth_or_layer_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatFromGPUTextureFormat", ExactSpelling = true)]
        private static extern SDL_PixelFormat iSDL_GetPixelFormatFromGPUTextureFormat(SDL_GPUTextureFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUTextureFormatFromPixelFormat", ExactSpelling = true)]
        private static extern SDL_GPUTextureFormat iSDL_GetGPUTextureFormatFromPixelFormat(SDL_PixelFormat format);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_SAMPLER (1u << 0)")]
        public const uint SDL_GPU_TEXTUREUSAGE_SAMPLER = (1U << 0);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COLOR_TARGET (1u << 1)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COLOR_TARGET = (1U << 1);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_DEPTH_STENCIL_TARGET (1u << 2)")]
        public const uint SDL_GPU_TEXTUREUSAGE_DEPTH_STENCIL_TARGET = (1U << 2);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_GRAPHICS_STORAGE_READ (1u << 3)")]
        public const uint SDL_GPU_TEXTUREUSAGE_GRAPHICS_STORAGE_READ = (1U << 3);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_READ (1u << 4)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_READ = (1U << 4);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_WRITE (1u << 5)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_WRITE = (1U << 5);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_SIMULTANEOUS_READ_WRITE (1u << 6)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_SIMULTANEOUS_READ_WRITE = (1U << 6);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_VERTEX (1u << 0)")]
        public const uint SDL_GPU_BUFFERUSAGE_VERTEX = (1U << 0);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_INDEX (1u << 1)")]
        public const uint SDL_GPU_BUFFERUSAGE_INDEX = (1U << 1);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_INDIRECT (1u << 2)")]
        public const uint SDL_GPU_BUFFERUSAGE_INDIRECT = (1U << 2);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_GRAPHICS_STORAGE_READ (1u << 3)")]
        public const uint SDL_GPU_BUFFERUSAGE_GRAPHICS_STORAGE_READ = (1U << 3);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_READ (1u << 4)")]
        public const uint SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_READ = (1U << 4);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_WRITE (1u << 5)")]
        public const uint SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_WRITE = (1U << 5);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_INVALID 0")]
        public const int SDL_GPU_SHADERFORMAT_INVALID = 0;

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_PRIVATE (1u << 0)")]
        public const uint SDL_GPU_SHADERFORMAT_PRIVATE = (1U << 0);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_SPIRV (1u << 1)")]
        public const uint SDL_GPU_SHADERFORMAT_SPIRV = (1U << 1);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_DXBC (1u << 2)")]
        public const uint SDL_GPU_SHADERFORMAT_DXBC = (1U << 2);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_DXIL (1u << 3)")]
        public const uint SDL_GPU_SHADERFORMAT_DXIL = (1U << 3);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_MSL (1u << 4)")]
        public const uint SDL_GPU_SHADERFORMAT_MSL = (1U << 4);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_METALLIB (1u << 5)")]
        public const uint SDL_GPU_SHADERFORMAT_METALLIB = (1U << 5);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_R (1u << 0)")]
        public const uint SDL_GPU_COLORCOMPONENT_R = (1U << 0);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_G (1u << 1)")]
        public const uint SDL_GPU_COLORCOMPONENT_G = (1U << 1);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_B (1u << 2)")]
        public const uint SDL_GPU_COLORCOMPONENT_B = (1U << 2);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_A (1u << 3)")]
        public const uint SDL_GPU_COLORCOMPONENT_A = (1U << 3);

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_DEBUGMODE_BOOLEAN \"SDL.gpu.device.create.debugmode\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_DEBUGMODE_BOOLEAN => "SDL.gpu.device.create.debugmode";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_PREFERLOWPOWER_BOOLEAN \"SDL.gpu.device.create.preferlowpower\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_PREFERLOWPOWER_BOOLEAN => "SDL.gpu.device.create.preferlowpower";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VERBOSE_BOOLEAN \"SDL.gpu.device.create.verbose\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_VERBOSE_BOOLEAN => "SDL.gpu.device.create.verbose";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_NAME_STRING \"SDL.gpu.device.create.name\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_NAME_STRING => "SDL.gpu.device.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_CLIP_DISTANCE_BOOLEAN \"SDL.gpu.device.create.feature.clip_distance\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_FEATURE_CLIP_DISTANCE_BOOLEAN => "SDL.gpu.device.create.feature.clip_distance";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_DEPTH_CLAMPING_BOOLEAN \"SDL.gpu.device.create.feature.depth_clamping\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_FEATURE_DEPTH_CLAMPING_BOOLEAN => "SDL.gpu.device.create.feature.depth_clamping";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_INDIRECT_DRAW_FIRST_INSTANCE_BOOLEAN \"SDL.gpu.device.create.feature.indirect_draw_first_instance\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_FEATURE_INDIRECT_DRAW_FIRST_INSTANCE_BOOLEAN => "SDL.gpu.device.create.feature.indirect_draw_first_instance";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_ANISOTROPY_BOOLEAN \"SDL.gpu.device.create.feature.anisotropy\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_FEATURE_ANISOTROPY_BOOLEAN => "SDL.gpu.device.create.feature.anisotropy";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_PRIVATE_BOOLEAN \"SDL.gpu.device.create.shaders.private\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_PRIVATE_BOOLEAN => "SDL.gpu.device.create.shaders.private";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_SPIRV_BOOLEAN \"SDL.gpu.device.create.shaders.spirv\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_SPIRV_BOOLEAN => "SDL.gpu.device.create.shaders.spirv";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXBC_BOOLEAN \"SDL.gpu.device.create.shaders.dxbc\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXBC_BOOLEAN => "SDL.gpu.device.create.shaders.dxbc";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXIL_BOOLEAN \"SDL.gpu.device.create.shaders.dxil\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXIL_BOOLEAN => "SDL.gpu.device.create.shaders.dxil";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_MSL_BOOLEAN \"SDL.gpu.device.create.shaders.msl\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_MSL_BOOLEAN => "SDL.gpu.device.create.shaders.msl";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_METALLIB_BOOLEAN \"SDL.gpu.device.create.shaders.metallib\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_SHADERS_METALLIB_BOOLEAN => "SDL.gpu.device.create.shaders.metallib";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_ALLOW_FEWER_RESOURCE_SLOTS_BOOLEAN \"SDL.gpu.device.create.d3d12.allowtier1resourcebinding\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_D3D12_ALLOW_FEWER_RESOURCE_SLOTS_BOOLEAN => "SDL.gpu.device.create.d3d12.allowtier1resourcebinding";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_SEMANTIC_NAME_STRING \"SDL.gpu.device.create.d3d12.semantic\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_D3D12_SEMANTIC_NAME_STRING => "SDL.gpu.device.create.d3d12.semantic";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_VERSION_NUMBER \"SDL.gpu.device.create.d3d12.agility_sdk_version\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_VERSION_NUMBER => "SDL.gpu.device.create.d3d12.agility_sdk_version";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_PATH_STRING \"SDL.gpu.device.create.d3d12.agility_sdk_path\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_PATH_STRING => "SDL.gpu.device.create.d3d12.agility_sdk_path";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VULKAN_REQUIRE_HARDWARE_ACCELERATION_BOOLEAN \"SDL.gpu.device.create.vulkan.requirehardwareacceleration\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_VULKAN_REQUIRE_HARDWARE_ACCELERATION_BOOLEAN => "SDL.gpu.device.create.vulkan.requirehardwareacceleration";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VULKAN_OPTIONS_POINTER \"SDL.gpu.device.create.vulkan.options\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_VULKAN_OPTIONS_POINTER => "SDL.gpu.device.create.vulkan.options";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_METAL_ALLOW_MACFAMILY1_BOOLEAN \"SDL.gpu.device.create.metal.allowmacfamily1\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_METAL_ALLOW_MACFAMILY1_BOOLEAN => "SDL.gpu.device.create.metal.allowmacfamily1";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_ENABLE_BOOLEAN \"SDL.gpu.device.create.xr.enable\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_ENABLE_BOOLEAN => "SDL.gpu.device.create.xr.enable";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_INSTANCE_POINTER \"SDL.gpu.device.create.xr.instance_out\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_INSTANCE_POINTER => "SDL.gpu.device.create.xr.instance_out";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_SYSTEM_ID_POINTER \"SDL.gpu.device.create.xr.system_id_out\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_SYSTEM_ID_POINTER => "SDL.gpu.device.create.xr.system_id_out";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_VERSION_NUMBER \"SDL.gpu.device.create.xr.version\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_VERSION_NUMBER => "SDL.gpu.device.create.xr.version";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_FORM_FACTOR_NUMBER \"SDL.gpu.device.create.xr.form_factor\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_FORM_FACTOR_NUMBER => "SDL.gpu.device.create.xr.form_factor";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_EXTENSION_COUNT_NUMBER \"SDL.gpu.device.create.xr.extensions.count\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_EXTENSION_COUNT_NUMBER => "SDL.gpu.device.create.xr.extensions.count";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_EXTENSION_NAMES_POINTER \"SDL.gpu.device.create.xr.extensions.names\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_EXTENSION_NAMES_POINTER => "SDL.gpu.device.create.xr.extensions.names";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_LAYER_COUNT_NUMBER \"SDL.gpu.device.create.xr.layers.count\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_LAYER_COUNT_NUMBER => "SDL.gpu.device.create.xr.layers.count";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_LAYER_NAMES_POINTER \"SDL.gpu.device.create.xr.layers.names\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_LAYER_NAMES_POINTER => "SDL.gpu.device.create.xr.layers.names";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_APPLICATION_NAME_STRING \"SDL.gpu.device.create.xr.application.name\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_APPLICATION_NAME_STRING => "SDL.gpu.device.create.xr.application.name";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_APPLICATION_VERSION_NUMBER \"SDL.gpu.device.create.xr.application.version\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_APPLICATION_VERSION_NUMBER => "SDL.gpu.device.create.xr.application.version";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_ENGINE_NAME_STRING \"SDL.gpu.device.create.xr.engine.name\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_ENGINE_NAME_STRING => "SDL.gpu.device.create.xr.engine.name";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_XR_ENGINE_VERSION_NUMBER \"SDL.gpu.device.create.xr.engine.version\"")]
        public static string SDL_PROP_GPU_DEVICE_CREATE_XR_ENGINE_VERSION_NUMBER => "SDL.gpu.device.create.xr.engine.version";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_NAME_STRING \"SDL.gpu.device.name\"")]
        public static string SDL_PROP_GPU_DEVICE_NAME_STRING => "SDL.gpu.device.name";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_NAME_STRING \"SDL.gpu.device.driver_name\"")]
        public static string SDL_PROP_GPU_DEVICE_DRIVER_NAME_STRING => "SDL.gpu.device.driver_name";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_VERSION_STRING \"SDL.gpu.device.driver_version\"")]
        public static string SDL_PROP_GPU_DEVICE_DRIVER_VERSION_STRING => "SDL.gpu.device.driver_version";

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_INFO_STRING \"SDL.gpu.device.driver_info\"")]
        public static string SDL_PROP_GPU_DEVICE_DRIVER_INFO_STRING => "SDL.gpu.device.driver_info";

        [NativeTypeName("#define SDL_PROP_GPU_COMPUTEPIPELINE_CREATE_NAME_STRING \"SDL.gpu.computepipeline.create.name\"")]
        public static string SDL_PROP_GPU_COMPUTEPIPELINE_CREATE_NAME_STRING => "SDL.gpu.computepipeline.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_GRAPHICSPIPELINE_CREATE_NAME_STRING \"SDL.gpu.graphicspipeline.create.name\"")]
        public static string SDL_PROP_GPU_GRAPHICSPIPELINE_CREATE_NAME_STRING => "SDL.gpu.graphicspipeline.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_SAMPLER_CREATE_NAME_STRING \"SDL.gpu.sampler.create.name\"")]
        public static string SDL_PROP_GPU_SAMPLER_CREATE_NAME_STRING => "SDL.gpu.sampler.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_SHADER_CREATE_NAME_STRING \"SDL.gpu.shader.create.name\"")]
        public static string SDL_PROP_GPU_SHADER_CREATE_NAME_STRING => "SDL.gpu.shader.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_R_FLOAT \"SDL.gpu.texture.create.d3d12.clear.r\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_R_FLOAT => "SDL.gpu.texture.create.d3d12.clear.r";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_G_FLOAT \"SDL.gpu.texture.create.d3d12.clear.g\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_G_FLOAT => "SDL.gpu.texture.create.d3d12.clear.g";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_B_FLOAT \"SDL.gpu.texture.create.d3d12.clear.b\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_B_FLOAT => "SDL.gpu.texture.create.d3d12.clear.b";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_A_FLOAT \"SDL.gpu.texture.create.d3d12.clear.a\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_A_FLOAT => "SDL.gpu.texture.create.d3d12.clear.a";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_DEPTH_FLOAT \"SDL.gpu.texture.create.d3d12.clear.depth\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_DEPTH_FLOAT => "SDL.gpu.texture.create.d3d12.clear.depth";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_STENCIL_NUMBER \"SDL.gpu.texture.create.d3d12.clear.stencil\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_STENCIL_NUMBER => "SDL.gpu.texture.create.d3d12.clear.stencil";

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_NAME_STRING \"SDL.gpu.texture.create.name\"")]
        public static string SDL_PROP_GPU_TEXTURE_CREATE_NAME_STRING => "SDL.gpu.texture.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_BUFFER_CREATE_NAME_STRING \"SDL.gpu.buffer.create.name\"")]
        public static string SDL_PROP_GPU_BUFFER_CREATE_NAME_STRING => "SDL.gpu.buffer.create.name";

        [NativeTypeName("#define SDL_PROP_GPU_TRANSFERBUFFER_CREATE_NAME_STRING \"SDL.gpu.transferbuffer.create.name\"")]
        public static string SDL_PROP_GPU_TRANSFERBUFFER_CREATE_NAME_STRING => "SDL.gpu.transferbuffer.create.name";
    }
}
