using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             int[] num = { 99, 1, 4, 100, 5, 200, 2, 3 };
            int len = new Leetcode.LongestConsecutiveSequence().longestConsecutive(num);
            Console.WriteLine(len); 
 */
namespace Algorithm.Leetcode
{
    class LongestConsecutiveSequence
    {
        public int longestConsecutive(int[] num)
        {
            int max = 0;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < num.Length; i++)
            {
                hs.Add(num[i]);
            }
            for (int i = 0; i < num.Length; i++)
            {
                max = Math.Max(max, getLength(hs, num[i]));
            }
            return max;
        }

        private int getLength(HashSet<int> hs, int cur)
        {
            int len = 1, left = cur - 1, right = cur + 1;
            while (hs.Contains(left))
            {
                ++len;
                hs.Remove(left--);
            }
            while (hs.Contains(right))
            {
                ++len;
                hs.Remove(right++);
            }
            return len;
        }
    }
}
