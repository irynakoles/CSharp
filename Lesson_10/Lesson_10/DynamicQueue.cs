using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class DynamicQueue<T> : Container<T>
    {
        private int begin = 0;

        public void Engueue(T value)
        {
            container.Add(value); 
        }

        public T Dequeue()
        {
            T value = container.Get(begin);
            container.Remove(begin);
            return value;
        }
    }
}
