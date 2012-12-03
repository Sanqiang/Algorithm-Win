namespace Algorithm.StackAndQueue
{
    public class StackNode
    {
        public double Data;
        public StackNode Previous;
        public StackNode() { }
        public StackNode(double data) { this.Data = data; }
    }

    /*
                 StackAndQueue.Stack s = new StackAndQueue.Stack();
            s.push(1); s.push(2); s.push(3);
            Console.WriteLine(s.pop() +" "+ s.pop() +" "+ s.pop()+" "+s.getSize());
     */
    public class Stack
    {
        public StackNode head;
        int size = 0;
        public void push(double val)
        {
            StackNode sn = new StackNode(val);
            sn.Previous = head;
            head = sn;
            size++;
        }

        public double pop()
        {
            if (head == null)
            {
                return -1;
            }
            double val = head.Data;
            head = head.Previous;
            size--;
            return val;
        }

        public double peek()
        {
            if (head == null)
            {
                return -1;
            }
            return head.Data;
        }

        public int getSize()
        {
            return size;
        }

        public double popBottom()
        {
            StackNode sn = head;
            while (sn.Previous != null)
            {
                sn = sn.Previous;
            }
            double val = sn.Data;
            sn = null; size--;
            return val;
        }

        public string toString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            StackNode sn = head;
            while (sn != null)
            {
                sb.Append(sn.Data).Append(" ");
                sn = sn.Previous;
            }
            return sb.ToString();
        }
    }

    /*
                 StackAndQueue.Queue q = new StackAndQueue.Queue();
            q.enqueue(1); q.enqueue(2); q.enqueue(3);
            Console.WriteLine(q.dequeue() + " " + q.peek() + " " + q.dequeue() + " " + q.dequeue());
     */
    public class Queue
    {
        LinkedList.LinkedNode head = null;
        LinkedList.LinkedNode tail = null;
        public void enqueue(double val)
        {
            if (head == null)
            {
                head = new LinkedList.LinkedNode(val);
                tail = head;
                return;
            }
            LinkedList.LinkedNode ln = new LinkedList.LinkedNode(val);
            ln.Next = head;
            head = ln;
        }

        public double dequeue()
        {
            double val = tail.Data;

            LinkedList.LinkedNode ln = head;
            while (ln.Next != null && ln.Next.Next != null)
            {
                ln = ln.Next;
            }
            ln.Next = null;
            tail = ln;
            return val;
        }

        public double peek()
        {
            return tail.Data;
        }

    }
}
