using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
            int[] inorder = { 2, 5, 7, 10, 15 };
            int[] preorder = {10, 5, 2, 7, 15};
            var node = new Leetcode.ConstructBinaryTreefromPreorderandInorderTraversal().buildTree(preorder, inorder, 0,
                                                                                         preorder.Length - 1, 0,
                                                                                         inorder.Length - 1); 
 */
namespace Algorithm.Leetcode
{
    class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        public TreeAndGraph.BinaryTreeNode buildTree(int[] preorder, int[] inorder, int p_s, int p_e, int i_s, int i_e)
        {
            if (i_s > i_e || p_s > p_e)
            {
                return null;
            }
            int pivot = preorder[p_s];
            int i = 0;
            for (; i < inorder.Length; i++)
            {
                if (inorder[i] == pivot)
                {
                    break;
                }
            }
            TreeAndGraph.BinaryTreeNode root = new BinaryTreeNode(pivot);
            root.LeftNode = buildTree(preorder, inorder, p_s + 1, p_s + i - i_s, i_s, i - 1);
            root.RightNode = buildTree(preorder, inorder, p_s + i - i_s+1, p_e, i + 1, i_e);
            return root;
        }
    }
}
