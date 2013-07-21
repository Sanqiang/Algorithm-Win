using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            List<List<int>> list = new Leetcode.SubsetsII().subsetsWithDup(new int[] { 1, 2, 2 });
            foreach (List<int> ints in list)
            {
                foreach (int i in ints)
                {
                 Console.Write(i);   
                }
                Console.WriteLine();
            } 
 */

namespace Algorithm.Leetcode
{
    class SubsetsII
    {
        private int connective = 1;
        public List<List<int>> subsetsWithDup(int[] num, int ind = 0)
        {
            if (ind == num.Length)
            {
                List<List<int>> empty = new List<List<int>>();
                empty.Add(new List<int>());
                return empty;
            }
            List<List<int>> pre_solution = subsetsWithDup(num, ind + 1), solution = new List<List<int>>();
            if (ind + 1 < num.Length && num[ind] == num[ind + 1])
            {
                ++connective;
                List<int> temp = new List<int>();
                for (int i = 0; i < connective; i++)
                {
                    temp.Add(num[ind]);
                }
                solution.Add(temp);
                solution.AddRange(pre_solution);
                return solution;
            }
            else
            {
                connective = 1;
                int n = num[ind];
                foreach (List<int> pre_list in pre_solution)
                {
                    List<int> temp = new List<int>();
                    temp.AddRange(pre_list);
                    temp.Insert(0, n);
                    solution.Add(temp);
                }
                solution.AddRange(pre_solution);
                return solution;
            }
        }

        public List<List<int>> subsetsWithDup(int[] num)
        {
            List<List<int>> solution = new List<List<int>>();
            solution.Add(new List<int>());
            int last = 0, last2 =-1;
            for (int i = 0; i < num.Length; i++)
            {
                int n = num[i];
                if (i >= 1 && num[i] == num[i - 1])
                {
                    int count = solution.Count;
                    for (int j = last2; j < count; j++)
                    {
                        List<int> temp = new List<int>();
                        temp.AddRange(solution[j]);
                        temp.Add(n);
                        solution.Add(temp);
                    }
                }
                else
                {
                    int count = solution.Count;
                    for (int j = 0; j < count; j++)
                    {
                        List<int> temp = new List<int>();
                        temp.AddRange(solution[j]);
                        temp.Add(n);
                        solution.Add(temp);
                    }
                }
                last2 = last;
                last = solution.Count;
            }
            return solution;
        }
    }
}
