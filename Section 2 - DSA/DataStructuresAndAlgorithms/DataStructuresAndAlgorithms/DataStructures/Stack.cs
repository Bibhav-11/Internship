using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class CustomStack
    {
        private int[] stackArray;
        private int maxSize;
        private int top;

        public CustomStack(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full. Cannot push element.");
            }
            else
            {
                stackArray[++top] = value;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot pop element.");
                return -1;
            }
            else
            {
                return stackArray[top--];
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
                return -1;
            }
            else
            {
                return stackArray[top];
            }
        }
    }
}
