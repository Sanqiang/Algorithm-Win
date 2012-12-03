/*
            LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(4);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4;
             Microsoft.Q58.printBackFordLinkedList(ln1);
            Microsoft.Q58.printBackFordLinkedListEx(ln1);
 */
namespace Algorithm.Microsoft
{
    class Q58
    {
        public static LinkedList.LinkedNode printBackFordLinkedList(LinkedList.LinkedNode head)
        {
            if (head == null)
            {
                return head;
            }
            LinkedList.LinkedNode node = printBackFordLinkedList(head.Next);

            System.Console.WriteLine(head.Data);

            return node;
        }

        public static void printBackFordLinkedListEx(LinkedList.LinkedNode head)
        {
            if (head.Next!=null)
            {
                printBackFordLinkedListEx(head.Next);
            }

            System.Console.WriteLine(head.Data);
        }
    }
}
