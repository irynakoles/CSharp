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
            //int[] array = new int[10] { 10, 2, 5, 6, 3, 4, 5, 9, 2, 1 };
            //BubbleSorter<int> bubbleSort = new BubbleSorter<int>(array);
            //bubbleSort.Print();
            //bubbleSort.Sort();
            //bubbleSort.Print();

            //string[] stringArray = new string[3] { "Anna", "Katerina", "Alina" };
            //BubbleSorter<string> stringSorter = new BubbleSorter<string>(stringArray);
            //stringSorter.Print();
            //stringSorter.Sort();
            //stringSorter.Print();

            //int[] secondArray = new int[] { 10, 2, 5, 6, 3, 4, 5, 9, 2, 1 };

            //InsertionSorter<int> insertionSorter = new InsertionSorter<int>(secondArray);
            //insertionSorter.Print();
            //insertionSorter.Sort();
            //insertionSorter.PrintSorterAlg();
            //insertionSorter.Print();


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
        }
    }
}
