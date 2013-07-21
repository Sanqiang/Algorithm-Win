using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    class BalancedBinaryTree
    {
        public bool isBalanced(TreeAndGraph.BinaryTreeNode root)
        {
            int height = 0;
            return DFS(root) != -1;
        }

        int DFS(TreeAndGraph.BinaryTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int l =DFS(node.LeftNode);
            if (l == -1)
            {
                return -1;
            }
            int r =DFS(node.RightNode);
            if (r == -1)
            {
                return -1;
            }
            if (Math.Abs(l-r) >= 1)
            {
                return -1;
            }
            return Math.Max(l, r) + 1;
        }

    }
}
