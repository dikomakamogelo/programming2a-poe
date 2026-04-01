using System;
using System.Threading;
using System.Speech.Synthesis;

namespace ChatBot
{
    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            UIHelper.ShowLogo();
            UIHelper.TypeText("Welcome to the Cybersecurity Chatbot!\n");

            AskUserName();
            GreetUser();

            RunChatLoop();
        }

        private void AskUserName()
        {
            UIHelper.TypeText("Before we begin, what is your name?");
            Console.Write("\n> ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User";
            }
        }

        private void GreetUser()
        {
            Speak($"Hello {userName}, welcome to the Cybersecurity Chatbot.");
            UIHelper.TypeText($"\nHello, {userName}! 👋");
            UIHelper.TypeText("I am your Cybersecurity Assistant.");
        }

        private void RunChatLoop()
        {
            while (true)
            {
                UIHelper.ShowDivider();
                Console.Write($"\n{userName}: ");
                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.TypeText("I didn’t quite understand that. Could you please rephrase?");
                    continue;
                }

                if (input == "exit")
                {
                    UIHelper.TypeText($"Goodbye, {userName}! Stay safe online 🔐");
                    break;
                }

                string response = GetResponse(input);
                UIHelper.TypeText(response);
            }
        }

        private void Speak(string text)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(text);
        }

        private string GetResponse(string input)
        {
            if (input.Contains("how are you"))
            {
                return $"I'm functioning optimally, {userName}! Ready to help you stay safe online.";
            }
            else if (input.Contains("purpose"))
            {
                return "My purpose is to educate you about cybersecurity and help you stay safe online.";
            }
            else if (input.Contains("what can i ask"))
            {
                return "You can ask me about password safety, phishing, and safe browsing.";
            }
            else if (input.Contains("password"))
            {
                return "Use strong passwords with a mix of letters, numbers, and symbols. Avoid reusing passwords.";
            }
            else if (input.Contains("phishing"))
            {
                return "Phishing scams try to trick you into revealing personal information. Always verify suspicious emails or links.";
            }
            else if (input.Contains("safe browsing"))
            {
                return "Only visit secure websites (https), avoid clicking unknown links, and keep your browser updated.";
            }
            else
            {
                return "I didn’t quite understand that. Could you please rephrase?";
            }
        }
    }
}
