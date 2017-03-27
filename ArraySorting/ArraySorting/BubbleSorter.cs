using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class BubbleSorter : SorterHelper, ISorter
    {
        public BubbleSorter(int[] array) : base(array, "Bubble sort")
        {

        }

        public void Sort(bool isRevers)
        {
            PrintSorterName();
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (isRevers == false)
                        {
                            if (array[i] > array[j])
                            {
                                Swap(array, i, j);
                                swapped = true;
                            }
                        }
                        else
                        {
                            if (array[i] < array[j])
                            {
                                Swap(array, i, j);
                                swapped = true;
                            }
                        }
                    }
                }
            }
        }
    }
}