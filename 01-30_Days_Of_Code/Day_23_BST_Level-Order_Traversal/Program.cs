using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_23_BST_Level_Order_Traversal
{
    class Program
    {
        /*
         * https://www.hackerrank.com/challenges/30-binary-trees/tutorial
         * https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1?view=net-5.0
         * https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0
         * https://docs.microsoft.com/pt-br/dotnet/api/system.string.join?view=net-5.0
         */
        static Node node = new Node();

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = node.insert(root, data);
            }
            node.levelOrder(root);

        }
    }
}
