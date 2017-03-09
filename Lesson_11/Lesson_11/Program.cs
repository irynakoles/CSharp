using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            list.DeleteFirst();
            list.Add(1);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Print();
            list.DeleteLast();
            //list.AddFirst(40);
            //list.DeleteByValue(40);

           // list.DeleteFirst();
            list.Print();

            Console.ReadKey();

        }  
    }
}

