using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public delegate void StackStatusDelegate();

    class DynamicStack<T>
    {

        private DynamicArray<T> stack;
        public event StackStatusDelegate StackIsFullEvent;
        public event StackStatusDelegate StackIsEmptyEvent;

        public DynamicStack()
        {

            stack = new DynamicArray<T>();
            StackIsEmptyEvent += StackIsEmpty;
            StackIsFullEvent += StackIsFull;

        }

        public static void StackIsEmpty()
        {
            Console.WriteLine("Stack is empty!");
        }

        public static void StackIsFull()
        {
            Console.WriteLine("Stack is empty!");
        }

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T value = stack.Get(stack.GetSize() - 1);
                stack.Remove(stack.GetSize() - 1);
                return value;
            }
            return default(T);
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
            StackIsFullEvent();
            return stack.GetCapacity() == stack.GetSize();

        }

        public bool IsEmpty()
        {
            StackIsEmptyEvent();
            return stack.GetSize() == 0;

        }
    }
}
