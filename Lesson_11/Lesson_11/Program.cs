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
            list.AddLast(1);
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.Print();
            //list.AddBefore(3, 99);
            list.AddAfter(3, 100);
            list.Clear();
            //list.DeleteLast();
            //list.Print();
            //list.DeleteLast();
            //list.DeleteFirst();
            //list.AddFirst(40);
            //list.DeleteByValue(40);
            list.Print();

            Console.ReadKey();

        }  
    }
}

