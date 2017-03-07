using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public delegate void ChangesDelegate();
    public delegate void CapacityIncreaseDelegate();
    class DynamicArray<T>
    {
        private int size;
        private int capacity;
        private T[] array; 

        public event ChangesDelegate ElementAddedEvent;
        public event ChangesDelegate ElementRemovedEvent;
        public event ChangesDelegate ElementInsertedEvent;

        public event CapacityIncreaseDelegate CapacityIncreasedEvent;

        public DynamicArray()
        {
            capacity = 1;
            size = 0;
            array = new T[capacity];
            ElementAddedEvent += ElementAdded;
            ElementRemovedEvent += ElementRemoved;
            ElementInsertedEvent += ElementInserted;
            CapacityIncreasedEvent += CapacityIncreased;
            
        }

        public void CapacityIncreased()
        {
            Console.WriteLine("Capacity was increased!");
        }
        public void ElementInserted()
        {
            Console.WriteLine("Element was inserted by index!");
        }
        public void ElementRemoved()
        {
            Console.WriteLine("Element was removed!");
        }
        public void ElementAdded()
        {
            Console.WriteLine("Element was added!");
        }
        public void Remove(int index)
        {
            for (int i = index; i < size; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
            ElementRemovedEvent();
        }

        public void Add(T i)
        {
            if (size == (capacity - 1))
            {
                IncreaseCapacity();
            }
            array[size] = i;
            size++;
            ElementAddedEvent();
        }

        public void Insert(T insert, int index)
        {
            if (size == (capacity - 1))
            {
                IncreaseCapacity();
            }
            for (int i = index; i < size; i++)
            {
                array[i + 1] = array[i];

            }
            array[index] = insert;
            size++;
            ElementInsertedEvent();
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
            CapacityIncreasedEvent();
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