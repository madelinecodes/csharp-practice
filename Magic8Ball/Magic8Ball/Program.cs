using System;


namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask a question or enter q to quit: ");
            var response = Console.ReadLine();
            if (response.ToLower() == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Thinking...");
                System.Threading.Thread.Sleep(1000);
                Random random = new Random();
                int ballRoll = random.Next(8);
                switch (ballRoll)
                {
                    case 0:
                        Console.WriteLine("It is certain");
                        break;
                    case 1:
                        Console.WriteLine("Outlook good");
                        break;
                    case 2:
                        Console.WriteLine("You may rely on it");
                        break;
                    case 3:
                        Console.WriteLine("Ask again later");
                        break;
                    case 4:
                        Console.WriteLine("Concentrate and ask again");
                        break;
                    case 5:
                        Console.WriteLine("Reply hazy, try again");
                        break;
                    case 6:
                        Console.WriteLine("My reply is no");
                        break;
                    case 7:
                        Console.WriteLine("My sources say no");
                        break;
                    case 8:
                        Console.WriteLine("Sorry, try again");
                        break;
                }
            }
        }
    }
}
