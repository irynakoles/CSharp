using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayInitializator initializeFirstArray = new ArrayInitializator();
            int firstArraySize = initializeFirstArray.ReadArraySize();
            int[] firstArray = initializeFirstArray.ReadArrayNumbers(firstArraySize);
            BubbleSorter bubbleSort = new BubbleSorter();
            bubbleSort.PrintArray(firstArray);
            bubbleSort.BubbleSort(firstArray);
            bubbleSort.PrintSortedArray(firstArray);

            ArrayInitializator initalizeSecondArray = new ArrayInitializator();
            int secondArraySize = initalizeSecondArray.ReadArraySize();
            int[] secondArray = initalizeSecondArray.ReadArrayNumbers(secondArraySize);
            InsertionSorter insertionSort = new InsertionSorter();
            insertionSort.PrintArray(secondArray);
            insertionSort.InsertionSort(secondArray);
            insertionSort.PrintSortedArray(secondArray);

            Stack stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Print();
            Console.ReadKey();

            Queue queue = new Queue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.PrintQueue();
           
            Console.ReadKey();
        }
    }
}
            
            
                
 