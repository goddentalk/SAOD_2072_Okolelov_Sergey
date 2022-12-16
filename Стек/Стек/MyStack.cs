using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Стек
{
    public class MyStack<T>
    {
        public int size = 0;
        private T[] array;
       
         public MyStack(int n)
        {
            array = new T[n];
        }

        public bool Push(T value)
        {
            if (IsNoFull())
            {
                array[size] = value;
                size++;
                return true;
            }
            else return false;

        }
        public T Pop()
        {
            size--;

            return array[size];


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

        public T Top()
        {
            return array[size-1];
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

        public T[] ToArray()
        {
            T[] new_array = new T[size];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            }
            return new_array;
        }
    }
}
