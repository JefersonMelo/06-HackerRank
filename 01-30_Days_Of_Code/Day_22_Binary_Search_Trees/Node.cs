using System;

namespace Day_22_Binary_Search_Trees
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

        public int getHeight(Node root)
        {
            //Write your code here
            if (root == null)
            {
                return -1;
            }
            else
            {
                int esquerda = getHeight(root.left);
                int direita = getHeight(root.right);
                return Math.Max(esquerda, direita) + 1;
            }

        }

    }

}
