using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
   abstract class Buffer<T> : IBuffer<T>

    {
        public int size;

        public Buffer(int size)
        {
            this.size = size;
        }

        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract void Print();
        
    }
}
