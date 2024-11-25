using System;

namespace listyDwukierunkowe_16_10
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data)
        {
            next = null;
            prev = null;
            this.data = data;
        }
    }
}
