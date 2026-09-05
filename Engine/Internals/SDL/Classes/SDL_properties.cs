using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static uint SDL_GetGlobalProperties()
        {
            return iSDL_GetGlobalProperties();
        }

        public static uint SDL_CreateProperties()
        {
            return iSDL_CreateProperties();
        }

        public static SDL_Bool SDL_CopyProperties(uint src, uint dst)
        {
            return iSDL_CopyProperties(src, dst);
        }

        public static SDL_Bool SDL_LockProperties(uint props)
        {
            return iSDL_LockProperties(props);
        }

        public static void SDL_UnlockProperties(uint props)
        {
            iSDL_UnlockProperties(props);
        }

        public static SDL_Bool SDL_SetPointerPropertyWithCleanup(uint props, byte* name, void* value, IntPtr cleanup, void* userdata)
        {
            return iSDL_SetPointerPropertyWithCleanup(props, name, value, cleanup, userdata);
        }

        public static SDL_Bool SDL_SetPointerProperty(uint props, byte* name, void* value)
        {
            return iSDL_SetPointerProperty(props, name, value);
        }

        public static SDL_Bool SDL_SetStringProperty(uint props, byte* name, byte* value)
        {
            return iSDL_SetStringProperty(props, name, value);
        }

        public static SDL_Bool SDL_SetNumberProperty(uint props, byte* name, long value)
        {
            return iSDL_SetNumberProperty(props, name, value);
        }

        public static SDL_Bool SDL_SetFloatProperty(uint props, byte* name, float value)
        {
            return iSDL_SetFloatProperty(props, name, value);
        }

        public static SDL_Bool SDL_SetBooleanProperty(uint props, byte* name, SDL_Bool value)
        {
            return iSDL_SetBooleanProperty(props, name, value);
        }

        public static SDL_Bool SDL_HasProperty(uint props, byte* name)
        {
            return iSDL_HasProperty(props, name);
        }

        public static SDL_PropertyType SDL_GetPropertyType(uint props, byte* name)
        {
            return iSDL_GetPropertyType(props, name);
        }

        public static void* SDL_GetPointerProperty(uint props, byte* name, void* default_value)
        {
            return iSDL_GetPointerProperty(props, name, default_value);
        }

        public static byte* SDL_GetStringProperty(uint props, byte* name, byte* default_value)
        {
            return iSDL_GetStringProperty(props, name, default_value);
        }

        public static long SDL_GetNumberProperty(uint props, byte* name, long default_value)
        {
            return iSDL_GetNumberProperty(props, name, default_value);
        }

        public static float SDL_GetFloatProperty(uint props, byte* name, float default_value)
        {
            return iSDL_GetFloatProperty(props, name, default_value);
        }

        public static SDL_Bool SDL_GetBooleanProperty(uint props, byte* name, SDL_Bool default_value)
        {
            return iSDL_GetBooleanProperty(props, name, default_value);
        }

        public static SDL_Bool SDL_ClearProperty(uint props, byte* name)
        {
            return iSDL_ClearProperty(props, name);
        }

        public static int SDL_GetNumProperties(uint props)
        {
            return iSDL_GetNumProperties(props);
        }

        public static SDL_Bool SDL_EnumerateProperties(uint props, IntPtr callback, void* userdata)
        {
            return iSDL_EnumerateProperties(props, callback, userdata);
        }

        public static void SDL_DestroyProperties(uint props)
        {
            iSDL_DestroyProperties(props);
        }
    }
}