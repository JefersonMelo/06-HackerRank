namespace Day_15_Linked_List
{
    class Node
    {
        public int data;
        public Node next;

        public Node() { }

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public Node insert(Node head, int data)
        {
            //Complete this method
            Node no = new Node(data);
            Node temp = head;
            if (head == null)
            {
                head = no;
                return head;
            }
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = no;
            return head;
        }
    }
}
