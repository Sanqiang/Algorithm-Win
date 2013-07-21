using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
using Algorithm.TreeAndGraph;
/*
var inst =  new Leetcode.ConvertSortedListtoBinarySearchTree().sortedListToBST(LinkedNode.getInst()); 
 */
namespace Algorithm.Leetcode
{
    class ConvertSortedListtoBinarySearchTree
    {
        public BinaryTreeNode sortedListToBST(LinkedNode head)
        {
            looper = head;
            return DFS(0,head.getLength());
        }

        private static LinkedNode looper = null;
        private BinaryTreeNode DFS(int s, int e)
        {
            if (looper == null || s > e)
            {
                return null;
            }
            int m = s + (e - s) / 2;

            BinaryTreeNode left = DFS( s, m - 1);
            BinaryTreeNode root = new BinaryTreeNode(looper.Data);
            looper = looper.Next;
            root.LeftNode = left;
            root.RightNode = DFS( m + 1, e);
            return root;
        }
    }
}
