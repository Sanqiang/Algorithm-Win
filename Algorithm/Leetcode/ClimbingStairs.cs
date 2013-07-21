using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             var inst = new Leetcode.ClimbingStairs();
            Console.WriteLine(inst.climbStairs(10));
            Console.WriteLine(inst.climbStairsDp(10)); 
 */
namespace Algorithm.Leetcode
{
    class ClimbingStairs
    {
        Dictionary<int, int> cache = new Dictionary<int, int>();
        public int climbStairs(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 0;
            }
            else
            {
                if (cache.ContainsKey(n))
                {
                    return cache[n];
                }
                int nums = climbStairs(n - 1) + climbStairs(n - 2);
                cache.Add(n, nums);
                return nums;
            }
        }

        public int climbStairsDp(int n)
        {
            int[] cache = new int[3];
            cache[0] = 1;
            cache[1] = 2;
            for (int i = 2; i < n; i++)
            {
                int pre1 = cache[(i + 1) % 3], pre2 = cache[(i + 2) % 3];
                cache[i % 3] = pre1 + pre2;
            }

            return cache[(n-1) % 3];
        }
    }
}
