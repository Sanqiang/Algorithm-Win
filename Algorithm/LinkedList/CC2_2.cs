/*
            LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(6);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(4);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(4);
            LinkedList.LinkedNode ln6 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln7 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln8 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln9 = new LinkedList.LinkedNode(9);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; ln5.Next = ln6; ln6.Next = ln7; ln7.Next = ln8; ln8.Next = ln9;
            LinkedList.LinkedNode ln = LinkedList.CC2_2.getNthToLastRecursive(ln1, 4);
            Console.WriteLine(ln.Data);

            LinkedList.CC2_2.getNthToLastRecursiveEx2(ln1, 4);
            Console.WriteLine(LinkedList.CC2_2.result.Data);

            Console.WriteLine(LinkedList.CC2_2.getNthToLastIterate(ln1, 4).Data);
 */

namespace Algorithm.LinkedList
{
    class CC2_2
    {
        public static LinkedNode getNthToLastRecursive(LinkedNode head, int n)
        {
            if (head == null)
            {
                count = 0;
                return null;
            }

            LinkedNode node = getNthToLastRecursive(head.Next, n);
            count++;
            if (count == n)
            {
                return head;
            }

            return node;

        }
        static int count = new System.Random().Next();


        public static LinkedList.LinkedNode result = null;
        public static int getNthToLastRecursiveEx2(LinkedNode head, int n)
        {
            if (head == null)
            {
                return 0;
            }
            int i = getNthToLastRecursiveEx2(head.Next, n) + 1;

            if (i == n)
            {
                result = head;
            }

            return i;
        }

        public static LinkedNode getNthToLastIterate(LinkedNode head, int n)
        {
            LinkedNode ToTarget = head;
            LinkedNode ToEnd = head;
            for (int i = 0; i < n; i++)
            {
                ToEnd = ToEnd.Next;
            }
            while (ToEnd!=null)
            {
                ToTarget = ToTarget.Next;
                ToEnd = ToEnd.Next;
            }
            return ToTarget;
        }

    }
}
