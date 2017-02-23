using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Sorter
    {
        public int[] array;
        public int size;

        public Sorter(int[] array)
        {
            this.array = array;
            array = new int[size];
        }

        //Will be override in bubble sorter and Insertion sorter
        public virtual void Sort()
        { }

        //Swap numbers
        public static void Swap(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        //Print Sorted Array
        public void PrintSortedArray(int[] array)
        {
            Console.WriteLine("Array after sorting: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        //Print array before sorting
        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array before sorting: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}