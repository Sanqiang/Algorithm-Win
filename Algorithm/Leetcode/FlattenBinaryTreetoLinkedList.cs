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

            new Leetcode.FlattenBinaryTreetoLinkedList().flatten(btn1); 
 */
namespace Algorithm.Leetcode
{
    class FlattenBinaryTreetoLinkedList
    {
        public void flatten(TreeAndGraph.BinaryTreeNode root)
        {
            _last_node = null;
            PreDFS(root);
        }

        private TreeAndGraph.BinaryTreeNode _last_node = null;
        private void PreDFS(TreeAndGraph.BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            TreeAndGraph.BinaryTreeNode l = node.LeftNode, r = node.RightNode;
            node.LeftNode = null;
            if (_last_node == null)
            {
                _last_node = node;
            }
            else
            {
                _last_node.RightNode = node;
                _last_node = node;
            }
            PreDFS(l);
            PreDFS(r);
        }
    }
}
