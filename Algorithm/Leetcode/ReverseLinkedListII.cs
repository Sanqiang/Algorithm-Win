using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;

namespace Algorithm.Leetcode
{
    class ReverseLinkedListII
    {
        public LinkedList.LinkedNode reverseBetween(LinkedList.LinkedNode head, int m, int n)
        {
            LinkedList.LinkedNode pre_hard = new LinkedNode(-1);
            pre_hard.Next = head;
            LinkedList.LinkedNode pre = pre_hard, cur = head, next = head.Next, lefts = null,lefte = null, rights = null,righte;
            int count = m - 1;
            while (count -- > 0)
            {
                next = cur.Next;
                pre = cur;
                cur = next;
            }
            count = n - m+1;
            while (count-- > 0)
            {
                next = cur.Next;
                if (lefte == null)
                {
                    lefte = cur;
                    lefts = pre;
                }
                else
                {
                    cur.Next = pre;
                }
                pre = cur;
                cur = next;
            }
            rights = pre;
            righte = cur;
            lefts.Next = rights;
            lefte.Next = righte;
            return pre_hard.Next;
        }
    }
}
