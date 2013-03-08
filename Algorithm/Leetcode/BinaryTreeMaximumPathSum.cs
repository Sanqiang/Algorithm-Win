using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int len = new Leetcode.BinaryTreeMaximumPathSum().maxPathSum(btn1);
            Console.WriteLine(len);
 */
namespace Algorithm.Leetcode
{
    class BinaryTreeMaximumPathSum
    {
        public int maxPathSum(TreeAndGraph.BinaryTreeNode root)
        {
            return DFS(root).LoopLen;
        }

        private Wrapper DFS(TreeAndGraph.BinaryTreeNode head)
        {
            Wrapper wr = new Wrapper();
            if (head == null)
            {
                return wr;
            }
            Wrapper l = DFS(head.LeftNode);
            Wrapper r = DFS(head.RightNode);
            wr.BranchLen = Math.Max(l.BranchLen, r.BranchLen) + (int)head.Data;
            wr.LoopLen = Math.Max(Math.Max(l.LoopLen, r.LoopLen), l.BranchLen + r.BranchLen + (int)head.Data);
            return wr;
        }

        class Wrapper
        {
            public int BranchLen = 0;
            public int LoopLen = 0;

        }
    }
}
