using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class MyLinkedList<T> where T : IComparable
    {
        private Node<T> head; // first node
        private Node<T> tail; // last node

        public int count;  // total number of nodes

        public MyLinkedList()
        {
            head = new Node<T>();
            tail = head;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>() { Value = value };
            newNode.Next = head.Next;
            head.Next = newNode;
            count++;
        }


        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            tail.Next = newNode;
            tail = newNode;
            count++;
        }

        public void AddBefore(int index, T value)
        {
               if (index >= count)
               {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
               }
               else 
               {
                    int currentIndex = 0;
                    Node<T> currNode = this.head;
                    Node<T> prevNode = null;

                    //Find Index
                    while(currentIndex < index)
                    {
                        prevNode = currNode;
                        currNode = currNode.Next;
                        currentIndex++;
                    }

                Node<T> newNode = new Node<T>();
                newNode.Value = value;
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
                
                count++;

            }
        }

        public void AddAfter(int index, T value)
        {
            if(index>= count)
            {
                throw new IndexOutOfRangeException("Invalid index : " + index);
            }
            else 
            {
                int currentIndex = 0;
                Node<T> currNode = this.head;
                Node<T> prevNode = null;

                //Find Index
                while (currentIndex <= index)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                    currentIndex++;
                }

                //Create new Node 
                Node<T> newNode = new Node<T>();
                newNode.Value = value;
                newNode.Next = prevNode.Next.Next;
                prevNode.Next.Next = newNode;
               

                count++;
            }
        }
       
        public void DeleteFirst()
        {
            if (count > 0)
            {
                head.Next = head.Next.Next;
                count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list!");
            }
        }

        public void DeleteLast()
        {
            Node<T> previous = null;
            Node<T> current = head;

            while (current!= null)
            {
                if(current.Next ==null)
                {
                    tail = previous;
                    tail.Next = null;
                }
                previous = current;
                current = current.Next;
            }
            count--;
        }

        public void DeleteByValue(T value)
        {
            Node<T> current = head;

            while (current.Next != null)
            {
                if (current.Next.Value.CompareTo(value) == 0)
                {
                    current.Next = current.Next.Next;
                    break;
                }
                else
                {
                    current = current.Next;
                }

            }
        }

        //Removes all nodes from List
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
            Console.WriteLine("Linked list is empty!");
        }

        //public void RemoveNode(Node<T> node,Node<T> prevNode)
        //{
        //    prevNode.Next = node.Next;
        //}

        //public void ConvertTo(T[] array, int arrayindex )
        //{
        //    Node<T> current = head;
        //    if (count == 0) return;

        //    while(current != null )
        //    {
        //        array[arrayindex] = current.Value;
        //        current = current.Next;
        //        arrayindex++;
        //    }
            
        //}

        //public void PrintArray(T[] array)
        //{
        //    for (int i =0; i<array.Length; i++)
        //    {
        //        Console.WriteLine("Array: ", array[i]);
        //    }
          
        //}

        public void Print()
        {
            Console.Write("Head ->");
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
                Console.Write(current.Value);
                Console.Write("->");
            }
            Console.Write("Null");
        }
    }
}
