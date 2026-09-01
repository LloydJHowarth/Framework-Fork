using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    public readonly struct SDL_Bool
    {
        private readonly byte handle;

        public SDL_Bool(bool value)
        {
            handle = (byte)(value ? 1 : 0);
        }

        public static implicit operator bool(SDL_Bool value) => value.handle != 0;
        public static implicit operator SDL_Bool(bool value) => new SDL_Bool(value);
    }
}