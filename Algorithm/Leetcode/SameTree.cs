using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.SameTree();
            BinaryTreeNode syn = BinaryTreeNode.getSymInst(), asyn = BinaryTreeNode.getInst();
            Console.WriteLine(inst.verify(syn,syn) + "-" +inst.verify(syn,asyn)); 
 */
namespace Algorithm.Leetcode
{
    class SameTree
    {
        public bool verify(TreeAndGraph.BinaryTreeNode t1, TreeAndGraph.BinaryTreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }else if (t1 == null || t2 == null ||t1.Data != t2.Data)
            {
                return false;
            }
            return verify(t1.LeftNode, t2.LeftNode) && verify(t1.RightNode, t2.RightNode);
        }
    }
}
