using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Queue
    {
        public int size;
        public int[] queue;
        public int begin;
        public int end;
        public int numberOfElements;

        public Queue(int size)
        {
            this.size = size;
            queue = new int[size];
            begin = 0;
            end = -1;
            numberOfElements = 0;
        }
        public void Enqueue(int i)
        {
            Console.WriteLine("Enqueue: {0}", i);
            if (end == size - 1)
                end = -1;
            queue[++end] = i;
            numberOfElements++;
        }

        public int Dequeue()
        {
            int temp = queue[begin++];
            if (!IsEmpty())
                begin = 0;
            numberOfElements--;
            return temp;

        }
        public bool IsFull()
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
        public bool IsEmpty()
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
        public void PrintQueue()
        {
            Console.WriteLine("Queue: ");
            for (int i = 0; i < queue.Length; i++)
            {
                Console.WriteLine(queue[i]);
            }
            Console.ReadKey();
        }
    }
}

