using System;

namespace Lesson_4
{
    class BubbleSorter
    {
        bool swapped = true;

        //Sorting Array
        public void BubbleSort(int[] array)
        {
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            Swap(array, i, j);
                            swapped = true;
                        }
                    }
                }
            }
        }
        //Swap numbers
        public void Swap(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        //Print array before sorting
        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array before bubble sorting: ");
            for (int i =0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
        //Print Sorted Array
        public void PrintSortedArray(int[] array)
        {
            Console.WriteLine("Array after bubble sorting: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}

