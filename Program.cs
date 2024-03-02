namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flow Control Application");

            bool runMenu = true;

            do
            {
                Console.WriteLine("Main menu, please enter a number from the options below to continue.");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Cinema, age-check");
                Console.WriteLine("2. Cinema, number of guests and total cost");
                Console.WriteLine("3. Repeat 10 times");
                Console.WriteLine("4. Play a word-game");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 0: //Exit the application
                        runMenu = false;
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.WriteLine("Cinema, age-check");
                        continue;

                    case 2:
                        Console.WriteLine("Cinema, number of guests and total cost");
                        continue;

                    case 3:
                        Console.WriteLine("Repeat 10 times");
                        continue;

                    case 4:
                        Console.WriteLine("Play a word-game");
                        continue;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);


        }
    }
}
