using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static int SDL_GetNumCameraDrivers()
        {
            return iSDL_GetNumCameraDrivers();
        }

        internal static byte* SDL_GetCameraDriver(int index)
        {
            return iSDL_GetCameraDriver(index);
        }

        internal static byte* SDL_GetCurrentCameraDriver()
        {
            return iSDL_GetCurrentCameraDriver();
        }

        internal static uint* SDL_GetCameras(int* count)
        {
            return iSDL_GetCameras(count);
        }

        internal static SDL_CameraSpec** SDL_GetCameraSupportedFormats(uint instance_id, int* count)
        {
            return iSDL_GetCameraSupportedFormats(instance_id, count);
        }

        internal static byte* SDL_GetCameraName(uint instance_id)
        {
            return iSDL_GetCameraName(instance_id);
        }

        internal static SDL_CameraPosition SDL_GetCameraPosition(uint instance_id)
        {
            return iSDL_GetCameraPosition(instance_id);
        }

        internal static SDL_Camera* SDL_OpenCamera(uint instance_id, SDL_CameraSpec* spec)
        {
            return iSDL_OpenCamera(instance_id, spec);
        }

        internal static SDL_CameraPermissionState SDL_GetCameraPermissionState(SDL_Camera* camera)
        {
            return iSDL_GetCameraPermissionState(camera);
        }

        internal static uint SDL_GetCameraID(SDL_Camera* camera)
        {
            return iSDL_GetCameraID(camera);
        }

        internal static uint SDL_GetCameraProperties(SDL_Camera* camera)
        {
            return iSDL_GetCameraProperties(camera);
        }

        internal static SDL_Bool SDL_GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec)
        {
            return iSDL_GetCameraFormat(camera, spec);
        }

        internal static SDL_Surface* SDL_AcquireCameraFrame(SDL_Camera* camera, ulong* timestampNS)
        {
            return iSDL_AcquireCameraFrame(camera, timestampNS);
        }

        internal static void SDL_ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame)
        {
            iSDL_ReleaseCameraFrame(camera, frame);
        }

        internal static void SDL_CloseCamera(SDL_Camera* camera)
        {
            iSDL_CloseCamera(camera);
        }
    }
}