using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_NUMBER_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            string oddEven = "";
            string range = "";
            string userName = "";
            Boolean retry = true;

            UserInfo(ref userName);
            while (retry)
            {
                Boolean print = true;

                Console.Clear();
                Greeting(userName);
                UserInput(ref retry, ref print, ref input, userName);
                MathOddEven(ref retry, ref print, input, ref oddEven, userName);
                MathRange(ref retry, ref print, input, ref range, userName);
                PrintResults(ref retry, ref print, input, range, oddEven, userName);
                retry = Retry(ref retry, ref print, userName);
            }
            Exit(userName);
        }

        public static string UserInfo(ref string userName)
        {
            Console.WriteLine("HI! What is your name? ");
            userName = Console.ReadLine();
            return userName;
        }

        public static void Greeting(string userName)
        {
            Console.WriteLine("Welcome {0}, please enter a number between 1 and 100: ", userName);
        }

        public static int UserInput(ref bool retry, ref bool print, ref int input, string userName)
        {
            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100)
            {
                return input;
            }
            else
            {
                Invalid(ref retry, ref print, userName);
                return input;
            }
        }

        public static void Restraints(ref bool retry, ref bool print, ref int input, string userName)
        {
            if (input < 1 || input > 100)
            {
                Console.WriteLine("\nNumber must be between 1 and 100");
                Invalid(ref retry, ref print, userName);
            }
        }

        public static string MathOddEven(ref bool retry, ref bool print, int input, ref string oddEven, string userName)
        {
            if (input % 2 != 0)
            {
                oddEven = "ODD";
            }
            else if (input % 2 != 1)
            {
                oddEven = "EVEN";
            }
            else
            {
                Console.WriteLine("Sorry {0}, the number you entered is not divisible by 1 or 2... which means this program is broken");
                Invalid(ref retry, ref print, userName);
            }
            return oddEven;
        }

        public static string MathRange(ref bool retry, ref bool print, int input, ref string range, string userName)
        {
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
            return range;
        }

        public static void PrintResults(ref bool retry, ref bool print, int input, string range, string oddEven, string userName)
        {
            if (print)
            {
                Console.WriteLine("Here is your output, {0}: {1} is {2} and {3}", userName, input, oddEven, range);
            }
        }

        public static void Invalid(ref bool retry, ref bool print, string userName)
        {
            Console.WriteLine("\nERROR - Sorry {0}, your input is invalid...", userName);
            Retry(ref retry, ref print, userName);
        }

        public static Boolean Retry(ref bool retry, ref bool print, string userName)
        {
            if (print)
            {
                Console.WriteLine("\nWould you like to add another number, {0}? (y/n): ", userName);
                ConsoleKeyInfo answer = Console.ReadKey(true);
                string strAnswer = answer.KeyChar.ToString();
                if (strAnswer == "Y" || strAnswer == "y")
                {
                    retry = true;
                    print = false;
                }
                else if (strAnswer == "N" || strAnswer == "n")
                {
                    retry = false;
                }
                else
                {
                    Invalid(ref retry, ref print, userName);
                }
            }
            return retry;
        }

        public static void Exit(string userName)
        {
            Console.WriteLine("\nGoodbye {0}, Press ESCAPE to Exit", userName);

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.ReadLine();
                continue;
            }
        }
    }
}//October 9, 2018