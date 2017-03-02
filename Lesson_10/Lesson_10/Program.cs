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

            queue.GetCapacity();
            queue.GetSize();
            queue.Engueue(10);
            queue.Engueue(20);
            queue.Engueue(30);
            
            queue.GetSize();
            queue.GetCapacity();
            Console.WriteLine(queue.capacity);       
            queue.Print();
            queue.Dequeue();
            queue.Print();


            //DynamicStack<int> stack = new DynamicStack<int>();
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.GetCapacity();
            //stack.GetSize();
            //stack.Push(5);
            //stack.Pop();
            //stack.Print();           

            //list.Get(3);
            //list.Remove(1);
            //Console.WriteLine("Capacity: {0}", list.capacity);
            //Console.WriteLine("Size: {0}", list.size);

            //list.Print();
            //list.Insert(555, 1);
            //Console.WriteLine("After insertion: ");
            //Console.WriteLine("Capacity: {0}", list.capacity);
            //Console.WriteLine("Size: {0}", list.size);
            //list.Print();
            Console.ReadKey();


            //Console.WriteLine("Content before sort: ");
            //foreach (int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadLine();
            //list.Sort();
            //Console.WriteLine("Content after sort: ");
            //foreach(int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadLine();
            //list.Reverse();
            //Console.WriteLine("Content after reverse: ");
            //foreach(int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadKey();
        }
    }
}
