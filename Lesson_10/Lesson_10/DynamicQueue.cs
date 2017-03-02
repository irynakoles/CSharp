using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class DynamicQueue<T>:DynamicArray<T>
    {
        public DynamicArray<T> queue;
        int begin = 0;
        int end = 0;

        public DynamicQueue():base()
        {
            queue = new DynamicArray<T>();
        }

        public bool IsEmpty()
        {
            if(begin==end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if(queue.size==queue.capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Engueue(T value)
        {
                queue.Add(value);
            
        }

        public T Dequeue()
        {
            T value = queue.Get(begin);
            queue.Remove(begin);
            return value;
        }

        public void Print()
        {
            Console.WriteLine("Queue: ");
            for(int i =0; i <queue.size;i++)
            {
                Console.WriteLine(queue.Get(i));
            } 
        }
    }
}
