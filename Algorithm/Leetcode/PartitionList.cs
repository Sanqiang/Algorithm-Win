using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
/*
            var inst = new Leetcode.PartitionList();
            LinkedNode ln = inst.partition(LinkedNode.getInst(),3); 
 */
namespace Algorithm.Leetcode
{
    class PartitionList
    {
        public LinkedNode partition(LinkedNode head, int x)
        {
            LinkedNode lefthead = null, lefttail = null, righthead = null, righttail = null, runner = head;
            while (runner != null)
            {
                LinkedNode next = runner.Next;
                double val = runner.Data;
                if (val >= x)
                {
                    if (righthead == null)
                    {
                        righthead = runner;
                        righttail = runner;
                    }
                    else
                    {
                        runner.Next = righthead;
                        righthead = runner;
                    }
                }
                else
                {
                    if (lefthead == null)
                    {
                        lefthead = runner;
                        lefttail = runner;
                    }
                    else
                    {
                        lefttail.Next = runner;
                        lefttail = runner;
                    }
                }

                runner = next;
            }
            lefttail.Next = righthead;
            righttail.Next = null;
            return lefthead;
        }
    }
}
