using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_2
{
    public class DynamicStack<T> : DynamicArray<T>
    {
        
        public void Push(T value)
        {
            Add(value);
        }

        public T Pop()
        {
            T value = Get(size - 1);
            Remove(size - 1);
            return value;
        }

        public void Print()
        {
            Console.WriteLine("Stack: ");
            for (int i = 0; i < size; i ++)
            {
                Console.WriteLine(Get(i));
            }
        }

        public bool IsFull()
        {
            return capacity == size;
            
        }

        public bool IsEmpty()
        {
            return size == 0;
            
        }
    }
}

