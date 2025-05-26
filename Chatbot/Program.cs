using System;

namespace Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audiowelcome.welcome();
            Logo.ascii();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey, I am cyber bot. What's your name?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            memory.UserName = name; // ✅ Store in memory

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {name}, nice to meet you. How could I help you today?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            userInt.interaction(name);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
