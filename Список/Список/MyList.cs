using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Список
{
    internal class MyList<T>
    {
        int size = 0;
        ListNode<T> first;
        ListNode<T> last;

        public MyList()
        {
            first = null;
            last = null;
            size = 0;
        }

        public void Append(T value)
        {
            ListNode<T> node = new ListNode<T>(value);

            if (first == null)
                first = node;
            else
            {
                last.Next = node;
                node.Prev = last;
            }
            last = node;
            size++;
        }

        public void Prepend(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            ListNode<T> temp = first;
            node.Next = temp;
            first = node;
            if (size == 0)
                last = first;
            else
                temp.Prev = node;
            size++;
        }

        public void Insert(T value, int index)
        {
            if (index == size)
            {
                Append(value);
                return;
            }
            if (size == 0 || index < 0 || index > size)
            {
                throw new Exception("Неверный индекс");
            }
            int d = 0;
            ListNode<T> tmp = first;
            while (d != size)
            {
                
                if (d == index)
                {
                    if (index == 0)
                    {
                        Prepend(value);
                        return;
                    }
                    else
                    {
                        ListNode<T> node = new ListNode<T>(value);
                        node.Next = tmp;
                        tmp.Prev.Next = node;
                        node.Prev = tmp.Prev;
                        tmp.Prev = node;
                    }
                    

                    break;
                }
                tmp = tmp.Next;
                d++;
            }
            size++;
        }

        public T Find(T value)
        {
            ListNode<T> tmp = first;

            while (tmp != null)
            {
                if (tmp.Value.Equals(value))
                {
                    return tmp.Value;
                }
                tmp = tmp.Next;
            }
            throw new Exception("Данного числа нет в списке ");
        }
        public void Remove(T value)
        {
            if (size == 0)
            {
                throw new Exception("Лист пуст");
            }
            ListNode<T> current = first;

            while (current != null)  
            {
                if (current.Value.Equals(value))
                {
                    break;
                }
                current = current.Next;
            }
            if (current == null)
            {
                throw new Exception("Нет элемента");
            }
            if (current != null) 
            {

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else            
                {

                    last = current.Prev;
                }


                if (current.Prev != null) 
                {
                    current.Prev.Next = current.Next;
                }
                else                     
                {

                    first = current.Next;
                }
                size--;
            }
        }
        public T At(int index)
        {
            if (index < 0 || index > size)
            {
                throw new Exception("Неверный индекс");
            }
            int q = 0;
            ListNode<T> f = first;

            while (q != index)
            {
                f = f.Next;
                q++;
            }
            return f.Value;
        }
        public T RemoveAt(int value)
        {
            if (size == 0)
            {
                throw new Exception("Лист пуст");
            }
            if (value < 0 || value > size - 1 || first == null)
            {
                throw new Exception("Неверный индекс");
            }
            int d = 0;
            ListNode<T> tmp = first;

            while (d != value)
            {
                if (tmp.Next == null)
                {
                    return default(T);
                }
                else
                {
                    tmp = tmp.Next;
                    d++;
                }
            }

            if (tmp != null) 
            {

                if (tmp.Next != null)
                {
                    tmp.Next.Prev = tmp.Prev;
                }
                else            
                {

                    last = tmp.Prev;
                }


                if (tmp.Prev != null) 
                {
                    tmp.Prev.Next = tmp.Next;
                }
                else                     
                {

                    first = tmp.Next;
                }

            }
            size--;
            return tmp.Value;
            
        }
        public string ToArray()
        {
            if (size == 0)
            {
                throw new Exception("лист пуст");
            }
            T[] array = new T[size];
            ListNode<T> b = first;
            array[0] = first.Value;
            for (int i = 1; i < size; i++)
            {
                if (b.Next == null)
                {
                    break;
                }
                b = b.Next;
                array[i] = b.Value;
            }

            string c = "";
            for (int i = 0; i < array.Length; i++)
            {
                c = c + " " + $"{array[i]}" + " ";
            }
            return c;
        }
        public int Count
        {
            get
            {
                return size;
            }
        }
    }
}

