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
            LinkedList.LinkedNode ln = ln1;
            while (ln != null)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
            Console.WriteLine();

            LinkedList.CC2_1.removeDuplicate(ln1);
            ln = ln1;
            while (ln != null)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
 */ 
namespace Algorithm.LinkedList
{
    class CC2_1
    {
        public static void removeDuplicate(LinkedNode head)
        {
            LinkedNode previous = head;
            LinkedNode current = head.Next;
            LinkedNode runner = head;
            while (current != null)
            {
                while (runner != current)
                {
                    if (runner.Data.Equals(current.Data))
                    {
                        //never change link, copy the value
                        double temp = current.Next.Data;
                        current.Data = temp;
                        current.Next = current.Next.Next;
                        break;
                    }
                    runner = runner.Next;
                }

                if (runner == current)
                {
                    previous = current;
                    current = current.Next;
                    runner = head;
                }
            }
        }
    }
}
