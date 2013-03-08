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

            var solution = new Leetcode.PathSum2().pathSum(btn1, 7); 
 */
namespace Algorithm.Leetcode
{
    class PathSum2
    {
        public List<List<double>> pathSum(TreeAndGraph.BinaryTreeNode root, int sum)
        {
            List<List<double>> solution = new List<List<double>>();
            int height = root.getHeight();
            count = new double[height];
            PreDPS(root, solution, sum, count, 0);
            return solution;
        }

        private double[] count = null;
        void PreDPS(TreeAndGraph.BinaryTreeNode node, List<List<double>> solution, int sum, double[] count, int level)
        {
            if (node == null)
            {
                return;
            }
            count[level] = node.Data;
            double temp = sum;
            for (int i = level; i >= 0; i--)
            {
                temp -= count[i];
                if (temp == 0)
                {
                    List<double> temp_list = new List<double>();
                    for (int j = i; j <= level; j++)
                    {
                        temp_list.Add(count[j]);
                    }
                    solution.Add(temp_list);
                }
            }
            PreDPS(node.LeftNode, solution, sum, count, level + 1);
            PreDPS(node.RightNode, solution, sum, count, level + 1);
        }
    }
}
