using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.Combinations();
            List<List<int>> solution = inst.combine(4, 2);
            foreach (List<int> ints in solution)
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
    class Combinations
    {
        public List<List<int>> combine(int n, int k)
        {
            List<List<List<int>>> solution = new List<List<List<int>>>();
            solution.Add(new List<List<int>>());
            solution.Add(new List<List<int>>());

            for (int num = 1; num <= n; num++)
            {
                List<int> temp = new List<int>(); 
                temp.Add(num);
                solution[0].Add(temp);
            }

            for (int loop = 1; loop < k; loop++)
            {
                List<List<int>> cur = solution[loop % 2], pre = solution[(loop + 1) % 2];
                foreach (List<int> ints in pre)
                {
                    for (int num = 1; num <= n; num++)
                    {
                        if (ints[ints.Count - 1] < num)
                        {
                            List<int> temp = new List<int>();
                            temp.AddRange(ints);
                            temp.Add(num);
                            cur.Add(temp);
                        }
                    }
                }
                pre.Clear();
            }

            return solution[(k+1) % 2];
        }
    }
}
