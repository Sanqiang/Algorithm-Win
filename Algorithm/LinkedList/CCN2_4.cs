/*
             LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(9);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(8);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(7);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(5);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln6 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln7 = new LinkedList.LinkedNode(1);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; ln5.Next = ln6; ln6.Next = ln7;
            LinkedList.LinkedNode head = LinkedList.CCN2_4.partitionLinkedlistEx(ln1, 4);
            LinkedList.LinkedNode ln = head;
            while (ln!=null)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
 */ 
namespace Algorithm.LinkedList
{
    public class CCN2_4
    {
        public static LinkedNode partitionLinkedlist(LinkedNode head, double x)
        {
            if (head == null)
            {
                return null;
            }
            LinkedNode PivotSmallStart = null, PivotSmallEnd = null, PivotLargeStart = null, PivotLargeEnd = null;
            LinkedNode loop = head;
            while (loop != null)
            {
                //note: you cannot interate from start
                if (loop.Data <= x)
                {
                    if (PivotSmallStart == null)
                    {
                        PivotSmallEnd = loop;
                        PivotSmallStart = PivotSmallEnd;
                    }
                    else
                    {
                        PivotSmallEnd.Next = loop;
                        PivotSmallEnd = loop;
                    }
                }
                else
                {
                    if (PivotLargeStart == null)
                    {
                        PivotLargeEnd = loop;
                        PivotLargeStart = PivotLargeEnd;
                    }
                    else
                    {
                        PivotLargeEnd.Next = loop;
                        PivotLargeEnd = loop;
                    }
                }
                loop = loop.Next;
            }

            PivotSmallEnd.Next = PivotLargeStart;
            PivotLargeEnd.Next = null;
            return PivotSmallStart;
        }

        public static LinkedNode partitionLinkedlistEx(LinkedNode head, double x)
        {
            if (head == null)
            {
                return null;
            }
            LinkedNode PivotSmall = null, PivotLarge = null;
            LinkedNode loop = head, next =head.Next;
            while (next != null)
            {
                next = loop.Next;
                
                if (loop.Data <= x)
                {
                    if (PivotSmall == null)
                    {
                        loop.Next = null;
                        PivotSmall = loop;
                    }
                    else
                    {
                        loop.Next = PivotSmall;
                        PivotSmall = loop;
                    }
                }
                else
                {
                    if (PivotLarge == null)
                    {
                        loop.Next = null;
                        PivotLarge = loop;
                    }
                    else
                    {
                        loop.Next = PivotLarge;
                        PivotLarge = loop;
                    }
                }
                loop = next;
            }

            loop = PivotSmall;
            for (; loop.Next != null; loop = loop.Next) ;
            loop.Next = PivotLarge;

            return PivotSmall;
        }
    }
}
