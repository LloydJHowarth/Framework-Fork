using System;
using Engine.SDL3;

namespace Engine
{
    public class Core
    {
        private bool IsRunning;
        
        public void Run()
        {
            SDL.SDL_Init((uint)(SDL_InitFlags.SDL_INIT_AUDIO | SDL_InitFlags.SDL_INIT_VIDEO));

            var devices = SDL.SDL_GetAudioPlaybackDevices(out int count);
            
            Console.WriteLine(devices.Length + " " + count);
            
            if (!IsRunning)
            {
                IsRunning = true;
                {
                    Main();
                }
            }
        }

        private void Main()
        {
            while (IsRunning)
            {
                // Console.WriteLine("Running");
            }
            
            Exit();
        }

        private void Exit()
        {
            IsRunning = false;
        }
    }
}

