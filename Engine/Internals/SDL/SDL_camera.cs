using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public static unsafe partial class SDL
    {
        public static int SDL_GetNumCameraDrivers()
        {
            return iSDL_GetNumCameraDrivers();
        }

        public static byte* SDL_GetCameraDriver(int index)
        {
            return iSDL_GetCameraDriver(index);
        }

        public static byte* SDL_GetCurrentCameraDriver()
        {
            return iSDL_GetCurrentCameraDriver();
        }

        public static uint* SDL_GetCameras(int* count)
        {
            return iSDL_GetCameras(count);
        }

        public static SDL_CameraSpec** SDL_GetCameraSupportedFormats(uint instance_id, int* count)
        {
            return iSDL_GetCameraSupportedFormats(instance_id, count);
        }

        public static byte* SDL_GetCameraName(uint instance_id)
        {
            return iSDL_GetCameraName(instance_id);
        }

        public static SDL_CameraPosition SDL_GetCameraPosition(uint instance_id)
        {
            return iSDL_GetCameraPosition(instance_id);
        }

        public static SDL_Camera* SDL_OpenCamera(uint instance_id, SDL_CameraSpec* spec)
        {
            return iSDL_OpenCamera(instance_id, spec);
        }

        public static SDL_CameraPermissionState SDL_GetCameraPermissionState(SDL_Camera* camera)
        {
            return iSDL_GetCameraPermissionState(camera);
        }

        public static uint SDL_GetCameraID(SDL_Camera* camera)
        {
            return iSDL_GetCameraID(camera);
        }

        public static uint SDL_GetCameraProperties(SDL_Camera* camera)
        {
            return iSDL_GetCameraProperties(camera);
        }

        public static SDL_Bool SDL_GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec)
        {
            return iSDL_GetCameraFormat(camera, spec);
        }

        public static SDL_Surface* SDL_AcquireCameraFrame(SDL_Camera* camera, ulong* timestampNS)
        {
            return iSDL_AcquireCameraFrame(camera, timestampNS);
        }

        public static void SDL_ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame)
        {
            iSDL_ReleaseCameraFrame(camera, frame);
        }

        public static void SDL_CloseCamera(SDL_Camera* camera)
        {
            iSDL_CloseCamera(camera);
        }
    }
}