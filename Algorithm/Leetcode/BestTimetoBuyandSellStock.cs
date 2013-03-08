using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int len = new Leetcode.BestTimetoBuyandSellStock().maxProfitint(new int[] {2, 3, 9, 4, 1});
            Console.WriteLine(len); 
 */
namespace Algorithm.Leetcode
{
    class BestTimetoBuyandSellStock
    {
        public int maxProfitint(int[] prices)
        {
            int[] buy = new int[prices.Length];
            int[] sell = new int[prices.Length];
            int price = prices[0];
            buy[0] = price;
            for (int i = 1; i < prices.Length; i++)
            {
                price = Math.Min(price,prices[i]);
                buy[i] = price;
            }
            price = prices[prices.Length - 1];
            for (int i = prices.Length-2; i >= 0; i--)
            {
                price = Math.Max(price, prices[i]);
                sell[i] = price;
            }
            price = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                price = Math.Max(price, sell[i] - buy[i]);
            }
            return price;
        }
    }
}
