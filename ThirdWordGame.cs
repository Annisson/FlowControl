namespace FlowControl
{
    internal class ThirdWordGame
    {
        private string WordInput { get; set; }

        public static void ThirdWord() //Method for case 4
        {
            Console.Write("Let's play a word-game!" +
            "\nType a sentence of at least three words: ");

            string WordInput = Console.ReadLine();
            var splitInput = WordInput.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Splitting the user input by each blank space to save into an array,
                                                                                          //and then removes any "empty" string entries, preventing blank spaces from being saved in the array

            if (splitInput.Length < 3) //If-statement to check if the user input contains less than 3 words
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
