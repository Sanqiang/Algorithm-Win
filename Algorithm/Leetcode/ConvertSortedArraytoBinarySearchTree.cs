using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
             TreeAndGraph.BinaryTreeNode root = null;
            double[] nums = {1,2,3,4,5,6,7,8,9};
            root = new Leetcode.ConvertSortedArraytoBinarySearchTree().sortedArrayToBST(nums, 0, nums.Length - 1);

 */
namespace Algorithm.Leetcode
{
    class ConvertSortedArraytoBinarySearchTree
    {
        public TreeAndGraph.BinaryTreeNode sortedArrayToBST(double[] num, int s , int e)
        {
            if (e < s)
            {
                return null;
            }
            int m = s + (e - s)/2;
            double val = num[m];
            TreeAndGraph.BinaryTreeNode root = new BinaryTreeNode(val);
            root.LeftNode = sortedArrayToBST(num, s, m - 1);
            root.RightNode = sortedArrayToBST(num, m + 1, e);
            return root;
        }
    }
}
