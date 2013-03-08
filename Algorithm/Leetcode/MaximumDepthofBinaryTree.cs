using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            BinaryTreeNode root = BinaryTreeNode.getInst();
            var inst = new Leetcode.MaximumDepthofBinaryTree();
            Console.WriteLine(inst.maxDepth(root) + " " + inst.maxDepth2(root)); 
 */
namespace Algorithm.Leetcode
{
    class MaximumDepthofBinaryTree
    {
        public int maxDepth(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(maxDepth(root.LeftNode), maxDepth(root.RightNode)) + 1;
        }

        public int maxDepth2(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(maxDepth2(root.LeftNode), maxDepth2(root.RightNode)) + (int)root.Data;
        }
    }
}
