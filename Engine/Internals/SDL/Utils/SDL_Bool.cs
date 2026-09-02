using System;

namespace Engine.SDL3
{
    public readonly struct SDL_Bool : IEquatable<SDL_Bool>
    {
        private readonly byte handle;
        
        public SDL_Bool(bool value)
        {
            handle = (byte)(value ? 1 : 0);
        }
        
        public static bool operator == (SDL_Bool left, SDL_Bool right)
        {
            return left.handle == right.handle;
        }

        public static bool operator != (SDL_Bool left, SDL_Bool right)
        {
            return left.handle != right.handle;
        }
        
        public static implicit operator bool (SDL_Bool value)
        {
            return value.handle != 0;
        }

        public static implicit operator SDL_Bool (bool value)
        {
            return new SDL_Bool(value);
        }

        public bool Equals(SDL_Bool other)
        {
            return handle == other.handle;
        }

        public override bool Equals(object obj)
        {
            if (obj is SDL_Bool)
            {
                return Equals((SDL_Bool)obj);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return handle;
        }
    }
}