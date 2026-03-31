using System;
using System.Media;

namespace CyberGuard
{
    class Program
    {
        static void Main()
        {
            // Play voice greeting
            try
            {
                SoundPlayer player = new SoundPlayer("CyberGuard_Greeting.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Voice greeting could not play.");
            }

            // Display UI
            UIHelper.DisplayHeader();

            // Start chatbot
            Chatbot bot = new Chatbot();
            bot.StartChat();
        }
    }
}