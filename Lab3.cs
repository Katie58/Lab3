using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool retry = true;
            string userName = null;

            UserInfo(ref userName);
            while (retry)
            {
                Range(userName);
                retry = Retry(userName);
            }
            Exit();
        }

        public static void UserInfo(ref string userName)
        {
            Console.WriteLine("HI! What is your name? ");
            userName = Console.ReadLine();
        }

        public static void Range(string userName)
        {
            int input = 0;
            string oddEven = null;
            string range = null;
            Console.Clear();
            Console.WriteLine("Welcome {0}, please enter a number between 1 and 100: ", userName);
            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100)
            {
                if (input % 2 != 0)
                {
                    oddEven = "ODD";
                }
                else
                    oddEven = "EVEN";
                if (input == 1 || input == 60)
                {
                    range = "sorry " + userName + ", you cannot enter 1 or 60 as defined by the hidden instructions";
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
                Console.WriteLine("Here is your output, {0}: {1} is {2} and {3}", userName, input, oddEven, range);
            }
        }

        public static void Invalid(string userName)
        {
            Console.WriteLine("\nERROR - Sorry {0}, your input is invalid...", userName);
        }

        public static bool Retry(string userName)
        {
            bool retry = true;
            Console.WriteLine("\nWould you like to add another number, {0}? (y/n): ", userName);
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                retry = true;
            }
            else if (key == ConsoleKey.N)
            {
                retry = false;
                Console.WriteLine("\nGoodbye {0}, Press ESCAPE to Exit", userName);
            }
            else
            {
                Invalid(userName);
                Retry(userName);
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
}//October 9, 2018 - revised October 15using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool retry = true;
            string userName = null;

            UserName(ref userName);
            while (retry)
            {
                Range();
                retry = Retry();
            }
            Exit();
        }

        public static string UserName(ref string userName)
        {
            Console.WriteLine("HI! What is your name? ");
            string userName = Console.ReadLine();
        }

        public static void Range(string userName)
        {
            int input = 0;
            string oddEven = null;
            string range = null;

            Console.Clear();
            Console.WriteLine("Welcome {0}, please enter a number between 1 and 100: ", userName);
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
                    range = "sorry " + userName + ", you cannot enter 1 or 60 as defined by the hidden instructions";
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
                Console.WriteLine("Here is your output, {0}: {1} is {2} and {3}", userName, input, oddEven, range);
            }
        }

        public static void Invalid(string userName)
        {
            Console.WriteLine("\nERROR - Sorry {0}, your input is invalid...", userName);
        }

        public static bool Retry(string userName)
        {
            bool retry = true;
            Console.WriteLine("\nWould you like to add another number, {0}? (y/n): ", userName);
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                retry = true;
            }
            else if (key == ConsoleKey.N)
            {
                retry = false;
                Console.WriteLine("\nGoodbye {0}, Press ESCAPE to Exit", userName);
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