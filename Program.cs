using System.ComponentModel.Design;

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

                    case 1: //Cinema, age-check
                        CinemaAgeCheck();
                        continue;

                    case 2: //Cinema, number of guests and total cost
                        Console.WriteLine("Cinema, number of guests and total cost");
                        continue;

                    case 3: //Repeat 10 times
                        Console.Write("Please type what you want to repeat 10 times: ");
                        string repeatInput = Console.ReadLine();
                        RepeatWords(repeatInput);
                        break;

                    case 4: //Word-game
                        Console.Write("Let's play a word-game!" +
                            "\nType a sentence of at least three words: ");
                        string wordInput = Console.ReadLine();
                        ThirdWord(wordInput);
                        continue;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);


        }

        static void CinemaAgeCheck()
        {
            Console.Write("Welcome to the cinema!\nPlease enter your age to check the price for your ticket: ");
            int.TryParse(Console.ReadLine(), out int input);

            if (input < 20)
            {
                if (input < 5)
                {
                    Console.WriteLine("Children under the age of 5 enter for free");
                }
                else if (input >= 5)
                {
                    Console.WriteLine("Youth ticket price: 80 SEK");
                }
            }
            else if (input >= 20)
            {
                if (input >= 20 && input <= 64)
                {
                    Console.WriteLine("Standard ticket price: 120 SEK");
                }
                else if(input > 64 && input <= 100)
                {
                    Console.WriteLine("Pensioner ticket price: 90 SEK");
                }
                else
                {
                    Console.WriteLine("Pensioners over the age of 100 enter for free");
                }
            }
            else
            {
                Console.WriteLine("Error beep boop");
            }
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

        static void ThirdWord(string input)
        {
            var splitInput = input.Split(' ');
            if (splitInput.Length < 3 )
            {
                Console.WriteLine("You sentence is not long enough, you need to enter at least three words.");
            }
            else
            {
                Console.WriteLine($"This is the third word: {splitInput[2]}");
            }
            
        }
    }
}
