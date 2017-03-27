using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class Program
    {
        private static int[,] array;
       
        static void Main(string[] args)
        {
            SortingProgram();
        }

        private static void SortingProgram()
        {
            while (true)
            {
                Console.WriteLine("Press 1 to sort random generated array \n"
                                  + "Press 2 to sort your own array. \n ");

                int initializationType = int.Parse(Console.ReadLine());

                switch (initializationType)
                {
                    //If random generated array
                    case 1:
                        {
                            ArrayInitializator initializator = new ArrayInitializator();
                            Console.WriteLine("Please input number of rows.");
                            int rows = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please input number of columns.");
                            int columns = int.Parse(Console.ReadLine());

                            array = initializator.RandomArrayGenerator(rows, columns);
                            ChoosingSortType(array,rows,columns);

                            break;
                        }
                    
                    //If manual created array
                    case 2:
                        {
                            ArrayInitializator manualInitializator = new ArrayInitializator();
                            int rows = manualInitializator.ReadRowNumber();
                            int columns = manualInitializator.ReadColumnsNumber();
                            int[,] array = manualInitializator.ReadArrayNumbers(rows, columns);

                            ChoosingSortType(array,rows,columns);
                            break;
                        }
                }
            }
        }

        // Type of sorting that will be used
        private static void ChoosingSortType(int [,]array,  int rows, int columns)
        {
            
            Console.WriteLine("Choose type of sorting : \n"
                                               + "1. Bubble Sort (Asc) \n"
                                               + "2. Bubble Sort (Desc) \n"
                                               + "3. Inserion Sort (Asc) \n"
                                               + "4. Insertion sort (Desc) \n"
                                               + "5. Built-In sort (Asc)\n"
                                               + "6. Built-in sort(Desc) \n");

            int sortType = int.Parse(Console.ReadLine());

            switch (sortType)
            { 
                case 1:
                    {
                       
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);
                        BubbleSorter bubbleSort = new BubbleSorter(tempArray);
                        bubbleSort.Sort(false);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
                case 2:
                    {
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);
                        BubbleSorter bubbleSort = new BubbleSorter(tempArray);
                        bubbleSort.Sort(true);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
                case 3:
                    {
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);
                        InserionSorter insertionSort = new InserionSorter(tempArray);
                        insertionSort.Sort(false);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
                case 4:
                    {
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);

                        InserionSorter insertionSort = new InserionSorter(tempArray);
                        insertionSort.Sort(true);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
                case 5:
                    {
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);
                        BuiltInSorter builtInSort = new BuiltInSorter(tempArray);
                        builtInSort.Sort(false);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
                case 6:
                    {
                        int[] tempArray = SorterHelper.ConvertTo1DArray(array, rows, columns);
                        BuiltInSorter builtInSort = new BuiltInSorter(tempArray);
                        builtInSort.Sort(true);
                        array = SorterHelper.ConvertTo2DArray(tempArray, rows, columns);
                        SorterHelper.PrintArray(array, rows, columns);
                        break;
                    }
            }
        }
    }
}