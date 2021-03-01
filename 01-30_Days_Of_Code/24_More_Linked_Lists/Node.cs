using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24_More_Linked_Lists
{
    class Node
    {
        public int data;
        public Node next;

        public Node()
        {
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public Node removeDuplicates(Node head)
        {
            //Write your code here
            for (Node node = head; node != null; node = node.next)
            {
                while (node.next != null && node.data == node.next.data)
                {
                    node.next = node.next.next;
                }
            }
            return head;
        }

        public Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
