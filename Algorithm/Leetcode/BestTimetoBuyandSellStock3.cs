using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int max = new Leetcode.BestTimetoBuyandSellStock3().maxProfitint(new int[] { 1, 9, 8, 100, 1, 100 });
            Console.WriteLine(max);
 */
namespace Algorithm.Leetcode
{
    class BestTimetoBuyandSellStock3
    {
        public int maxProfitint(int[] prices)
        {
            int[] left = new int[prices.Length], right = new int[prices.Length];
            int low = prices[0], max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                low = Math.Min(low, prices[i]);
                max = Math.Max(prices[i] - low, max);
                left[i] = max;
            }
            int high = prices[prices.Length - 1];
            max = 0;
            for (int i = prices.Length-2; i >= 0; i--)
            {
                high = Math.Max(high, prices[i]);
                max = Math.Max(max, high - prices[i]);
                right[i] = max;
            }
            max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                max = Math.Max(max, left[i-1] + right[i]);
            }
            return max;
        }
    }
}
