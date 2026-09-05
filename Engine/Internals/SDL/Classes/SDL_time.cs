using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Bool SDL_GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat)
        {
            return iSDL_GetDateTimeLocalePreferences(dateFormat, timeFormat);
        }

        public static SDL_Bool SDL_GetCurrentTime(long* ticks)
        {
            return iSDL_GetCurrentTime(ticks);
        }

        public static SDL_Bool SDL_TimeToDateTime(long ticks, SDL_DateTime* dt, SDL_Bool localTime)
        {
            return iSDL_TimeToDateTime(ticks, dt, localTime);
        }

        public static SDL_Bool SDL_DateTimeToTime(SDL_DateTime* dt, long* ticks)
        {
            return iSDL_DateTimeToTime(dt, ticks);
        }

        public static void SDL_TimeToWindows(long ticks, uint* dwLowDateTime, uint* dwHighDateTime)
        {
            iSDL_TimeToWindows(ticks, dwLowDateTime, dwHighDateTime);
        }

        public static long SDL_TimeFromWindows(uint dwLowDateTime, uint dwHighDateTime)
        {
            return iSDL_TimeFromWindows(dwLowDateTime, dwHighDateTime);
        }

        public static int SDL_GetDaysInMonth(int year, int month)
        {
            return iSDL_GetDaysInMonth(year, month);
        }

        public static int SDL_GetDayOfYear(int year, int month, int day)
        {
            return iSDL_GetDayOfYear(year, month, day);
        }

        public static int SDL_GetDayOfWeek(int year, int month, int day)
        {
            return iSDL_GetDayOfWeek(year, month, day);
        }
    }
}