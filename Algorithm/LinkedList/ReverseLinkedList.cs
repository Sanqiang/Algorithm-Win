/*
            LinkedList.LinkedNode n1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode n2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode n3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode n4 = new LinkedList.LinkedNode(4);
            n1.Next = n2; n2.Next = n3; n3.Next = n4;

            Console.WriteLine(n2.Next.Data);
            Console.WriteLine(n3.Next.Data);
            //LinkedList.ReverseLinkedList.reverse(n1);
            LinkedList.ReverseLinkedList.reverseRecursive(n1);
            Console.WriteLine(n2.Next.Data);
            Console.WriteLine(n3.Next.Data);
 */
namespace Algorithm.LinkedList
{

    public class ReverseLinkedList
    {
        public static void reverse(LinkedNode start_node)
        {
            LinkedNode current_node = start_node;
            LinkedNode last_node = null;
            LinkedNode next_node = start_node.Next;
            while (next_node != null)
            {
                current_node.Next = last_node;
                last_node = current_node;
                current_node = next_node;
                next_node = next_node.Next;
            }
        }

        public static void reverseRecursive(LinkedNode current_node, LinkedNode next_node = null, LinkedNode last_node = null)
        {
            if (next_node == null)
            {
                if (last_node == null)
                {
                    next_node = current_node.Next;
                }
                else
                {
                    return;
                }
            }
            current_node.Next = last_node;
            reverseRecursive(next_node, next_node.Next, current_node);
        }
    }
}
