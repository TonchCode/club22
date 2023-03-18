using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheLinkedLists
{
    internal class MyLinkedList
    {
        private class LLElement
        {
            public int value;
            public LLElement next;
        }

        LLElement first;
        int count;

        public MyLinkedList()
        {
            count = 0;
        }

        public void Print()
        {
            LLElement p = first;
            while (p != null)
            {
                Console.Write(p.value + ", ");
                p = p.next;
            }
            Console.WriteLine();
        }

        // AddFirst() for homework
        public void AddLast(int item)
        {
            if (count == 0)
            {
                first = new LLElement();
                first.value = item;
                count++;
                return;
            }

            if (count == 1)
            {
                first.next = new LLElement();
                first.next.value = item;
                count++;
                return;
            }

            LLElement p = first;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = new LLElement();
            p.next.value = item;
            count++;
        }

        public void AddFirst(int item)
        {
            if (count == 0)
            {
                first = new LLElement();
                first.value = item;
                count++;
                return;
            }

            LLElement temp = new LLElement();
            temp.value = item;
            temp.next = first;
            first = temp;
            count++;
        }

        // RemoveAt(int position) RemoveFirst() RemoveLast() for homework
        public bool RemoveFirstFoundValue(int value) // returns true on delete, false if there was no such element
        {
            if (first == null)
            {
                return false;
            }

            if (count == 1 && first.value == value)
            {
                first = null;
                count--;
                return true;
            }
            else if (count == 1)
            {
                return false;
            }

            LLElement p = first;

            if (p.value == value)
            {
                first = first.next;
                count--;
                return true;
            }

            while (p.next != null)
            {
                if (p.next.value == value)
                {
                    p.next = p.next.next;
                    count--;
                    return true;
                }
                p = p.next;
            }

            return false;
        }

        public bool RemoveAt(int pos)
        {
            if (pos > count)
            {
                return false;
            }

            if (count == 0)
            {
                return false;
            }

            if (count == 1)
            {
                first = null;
                count--;
                return true;
            }

            if (pos == 1)
            {
                first = first.next;
                count--;
            }

            LLElement temp = first;

            int i = 1;
            while (i < pos-1) // -1 because of 0 index
            {
                temp = temp.next;
                i++;
            }
            temp.next = temp.next.next;
            count--;
            return true;
        }

        public bool RemoveFirst()
        {
            if (count == 0)
            {
                return false;
            }

            if (first.next == null)
            {
                first = null;
                count--;
                return true;
            }

            first = first.next;
            count--;

            return true;
        }

        public bool RemoveLast()
        {
            if (count == 0)
            {
                return false;
            }

            if (count == 1)
            {
                first = null;
                count--;
                return true;
            }

            LLElement temp = first;

            int i = 1;
            while (i < count -1)
            {
                temp = temp.next;
                i++;
            }
            temp.next = null;
            count--;
            return true;
        }

        public int ElementAt(int position) // PositionOfFirstFoundValue(int value)
        {
            LLElement p = first;

            for (int i = 1; i < position; i++)
            {
                p = p.next;
            }

            return p.value;
        }
    }
}
