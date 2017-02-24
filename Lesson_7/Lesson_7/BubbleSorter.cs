using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class BubbleSorter<T> : Sorter<T> where T : IComparable
    {
        public BubbleSorter(T[] array) : base(array, "Bubble Sort")
        {
        }
        bool swapped = true;
        public override void Sort()
        {
            PrintSorterAlgorithm();
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].CompareTo(array[j])>0)
                        {
                            Swap( ref array[i], ref array[j]);
                            swapped = true;
                        }
                    }
                }
            }
        }
    }
}
