using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class MyStack<T> : Buffer<T>
    {
        public int size;
        public T[] stack;
        public int top;

        public MyStack(int size)
        {
            this.size = size;
            stack = new T[size];
            top = 0;
        }
        public override bool IsEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsFull()
        {
            if (top == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override T Peek()
        {
            return stack[top];
        }

        public override T Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Pop element: {0}, value: {1}", top - 1, stack[top - 1]);
                return stack[--top];
            }
            else
            {
                Console.WriteLine("Stack is Empty!");
                return default(T);
            }
        }

        public override void Print()
        {
            Console.WriteLine("Stack: ");
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
            Console.ReadKey();
        }

        public override void Push(T i )
        { 
            if (!IsFull())
            {
                Console.WriteLine("Push element: {0}", i);
                stack[top] = i;
                top++;
            }
            else
            {
                Console.WriteLine("Stack is Full!");
            }
        }
    }
}
