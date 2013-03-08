using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             BinaryTreeNode root = BinaryTreeNode.getInst();
            var solution = new Leetcode.BinaryTreeLevelOrderTraversalII().levelOrderBottom(root);
 
 */
namespace Algorithm.Leetcode
{
    class BinaryTreeLevelOrderTraversalII
    {
        public List<List<double>> levelOrderBottom(TreeAndGraph.BinaryTreeNode root)
        {
            List<List<double>> solution = new List<List<double>>();
            DFS(solution, root, 0);
            return solution;
        }

        void DFS(List<List<double>> solution, TreeAndGraph.BinaryTreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (solution.Count <= level)
            {
                solution.Insert(0, new List<double>());
            }
            solution[solution.Count - 1 - level].Add(root.Data);
            DFS(solution, root.LeftNode, level + 1);
            DFS(solution, root.RightNode, level + 1);
        }
    }
}
