using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
/*
            LinkedNode newlist =  new Leetcode.RemoveDuplicatesfromSortedList_II().deleteDuplicates(LinkedNode.getInst()); 
 */
namespace Algorithm.Leetcode
{
    class RemoveDuplicatesfromSortedList_II
    {
        public LinkedNode deleteDuplicates(LinkedNode head)
        {
            LinkedNode prehead = new LinkedNode(-1);
            prehead.Next = head;
            LinkedNode pre = prehead, cur = head, next = head.Next;

            while (cur != null)
            {
                next = cur.Next;
                LinkedNode looper = next;
                bool skip = false;
                while (looper != null && looper.Data.Equals(cur.Data))
                {
                    skip = true;
                    next = looper; 
                    looper = looper.Next;
                }
                if (skip)
                {
                    pre.Next = next.Next;
                    cur = next.Next;
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
