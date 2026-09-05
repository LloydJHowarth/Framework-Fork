using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static uint* SDL_GetSensors(int* count)
        {
            return iSDL_GetSensors(count);
        }

        public static byte* SDL_GetSensorNameForID(uint instance_id)
        {
            return iSDL_GetSensorNameForID(instance_id);
        }

        public static SDL_SensorType SDL_GetSensorTypeForID(uint instance_id)
        {
            return iSDL_GetSensorTypeForID(instance_id);
        }

        public static int SDL_GetSensorNonPortableTypeForID(uint instance_id)
        {
            return iSDL_GetSensorNonPortableTypeForID(instance_id);
        }

        public static SDL_Sensor* SDL_OpenSensor(uint instance_id)
        {
            return iSDL_OpenSensor(instance_id);
        }

        public static SDL_Sensor* SDL_GetSensorFromID(uint instance_id)
        {
            return iSDL_GetSensorFromID(instance_id);
        }

        public static uint SDL_GetSensorProperties(SDL_Sensor* sensor)
        {
            return iSDL_GetSensorProperties(sensor);
        }

        public static byte* SDL_GetSensorName(SDL_Sensor* sensor)
        {
            return iSDL_GetSensorName(sensor);
        }

        public static SDL_SensorType SDL_GetSensorType(SDL_Sensor* sensor)
        {
            return iSDL_GetSensorType(sensor);
        }

        public static int SDL_GetSensorNonPortableType(SDL_Sensor* sensor)
        {
            return iSDL_GetSensorNonPortableType(sensor);
        }

        public static uint SDL_GetSensorID(SDL_Sensor* sensor)
        {
            return iSDL_GetSensorID(sensor);
        }

        public static SDL_Bool SDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values)
        {
            return iSDL_GetSensorData(sensor, data, num_values);
        }

        public static void SDL_CloseSensor(SDL_Sensor* sensor)
        {
            iSDL_CloseSensor(sensor);
        }

        public static void SDL_UpdateSensors()
        {
            iSDL_UpdateSensors();
        }
    }
}