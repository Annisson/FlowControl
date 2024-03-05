namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flow Control Application");

            bool runMenu = true; //Created bool to run the do-while menu until the user decides to exit the application

            do
            {
                Console.WriteLine("\nMain menu, please enter a number from the options below to continue." +
                    "\n0. Exit" +
                    "\n1. Cinema, age-check" +
                    "\n2. Cinema, number of guests and total cost" +
                    "\n3. Repeat 10 times" +
                    "\n4. Play a word-game");

                int.TryParse(Console.ReadLine(), out int userInput); //Parse the string user input to an int saved in the variable userInput

                Console.Clear(); //Clean up console

                switch (userInput)
                {
                    case 0: //Exit the application
                        runMenu = false;
                        Environment.Exit(0);
                        break;

                    case 1: //Cinema, age-check
                        Cinema.CinemaAgeCheck();
                        break;

                    case 2: //Cinema, number of guests and total cost
                        Cinema.CinemaTotal();
                        break;

                    case 3: //Repeat 10 times
                        RepeatWordGame.RepeatWords();
                        break;

                    case 4: //Word-game
                        ThirdWordGame.ThirdWord();
                        break;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);
        }
    }
}
