using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            BinaryTreeNode root = BinaryTreeNode.getInst();
            var solution = new Leetcode.BinaryTreeZigzagLevelOrderTraversal().zigzagLevelOrder(root); 
 */
namespace Algorithm.Leetcode
{
    class BinaryTreeZigzagLevelOrderTraversal
    {
        public List<List<double>> zigzagLevelOrder(TreeAndGraph.BinaryTreeNode root)
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
                solution.Add( new List<double>());
            }
            if (level%2 == 0)
            {
                solution[level].Add(root.Data);
            }
            else
            {
                solution[level].Insert(0,root.Data);
            }
            DFS(solution, root.LeftNode, level + 1);
            DFS(solution, root.RightNode, level + 1);
        }
    }
}
