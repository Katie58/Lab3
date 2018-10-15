using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool retry = true;

            while (retry)
            {
                Range();
                retry = Retry();
            }
            Exit();
        }

        public static string UserName()
        {
            Console.WriteLine("HI! What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        public static void Range()
        {
            int input = 0;
            string oddEven = null;
            string range = null;
            Console.Clear();
            Console.WriteLine("Welcome {0}, please enter a number between 1 and 100: ", UserName());
            while (int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100)
            {
                if (input % 2 != 0)
                {
                    oddEven = "ODD";
                }
                else
                    oddEven = "EVEN";
                if (input == 1 || input == 60)
                {
                    range = "sorry " + UserName() + ", you cannot enter 1 or 60 as defined by the hidden instructions";
                }
                else if (input <= 25)
                {
                    range = "less than 25";
                }
                else if (input <= 60)
                {
                    range = "between 26 and 60";
                }
                else
                    range = "greater than 60";
                Console.WriteLine("Here is your output, {0}: {1} is {2} and {3}", UserName(), input, oddEven, range);
            }
        }

        public static void Invalid()
        {
            Console.WriteLine("\nERROR - Sorry {0}, your input is invalid...", UserName());
        }

        public static bool Retry()
        {
            bool retry = true;
            Console.WriteLine("\nWould you like to add another number, {0}? (y/n): ", UserName());
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                retry = true;
            }
            else if (key == ConsoleKey.N)
            {
                retry = false;
                Console.WriteLine("\nGoodbye {0}, Press ESCAPE to Exit", UserName());
            }
            else
            {
                Invalid();
                Retry();
            }
            return retry;
        }

        public static void Exit()
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Exit();
            }
        }
    }
}//October 9, 2018 - revised October 15