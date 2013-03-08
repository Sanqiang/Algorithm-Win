namespace Algorithm.LinkedList
{
    public class LinkedNode
    {
        public double Data;
        public LinkedNode Next;
        public int state = 0; //optional
        public LinkedNode() { }
        public LinkedNode(double data) { this.Data = data; }
        public int getLength()
        {
            int length = 0;
            LinkedNode loop = this;
            while (loop != null)
            {
                length++;
                loop = loop.Next;
            }
            return length;
        }

        public static LinkedNode getInst()
        {
            LinkedNode l1 = new LinkedNode(1);
            LinkedNode l2 = new LinkedNode(2);
            LinkedNode l3 = new LinkedNode(3);
            LinkedNode l4 = new LinkedNode(4);
            LinkedNode l5 = new LinkedNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            return l1;
        }
    }

    public class DoubleLinkedNode
    {
        public double Data;
        public DoubleLinkedNode Last;
        public DoubleLinkedNode Next;
        public int state = 0; //optional
        public DoubleLinkedNode() { }
        public DoubleLinkedNode(double data) { this.Data = data; }
    }
}
