using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace making_list
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;
        public Node(int number)
        {
            this.data = number;
        }
    }

    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;
        public void addFirst(int number)
        {
            Node add = new Node(number);
            if(head == null)
            {
                head = tail = add;
            }
            else
            {
                add.next = head;
                head.prev = add;
                head = add;
            }
            count++;
        }

        public void addLast(int number)
        {
            Node add = new Node(number);
            if(tail == null)
            {
                head = tail = add;
            }
            else
            {
                tail.next = add;
                add.prev = tail;
                tail = add;
            }
            count++;
        }

        public void removeFirst()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
        }

        public void removeLast()
        {
            if(tail == null)
            {
                return;
            }
            if(head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
        }

        public override string ToString()
        {
            if(head == null)
            {
                return "";
            }
            Node current = head;
            string result = "";
            while(current != null)
            {
                result += current.data + " ";
                current = current.next;
            }
            return result.Trim();
        }
    }
}
