using System;
using System.Collections.Generic;

namespace Day_23_BST_Level_Order_Traversal
{
    class Node
    {
        public Node left, right;
        public int data;

        public Node() { }

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
        public void LevelOrder(Node root)
        {
            //Write your code here
            List<Node> node = new List<Node>();
            List<string> nodeString = new List<string>();
            node.Add(root);

            while (node.Count > 0)
            {
                if (node[0].left != null)
                {
                    node.Add(node[0].left);
                }
                if (node[0].right != null)
                {
                    node.Add(node[0].right);
                }
                nodeString.Add((node[0].data).ToString());
                node.RemoveAt(0);
            }

            Console.WriteLine(string.Join(" ", nodeString.ToArray()));
        }

        public Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
