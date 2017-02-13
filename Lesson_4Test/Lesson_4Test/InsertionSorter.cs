using System;


namespace Lesson_4Test
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

        //Print array before sorting
        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array before sorting: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        } 
        //Print Sorted Array
        public void PrintSortedArray(int[] array)
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
