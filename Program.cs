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
                Console.WriteLine("1. Rerun menu");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 0: //Exit the application
                        runMenu = false;
                        Environment.Exit(0);
                        break;

                        case 1:
                            continue;

                    default:
                        Console.WriteLine("Incorrect input, please use numbers 0 or 1 only.");
                        break;
                }

            } while (runMenu);


        }
    }
}
