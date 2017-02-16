﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Stack
    {
        public int size;
        public int[] stack;
        public int top;

        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = 0;
        }
        //Add Element to stack
        public void Push(int i)
        {
            if (!IsFull())
            {
                Console.WriteLine("Push element: {0}", i);
                stack[top] = i;
                top++;
            }
            else
            {
                Console.WriteLine("Stack is Full!");
            }
        }
        //Remove element frm stack
        public int Pop()
        {   
            if(!IsEmpty())
            {
                Console.WriteLine("Pop element: {0}", top);
                return stack[top--];
            }
            else
            {
                Console.WriteLine("Stack is Empty!");
                return 0;
            }
        }
        public int Peek()
        {
            return stack[top];
        }
        // check if stack empty
        public bool IsEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check if stack i
        public bool IsFull()
        {
            if (top == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
                Console.WriteLine("Stack: ");
                for(int i=0; i <size; i++)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.ReadKey();
            }
        }
        
    }

