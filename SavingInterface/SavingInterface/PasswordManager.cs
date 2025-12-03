using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
        
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden is true)
            {
                string asteriks = "********************";
                int x = Password.Length;    
                Console.WriteLine(asteriks.Substring(0, x));
            }
            else
            {
                Console.WriteLine(Password);
            }

        
    }
    }
}