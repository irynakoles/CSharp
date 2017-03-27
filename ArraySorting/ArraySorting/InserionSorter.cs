using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class InserionSorter : SorterHelper, ISorter
    {
        public InserionSorter(int[] array) : base(array, "Insertion sort")
        {

        }
        public void Sort(bool isRevers)
        {
            PrintSorterName();

            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int j = i;
                if (isRevers == false)
                {
                    while (j > 0 && num < array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        j--;
                    }
                }
                else
                {
                    while (j > 0 && num > array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        j--;
                    }
                }
                }
            }
        }
    }