using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.SymmetricTree();
            BinaryTreeNode syn = BinaryTreeNode.getSymInst(), asyn = BinaryTreeNode.getInst();
            Console.WriteLine(inst.verify(syn) + "-" +inst.verify(asyn)); 
 */
namespace Algorithm.Leetcode
{
    class SymmetricTree
    {
        public bool verify(TreeAndGraph.BinaryTreeNode root)
        {
            return DFS(root, root);
        }

        bool DFS(TreeAndGraph.BinaryTreeNode left, TreeAndGraph.BinaryTreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left == null || right == null || left.Data != right.Data)
            {
                return false;
            }
            return DFS(left.LeftNode, right.RightNode) && DFS(left.RightNode, right.LeftNode);
        }
    }
}
