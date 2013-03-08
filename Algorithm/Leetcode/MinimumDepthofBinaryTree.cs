using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
            btn3.LeftNode = btn6; btn3.RightNode = btn7;

            var depth = new Leetcode.MinimumDepthofBinaryTree().minDepth(btn1);
            var depth2 = new Leetcode.MinimumDepthofBinaryTree().minDepth2(btn1);  
 */
namespace Algorithm.Leetcode
{
    class MinimumDepthofBinaryTree
    {
        public double minDepth(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Min(minDepth(root.LeftNode), minDepth(root.RightNode)) + root.Data;
        }

        public int minDepth2(TreeAndGraph.BinaryTreeNode root)
        {
            Queue<TreeAndGraph.BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(root);
            root.state = 1;
            while (q.Count != 0)
            {
                BinaryTreeNode node = q.Dequeue();
                if (node.LeftNode == null && node.RightNode == null)
                {
                    return node.state;
                }
                else
                {
                    if (node.LeftNode != null)
                    {
                        node.LeftNode.state = node.state + 1;
                        q.Enqueue(node.LeftNode);
                    }
                    if (node.RightNode != null)
                    {
                        node.RightNode.state = node.state + 1;
                        q.Enqueue(node.RightNode);
                    }
                }
            }
            return -1;
        }
    }
}
