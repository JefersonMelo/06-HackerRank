using System;

namespace Day_24_More_Linked_Lists
{
    class Program
    {
        /*
         * https://www.hackerrank.com/challenges/30-linked-list-deletion/problem
         * https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0
         * 
         */
        static Node node = new Node();
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = node.insert(head, data);
            }
            head = node.removeDuplicates(head);
            node.display(head);
        }
    }
}
