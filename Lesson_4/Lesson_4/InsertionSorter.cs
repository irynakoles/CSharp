using System;

namespace Lesson_4
{
    public class InsertionSorter
    {
        //Soring array -Insertion sort
        public void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int j = i;
                while (j > 0 && num < array[j - 1])
                {
                    Swap(array, j, j - 1);
                    j--;
                }
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
        //Print array before sorting
        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array before insertion sorting: ");
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        //Print Sorted Array
        public void PrintSortedArray(int[] array)
        {
            Console.WriteLine("Array after insertion sort: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadKey();
        }
    }
}

