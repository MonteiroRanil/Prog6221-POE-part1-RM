using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    internal class CyberKnowledge
    {
   
           public static string Response(string input)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (input.Contains("ask"))
            {
                string response = "you can ask me about passwords,phishing and internet browsing ";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }

            if (input.Contains("how are you"))
            {
                string response = "I am good thank you, What would you like to be aware about?";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }

            if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to help people be aware of some cyber dangers");
                string response = "Like for example choose between passwords,phishing and internet browsing";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }

            if (input.Contains("password") || input.Contains("safe"))
            {
                Console.WriteLine("Strong passwords should be at least 12 characters long and include a mix of letters, numbers, and symbols. Never reuse passwords across different sites! ");
                string response = "Next: choose between phishing, safe browsing or if you're done you can exit";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }
            else if (input.Contains("phishing") || input.Contains("email"))
            {
                Console.WriteLine("Phishing emails often try to create urgency or fear. Always check the sender's address and never click links in suspicious emails.");
                string response = "Next: Choose password safety, safe browsing or if you're done you can exit";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }
            else if (input.Contains("browsing") || input.Contains("internet"))
            {
                Console.WriteLine("For safe browsing: look for HTTPS in URLs, avoid public WiFi for sensitive transactions, and keep your browser updated.");
                string response = "Next: Choose password safety, phishing or if you're done you can exit ";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }
            else
            {
                string response = "I'm not sure I understand. I can help with password safety, phishing, or safe browsing. Which topic interests you?";
                Console.WriteLine(response);
                Console.ResetColor();
                return "";
            }
        }
    }
}
