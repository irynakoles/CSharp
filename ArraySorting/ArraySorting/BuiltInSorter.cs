using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class BuiltInSorter : SorterHelper, ISorter
    {
        public BuiltInSorter(int[] array) : base(array, "Built-in Sorter" )
        {
        }

        public void Sort(bool isRevers)
        {
           
            if (isRevers == false)
            {
                Array.Sort(array);
            }
            else 
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
        }
    }
}
