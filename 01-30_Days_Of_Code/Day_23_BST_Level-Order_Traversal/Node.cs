using System;
using System.Collections.Generic;
using System.Text;

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
