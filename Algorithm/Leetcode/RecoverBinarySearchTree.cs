using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            BinaryTreeNode root = BinaryTreeNode.getBSTInst();
            root.LeftNode.LeftNode.Data = 12;
            root.RightNode.LeftNode.Data = 2;
            new Leetcode.RecoverBinarySearchTree().recover(root); 
 */
namespace Algorithm.Leetcode
{
    class RecoverBinarySearchTree
    {
        public void recover(TreeAndGraph.BinaryTreeNode root)
        {
            last = null;
            forward(root);
            last = null;
            backward(root);
            if (f != b)
            {
                double temp = f.Data;
                f.Data = b.Data;
                b.Data = temp;
            }
        }

        private TreeAndGraph.BinaryTreeNode last = null, f , b;
        void forward(TreeAndGraph.BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            forward(node.LeftNode);
            if (last == null)
            {
                last = node;
            }
            else
            {
                if (node.Data < last.Data)
                {
                    f = last;
                    return;
                }
                last = node;
            }
            forward(node.RightNode);
        }

        void backward(TreeAndGraph.BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            backward(node.RightNode);
            if (last == null)
            {
                last = node;
            }
            else
            {
                if (node.Data > last.Data)
                {
                    b = last;
                    return;
                }
                last = node;
            }
            backward(node.LeftNode);
        }
    }
}
