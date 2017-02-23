using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class BubbleSorter: Sorter
    {
        public BubbleSorter(int[] array) : base(array)
        {
        }

        bool swapped= true;

        public override void Sort()
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
                            Swap(array, i ,j);
                            swapped = true;
                        }
                    }
                }
            }
        }  
    }
}
