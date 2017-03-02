using System;
using System.Collections.Generic;


namespace Lesson_10
{
    class DynamicStack<T> : Container<T>
    {
        public void Push(T value)
        {
            container.Add(value);
        }

        public T Pop()
        {
            T value = container.Get(container.GetSize() - 1);
            container.Remove(container.GetSize() - 1);
            return value;
        }
    }
}


 