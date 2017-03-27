using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    public class SorterHelper
    {
        public int[] array;
        private string sortType;
        

        public SorterHelper(int[] array, string sortType)
        {
            this.array = array;
            this.sortType = sortType;
            
        }

        public void PrintSorterName()
        {
            Console.WriteLine("Sorted by : {0}", sortType);
        }

        public void Swap(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        public static int[] ConvertTo1DArray(int[,] array, int rows, int columns)
        {
            int[] tempArray = new int[columns * rows];
            int x = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tempArray[x] = array[i, j];
                    x++;
                }
            }
            return tempArray;
        }

        public static int[,] ConvertTo2DArray(int[] array, int columns, int rows)
        {
            int[,] tempArray = new int[columns, rows];
            int x = 0;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    tempArray[i, j] = array[x];
                    x++;
                }
            }
            return tempArray;
        }

        public  static void PrintArray(int[,] array, int columns, int rows)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}


