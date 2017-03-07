using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class DynamicQueue<T>
    {
        private DynamicArray<T> queue;
        private int begin = 0;

        public DynamicQueue()
        {
            queue = new DynamicArray<T>();
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

        public void EnqueueByIndex(T value, int index)
        {
            queue.Insert(value, index);
        }

        public void PrintQueue()
        {
            Console.WriteLine("Queue: ");
            for (int i = 0; i < queue.GetSize(); i++)
            {
                Console.WriteLine(queue.Get(i));
            }
        }
        public void PrintCapacity()
        {
            Console.WriteLine($"Capacity: {queue.GetCapacity()}");
        }

        public void PrintSize()
        {
            Console.WriteLine($"Size: {queue.GetSize()}");
        }

        public bool IsFull()
        {
            return queue.GetCapacity() == queue.GetSize();

        }

        public bool IsEmpty()
        {
            return queue.GetSize() == 0;

        }
    }
}