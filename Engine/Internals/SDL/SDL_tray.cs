using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Tray* SDL_CreateTray(SDL_Surface* icon, byte* tooltip)
        {
            return iSDL_CreateTray(icon, tooltip);
        }

        public static SDL_Tray* SDL_CreateTrayWithProperties(uint props)
        {
            return iSDL_CreateTrayWithProperties(props);
        }

        public static void SDL_SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon)
        {
            iSDL_SetTrayIcon(tray, icon);
        }

        public static void SDL_SetTrayTooltip(SDL_Tray* tray, byte* tooltip)
        {
            iSDL_SetTrayTooltip(tray, tooltip);
        }

        public static SDL_TrayMenu* SDL_CreateTrayMenu(SDL_Tray* tray)
        {
            return iSDL_CreateTrayMenu(tray);
        }

        public static SDL_TrayMenu* SDL_CreateTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_CreateTraySubmenu(entry);
        }

        public static SDL_TrayMenu* SDL_GetTrayMenu(SDL_Tray* tray)
        {
            return iSDL_GetTrayMenu(tray);
        }

        public static SDL_TrayMenu* SDL_GetTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_GetTraySubmenu(entry);
        }

        public static SDL_TrayEntry** SDL_GetTrayEntries(SDL_TrayMenu* menu, int* count)
        {
            return iSDL_GetTrayEntries(menu, count);
        }

        public static void SDL_RemoveTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_RemoveTrayEntry(entry);
        }

        public static SDL_TrayEntry* SDL_InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, byte* label, uint flags)
        {
            return iSDL_InsertTrayEntryAt(menu, pos, label, flags);
        }

        public static void SDL_SetTrayEntryLabel(SDL_TrayEntry* entry, byte* label)
        {
            iSDL_SetTrayEntryLabel(entry, label);
        }

        public static byte* SDL_GetTrayEntryLabel(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryLabel(entry);
        }

        public static void SDL_SetTrayEntryChecked(SDL_TrayEntry* entry, SDL_Bool @checked)
        {
            iSDL_SetTrayEntryChecked(entry, @checked);
        }

        public static SDL_Bool SDL_GetTrayEntryChecked(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryChecked(entry);
        }

        public static void SDL_SetTrayEntryEnabled(SDL_TrayEntry* entry, SDL_Bool enabled)
        {
            iSDL_SetTrayEntryEnabled(entry, enabled);
        }

        public static SDL_Bool SDL_GetTrayEntryEnabled(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryEnabled(entry);
        }

        public static void SDL_SetTrayEntryCallback(SDL_TrayEntry* entry, IntPtr callback, void* userdata)
        {
            iSDL_SetTrayEntryCallback(entry, callback, userdata);
        }

        public static void SDL_ClickTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_ClickTrayEntry(entry);
        }

        public static void SDL_DestroyTray(SDL_Tray* tray)
        {
            iSDL_DestroyTray(tray);
        }

        public static SDL_TrayMenu* SDL_GetTrayEntryParent(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryParent(entry);
        }

        public static SDL_TrayEntry* SDL_GetTrayMenuParentEntry(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentEntry(menu);
        }

        public static SDL_Tray* SDL_GetTrayMenuParentTray(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentTray(menu);
        }

        public static void SDL_UpdateTrays()
        {
            iSDL_UpdateTrays();
        }
    }
}