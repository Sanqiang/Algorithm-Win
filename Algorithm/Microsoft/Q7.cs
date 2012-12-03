/*
            LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(4);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(5);
            LinkedList.LinkedNode ln6 = new LinkedList.LinkedNode(6);
            LinkedList.LinkedNode ln7 = new LinkedList.LinkedNode(7);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; //ln5.Next = ln3;
            ln6.Next = ln7; ln7.Next = ln4;

            Console.WriteLine(Microsoft.Q7.getCrossForTwoLinkedList(ln1, ln6) != null ? Microsoft.Q7.getCrossForTwoLinkedList(ln1, ln6).Data.ToString() : "Not Found");
            //cannot handle circular
            Console.WriteLine(Microsoft.Q7.getCrossForTwoLinkedListEx(ln1, ln6) != null ? Microsoft.Q7.getCrossForTwoLinkedList(ln1, ln6).Data.ToString() : "Not Found");
 */
//just verify the tail if no circular linked list.
//you can run 1step vs 2step to verify whether it is circular linked list. 
//first check whether two are circular, both not, run getCrossForTwoLinkedListEx, both are . get loop entry, and both next by 1
namespace Algorithm.Microsoft
{
    class Q7
    {
        //By state
        public static LinkedList.LinkedNode getCrossForTwoLinkedList(LinkedList.LinkedNode ln1, LinkedList.LinkedNode ln2)
        {
            LinkedList.LinkedNode ln = ln1;
            while (ln != null && ln.state!=1)
            {
                ln.state = 1;
                ln = ln.Next;
            }

            ln = ln2;
            while (ln!=null)
            {
                if (ln.state == 1)
                {
                    return ln;
                }
                ln = ln.Next;
            }
            return null;
        }

        public static LinkedList.LinkedNode getCrossForTwoLinkedListEx(LinkedList.LinkedNode ln1, LinkedList.LinkedNode ln2)
        {
            LinkedList.LinkedNode loop_ln1 = ln1;
            int ln1_length = 0;
            while (loop_ln1 != null)
            {
                ln1_length++;
                loop_ln1 = loop_ln1.Next;
            }
            LinkedList.LinkedNode loop_ln2 = ln2;
            int ln2_length = 0;
            while (loop_ln2 != null)
            {
                ln2_length++;
                loop_ln2 = loop_ln2.Next;
            }
            if (loop_ln1 == loop_ln2)
            {
                LinkedList.LinkedNode longer_list = ln1_length > ln2_length ? ln1 : ln2;
                LinkedList.LinkedNode smaller_list = ln1_length < ln2_length ? ln1 : ln2;
                for (int i = 0; i < System.Math.Abs(ln1_length-ln2_length); i++)
                {
                    longer_list = longer_list.Next;
                }
                while (true)
                {
                    if (longer_list == smaller_list)
                    {
                        return longer_list;
                    }
                    longer_list = longer_list.Next;
                    smaller_list = smaller_list.Next;
                }

            }
            return null;
        } 
    }
}
