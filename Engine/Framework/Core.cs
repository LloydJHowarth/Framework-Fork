using System;

namespace Engine
{
    public class Core
    {
        private bool IsRunning;
        
        public void Run()
        {
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
                Console.WriteLine("Running");
            }
            
            Exit();
        }

        private void Exit()
        {
            IsRunning = false;
        }
    }
}

