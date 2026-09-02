using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_Vulkan_LoadLibrary(byte* path)
        {
            return iSDL_Vulkan_LoadLibrary(path);
        }

        public static IntPtr SDL_Vulkan_GetVkGetInstanceProcAddr()
        {
            return iSDL_Vulkan_GetVkGetInstanceProcAddr();
        }

        public static void SDL_Vulkan_UnloadLibrary()
        {
            iSDL_Vulkan_UnloadLibrary();
        }

        public static byte** SDL_Vulkan_GetInstanceExtensions(uint* count)
        {
            return iSDL_Vulkan_GetInstanceExtensions(count);
        }

        public static SDL_Bool SDL_Vulkan_CreateSurface(SDL_Window* window, VkInstance_T* instance, VkAllocationCallbacks* allocator, VkSurfaceKHR_T** surface)
        {
            return iSDL_Vulkan_CreateSurface(window, instance, allocator, surface);
        }

        public static void SDL_Vulkan_DestroySurface(VkInstance_T* instance, VkSurfaceKHR_T* surface, VkAllocationCallbacks* allocator)
        {
            iSDL_Vulkan_DestroySurface(instance, surface, allocator);
        }

        public static SDL_Bool SDL_Vulkan_GetPresentationSupport(VkInstance_T* instance, VkPhysicalDevice_T* physicalDevice, uint queueFamilyIndex)
        {
            return iSDL_Vulkan_GetPresentationSupport(instance, physicalDevice, queueFamilyIndex);
        }
    }
}