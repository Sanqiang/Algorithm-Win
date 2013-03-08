using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            TreeAndGraph.BinaryTreeNode root = BinaryTreeNode.getBSTInst();
            var inst = new Leetcode.ValidateBinarySearchTree();
            Console.WriteLine(inst.validate(root)); 
 */
namespace Algorithm.Leetcode
{
    class ValidateBinarySearchTree
    {
        public bool validate(TreeAndGraph.BinaryTreeNode root, double min = double.MinValue , double max = double.MaxValue)
        {
            if (root == null)
            {
                return true;
            }
            if (root.Data < min || root.Data > max)
            {
                return false;
            }
            return validate(root.LeftNode, min, root.Data) && validate(root.RightNode, root.Data, max);
        }
    }
}
