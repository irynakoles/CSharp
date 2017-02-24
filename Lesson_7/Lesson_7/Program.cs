using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 10, 2, 5, 6, 3, 4, 5, 9, 2, 1 };
            BubbleSorter<int> bubbleSort = new BubbleSorter<int>(array);
            bubbleSort.Print();
            bubbleSort.Sort();
            bubbleSort.Print();

            string[] stringArray = new string[3] { "Anna", "Katerina", "Alina" };
            BubbleSorter<string> stringSorter = new BubbleSorter<string>(stringArray);
            stringSorter.Print();
            stringSorter.Sort();
            stringSorter.Print();

            int[] secondArray = new int[] { 10, 2, 5, 6, 3, 4, 5, 9, 2, 1 };

            InsertionSorter<int> insertionSorter = new InsertionSorter<int>(secondArray);
            insertionSorter.Print();
            insertionSorter.Sort();
            insertionSorter.Print();

            MyStack<int> stack = new MyStack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(5);
            stack.Push(6);
            stack.Print();

            MyQueue<int> queue = new MyQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Print();

            Console.ReadKey();
        }
    }
}
