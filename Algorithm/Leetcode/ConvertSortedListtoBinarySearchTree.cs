using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    class ConvertSortedListtoBinarySearchTree
    {
        public TreeAndGraph.BinaryTreeNode sortedListToBST(LinkedList.LinkedNode head)
        {

            LinkedList.LinkedNode node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            return null;
        }
    }
}
