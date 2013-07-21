using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
/*
 LinkedNode newlist = new Leetcode.RemoveDuplicatesfromSortedList().deleteDuplicates(LinkedNode.getInst());  
 */
namespace Algorithm.Leetcode
{
    class RemoveDuplicatesfromSortedList
    {
        public LinkedNode deleteDuplicates(LinkedNode head)
        {
            LinkedNode prehead = new LinkedNode(-1);
            prehead.Next = head;
            LinkedNode pre = prehead, cur = head, next = head.Next;

            while (cur != null)
            {
                next = cur.Next;

                LinkedNode looper = cur.Next;
                bool skip = false;
                while (looper != null && looper.Data.Equals(cur.Data))
                {
                    next = looper;
                    skip = true;
                    looper = looper.Next;
                }
                if (skip)
                {
                    cur.Next = next.Next;
                    pre = cur;
                    cur = next;
                }
                else
                {
                    pre = cur;
                    cur = next;
                }
            }
            return prehead.Next;
        }
    }
}
