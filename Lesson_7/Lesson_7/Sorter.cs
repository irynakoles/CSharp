using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
     public abstract class Sorter<T> : ISorter<T>
    {
        public T [] array;
        string sortType;

        public Sorter(T[] array, string sortType)
        {
            this.array = array;
            this.sortType = sortType;
        }

        public void Print()
        {
            Console.WriteLine("Array : ");
            for (int i =0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        //Will be override in BubbleSorter and InsertionSorter
        public abstract void Sort();

        //Print name of algorithm that was used
        public void PrintSorterAlgorithm()
        {
            Console.WriteLine("Sorted By: {0}", sortType);
        }

        public void Swap(ref T i, ref T j)
        {
            T temp;
            temp = i;
            i = j;
            j = temp;
        }
    }
}
