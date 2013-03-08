using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            List<List<int>> triangle = new Leetcode.PascalTriangle().generate(5); 
 */
namespace Algorithm.Leetcode
{
    class PascalTriangle
    {
        public List<List<int>> generate(int numRows)
        {
            List<List<int>> solutions = new List<List<int>>();
            List<int> temp = new List<int>();
            temp.Add(1);
            solutions.Add(temp);
            for (int i = 1; i < numRows; i++)
            {
                temp = solutions[i - 1];
                List<int> cur = new List<int>();
                for (int row = 0; row <= temp.Count; row++)
                {
                    int num = 0;
                    if (row < temp.Count)
                    {
                        num += temp[row];
                    }
                    if (row - 1 >= 0)
                    {
                        num += temp[row - 1];
                    }
                    cur.Add(num);
                }
                solutions.Add(cur);
            }

            return solutions;
        }
    }
}
