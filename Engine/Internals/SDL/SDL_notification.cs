using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Bool SDL_RequestNotificationPermission()
        {
            return iSDL_RequestNotificationPermission();
        }

        internal static uint SDL_ShowNotificationWithProperties(uint props)
        {
            return iSDL_ShowNotificationWithProperties(props);
        }

        internal static uint SDL_ShowNotification(byte* title, byte* message, SDL_Surface* image, SDL_NotificationAction* actions, int num_actions)
        {
            return iSDL_ShowNotification(title, message, image, actions, num_actions);
        }

        internal static SDL_Bool SDL_RemoveNotification(uint notification)
        {
            return iSDL_RemoveNotification(notification);
        }
    }
}