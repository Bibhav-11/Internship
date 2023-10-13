using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class CustomQueue
    {
        private int[] queueArray;
        private int maxSize;
        private int front;
        private int rear;
        private int itemCount;

        public CustomQueue(int size)
        {
            maxSize = size;
            queueArray = new int[maxSize];
            front = 0;
            rear = -1;
            itemCount = 0;
        }

        public bool IsEmpty()
        {
            return itemCount == 0;
        }

        public bool IsFull()
        {
            return itemCount == maxSize;
        }

        public int Size()
        {
            return itemCount;
        }

        public void Enqueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue element.");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                queueArray[++rear] = value;
                itemCount++;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue element.");
                return -1;
            }
            else
            {
                int temp = queueArray[front++];
                if (front == maxSize)
                {
                    front = 0;
                }
                itemCount--;
                return temp;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot peek.");
                return -1;
            }
            else
            {
                return queueArray[front];
            }
        }
    }
}
