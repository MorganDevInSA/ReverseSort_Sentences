using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSort_Words.Input
{
    public class UserInputValidator
    {
        public static (bool, int) ValidateInput(string input, int minValue, int maxValue)
        {
            bool isValid = false;
            int userInput;

            if (int.TryParse(input, out userInput))
            {
                if (userInput >= minValue && userInput <= maxValue)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"Please enter a number between {minValue} and {maxValue}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            return (isValid, userInput);
        }

        public static int GetValidNumberInput(int minValue, int maxValue, string message)
        {
            int userInput;
            bool isValid = false;

            do
            {
                Console.WriteLine(message);
                Console.WriteLine("");
                string input = Console.ReadLine();

                (isValid, userInput) =  ValidateInput(input, 1, 25);              
            } while (!isValid);

            return userInput;
        }
    }
}
