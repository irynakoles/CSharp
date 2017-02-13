using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4Test
{
    public class Stack
    {
        int stackSize;
        int[] stack;
        int top;

        public Stack(int stackSize)
        {
            this.stackSize = stackSize;
            stack = new int[stackSize];
            top = -1;
        }
        public bool IsEmpty()
        {
            if(top==0)
            {
                Console.WriteLine("This stack is empty");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if(top==stackSize)
            {
                Console.WriteLine("This stack is full");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(int i )
        {
           if(IsFull())
            {
                Console.WriteLine("This stack is full!");
            }
           else
            {
                stack[++top] = i;
               
                
            }
        }
        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("This stack is empty!");
                return 0;
            }
            else
            {
                return stack[--top];
            }
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("This stack is empty");
                return 0;
            }
            else
            {
                return stack[top];
            }
        }
        public void PrintStack()
        {
            for (int i=0; i<stack.Length; i++)
            {
                Console.WriteLine(stack[i]);
                Console.ReadKey();

            }
        }
    }
}
