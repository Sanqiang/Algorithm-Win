using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            List<int> list = new Leetcode.PascalTriangle2().getRow(3);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            } 
 */
namespace Algorithm.Leetcode
{
    class PascalTriangle2
    {
        public List<int> getRow(int rowIndex)
        {
            List<int>[] solutions = new List<int>[2];
            solutions[0] = new List<int>();
            solutions[1] = new List<int>();

            solutions[0].Add(1);
            for (int i = 1; i <= rowIndex; i++)
            {
                List<int> cur = solutions[i % 2], last = solutions[(i + 1) % 2];

                for (int j = 0; j <= last.Count; j++)
                {
                    int num = 0;
                    if (j < last.Count)
                    {
                        num += last[j];
                    }
                    if (j - 1 >= 0)
                    {
                        num += last[j - 1];
                    }
                    cur.Add(num);
                }
                if (i == rowIndex)
                {
                    return cur;
                }
                last.Clear();
            }
            return null;
        }
    }
}
