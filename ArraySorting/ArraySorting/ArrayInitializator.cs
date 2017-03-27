using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class ArrayInitializator
    {
        private string userInput;
        private int columns;
        private int rows;

        // Read the number of rows in array
        public int ReadRowNumber()
        {
            Console.WriteLine("Please, enter the number of rows : ");
            userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out columns))
            {
                Console.WriteLine("Please, enter the correct number!");
                Console.ReadKey();
                return -1;
            }

            return columns;
        }

        // Read the number of columns in array
        public int ReadColumnsNumber()
        {
            Console.WriteLine("Please, enter the number of columns: ");
            userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out rows))
            {
                Console.WriteLine("Please, enter the correct number!");
                Console.ReadKey();
                return -1;
            }
            return rows;
        }

        // Fill array with numbers
        public int[,] ReadArrayNumbers(int columns, int rows)
        {
            int[,] array = new int[columns, rows];
            Console.WriteLine("Please, enter the numbers to array: ");
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    {
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return array;
        }

        //Fill array with random values
        public int [,] RandomArrayGenerator(int columns, int rows)
        {
            int[,] array = new int[columns, rows];
            Random random= new Random();

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array[i, j] = random.Next(0, 100);
                }
            }
            return array;
        }
    }
}
