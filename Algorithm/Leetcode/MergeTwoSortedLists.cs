using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
/*
            var head =  new Leetcode.MergeTwoSortedLists().mergeTwoLists(LinkedNode.getInst(), LinkedNode.getInst()); 
 */
namespace Algorithm.Leetcode
{
    class MergeTwoSortedLists
    {
        public LinkedNode mergeTwoLists(LinkedNode l1, LinkedNode l2)
        {
            LinkedNode head = null, output = null;
            while (l1 != null && l2 != null)
            {
                if (l1 == null)
                {
                    if (head == null)
                    {
                        head = l2;
                        output = l2;
                    }
                    else
                    {
                        head.Next = l2;
                        head = l2;
                    } l2 = l2.Next;
                }
                else if (l2 == null)
                {
                    if (head == null)
                    {
                        head = l1; output = l1;
                    }
                    else
                    {
                        head.Next = l1;
                        head = l1;
                    } l1 = l1.Next;
                }
                else
                {
                    if (l1.Data <= l2.Data)
                    {
                        if (head == null)
                        {
                            head = l1; output = l1;
                        }
                        else
                        {
                            head.Next = l1;
                            head = l1;
                        } l1 = l1.Next;
                    }
                    else
                    {
                        if (head == null)
                        {
                            head = l2; output = l2;
                        }
                        else
                        {
                            head.Next = l2;
                            head = l2;
                        } l2 = l2.Next;
                    }

                }
            }
            return output;
        }
    }
}
