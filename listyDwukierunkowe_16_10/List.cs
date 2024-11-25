using System;

namespace listyDwukierunkowe_16_10
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public List()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            count++;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            count++;
        }

        public void RemoveFirst()
        {
            if (head == null) return;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
        }

        public void RemoveLast()
        {
            if (tail == null) return;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
        }

        public string ToStringg()
        {
            string result = "";
            Node current = head;
            while (current != tail)
            {
                result += current.data + " ";
                current = current.next;
            }
            result += current.data;
            return result;
        }

        public Node GetNode(int n)
        {
            Node current = head;
            for (int i = 0; i < n; i++) current = current.next;
            return current;
        }

        public int GetData(int n)
        {
            if (n < 0 || n >= count)
            {
                return -1;
            }
            Node current = head;
            for (int i = 0; i < n; i++) current = current.next;
            return current.data;
        }
    }
}
