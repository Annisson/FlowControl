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
                
                Console.WriteLine("\nMain menu, please enter a number from the options below to continue." +
                    "\n0. Exit" +
                    "\n1. Cinema, age-check" +
                    "\n2. Cinema, number of guests and total cost" +
                    "\n3. Repeat 10 times" +
                    "\n4. Play a word-game");

                int.TryParse(Console.ReadLine(), out int userInput);

                Console.Clear(); //Clean up console

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
                        Console.Write("Please type what you want to repeat 10 times: ");
                        string repeatInput = Console.ReadLine();
                        RepeatWords(repeatInput);
                        break;

                    case 4:
                        Console.WriteLine("Play a word-game");
                        continue;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);


        }

        static void RepeatWords(string input)
        {
            int count = 1;
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                    Console.Write($"{count}. {input}, ");
                else
                    Console.Write($"{count}. {input}\n");
                count++;
            }
        }

    }
}
