using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static int SDL_GetNumAudioDrivers()
        {
            return iSDL_GetNumAudioDrivers();
        }

        internal static byte* SDL_GetAudioDriver(int index)
        {
            return iSDL_GetAudioDriver(index);
        }

        internal static byte* SDL_GetCurrentAudioDriver()
        {
            return iSDL_GetCurrentAudioDriver();
        }

        internal static uint* SDL_GetAudioPlaybackDevices(int* count)
        {
            return iSDL_GetAudioPlaybackDevices(count);
        }

        internal static uint* SDL_GetAudioRecordingDevices(int* count)
        {
            return iSDL_GetAudioRecordingDevices(count);
        }

        internal static byte* SDL_GetAudioDeviceName(uint devid)
        {
            return iSDL_GetAudioDeviceName(devid);
        }

        internal static SDL_Bool SDL_GetAudioDeviceFormat(uint devid, SDL_AudioSpec* spec, int* sample_frames)
        {
            return iSDL_GetAudioDeviceFormat(devid, spec, sample_frames);
        }

        internal static int* SDL_GetAudioDeviceChannelMap(uint devid, int* count)
        {
            return iSDL_GetAudioDeviceChannelMap(devid, count);
        }

        internal static uint SDL_OpenAudioDevice(uint devid, SDL_AudioSpec* spec)
        {
            return iSDL_OpenAudioDevice(devid, spec);
        }

        internal static SDL_Bool SDL_IsAudioDevicePhysical(uint devid)
        {
            return iSDL_IsAudioDevicePhysical(devid);
        }

        internal static SDL_Bool SDL_IsAudioDevicePlayback(uint devid)
        {
            return iSDL_IsAudioDevicePlayback(devid);
        }

        internal static SDL_Bool SDL_PauseAudioDevice(uint devid)
        {
            return iSDL_PauseAudioDevice(devid);
        }

        internal static SDL_Bool SDL_ResumeAudioDevice(uint devid)
        {
            return iSDL_ResumeAudioDevice(devid);
        }

        internal static SDL_Bool SDL_AudioDevicePaused(uint devid)
        {
            return iSDL_AudioDevicePaused(devid);
        }

        internal static float SDL_GetAudioDeviceGain(uint devid)
        {
            return iSDL_GetAudioDeviceGain(devid);
        }

        internal static SDL_Bool SDL_SetAudioDeviceGain(uint devid, float gain)
        {
            return iSDL_SetAudioDeviceGain(devid, gain);
        }

        internal static void SDL_CloseAudioDevice(uint devid)
        {
            iSDL_CloseAudioDevice(devid);
        }

        internal static SDL_Bool SDL_BindAudioStreams(uint devid, SDL_AudioStream** streams, int num_streams)
        {
            return iSDL_BindAudioStreams(devid, streams, num_streams);
        }

        internal static SDL_Bool SDL_BindAudioStream(uint devid, SDL_AudioStream* stream)
        {
            return iSDL_BindAudioStream(devid, stream);
        }

        internal static void SDL_UnbindAudioStreams(SDL_AudioStream** streams, int num_streams)
        {
            iSDL_UnbindAudioStreams(streams, num_streams);
        }

        internal static void SDL_UnbindAudioStream(SDL_AudioStream* stream)
        {
            iSDL_UnbindAudioStream(stream);
        }

        internal static uint SDL_GetAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamDevice(stream);
        }

        internal static SDL_AudioStream* SDL_CreateAudioStream(SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_CreateAudioStream(src_spec, dst_spec);
        }

        internal static uint SDL_GetAudioStreamProperties(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamProperties(stream);
        }

        internal static SDL_Bool SDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_GetAudioStreamFormat(stream, src_spec, dst_spec);
        }

        internal static SDL_Bool SDL_SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_SetAudioStreamFormat(stream, src_spec, dst_spec);
        }

        internal static float SDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamFrequencyRatio(stream);
        }

        internal static SDL_Bool SDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio)
        {
            return iSDL_SetAudioStreamFrequencyRatio(stream, ratio);
        }

        internal static float SDL_GetAudioStreamGain(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamGain(stream);
        }

        internal static SDL_Bool SDL_SetAudioStreamGain(SDL_AudioStream* stream, float gain)
        {
            return iSDL_SetAudioStreamGain(stream, gain);
        }

        internal static int* SDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count)
        {
            return iSDL_GetAudioStreamInputChannelMap(stream, count);
        }

        internal static int* SDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count)
        {
            return iSDL_GetAudioStreamOutputChannelMap(stream, count);
        }

        internal static SDL_Bool SDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* chmap, int count)
        {
            return iSDL_SetAudioStreamInputChannelMap(stream, chmap, count);
        }

        internal static SDL_Bool SDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* chmap, int count)
        {
            return iSDL_SetAudioStreamOutputChannelMap(stream, chmap, count);
        }

        internal static SDL_Bool SDL_PutAudioStreamData(SDL_AudioStream* stream, void* buf, int len)
        {
            return iSDL_PutAudioStreamData(stream, buf, len);
        }

        internal static SDL_Bool SDL_PutAudioStreamDataNoCopy(SDL_AudioStream* stream, void* buf, int len, IntPtr callback, void* userdata)
        {
            return iSDL_PutAudioStreamDataNoCopy(stream, buf, len, callback, userdata);
        }

        internal static SDL_Bool SDL_PutAudioStreamPlanarData(SDL_AudioStream* stream, void** channel_buffers, int num_channels, int num_samples)
        {
            return iSDL_PutAudioStreamPlanarData(stream, channel_buffers, num_channels, num_samples);
        }

        internal static int SDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len)
        {
            return iSDL_GetAudioStreamData(stream, buf, len);
        }

        internal static int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamAvailable(stream);
        }

        internal static int SDL_GetAudioStreamQueued(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamQueued(stream);
        }

        internal static SDL_Bool SDL_FlushAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_FlushAudioStream(stream);
        }

        internal static SDL_Bool SDL_ClearAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_ClearAudioStream(stream);
        }

        internal static SDL_Bool SDL_PauseAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_PauseAudioStreamDevice(stream);
        }

        internal static SDL_Bool SDL_ResumeAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_ResumeAudioStreamDevice(stream);
        }

        internal static SDL_Bool SDL_AudioStreamDevicePaused(SDL_AudioStream* stream)
        {
            return iSDL_AudioStreamDevicePaused(stream);
        }

        internal static SDL_Bool SDL_LockAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_LockAudioStream(stream);
        }

        internal static SDL_Bool SDL_UnlockAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_UnlockAudioStream(stream);
        }

        internal static SDL_Bool SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioStreamGetCallback(stream, callback, userdata);
        }

        internal static SDL_Bool SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioStreamPutCallback(stream, callback, userdata);
        }

        internal static void SDL_DestroyAudioStream(SDL_AudioStream* stream)
        {
            iSDL_DestroyAudioStream(stream);
        }

        internal static SDL_AudioStream* SDL_OpenAudioDeviceStream(uint devid, SDL_AudioSpec* spec, IntPtr callback, void* userdata)
        {
            return iSDL_OpenAudioDeviceStream(devid, spec, callback, userdata);
        }

        internal static SDL_Bool SDL_SetAudioPostmixCallback(uint devid, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioPostmixCallback(devid, callback, userdata);
        }

        internal static SDL_Bool SDL_LoadWAV_IO(SDL_IOStream* src, SDL_Bool closeio, SDL_AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            return iSDL_LoadWAV_IO(src, closeio, spec, audio_buf, audio_len);
        }

        internal static SDL_Bool SDL_LoadWAV(byte* path, SDL_AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            return iSDL_LoadWAV(path, spec, audio_buf, audio_len);
        }

        internal static SDL_Bool SDL_MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint len, float volume)
        {
            return iSDL_MixAudio(dst, src, format, len, volume);
        }

        internal static SDL_Bool SDL_ConvertAudioSamples(SDL_AudioSpec* src_spec, byte* src_data, int src_len, SDL_AudioSpec* dst_spec, byte** dst_data, int* dst_len)
        {
            return iSDL_ConvertAudioSamples(src_spec, src_data, src_len, dst_spec, dst_data, dst_len);
        }

        internal static byte* SDL_GetAudioFormatName(SDL_AudioFormat format)
        {
            return iSDL_GetAudioFormatName(format);
        }

        internal static int SDL_GetSilenceValueForFormat(SDL_AudioFormat format)
        {
            return iSDL_GetSilenceValueForFormat(format);
        }
    }
}