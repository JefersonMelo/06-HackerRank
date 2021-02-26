using System;

namespace Day_22_Binary_Search_Trees
{
    class Program
    {
        /*https://www.hackerrank.com/challenges/30-binary-search-trees/tutorial
          https://hackerrankweb.wordpress.com/2016/12/07/day-22-binary-search-trees/
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
            int height = node.getHeight(root);
            Console.WriteLine(height);

        }
    }
}
