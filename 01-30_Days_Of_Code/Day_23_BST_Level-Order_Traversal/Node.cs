using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public void levelOrder(Node root)
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

        public Node insert(Node root, int data)
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
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
