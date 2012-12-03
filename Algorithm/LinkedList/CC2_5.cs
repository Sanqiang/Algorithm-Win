/*
             LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(4);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(5);

            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; ln5.Next = ln4;

            LinkedList.LinkedNode ln = ln1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
            Console.WriteLine();
            Console.WriteLine(LinkedList.CC2_5.findLoopNode(ln1).Data);
 */ 
namespace Algorithm.LinkedList
{
    class CC2_5
    {
        //Math: 1step runs, 2steps, finally they meet at the point at from k step from loop, k is start distance
        public static LinkedNode findLoopNode(LinkedNode head)
        {
            LinkedNode p1 = head;
            LinkedNode p2 = head;
            while (true)
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;
                if (p1 == p2)
                {
                    break;
                }
            }

            if (p1 == null || p2==null)
            {
                return null;
            }

            p1 = head;
            while (true)
            {
                if (p1 == p2)
                {
                    return p1;
                }
                p1 = p1.Next;
                p2 = p2.Next;
            }
        }
    }
}
