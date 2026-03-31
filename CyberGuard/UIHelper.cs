using System;

namespace CyberGuard
{
    public static class UIHelper
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================");
            Console.WriteLine("          CYBERGUARD CHATBOT");
            Console.WriteLine("=======================================");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
              /\
             /  \
            /----\
           / |  | \
          /  |  |  \
         /   |  |   \
        /    |  |    \
       /_____|__|_____\
           \      /
            \    /
             \  /
              \/

            ");

            Console.ResetColor();
        }
    }
}