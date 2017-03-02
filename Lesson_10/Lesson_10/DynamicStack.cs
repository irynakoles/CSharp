using System;
using System.Collections.Generic;


namespace Lesson_10
{
    class DynamicStack<T>:DynamicArray<T>
    {
        public DynamicArray<T> stack;

        public DynamicStack():base()
        {
           stack = new DynamicArray<T>();
        }

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            T value = stack.Get(stack.size-1);
            stack.Remove(stack.size-1);
            return value;
        }

        public void Print()
        {
            Console.WriteLine("Stack: ");
            for (int i =stack.size-1; i>=0; i--)
            {
                Console.WriteLine(stack.Get(i));
            }
        }

        public bool IsFull()
        {
            if(stack.capacity==stack.size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (stack.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


 