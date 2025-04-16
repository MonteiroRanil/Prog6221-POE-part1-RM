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
 
                if (string.IsNullOrWhiteSpace(input))// if statement for if they eft it blank or asked something the bot does not know
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (input.Contains("exit") || input.Contains("quit") || input.Contains("leave") || input.Contains("goodbye"))//if statement for if the user wants to leave the bot
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Goodbye {name},I hope i made you more aware about your safety online, Stay safe");
                    Console.WriteLine($"See you later {name}");
                    Environment.Exit(0);
                    break;
                }

                string response = CyberKnowledge.Response(input);//calling the class with the knowledge
                Console.WriteLine(response);
            }
        }
    }
}
