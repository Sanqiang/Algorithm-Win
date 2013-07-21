using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            List<int> solu = new Leetcode.GreyCode().grayCode(3);
            foreach (int i in solu)
            {
                Console.WriteLine(i);
            } 
 */
namespace Algorithm.Leetcode
{
    class GreyCode
    {
        public List<int> grayCode(int n)
        {
            List<int> solution = new List<int>();
            int len = 1 << n;
            for (int i = 0; i < len; i++)
            {
                solution.Add(((i>>1)^i));
            }
            return solution;
        }
    }
}
