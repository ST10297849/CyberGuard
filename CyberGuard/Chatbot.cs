using System;

namespace CyberGuard
{
    public class Chatbot
    {
        private User user = new User();

        public void StartChat()
        {
            AskName();
            ChatLoop();
        }

        private void AskName()
        {
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.Name))
            {
                user.Name = "User";
            }

            Console.WriteLine($"\nHello {user.Name}");
            Console.WriteLine("Welcome to CyberGuard.");
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("CyberGuard: Please enter something.");
                    continue;
                }

                input = input.ToLower();

                // Input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("CyberGuard: Please enter something.");
                    continue;
                }

                // Responses
                if (input.Contains("arrow"))
                {
                    Console.WriteLine("CyberGuard: The shield has been raised.");
                }
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine("CyberGuard: My purpose is to shield you from cyber threats");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("CyberGuard: Create passwords that make use of uppercase letters, lowercase letters, numbers, and special characters/symbols.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("CyberGuard: Be careful of suspicious emails and do not click any unknown links.");
                }
                else if (input.Contains("safe browsing"))
                {
                    Console.WriteLine("CyberGuard: Always check URLs and avoid unsecured websites, https refers to secured websites and http are unsecured websites.");
                }
                else if (input.Contains("Shutdown"))
                {
                    Console.WriteLine("CyberGuard: Its been a pleasure.");
                    break;
                }
                else
                {
                    Console.WriteLine("CyberGuard: I didn’t quite understand that. Could you rephrase?");
                }
            }
        }
    }
}