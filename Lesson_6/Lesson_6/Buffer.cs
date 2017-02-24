using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    abstract class Buffer
    {
        public int[] array;
        public int size;

        public Buffer(int size)
        {
            this.size = size;
        }

        // Will be override for stack and queue 
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract void Print();

    }
}
