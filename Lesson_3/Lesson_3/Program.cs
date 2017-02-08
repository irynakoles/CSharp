using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = ReadArraySize();
            int[] array = ReadArrayNumbers(arraySize);
            PrintMax(array);
            PrintMin(array);
   
        }

        //Array size
        static int ReadArraySize()
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
        static int [] ReadArrayNumbers(int arraySize)
        {
            
            int[] array = new int[arraySize];

            Console.WriteLine("Please, enter the numbers to array.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            return array;  
        }

        // Print max
        static void PrintMax(int[] array)
        {
            int max = GetMaxValue(array);
            Console.WriteLine("Max {0} ", max);
        }

        //Print min
        static void PrintMin(int [] array)
        {
            int min = GetMinValue(array);
            Console.WriteLine("Min {0} ", min);
            Console.ReadKey();
        }

        //Maximum value
        static int GetMaxValue(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                
            }
            return max;
        }
        //Minimum value
        static int GetMinValue(int [] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        
    }

}
      