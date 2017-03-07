using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class DynamicStack<T>
    {

        private DynamicArray<T> stack;

        public DynamicStack()
        {
            stack = new DynamicArray<T>();
        }

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            T value = stack.Get(stack.GetSize() - 1);
            stack.Remove(stack.GetSize() - 1);
            return value;
        }

        public void PrintStack()
        {
            Console.WriteLine("Stack: ");
            for (int i = 0; i < stack.GetSize(); i++)
            {
                Console.WriteLine(stack.Get(i));
            }
        }

        public void PrintCapacity()
        {
            Console.WriteLine($"Capacity: {stack.GetCapacity()}");
        }

        public void PrintSize()
        {
            Console.WriteLine($"Size: {stack.GetSize()}");
        }

        public bool IsFull()
        {
            return stack.GetCapacity() == stack.GetSize();

        }

        public bool IsEmpty()
        {
            return stack.GetSize() == 0;

        }
    }
}
