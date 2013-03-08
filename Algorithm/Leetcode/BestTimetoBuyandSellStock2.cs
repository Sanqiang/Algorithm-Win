using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int len = new Leetcode.BestTimetoBuyandSellStock2().maxProfitint(new int[] { 2, 3, 9, 4, 1,5 });
            Console.WriteLine(len); 
 */
namespace Algorithm.Leetcode
{
    class BestTimetoBuyandSellStock2
    {
        public int maxProfitint(int[] prices)
        {
            int price = 0, buy = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[i-1])
                {
                    price += prices[i-1] - buy;
                    buy = prices[i];
                }
            }
            price += prices[prices.Length - 1] - buy;
            return price;
        }
    }
}
