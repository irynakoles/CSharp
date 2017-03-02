using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    public class DynamicArray<T>
    {
        public int size;
        public int capacity;
        public T[] array;

        public DynamicArray()
        {
            capacity = 1;
            size = 0;
            array = new T[capacity];
        }

        public void Remove(int index)
        {
            for (int i = index; i < size; i++)
            {
                array[i] = array[i + 1];
            }
            Console.WriteLine("Remove: index: {0}", index);
            size--;
        }
        
        public void Add(T i)
        {
            if (size == capacity)
            {
                IncreaseCapacity();
            }
            array[size] = i;
            size++;
        }

        public void Insert(T insert, int index)
        {
            if (size == capacity)
            {
                IncreaseCapacity();
                for (int i = index; i < size; i++)
                {
                    array[i] = array[i + 1];

                }
                array[index] = insert;
                size++;
            }
            else
            {
                for (int i = size; i >=index; i--)
                {
                    array[i + 1] = array[i];
                }
                array[index] = insert;
                size++;
            }

        }

        public T Get(int index)
        {
            T value = array[index];
            //Console.WriteLine("Value is: {0}", value);
            return value;
        }

        public void IncreaseCapacity()
        {
            this.capacity = this.capacity * 2;
            T[] secondArray = new T[capacity*2];
            for (int i = 0; i < array.Length; i++)
            {
                secondArray[i] = array[i];
            }
            array = secondArray;
        }

        public int GetCapacity()
        {
            Console.WriteLine("Capacity: {0}", capacity);
            return capacity;
        }

        public int GetSize()
        {
            Console.WriteLine("Size: {0}",size);
            return size;  
        }
    }
}
