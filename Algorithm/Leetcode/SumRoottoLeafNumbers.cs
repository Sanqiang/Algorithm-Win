using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             BinaryTreeNode root = new BinaryTreeNode(1);
            root.LeftNode = new BinaryTreeNode(2);
            root.LeftNode.LeftNode = new BinaryTreeNode(4);
            root.RightNode = new BinaryTreeNode(3);
            int count = new Leetcode.SumRoottoLeafNumbers().sumNumbers(root);
            Console.WriteLine(count); 
 */
namespace Algorithm.Leetcode
{
    class SumRoottoLeafNumbers
    {
        public int sumNumbers(TreeAndGraph.BinaryTreeNode root)
        {
            int count = 0;
            BFS(root, 0, ref count);
            return count;
        }

        private void BFS(TreeAndGraph.BinaryTreeNode node, int cur, ref int count)
        {
            if (node == null)
            {
                return;
            }
            cur = cur * 10 + (int)node.Data;
            BFS(node.LeftNode, cur, ref count);
            BFS(node.RightNode, cur, ref count);
            //cur = (cur - (int)node.Data) / 10;
            if (node.LeftNode == null && node.RightNode == null)
            {
                count += cur;
            }
        }
    }
}
