using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
            string capturedString = Console.ReadLine();
            capturedString = capturedString.ToLower();
            char[] secretMessage = capturedString.ToCharArray();
            char [] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char x =  secretMessage[i];
                int z = Array.IndexOf(alphabet, x);
                if (z == 23)
                {
                    z = 0;
                }
                else if (z == 24)
                {
                    z = 1;
                }
                else if (z == 25)
                {
                    z = 2;
                }
                else if (z == 26)
                {
                    z = 26;
                }
                else
                {
                    z += 3;
                }
                encryptedMessage[i] = alphabet[z];
                
                Console.Write(encryptedMessage[i]);
            }
        }
    }
}