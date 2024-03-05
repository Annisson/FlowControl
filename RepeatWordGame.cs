namespace FlowControl
{
    internal class RepeatWordGame
    {
        private string RepeatInput {  get; set; }

        public static void RepeatWords() //Method for case 3
        {
            Console.Write("Please type what you want to repeat 10 times: ");
            string RepeatInput = Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
                if (i < 9)
                    Console.Write($"{i}. {RepeatInput}, "); //If-statement to add commas to every loop except the last for clean output
                else
                    Console.Write($"{i}. {RepeatInput}\n");
            }
        }
    }
}
