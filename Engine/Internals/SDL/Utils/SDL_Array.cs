using System.Collections.Generic;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static T[] SDL_PointerToArray<T>(T* ptr, int count, bool free = true) where T : unmanaged
        {
            if (ptr == null)
            {
                return Array.Empty<T>();
            }

            try
            {
                if (count <= 0)
                {
                    return Array.Empty<T>();
                }

                return new ReadOnlySpan<T>(ptr, count).ToArray();
            }
            finally
            {
                if (free)
                {
                    iSDL_free(ptr);
                }
            }
        }

        public static T[] SDL_PointerToArray<T>(T* ptr, out int count, bool free = true) where T : unmanaged
        {
            count = 0;

            if (ptr == null)
            {
                return Array.Empty<T>();
            }

            try
            {
                while (!EqualityComparer<T>.Default.Equals(ptr[count], default(T)))
                {
                    count++;
                }

                return new ReadOnlySpan<T>(ptr, count).ToArray();
            }
            finally
            {
                if (free)
                {
                    iSDL_free(ptr);
                }
            }
        }

        public static T[] SDL_PointerToArray<T>(T* ptr, bool free = true) where T : unmanaged
        {
            if (ptr == null)
            {
                return Array.Empty<T>();
            }

            try
            {
                int count = 0;

                while (!EqualityComparer<T>.Default.Equals(ptr[count], default(T)))
                {
                    count++;
                }

                return new ReadOnlySpan<T>(ptr, count).ToArray();
            }
            finally
            {
                if (free)
                {
                    iSDL_free(ptr);
                }
            }
        }
    }
}