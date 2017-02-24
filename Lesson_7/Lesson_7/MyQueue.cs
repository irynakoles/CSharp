using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        public T[] queue;
        public int begin;
        public int end;
        public int numberOfElements;
     
        public MyQueue(int size):base(size)
        {
            queue = new T[size];
            begin = 0;
            end = -1;
            numberOfElements = 0;
        }

        public override bool IsEmpty()
        {
            if (numberOfElements == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsFull()
        {
            if (numberOfElements == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Print()
        {
            Console.WriteLine("Queue: ");
            for (int i = 0; i < queue.Length; i++)
            {
                Console.WriteLine(queue[i]);
            }
            Console.ReadKey();
        }

        public void Enqueue(T i)
        {
            Console.WriteLine("Enqueue: {0}", i);
            if (end == size - 1)
                end = -1;
            queue[++end] = i;
            numberOfElements++;
        }

        public T Dequeue()
        {
            T temp;
            temp = queue[begin++];
            if (begin == size)
                begin = 0;
            numberOfElements--;
            Console.WriteLine("Dequeue: {0}", temp);
            return temp;
           
        }
    }
}
