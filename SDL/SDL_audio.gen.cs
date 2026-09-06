using System;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal enum SDL_AudioFormat
    {
        SDL_AUDIO_UNKNOWN = ((int)(0x0000U)),
        SDL_AUDIO_U8 = ((int)(0x0008U)),
        SDL_AUDIO_S8 = ((int)(0x8008U)),
        SDL_AUDIO_S16LE = ((int)(0x8010U)),
        SDL_AUDIO_S16BE = ((int)(0x9010U)),
        SDL_AUDIO_S32LE = ((int)(0x8020U)),
        SDL_AUDIO_S32BE = ((int)(0x9020U)),
        SDL_AUDIO_F32LE = ((int)(0x8120U)),
        SDL_AUDIO_F32BE = ((int)(0x9120U)),
        SDL_AUDIO_S16 = SDL_AUDIO_S16LE,
        SDL_AUDIO_S32 = SDL_AUDIO_S32LE,
        SDL_AUDIO_F32 = SDL_AUDIO_F32LE,
    }

    internal partial struct SDL_AudioSpec
    {
        public SDL_AudioFormat format;

        public int channels;

        public int freq;
    }

    internal partial struct SDL_AudioStream
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_AudioStreamDataCompleteCallback(void* userdata, [NativeTypeName("const void *")] void* buf, int buflen);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_AudioStreamCallback(void* userdata, SDL_AudioStream* stream, int additional_amount, int total_amount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_AudioPostmixCallback(void* userdata, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, float* buffer, int buflen);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAudioDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumAudioDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetAudioDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetCurrentAudioDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioPlaybackDevices", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        private static extern uint* iSDL_GetAudioPlaybackDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioRecordingDevices", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        private static extern uint* iSDL_GetAudioRecordingDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetAudioDeviceName([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetAudioDeviceFormat([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioSpec* spec, int* sample_frames);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceChannelMap", ExactSpelling = true)]
        private static extern int* iSDL_GetAudioDeviceChannelMap([NativeTypeName("SDL_AudioDeviceID")] uint devid, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        private static extern uint iSDL_OpenAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePhysical", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_IsAudioDevicePhysical([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePlayback", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_IsAudioDevicePlayback([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioDevicePaused", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceGain", ExactSpelling = true)]
        private static extern float iSDL_GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioDeviceGain", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAudioDevice", ExactSpelling = true)]
        private static extern void iSDL_CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStreams", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BindAudioStreams([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_BindAudioStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnbindAudioStreams", ExactSpelling = true)]
        private static extern void iSDL_UnbindAudioStreams([NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnbindAudioStream", ExactSpelling = true)]
        private static extern void iSDL_UnbindAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        private static extern uint iSDL_GetAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAudioStream", ExactSpelling = true)]
        private static extern SDL_AudioStream* iSDL_CreateAudioStream([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetAudioStreamProperties(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamFormat(SDL_AudioStream* stream, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamFrequencyRatio", ExactSpelling = true)]
        private static extern float iSDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFrequencyRatio", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamGain", ExactSpelling = true)]
        private static extern float iSDL_GetAudioStreamGain(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGain", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamGain(SDL_AudioStream* stream, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamInputChannelMap", ExactSpelling = true)]
        private static extern int* iSDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamOutputChannelMap", ExactSpelling = true)]
        private static extern int* iSDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamInputChannelMap", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamOutputChannelMap", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PutAudioStreamData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PutAudioStreamDataNoCopy", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PutAudioStreamDataNoCopy(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len, [NativeTypeName("SDL_AudioStreamDataCompleteCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PutAudioStreamPlanarData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PutAudioStreamPlanarData(SDL_AudioStream* stream, [NativeTypeName("const void *const *")] void** channel_buffers, int num_channels, int num_samples);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamData", ExactSpelling = true)]
        private static extern int iSDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamAvailable", ExactSpelling = true)]
        private static extern int iSDL_GetAudioStreamAvailable(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamQueued", ExactSpelling = true)]
        private static extern int iSDL_GetAudioStreamQueued(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_FlushAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ClearAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_PauseAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ResumeAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamDevicePaused", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_AudioStreamDevicePaused(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_UnlockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGetCallback", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamPutCallback", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAudioStream", ExactSpelling = true)]
        private static extern void iSDL_DestroyAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDeviceStream", ExactSpelling = true)]
        private static extern SDL_AudioStream* iSDL_OpenAudioDeviceStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioPostmixCallback", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_SetAudioPostmixCallback([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioPostmixCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV_IO", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LoadWAV_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDL_Bool closeio, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_LoadWAV([NativeTypeName("const char *")] byte* path, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MixAudio", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, SDL_AudioFormat format, [NativeTypeName("Uint32")] uint len, float volume);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertAudioSamples", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_ConvertAudioSamples([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetAudioFormatName(SDL_AudioFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSilenceValueForFormat", ExactSpelling = true)]
        private static extern int iSDL_GetSilenceValueForFormat(SDL_AudioFormat format);

        [NativeTypeName("#define SDL_AUDIO_MASK_BITSIZE (0xFFu)")]
        public const uint SDL_AUDIO_MASK_BITSIZE = (0xFFU);

        [NativeTypeName("#define SDL_AUDIO_MASK_FLOAT (1u<<8)")]
        public const uint SDL_AUDIO_MASK_FLOAT = (1U << 8);

        [NativeTypeName("#define SDL_AUDIO_MASK_BIG_ENDIAN (1u<<12)")]
        public const uint SDL_AUDIO_MASK_BIG_ENDIAN = (1U << 12);

        [NativeTypeName("#define SDL_AUDIO_MASK_SIGNED (1u<<15)")]
        public const uint SDL_AUDIO_MASK_SIGNED = (1U << 15);

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK ((SDL_AudioDeviceID) 0xFFFFFFFFu)")]
        public const uint SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_RECORDING ((SDL_AudioDeviceID) 0xFFFFFFFEu)")]
        public const uint SDL_AUDIO_DEVICE_DEFAULT_RECORDING = ((uint)(0xFFFFFFFEU));

        [NativeTypeName("#define SDL_PROP_AUDIOSTREAM_AUTO_CLEANUP_BOOLEAN \"SDL.audiostream.auto_cleanup\"")]
        public static string SDL_PROP_AUDIOSTREAM_AUTO_CLEANUP_BOOLEAN => "SDL.audiostream.auto_cleanup";
    }
}
