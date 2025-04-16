namespace Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audiowelcome.welcome();//calling the audio class
            Logo.ascii();//calling the comments class 

            Console.ForegroundColor = ConsoleColor.Green;// making the chatbots colour green
            Console.WriteLine("Hey, I am cyber bot whats your name?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;//making the user's colour white
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {name}, nice to meet you, how could i help you today?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            userInt.interaction(name);//calling the user interaction class
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
