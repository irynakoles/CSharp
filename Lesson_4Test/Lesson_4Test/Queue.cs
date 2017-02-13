using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4Test
{
    public class Queue
    {
        public int size;
        public int[] queue;
        public int begin;
        public int end;
        public int elements;

        public Queue(int size)
        {
            this.size = size;
            queue = new int[size];
            begin = 0;
            end = -1;
        }

        public void Enqueue(int i)
        {
            if (end == size - 1)
                end = -1;
            queue[++end] = i;
            elements++;

        }
        public int Dequeue()
        {
            int temp = queue[begin++];
            if (begin == size)
                begin = 0;
            elements--;
            return temp;

        }
        public int Peek()
        {
            return queue[begin];
        }
        public bool IsEmpty()
        {
            return (elements == 0);
        }
        public bool IsFull()
        {
            return (elements == size);
        }
        public int GetSize()
        {
            return elements;
        }
    }
}
