using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_2
{
    public class DynamicQueue<T>: DynamicArray<T>
    {
       private int begin = 0;
       private int end = 0;

        public bool IsEmpty()
        {
            return begin == end;
        }

        public bool IsFull()
        {
            return size == capacity;   
        }

        public void Engueue(T value)
        {
            Add(value);
        }

        public T Dequeue()
        {
            T value = Get(begin);
            Remove(begin);
            return value;
        }

        public void Print()
        {
            Console.WriteLine("Queue: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Get(i));
            }
        }
    }
}
