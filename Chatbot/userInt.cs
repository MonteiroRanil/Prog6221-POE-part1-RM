using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    internal class userInt
    {
        public static void interaction(string name)
        {
            while (true)  
            {
                
                string input = Console.ReadLine().ToLower();
 
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (input.Contains("exit") || input.Contains("quit") || input.Contains("leave") || input.Contains("goodbye"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Goodbye {name},I hope i made you more aware about your safety online, Stay safe");
                    Console.WriteLine("See you later");
                    Environment.Exit(0);
                    break;
                }

                string response = CyberKnowledge.Response(input);
                Console.WriteLine(response);
            }
        }
    }
}
