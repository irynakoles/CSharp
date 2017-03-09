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
        private Node<T> current; // last node

        public int count;  // total number of nodes

        private  Node<T> node;

        public MyLinkedList()
        {
            head = new Node<T>();
            current = head;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>() { Value = value };
            newNode.Next = head.Next;
            head.Next = newNode;
            count++;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            current.Next = newNode;
            current = newNode;
            count++;
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

        public void RemoveNode(Node<T> node,Node<T> prevNode)
        {
            prevNode.Next = node.Next;
        }

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
