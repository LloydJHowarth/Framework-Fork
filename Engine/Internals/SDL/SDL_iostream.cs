using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_IOStream* SDL_IOFromFile(byte* file, byte* mode)
        {
            return iSDL_IOFromFile(file, mode);
        }

        internal static SDL_IOStream* SDL_IOFromMem(void* mem, nuint size)
        {
            return iSDL_IOFromMem(mem, size);
        }

        internal static SDL_IOStream* SDL_IOFromConstMem(void* mem, nuint size)
        {
            return iSDL_IOFromConstMem(mem, size);
        }

        internal static SDL_IOStream* SDL_IOFromDynamicMem()
        {
            return iSDL_IOFromDynamicMem();
        }

        internal static SDL_IOStream* SDL_OpenIO(SDL_IOStreamInterface* iface, void* userdata)
        {
            return iSDL_OpenIO(iface, userdata);
        }

        internal static SDL_Bool SDL_CloseIO(SDL_IOStream* context)
        {
            return iSDL_CloseIO(context);
        }

        internal static uint SDL_GetIOProperties(SDL_IOStream* context)
        {
            return iSDL_GetIOProperties(context);
        }

        internal static SDL_IOStatus SDL_GetIOStatus(SDL_IOStream* context)
        {
            return iSDL_GetIOStatus(context);
        }

        internal static long SDL_GetIOSize(SDL_IOStream* context)
        {
            return iSDL_GetIOSize(context);
        }

        internal static long SDL_SeekIO(SDL_IOStream* context, long offset, SDL_IOWhence whence)
        {
            return iSDL_SeekIO(context, offset, whence);
        }

        internal static long SDL_TellIO(SDL_IOStream* context)
        {
            return iSDL_TellIO(context);
        }

        internal static nuint SDL_ReadIO(SDL_IOStream* context, void* ptr, nuint size)
        {
            return iSDL_ReadIO(context, ptr, size);
        }

        internal static nuint SDL_WriteIO(SDL_IOStream* context, void* ptr, nuint size)
        {
            return iSDL_WriteIO(context, ptr, size);
        }

        internal static nuint SDL_IOprintf(SDL_IOStream* context, byte* fmt)
        {
            return iSDL_IOprintf(context, fmt);
        }

        internal static nuint SDL_IOvprintf(SDL_IOStream* context, byte* fmt, byte* ap)
        {
            return iSDL_IOvprintf(context, fmt, ap);
        }

        internal static SDL_Bool SDL_FlushIO(SDL_IOStream* context)
        {
            return iSDL_FlushIO(context);
        }

        internal static void* SDL_LoadFile_IO(SDL_IOStream* src, nuint* datasize, SDL_Bool closeio)
        {
            return iSDL_LoadFile_IO(src, datasize, closeio);
        }

        internal static void* SDL_LoadFile(byte* file, nuint* datasize)
        {
            return iSDL_LoadFile(file, datasize);
        }

        internal static SDL_Bool SDL_SaveFile_IO(SDL_IOStream* src, void* data, nuint datasize, SDL_Bool closeio)
        {
            return iSDL_SaveFile_IO(src, data, datasize, closeio);
        }

        internal static SDL_Bool SDL_SaveFile(byte* file, void* data, nuint datasize)
        {
            return iSDL_SaveFile(file, data, datasize);
        }

        internal static SDL_Bool SDL_ReadU8(SDL_IOStream* src, byte* value)
        {
            return iSDL_ReadU8(src, value);
        }

        internal static SDL_Bool SDL_ReadS8(SDL_IOStream* src, sbyte* value)
        {
            return iSDL_ReadS8(src, value);
        }

        internal static SDL_Bool SDL_ReadU16LE(SDL_IOStream* src, ushort* value)
        {
            return iSDL_ReadU16LE(src, value);
        }

        internal static SDL_Bool SDL_ReadS16LE(SDL_IOStream* src, short* value)
        {
            return iSDL_ReadS16LE(src, value);
        }

        internal static SDL_Bool SDL_ReadU16BE(SDL_IOStream* src, ushort* value)
        {
            return iSDL_ReadU16BE(src, value);
        }

        internal static SDL_Bool SDL_ReadS16BE(SDL_IOStream* src, short* value)
        {
            return iSDL_ReadS16BE(src, value);
        }

        internal static SDL_Bool SDL_ReadU32LE(SDL_IOStream* src, uint* value)
        {
            return iSDL_ReadU32LE(src, value);
        }

        internal static SDL_Bool SDL_ReadS32LE(SDL_IOStream* src, int* value)
        {
            return iSDL_ReadS32LE(src, value);
        }

        internal static SDL_Bool SDL_ReadU32BE(SDL_IOStream* src, uint* value)
        {
            return iSDL_ReadU32BE(src, value);
        }

        internal static SDL_Bool SDL_ReadS32BE(SDL_IOStream* src, int* value)
        {
            return iSDL_ReadS32BE(src, value);
        }

        internal static SDL_Bool SDL_ReadU64LE(SDL_IOStream* src, ulong* value)
        {
            return iSDL_ReadU64LE(src, value);
        }

        internal static SDL_Bool SDL_ReadS64LE(SDL_IOStream* src, long* value)
        {
            return iSDL_ReadS64LE(src, value);
        }

        internal static SDL_Bool SDL_ReadU64BE(SDL_IOStream* src, ulong* value)
        {
            return iSDL_ReadU64BE(src, value);
        }

        internal static SDL_Bool SDL_ReadS64BE(SDL_IOStream* src, long* value)
        {
            return iSDL_ReadS64BE(src, value);
        }

        internal static SDL_Bool SDL_WriteU8(SDL_IOStream* dst, byte value)
        {
            return iSDL_WriteU8(dst, value);
        }

        internal static SDL_Bool SDL_WriteS8(SDL_IOStream* dst, sbyte value)
        {
            return iSDL_WriteS8(dst, value);
        }

        internal static SDL_Bool SDL_WriteU16LE(SDL_IOStream* dst, ushort value)
        {
            return iSDL_WriteU16LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS16LE(SDL_IOStream* dst, short value)
        {
            return iSDL_WriteS16LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteU16BE(SDL_IOStream* dst, ushort value)
        {
            return iSDL_WriteU16BE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS16BE(SDL_IOStream* dst, short value)
        {
            return iSDL_WriteS16BE(dst, value);
        }

        internal static SDL_Bool SDL_WriteU32LE(SDL_IOStream* dst, uint value)
        {
            return iSDL_WriteU32LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS32LE(SDL_IOStream* dst, int value)
        {
            return iSDL_WriteS32LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteU32BE(SDL_IOStream* dst, uint value)
        {
            return iSDL_WriteU32BE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS32BE(SDL_IOStream* dst, int value)
        {
            return iSDL_WriteS32BE(dst, value);
        }

        internal static SDL_Bool SDL_WriteU64LE(SDL_IOStream* dst, ulong value)
        {
            return iSDL_WriteU64LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS64LE(SDL_IOStream* dst, long value)
        {
            return iSDL_WriteS64LE(dst, value);
        }

        internal static SDL_Bool SDL_WriteU64BE(SDL_IOStream* dst, ulong value)
        {
            return iSDL_WriteU64BE(dst, value);
        }

        internal static SDL_Bool SDL_WriteS64BE(SDL_IOStream* dst, long value)
        {
            return iSDL_WriteS64BE(dst, value);
        }
    }
}