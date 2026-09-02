using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        internal static SDL_Tray* SDL_CreateTray(SDL_Surface* icon, byte* tooltip)
        {
            return iSDL_CreateTray(icon, tooltip);
        }

        internal static SDL_Tray* SDL_CreateTrayWithProperties(uint props)
        {
            return iSDL_CreateTrayWithProperties(props);
        }

        internal static void SDL_SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon)
        {
            iSDL_SetTrayIcon(tray, icon);
        }

        internal static void SDL_SetTrayTooltip(SDL_Tray* tray, byte* tooltip)
        {
            iSDL_SetTrayTooltip(tray, tooltip);
        }

        internal static SDL_TrayMenu* SDL_CreateTrayMenu(SDL_Tray* tray)
        {
            return iSDL_CreateTrayMenu(tray);
        }

        internal static SDL_TrayMenu* SDL_CreateTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_CreateTraySubmenu(entry);
        }

        internal static SDL_TrayMenu* SDL_GetTrayMenu(SDL_Tray* tray)
        {
            return iSDL_GetTrayMenu(tray);
        }

        internal static SDL_TrayMenu* SDL_GetTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_GetTraySubmenu(entry);
        }

        internal static SDL_TrayEntry** SDL_GetTrayEntries(SDL_TrayMenu* menu, int* count)
        {
            return iSDL_GetTrayEntries(menu, count);
        }

        internal static void SDL_RemoveTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_RemoveTrayEntry(entry);
        }

        internal static SDL_TrayEntry* SDL_InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, byte* label, uint flags)
        {
            return iSDL_InsertTrayEntryAt(menu, pos, label, flags);
        }

        internal static void SDL_SetTrayEntryLabel(SDL_TrayEntry* entry, byte* label)
        {
            iSDL_SetTrayEntryLabel(entry, label);
        }

        internal static byte* SDL_GetTrayEntryLabel(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryLabel(entry);
        }

        internal static void SDL_SetTrayEntryChecked(SDL_TrayEntry* entry, SDL_Bool @checked)
        {
            iSDL_SetTrayEntryChecked(entry, @checked);
        }

        internal static SDL_Bool SDL_GetTrayEntryChecked(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryChecked(entry);
        }

        internal static void SDL_SetTrayEntryEnabled(SDL_TrayEntry* entry, SDL_Bool enabled)
        {
            iSDL_SetTrayEntryEnabled(entry, enabled);
        }

        internal static SDL_Bool SDL_GetTrayEntryEnabled(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryEnabled(entry);
        }

        internal static void SDL_SetTrayEntryCallback(SDL_TrayEntry* entry, IntPtr callback, void* userdata)
        {
            iSDL_SetTrayEntryCallback(entry, callback, userdata);
        }

        internal static void SDL_ClickTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_ClickTrayEntry(entry);
        }

        internal static void SDL_DestroyTray(SDL_Tray* tray)
        {
            iSDL_DestroyTray(tray);
        }

        internal static SDL_TrayMenu* SDL_GetTrayEntryParent(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryParent(entry);
        }

        internal static SDL_TrayEntry* SDL_GetTrayMenuParentEntry(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentEntry(menu);
        }

        internal static SDL_Tray* SDL_GetTrayMenuParentTray(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentTray(menu);
        }

        internal static void SDL_UpdateTrays()
        {
            iSDL_UpdateTrays();
        }
    }
}