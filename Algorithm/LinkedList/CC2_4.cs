/*
            LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(9);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(2);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4;
            LinkedList.LinkedNode lo1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode lo2 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode lo3 = new LinkedList.LinkedNode(9);
            lo1.Next = lo2; lo2.Next = lo3;

            //LinkedList.LinkedNode ln =  LinkedList.CC2_4.addition(ln1, lo1);
            //LinkedList.LinkedNode ln = LinkedList.CC2_4.addtionRecursive(ln1, lo1);
            LinkedList.LinkedNode ln = LinkedList.CC2_4.addLists(ln1, lo1,0);
            while (ln != null)
            {
                Console.WriteLine(ln.Data);
                ln = ln.Next;
            }
 */
namespace Algorithm.LinkedList
{
    class CC2_4
    {
        public static LinkedNode addition(LinkedNode ln1, LinkedNode ln2)
        {
            double loop = 0;
            LinkedNode head = null, end = null;
            while (ln1 != null || ln2 != null)
            {

                double data1 = 0, data2 = 0;
                if (ln1 == null)
                {
                    data1 = 0;
                }
                else
                {
                    data1 = ln1.Data;
                    ln1 = ln1.Next;
                }
                if (ln2 == null)
                {
                    data2 = 0;
                }
                else
                {
                    data2 = ln2.Data;
                    ln2 = ln2.Next;
                }
                double data = (data1 + data2 + loop) % 10;
                loop = (int)(data1 + data2 + loop) / 10;


                if (head == null)
                {
                    head = new LinkedNode(data);
                    end = head;
                }
                else
                {
                    LinkedNode ln = new LinkedNode(data);
                    end.Next = ln;
                    end = ln;
                }
            }
            return head;
        }



        public static LinkedNode addtionRecursive(LinkedNode ln1, LinkedNode ln2, int loop = 0)
        {
            LinkedNode ln = null;
            double data1, data2;
            if (ln1 == null && ln2 == null && loop == 0)
            {
                return ln;
            }
            if (ln1 == null)
            {
                data1 = 0;
            }
            else
            {
                data1 = ln1.Data;
            }
            if (ln2 == null)
            {
                data2 = 0;
            }
            else
            {
                data2 = ln2.Data;
            }
            double data = (data1 + data2 + loop) % 10;
            loop = (int)(data1 + data2 + loop) / 10;
            ln = new LinkedNode(data);

            LinkedNode next = addtionRecursive(ln1 != null ? ln1.Next : null, ln2 != null ? ln2.Next : null, loop);
            ln.Next = next;
            return ln;
        }


        //Sample
        public static LinkedNode addLists(LinkedNode l1, LinkedNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

            LinkedNode result = new LinkedNode(carry);

            double value = carry;
            if (l1 != null)
            {
                value += l1.Data;
            }
            if (l2 != null)
            {
                value += l2.Data;
            }
            result.Data = value % 10;
            if (l1 != null || l2 != null || value >= 10)
            {
                LinkedNode more = addLists(
                    l1 == null ? null : l1.Next,
                    l2 == null ? null : l2.Next,
                    value >= 10 ? 1 : 0
                    );
                result.Next = more;
            }
            return result;
        }
    }
}
