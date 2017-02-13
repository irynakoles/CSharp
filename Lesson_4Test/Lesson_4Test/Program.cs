using System;

namespace Lesson_4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayInitializator initialize = new ArrayInitializator();
            //BubleSort
            int arraySize = initialize.ReadArraySize();
            int[] array = initialize.ReadArrayNumbers(arraySize);
            BubbleSorter bubleSort = new BubbleSorter();
            bubleSort.PrintArray(array);
            bubleSort.BubbleSort(array);
            bubleSort.PrintSortedArray(array);
            
            //Inserion Sort
            int secondArraySize= initialize.ReadArraySize();
            int[] secondArray = initialize.ReadArrayNumbers(secondArraySize);
            InsertionSorter insertionSort = new InsertionSorter();
            insertionSort.PrintArray(secondArray);
            insertionSort.InserionSort(secondArray);
            insertionSort.PrintSortedArray(secondArray);

            //Stack example
            Stack myStack = new Stack(10);
            myStack.Push(1);
            myStack.Push(3);
            myStack.Push(20);
            myStack.Push(210);
            myStack.Push(3);
            myStack.Push(20);

            while (!myStack.IsEmpty())
            {
              int i = myStack.Pop();
              Console.WriteLine(i);
            }
            Console.ReadKey();

            Console.ReadLine();
            //Queue example
            Queue queue = new Queue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);

            queue.Dequeue();

            
            Console.WriteLine("Queue example: ");
            while (!queue.IsEmpty())
            {
                int i = queue.Dequeue();
                Console.WriteLine(i);
            }
           Console.ReadKey();
        }
    }
}     
     