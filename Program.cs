namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flow Control Application");

            Console.WriteLine("Main menu, please enter a number from the options below to continue.");
            Console.WriteLine("0. Exit");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 0: //Exit the application
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                    break;
            }

        }
    }
}
