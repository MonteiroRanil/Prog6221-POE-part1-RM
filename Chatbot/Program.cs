namespace Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audiowelcome.welcome();
            Logo.ascii();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hey, I am cyber bot whats your name?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {name}, nice to meet you, how could i help you today?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            userInt.interaction(name);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
