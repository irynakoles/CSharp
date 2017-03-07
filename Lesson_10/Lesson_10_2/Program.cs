using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicStack<int> stack = new DynamicStack<int>();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine($"Size: {stack.GetSize()}");
            Console.WriteLine($"Capacity: {stack.GetCapacity()}");
            stack.Push(5);
            stack.Insert(10, 3);
            stack.Push(6);
            Console.WriteLine($"Size: {stack.GetSize()}");
            Console.WriteLine($"Capacity: {stack.GetCapacity()}");
            stack.Push(7);
            stack.Pop();
            stack.Print();

            DynamicQueue<int> queue = new DynamicQueue<int>();
            Console.WriteLine(" ");
            Console.WriteLine($"Size: {queue.GetSize()}");
            Console.WriteLine($"Capacity: {queue.GetCapacity()}");

            queue.Engueue(10);
            queue.Engueue(20);
            queue.Print();
            queue.Engueue(30);
            Console.WriteLine($"Size: {queue.GetSize()}");
            queue.Insert(5, 2);
            Console.WriteLine($"Capacity: {queue.GetCapacity()}");

            queue.Print();
            queue.Dequeue();
            queue.Print();

            Console.ReadKey();
        }
    }
}
