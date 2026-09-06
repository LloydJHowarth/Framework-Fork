using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_DateTime
    {
        public int year;

        public int month;

        public int day;

        public int hour;

        public int minute;

        public int second;

        public int nanosecond;

        public int day_of_week;

        public int utc_offset;
    }

    internal enum SDL_DateFormat
    {
        SDL_DATE_FORMAT_YYYYMMDD = 0,
        SDL_DATE_FORMAT_DDMMYYYY = 1,
        SDL_DATE_FORMAT_MMDDYYYY = 2,
    }

    internal enum SDL_TimeFormat
    {
        SDL_TIME_FORMAT_24HR = 0,
        SDL_TIME_FORMAT_12HR = 1,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDateTimeLocalePreferences", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentTime", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToDateTime", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_TimeToDateTime([NativeTypeName("SDL_Time")] long ticks, SDL_DateTime* dt, [NativeTypeName("bool")] SDL_Bool localTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DateTimeToTime", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_DateTimeToTime([NativeTypeName("const SDL_DateTime *")] SDL_DateTime* dt, [NativeTypeName("SDL_Time *")] long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToWindows", ExactSpelling = true)]
        private static extern void iSDL_TimeToWindows([NativeTypeName("SDL_Time")] long ticks, [NativeTypeName("Uint32 *")] uint* dwLowDateTime, [NativeTypeName("Uint32 *")] uint* dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeFromWindows", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Time")]
        private static extern long iSDL_TimeFromWindows([NativeTypeName("Uint32")] uint dwLowDateTime, [NativeTypeName("Uint32")] uint dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDaysInMonth", ExactSpelling = true)]
        private static extern int iSDL_GetDaysInMonth(int year, int month);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfYear", ExactSpelling = true)]
        private static extern int iSDL_GetDayOfYear(int year, int month, int day);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfWeek", ExactSpelling = true)]
        private static extern int iSDL_GetDayOfWeek(int year, int month, int day);
    }
}
