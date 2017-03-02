using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    public class DynamicArray<T>
    {
        private int capacity;
        private int size;
        private T[] array;

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
            size--;
        }
        
        public void Add(T i)
        {
            if (size == (capacity-1))
            {
                IncreaseCapacity();
            }
            array[size] = i;
            size++;
        }

        public void Insert(T insert, int index)
        {
            if (size == (capacity - 1))
            {
                IncreaseCapacity();
            }
            for (int i = index; i < size; i++)
            {
                array[i] = array[i + 1];

            }
            array[index] = insert;
            size++;
        }

        public T Get(int index)
        {
            T value = array[index];
            return value;
        }

        public void IncreaseCapacity()
        {
            capacity *= 2;
            T[] secondArray = new T[capacity];
            for (int i = 0; i < array.Length; i++)
            {
                secondArray[i] = array[i];
            }
            array = secondArray;
        }
        public int GetSize()
        {
            return size;
        }

        public int GetCapacity()
        {
            return capacity;
        }
    }
}
