using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        class Program
    {
        static void Main(string[] args)
        {
            //user prompts entered as string types
            string value1 = PromptUserForNumber("your first number:");
            string value2 = PromptUserForNumber("your second number:");

            //validation loop to confirm both number are the same length
            while (value1.Length != value2.Length)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR: The two values your entered do not have the same number of digits. Please try again.");
                value1 = PromptUserForNumber("your first number:");
                value2 = PromptUserForNumber("your second number:");
            }

            
            if (IsMatchingSumsInEachNumberPlace(value1, value2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
            //method to prompt user for numbers and deliver error messages
        private static string PromptUserForNumber(string message)
        {
            Console.WriteLine("Please enter " + message);
            string value = Console.ReadLine();
            int number;
            while (!int.TryParse(value, out number))
            {
                Console.WriteLine("ERROR: That is not a number. Please try again:");
                value = Console.ReadLine();
            }
            return value;
        }
            //method to add numbers in crresponding places and check if sum is the same
        private static bool IsMatchingSumsInEachNumberPlace(string inputNumber1, string inputNumber2)
        {
            int sumOfIntegers = 0;
            int previousSumOfIntegers = 0;
            int integer1 = 0;
            int integer2 = 0;
            for (var i = 0; i < inputNumber1.Length; i++)
            {
                integer1 = int.Parse(inputNumber1.Substring(i, 1));
                integer2 = int.Parse(inputNumber2.Substring(i, 1));
                sumOfIntegers = integer1 + integer2;

                if (i > 0 && sumOfIntegers != previousSumOfIntegers)
                {
                    return false;
                }
                previousSumOfIntegers = sumOfIntegers;
            }
            return true;
        }
    }
               }
   
/*
            maggie was here :)
*/