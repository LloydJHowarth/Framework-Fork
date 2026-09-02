using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_hid_init()
        {
            return iSDL_hid_init();
        }

        public static int SDL_hid_exit()
        {
            return iSDL_hid_exit();
        }

        public static uint SDL_hid_device_change_count()
        {
            return iSDL_hid_device_change_count();
        }

        public static SDL_hid_device_info* SDL_hid_enumerate(ushort vendor_id, ushort product_id)
        {
            return iSDL_hid_enumerate(vendor_id, product_id);
        }

        public static void SDL_hid_free_enumeration(SDL_hid_device_info* devs)
        {
            iSDL_hid_free_enumeration(devs);
        }

        public static SDL_hid_device* SDL_hid_open(ushort vendor_id, ushort product_id, ushort* serial_number)
        {
            return iSDL_hid_open(vendor_id, product_id, serial_number);
        }

        public static SDL_hid_device* SDL_hid_open_path(byte* path)
        {
            return iSDL_hid_open_path(path);
        }

        public static uint SDL_hid_get_properties(SDL_hid_device* dev)
        {
            return iSDL_hid_get_properties(dev);
        }

        public static int SDL_hid_write(SDL_hid_device* dev, byte* data, nuint length)
        {
            return iSDL_hid_write(dev, data, length);
        }

        public static int SDL_hid_read_timeout(SDL_hid_device* dev, byte* data, nuint length, int milliseconds)
        {
            return iSDL_hid_read_timeout(dev, data, length, milliseconds);
        }

        public static int SDL_hid_read(SDL_hid_device* dev, byte* data, nuint length)
        {
            return iSDL_hid_read(dev, data, length);
        }

        public static int SDL_hid_set_nonblocking(SDL_hid_device* dev, int nonblock)
        {
            return iSDL_hid_set_nonblocking(dev, nonblock);
        }

        public static int SDL_hid_send_feature_report(SDL_hid_device* dev, byte* data, nuint length)
        {
            return iSDL_hid_send_feature_report(dev, data, length);
        }

        public static int SDL_hid_get_feature_report(SDL_hid_device* dev, byte* data, nuint length)
        {
            return iSDL_hid_get_feature_report(dev, data, length);
        }

        public static int SDL_hid_get_input_report(SDL_hid_device* dev, byte* data, nuint length)
        {
            return iSDL_hid_get_input_report(dev, data, length);
        }

        public static int SDL_hid_close(SDL_hid_device* dev)
        {
            return iSDL_hid_close(dev);
        }

        public static int SDL_hid_get_manufacturer_string(SDL_hid_device* dev, ushort* @string, nuint maxlen)
        {
            return iSDL_hid_get_manufacturer_string(dev, @string, maxlen);
        }

        public static int SDL_hid_get_product_string(SDL_hid_device* dev, ushort* @string, nuint maxlen)
        {
            return iSDL_hid_get_product_string(dev, @string, maxlen);
        }

        public static int SDL_hid_get_serial_number_string(SDL_hid_device* dev, ushort* @string, nuint maxlen)
        {
            return iSDL_hid_get_serial_number_string(dev, @string, maxlen);
        }

        public static int SDL_hid_get_indexed_string(SDL_hid_device* dev, int string_index, ushort* @string, nuint maxlen)
        {
            return iSDL_hid_get_indexed_string(dev, string_index, @string, maxlen);
        }

        public static SDL_hid_device_info* SDL_hid_get_device_info(SDL_hid_device* dev)
        {
            return iSDL_hid_get_device_info(dev);
        }

        public static int SDL_hid_get_report_descriptor(SDL_hid_device* dev, byte* buf, nuint buf_size)
        {
            return iSDL_hid_get_report_descriptor(dev, buf, buf_size);
        }

        public static void SDL_hid_ble_scan(SDL_Bool active)
        {
            iSDL_hid_ble_scan(active);
        }
    }
}