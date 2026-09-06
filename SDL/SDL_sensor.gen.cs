using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_Sensor
    {
    }

    internal enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
        SDL_SENSOR_COUNT,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensors", ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID *")]
        private static extern uint* iSDL_GetSensors(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetSensorNameForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorTypeForID", ExactSpelling = true)]
        private static extern SDL_SensorType iSDL_GetSensorTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableTypeForID", ExactSpelling = true)]
        private static extern int iSDL_GetSensorNonPortableTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenSensor", ExactSpelling = true)]
        private static extern SDL_Sensor* iSDL_OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorFromID", ExactSpelling = true)]
        private static extern SDL_Sensor* iSDL_GetSensorFromID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        private static extern uint iSDL_GetSensorProperties(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        private static extern byte* iSDL_GetSensorName(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorType", ExactSpelling = true)]
        private static extern SDL_SensorType iSDL_GetSensorType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableType", ExactSpelling = true)]
        private static extern int iSDL_GetSensorNonPortableType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID")]
        private static extern uint iSDL_GetSensorID(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorData", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        private static extern SDL_Bool iSDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseSensor", ExactSpelling = true)]
        private static extern void iSDL_CloseSensor(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateSensors", ExactSpelling = true)]
        private static extern void iSDL_UpdateSensors();

        [NativeTypeName("#define SDL_STANDARD_GRAVITY 9.80665f")]
        public const float SDL_STANDARD_GRAVITY = 9.80665f;
    }
}
