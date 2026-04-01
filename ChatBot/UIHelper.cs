using System;
using System.Threading;

namespace ChatBot
{
    public static class UIHelper
    {
        public static void ShowLogo()
        {
            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine("   CYBERSECURITY CHATBOT SYSTEM");
            Console.WriteLine("=====================================\n");

            Console.WriteLine("   [ ASCII LOGO ]");
            Console.WriteLine("    _____________");
            Console.WriteLine("   |  SECURITY  |");
            Console.WriteLine("   |   SHIELD   |");
            Console.WriteLine("   |____________|\n");
        }

        public static void ShowDivider()
        {
            Console.WriteLine("\n-------------------------------------");
        }

        public static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15); // typing effect
            }
            Console.WriteLine();
        }
    }
}