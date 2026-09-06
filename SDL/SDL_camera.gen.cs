using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_Camera
    {
    }

    internal partial struct SDL_CameraSpec
    {
        public SDL_PixelFormat format;

        public SDL_Colorspace colorspace;

        public int width;

        public int height;

        public int framerate_numerator;

        public int framerate_denominator;
    }

    internal enum SDL_CameraPosition
    {
        SDL_CAMERA_POSITION_UNKNOWN,
        SDL_CAMERA_POSITION_FRONT_FACING,
        SDL_CAMERA_POSITION_BACK_FACING,
    }

    internal enum SDL_CameraPermissionState
    {
        SDL_CAMERA_PERMISSION_STATE_DENIED = -1,
        SDL_CAMERA_PERMISSION_STATE_PENDING,
        SDL_CAMERA_PERMISSION_STATE_APPROVED,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumCameraDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumCameraDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetCameraDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentCameraDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetCurrentCameraDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameras", ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID *")]
        private static extern uint* iSDL_GetCameras(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraSupportedFormats", ExactSpelling = true)]
        private static extern SDL_CameraSpec** iSDL_GetCameraSupportedFormats([NativeTypeName("SDL_CameraID")] uint instance_id, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPosition", ExactSpelling = true)]
        private static extern SDL_CameraPosition iSDL_GetCameraPosition([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenCamera", ExactSpelling = true)]
        private static extern SDL_Camera* iSDL_OpenCamera([NativeTypeName("SDL_CameraID")] uint instance_id, [NativeTypeName("const SDL_CameraSpec *")] SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPermissionState", ExactSpelling = true)]
        private static extern SDL_CameraPermissionState iSDL_GetCameraPermissionState(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID")]
        private static extern uint iSDL_GetCameraID(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetCameraProperties(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraFormat", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireCameraFrame", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_AcquireCameraFrame(SDL_Camera* camera, [NativeTypeName("Uint64 *")] ulong* timestampNS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseCameraFrame", ExactSpelling = true)]
        private static extern void iSDL_ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseCamera", ExactSpelling = true)]
        private static extern void iSDL_CloseCamera(SDL_Camera* camera);
    }
}
