using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    class BinaryTreeLevelOrderTraversal
    {
        public List<List<double>> levelOrder(TreeAndGraph.BinaryTreeNode root)
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
                solution.Add(new List<double>());
            }
            solution[level].Add(root.Data);
            DFS(solution, root.LeftNode, level + 1);
            DFS(solution, root.RightNode, level + 1);
        }
    }
}
