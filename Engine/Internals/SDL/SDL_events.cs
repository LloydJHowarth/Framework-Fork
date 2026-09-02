using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static void SDL_PumpEvents()
        {
            iSDL_PumpEvents();
        }

        internal static int SDL_PeepEvents(SDL_Event* events, int numevents, SDL_EventAction action, uint minType, uint maxType)
        {
            return iSDL_PeepEvents(events, numevents, action, minType, maxType);
        }

        internal static SDL_Bool SDL_HasEvent(uint type)
        {
            return iSDL_HasEvent(type);
        }

        internal static SDL_Bool SDL_HasEvents(uint minType, uint maxType)
        {
            return iSDL_HasEvents(minType, maxType);
        }

        internal static void SDL_FlushEvent(uint type)
        {
            iSDL_FlushEvent(type);
        }

        internal static void SDL_FlushEvents(uint minType, uint maxType)
        {
            iSDL_FlushEvents(minType, maxType);
        }

        internal static SDL_Bool SDL_PollEvent(SDL_Event* @event)
        {
            return iSDL_PollEvent(@event);
        }

        internal static SDL_Bool SDL_WaitEvent(SDL_Event* @event)
        {
            return iSDL_WaitEvent(@event);
        }

        internal static SDL_Bool SDL_WaitEventTimeout(SDL_Event* @event, int timeoutMS)
        {
            return iSDL_WaitEventTimeout(@event, timeoutMS);
        }

        internal static SDL_Bool SDL_PushEvent(SDL_Event* @event)
        {
            return iSDL_PushEvent(@event);
        }

        internal static void SDL_SetEventFilter(IntPtr filter, void* userdata)
        {
            iSDL_SetEventFilter(filter, userdata);
        }

        internal static SDL_Bool SDL_GetEventFilter(IntPtr* filter, void** userdata)
        {
            return iSDL_GetEventFilter(filter, userdata);
        }

        internal static SDL_Bool SDL_AddEventWatch(IntPtr filter, void* userdata)
        {
            return iSDL_AddEventWatch(filter, userdata);
        }

        internal static void SDL_RemoveEventWatch(IntPtr filter, void* userdata)
        {
            iSDL_RemoveEventWatch(filter, userdata);
        }

        internal static void SDL_FilterEvents(IntPtr filter, void* userdata)
        {
            iSDL_FilterEvents(filter, userdata);
        }

        internal static void SDL_SetEventEnabled(uint type, SDL_Bool enabled)
        {
            iSDL_SetEventEnabled(type, enabled);
        }

        internal static SDL_Bool SDL_EventEnabled(uint type)
        {
            return iSDL_EventEnabled(type);
        }

        internal static uint SDL_RegisterEvents(int numevents)
        {
            return iSDL_RegisterEvents(numevents);
        }

        internal static SDL_Window* SDL_GetWindowFromEvent(SDL_Event* @event)
        {
            return iSDL_GetWindowFromEvent(@event);
        }

        internal static int SDL_GetEventDescription(SDL_Event* @event, byte* buf, int buflen)
        {
            return iSDL_GetEventDescription(@event, buf, buflen);
        }
    }
}