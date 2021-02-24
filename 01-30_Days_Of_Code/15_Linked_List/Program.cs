using System;

namespace Day_15_Linked_List
{
    /*
     https://hackerrankweb.wordpress.com/2016/11/30/day-15-linked-list/
     */
    class Program
    {
        static Node no = new Node();

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = no.insert(head, data);
            }
            display(head);
        }
    }
}