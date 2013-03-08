using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
             int[] inorder = { 2, 5, 7, 10, 15 };
            int[] postorder = { 2, 7, 5, 15, 10 };
            var node = new Leetcode.ConstructBinaryTreefromInorderandPostorderTraversal().buildTree(inorder, postorder, 0,
                                                                                         inorder.Length - 1, 0,
                                                                                         postorder.Length - 1);
 
 */
namespace Algorithm.Leetcode
{
    class ConstructBinaryTreefromInorderandPostorderTraversal
    {
        public TreeAndGraph.BinaryTreeNode buildTree(int[] inorder, int[] postorder, int i_s, int i_e, int p_s, int p_e)
        {
            if (i_s > i_e || p_s > p_e)
            {
                return null;
            }
            int pivot = postorder[p_e];
            int i = 0;
            for (; i < inorder.Length; i++)
            {
                if (inorder[i] == pivot)
                {
                    break;
                }
            }
            TreeAndGraph.BinaryTreeNode head = new BinaryTreeNode(pivot);
            head.LeftNode = buildTree(inorder, postorder, i_s, i - 1, p_s, p_s + i - i_s - 1);
            head.RightNode = buildTree(inorder, postorder, i + 1, i_e, p_s + i - i_s , p_e - 1);
            return head;
        }
    }
}
