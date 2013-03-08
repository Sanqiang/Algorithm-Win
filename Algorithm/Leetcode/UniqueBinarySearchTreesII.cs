using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.TreeAndGraph;
/*
            var list = new Leetcode.UniqueBinarySearchTreesII().total(1, 3); 
 */
namespace Algorithm.Leetcode
{
    class UniqueBinarySearchTreesII
    {
        public List<BinaryTreeNode> total(int s, int e)
        {
            List<BinaryTreeNode> list = new List<BinaryTreeNode>();
            if (s > e)
            {
                list.Add(null);
                return list;
            }else if (s == e)
            {
                list.Add(new BinaryTreeNode(s));
                return list;
            }
            for (int i = s; i <= e; i++)
            {
                List<BinaryTreeNode> lefts = total(s, i - 1), rights = total(i + 1, e);
                foreach (BinaryTreeNode left in lefts)
                {
                    foreach (BinaryTreeNode right in rights)
                    {
                        BinaryTreeNode node = new BinaryTreeNode(i);
                        node.LeftNode = left;
                        node.RightNode = right;
                        list.Add(node);
                    }
                }
            }
            return list;
        }
    }
}
