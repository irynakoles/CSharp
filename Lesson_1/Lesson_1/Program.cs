using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int firstNumber;
            int secondNumber;

            //Entering  and validating first number
            Console.WriteLine("Enter first number: ");
            try
            {
                userInput = Console.ReadLine();
                firstNumber = Convert.ToInt32(userInput);
                // Entering and validating second number
                Console.WriteLine("Enter second number: ");
                userInput = Console.ReadLine();
                secondNumber = Convert.ToInt32(userInput);

                //Check if first number devided by second without remainder
                if (firstNumber % secondNumber == 0)
                {
                    Console.WriteLine("First number divide by second number without remainder ");
                }
                else
                {
                    Console.WriteLine("First number devide by second number with remainder ");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}