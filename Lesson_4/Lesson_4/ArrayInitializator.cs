using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class ArrayInitializator
    {
        //Input array size
        public int ReadArraySize()
        {
            string userInput;
            int arraySize;
            Console.WriteLine("Please, enter size of array. ");
            userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out arraySize))
            {
                Console.WriteLine("Please, Enter the correct number");
                Console.ReadKey();
                return -1;

            }
            return arraySize;
        }
        //Fill the array
        public int[] ReadArrayNumbers(int arraySize)
        {

            int[] array = new int[arraySize];

            Console.WriteLine("Please, enter the numbers to array.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            return array;
        }
    }
}
