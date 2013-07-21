using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int[] height = { 2, 1, 5, 6, 2,2,2, 3 };
            Console.WriteLine(new Leetcode.LargestRectangleinHistogram().largestRectangleArea(height)); 
 */
namespace Algorithm.Leetcode
{
    class LargestRectangleinHistogram
    {
        public int largestRectangleArea(int[] height)
        {
            Stack<int> s_val = new Stack<int>(), s_ind = new Stack<int>();
            int max = 0;
            s_val.Push(height[0]);
            s_ind.Push(0);
            int i = 1;
            for (; i < height.Length; i++)
            {
                if (height[i] >= height[i - 1])
                {
                    s_val.Push(height[i]);
                    s_ind.Push(i);
                }
                else
                {
                    while (s_val.Count != 0 && s_val.Peek() >= height[i])
                    {
                        int pval = s_val.Pop();
                        s_ind.Pop();
                        int pi = 0;
                        if (s_ind.Count != 0)
                        {
                            pi = s_ind.Peek() + 1;
                        }
                        int area = (i - pi) * pval;
                        max = Math.Max(area, max);
                    }
                    s_val.Push(height[i]);
                    s_ind.Push(i);
                }
            }
            i = height.Length;
            while (s_val.Count != 0)
            {
                int pval = s_val.Pop();
                s_ind.Pop();
                int pi = 0;
                if (s_ind.Count != 0)
                {
                    pi = s_ind.Peek() + 1;
                }
                int area = (i - pi) * pval;
                max = Math.Max(area, max);
            }

            return max;
        }
    }
}
