using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            Console.WriteLine(new Leetcode.UniqueBinarySearchTrees().total(1, 3)); 
 */
namespace Algorithm.Leetcode
{
    class UniqueBinarySearchTrees
    {
        public int total(int s, int e)
        {
            if (s >= e)
            {
                return 1;
            }
            int count = 0;
            for (int i = s; i <= e; i++)
            {
                count += (total(s, i - 1) * total(i + 1, e));
            }
            return count;
        }
    }
}
