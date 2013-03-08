using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
            var root = BinaryTreeNode.getBSTInst();
            var list = new Leetcode.BinaryTreeInorderTraversal().inorder(root); 
 */
namespace Algorithm.Leetcode
{
    class BinaryTreeInorderTraversal
    {
        public List<double> inorder(TreeAndGraph.BinaryTreeNode root)
        {
            List<double> list = new List<double>();
            Stack<TreeAndGraph.BinaryTreeNode> s = new Stack<BinaryTreeNode>();
            s.Push(root);
            while (s.Count != 0)
            {
                while (s.Peek().LeftNode != null)
                {
                    s.Push(s.Peek().LeftNode);
                }

                do
                {
                    TreeAndGraph.BinaryTreeNode node = s.Pop();
                    list.Add(node.Data);
                    if (node.RightNode != null)
                    {
                        s.Push(node.RightNode);
                        break;
                    }
                } while (s.Count != 0);


            }
            return list;
        }
    }
}
