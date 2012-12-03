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
