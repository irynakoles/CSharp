using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    public class Container<T>
    {
        public DynamicArray<T> container = new DynamicArray<T>();


        public void PrintCapacity()
        {
            Console.WriteLine($"Capacity: {container.GetCapacity()}");
        }

        public void PrintSize()
        {
            Console.WriteLine($"Size: {container.GetSize()}");
        }

        public void Print()
        {
            Console.WriteLine(GetType().Name);
            for (int i = 0; i < container.GetSize(); i++)
            {
                Console.WriteLine(container.Get(i));
            }
        }
        public bool IsFull()
        {
            return (container.GetCapacity() == container.GetSize());
        }

        public bool IsEmpty()
        {
            return (container.GetSize() == 0);
        }
    }
}
