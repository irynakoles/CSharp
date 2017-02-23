using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable
    {
        public InsertionSorter(T[] array) : base(array, "Insertion sorter")
        {
        }

        public override void Sort()
        {
            PrintSorterAlg();
            for (int i = 0; i < array.Length; i++)
            {
                T num = array[i];
                int j = i;
                while (j > 0 && num.CompareTo(array[j - 1]) <0)
                {
                    Swap(ref array[j], ref array[j - 1]);
                    j--;
                }
            }
        }
    }
}