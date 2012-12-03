/*
             LinkedList.LinkedNode ln11 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln12 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln13 = new LinkedList.LinkedNode(3);
            ln11.Next = ln12; ln12.Next = ln13;

            LinkedList.LinkedNode ln21 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln22 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln23 = new LinkedList.LinkedNode(5);
            ln21.Next = ln22; ln22.Next = ln23;

            Microsoft.Q42.printSeriesLinkedList(ln11, ln21);
 */ 
namespace Algorithm.Microsoft
{
    public class Q42
    {
        public static void printSeriesLinkedList(LinkedList.LinkedNode ln1, LinkedList.LinkedNode ln2)
        {
            LinkedList.LinkedNode ln_loop1 = ln1;
            LinkedList.LinkedNode ln_loop2 = ln2;

            while (ln_loop1 != null && ln_loop2 != null)
            {
                if (ln_loop1.Data < ln_loop2.Data)
                {
                    System.Console.WriteLine(ln_loop1.Data);
                    ln_loop1 = ln_loop1.Next;
                }
                else if (ln_loop1.Data == ln_loop2.Data)
                {
                    System.Console.WriteLine(ln_loop1.Data);
                    ln_loop1 = ln_loop1.Next;
                    ln_loop2 = ln_loop2.Next;
                }
                else
                {
                    System.Console.WriteLine(ln_loop2.Data);
                    ln_loop2 = ln_loop2.Next;
                }
            }

            while (ln_loop1 != null)
            {
                System.Console.WriteLine(ln_loop1.Data);
                ln_loop1 = ln_loop1.Next;
            }

            while (ln_loop2 != null)
            {
                System.Console.WriteLine(ln_loop2.Data);
                ln_loop2 = ln_loop2.Next;
            }

        }
    }
}
