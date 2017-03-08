using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public delegate void QueueStatusDelegate();
    class DynamicQueue<T>
    {
        private DynamicArray<T> queue;
        private int begin = 0;
        public event QueueStatusDelegate QueueIsFullEvent;
        public event QueueStatusDelegate QueueIsEmptyEvent;

        public DynamicQueue()
        {
            queue = new DynamicArray<T>();
            QueueIsFullEvent += QueueIsFull;
            QueueIsEmptyEvent += QueueIsEmpty;
        }

        public void QueueIsEmpty()
        {
            Console.WriteLine("Queue is empty!");
        }
        public void QueueIsFull()
        {
            Console.WriteLine("Queue is full!");
        }
        public void Engueue(T value)
        {
            queue.Add(value);
        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T value = queue.Get(begin);
                queue.Remove(begin);
                return value;
            }
            return default(T);
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
            QueueIsFullEvent();
            return queue.GetCapacity() == queue.GetSize();

        }

        public bool IsEmpty()
        {
            QueueIsEmptyEvent();
            return queue.GetSize() == 0;
            
        }
    }
}