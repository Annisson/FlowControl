using System.ComponentModel.Design;
using System.Diagnostics;

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
                        continue;

                    case 2: //Cinema, number of guests and total cost
                        Cinema.CinemaTotal();
                        continue;

                    case 3: //Repeat 10 times
                        RepeatWords();
                        break;

                    case 4: //Word-game
                        ThirdWord();
                        continue;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);
        }

        static void RepeatWords() //Method for case 3
        {
            Console.Write("Please type what you want to repeat 10 times: ");
            string repeatInput = Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
                if (i < 9)
                    Console.Write($"{i}. {repeatInput}, "); //If-statement to add commas to every loop except the last for clean output
                else
                    Console.Write($"{i}. {repeatInput}\n");
            }
        }

        static void ThirdWord() //Method for case 4
        {
            Console.Write("Let's play a word-game!" +
            "\nType a sentence of at least three words: ");

            string wordInput = Console.ReadLine();
            var splitInput = wordInput.Split(' '); //Splitting the user input by each space to save into an array

            if (splitInput.Length < 3 ) //If-statement to check if the user input contains less than 3 words
            {
                Console.WriteLine("You sentence is not long enough, you need to enter at least three words.");
            }
            else //If the user entered at least 3 words then the output will be of the 2nd arrayvalue, starting from 0 which gives us the 3rd word
            {
                Console.WriteLine($"This is the third word: {splitInput[2]}");
            }
            
        }
    }
}
