using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firstArray = new int[] { 1, 5, 5, 4, 6, 5, 8, 4, 5, 2, 7, 4, 5, 6, 9 };
            int[] secondArray = new int[] { 2, 4, 5, 64, 3, 4, 5, 6, 3, 4, 2, 2 };
            BubbleSorter bubbleSort = new BubbleSorter(firstArray);
            bubbleSort.PrintArray(firstArray);
            bubbleSort.Sort();
            bubbleSort.PrintSortedArray(firstArray);

            InsertionSorter insertionSort = new InsertionSorter(secondArray);
            insertionSort.PrintArray(secondArray);
            insertionSort.Sort();
            insertionSort.PrintSortedArray(secondArray);

            MyStack stack = new MyStack(5);
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

            MyQueue queue = new MyQueue(5);
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
