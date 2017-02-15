using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class InsertionSorter
    {
        //Soring array -Insertion sort
        public void InserionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int j = i;
                while (j > 0 && num < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = num;
            }
        }

        //Swap numbers
        static void Swap(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        //Print Sorted Array
        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array after sorting inserion sort: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}

