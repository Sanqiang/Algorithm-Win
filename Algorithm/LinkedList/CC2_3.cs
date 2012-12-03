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

            LinkedList.CC2_3.deleteNode(ln3);

            LinkedList.LinkedNode ln = ln1;
            while (ln != null)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
 */ 
namespace Algorithm.LinkedList
{
    class CC2_3
    {
        public static void deleteNode(LinkedNode ln)
        {
            if (ln.Next==null || ln ==null)
            {
                return;
            }
            ln.Data = ln.Next.Data;
            ln.Next = ln.Next.Next;
        }
    }
}
