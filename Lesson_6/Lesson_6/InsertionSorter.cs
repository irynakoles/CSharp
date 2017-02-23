using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class InsertionSorter : Sorter
    {
        public InsertionSorter(int[] array) : base(array)
        {
        }

        public override void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int j = i;
                while (j > 0 && num < array[j - 1])
                {
                    Swap(array, j,j - 1);
                    j--;
                }
                array[j] = num;
            }
        }
    }
}

