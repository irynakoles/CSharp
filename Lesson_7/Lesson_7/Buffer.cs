using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
   abstract class Buffer<T> : IBuffer<T>, IMyStack<T>
        
    {
        //public T[] array;

        //public Buffer(T[] array)
        //{
        //    this.array = array;
        //}

        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peek();

        public abstract T Pop();

        public abstract void Print();

        public abstract void Push(T i);
    }
}
