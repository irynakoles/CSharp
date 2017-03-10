using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicStack<int> stack = new DynamicStack<int>();
            stack.PrintCapacity();
            stack.PrintSize();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.PrintCapacity();
            stack.PrintSize();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Pop();
            stack.PrintCapacity();
            stack.PrintSize();
            stack.PrintStack();

            Console.WriteLine(" ");
            DynamicQueue<int> queue = new DynamicQueue<int>();

            queue.PrintCapacity();
            queue.PrintSize();
            queue.Engueue(10);
            queue.Engueue(20);
            queue.Engueue(30);
            queue.PrintCapacity();
            queue.EnqueueByIndex(2, 2);
            queue.PrintQueue();
            queue.Dequeue();
            queue.PrintQueue();
            
            Console.ReadKey();
        }
    }
}