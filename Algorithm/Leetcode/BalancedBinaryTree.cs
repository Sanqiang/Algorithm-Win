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
            return DFS(root, ref height);
        }

        bool DFS(TreeAndGraph.BinaryTreeNode node, ref int height)
        {
            if (node == null)
            {
                height = 0;
                return true;
            }
            int lh = 0, rh = 0;
            bool l = DFS(node.LeftNode, ref lh);
            bool r = DFS(node.RightNode, ref rh);
            height = Math.Max(lh, rh) + 1;
            return l && r && Math.Abs(lh - rh) <= 1;
        }

    }
}
