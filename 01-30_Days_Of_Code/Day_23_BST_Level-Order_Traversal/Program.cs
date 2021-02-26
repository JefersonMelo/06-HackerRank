using System;

namespace Day_23_BST_Level_Order_Traversal
{
    class Program
    {
        /*
         * https://www.hackerrank.com/challenges/30-binary-trees/tutorial
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
