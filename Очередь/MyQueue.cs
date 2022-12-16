using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Очередь
{
     public class MyQueue<T>
    {

        public int size = 0;
        private T[] array;
        private int currentIn = 0;
        private int currentOut = 0;

        public MyQueue(int n)
        {
            array = new T[n];
        }

        public bool Enqueue(T value)
        {
            if (IsNoFull())
            {
                if (currentIn >= array.Length)
                {
                    currentIn = 0;
                }
                array[currentIn] = value;
                size++;
                currentIn++;
                return true;
            }
            else return false;

        }

        public bool Dequeue()
        {
            if (!IsEmpty())
            {
                size--;
                array[currentOut] = default(T);
                currentOut++;
                if (currentOut >= array.Length)
                {
                    currentOut = 0;
                }

                return true;
            }
            else return false;
            
        }

        public bool IsNoFull()
        {
            if (size != this.array.Length)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            if (size == 0)
                return true;
            else return false;
        }

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public T Peek()
        {
            return array[currentOut];
        }

        public T[] ToArray()
        {

            int index = currentOut;
            T[] new_array = new T[size];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[index];
                index++;
                if (index == array.Length)
                {
                    index = 0;
                }
            }
            return new_array;

        }

    }
}
