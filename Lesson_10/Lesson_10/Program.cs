using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicQueue<int> queue = new DynamicQueue<int>();

            queue.PrintCapacity();
            queue.PrintSize();
            queue.Engueue(10);
            queue.Engueue(20);
            queue.Engueue(30);
            queue.PrintCapacity();
            queue.PrintSize();
            queue.Dequeue();
            queue.Print();


            DynamicStack<int> stack = new DynamicStack<int>();

            stack.PrintCapacity();
            stack.PrintSize();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.PrintCapacity();
            stack.PrintSize();
            stack.Pop();
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.PrintCapacity();
            stack.PrintSize();
            stack.Print();
            
            Console.ReadKey();
            
        }
    }
}
