/*
             LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(4);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(5);
            LinkedList.LinkedNode ln6 = new LinkedList.LinkedNode(6);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; ln5.Next = ln6;
            Console.WriteLine(Microsoft.Q13.findNthBackWard(ln1,2).Data);
 */ 
namespace Algorithm.Microsoft
{
    class Q13
    {
        public static LinkedList.LinkedNode findNthBackWard(LinkedList.LinkedNode head, int n)
        {
            LinkedList.LinkedNode ToEnd = head;
            LinkedList.LinkedNode ToTarget = head;

            while (n-- != 0)
            {
                if (ToEnd == null)
                {
                    return null;
                }
                ToEnd = ToEnd.Next;
            }

            while (true)
            {
                if (ToEnd.Next == null)
                {
                    return ToTarget;
                }
                ToTarget = ToTarget.Next;
                ToEnd = ToEnd.Next;
            }
        }

        /*
            LinkedNode l1 = new LinkedNode(1);
            LinkedNode l2 = new LinkedNode(2);
            LinkedNode l3 = new LinkedNode(3);
            LinkedNode l4 = new LinkedNode(4);
            LinkedNode l5 = new LinkedNode(5);
            l1.Next = l2; l2.Next = l3; l3.Next = l4; l4.Next = l5;
            Console.WriteLine(getLastNthLinklistNode(l1, 2).Data);
        */
        static int count = 0;
        public static LinkedList.LinkedNode getLastNthLinklistNode(LinkedList.LinkedNode node, int n)
        {
            if (node == null)
            {
                return node;
            }

            LinkedList.LinkedNode result = getLastNthLinklistNode(node.Next, n);

            if (count++ == n)
            {
                return node;
            }

            return result;
        }
    }
}
