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
        // public int size;
        string sortAlg;
        public Sorter(T[] array, string sortAlg)
        {
            this.array = array;
            this.sortAlg = sortAlg;
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

        public abstract void Sort();

        public void PrintSorterAlg()
        {
            Console.WriteLine("Sorter By: {0}", sortAlg);
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
