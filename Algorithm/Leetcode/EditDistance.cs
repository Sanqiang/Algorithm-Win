using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Console.WriteLine(new Leetcode.EditDistance().minDistance("abc", "cab")); 
 */
namespace Algorithm.Leetcode
{
    class EditDistance
    {
        public int minDistance(String word1, String word2)
        {
            int[,] dp = new int[word1.Length, word2.Length];
            if (word1[0] == word2[0])
            {
                dp[0, 0] = 0;
            }
            else
            {
                dp[0, 0] = 1;
            }

            for (int col = 1; col < word1.Length; col++)
            {
                if (word1[col] == word2[0])
                {
                    dp[col, 0] = dp[col - 1, 0];
                }
                else
                {
                    dp[col, 0] = dp[col - 1, 0] + 1;
                }
            }

            for (int row = 1; row < word2.Length; row++)
            {
                if (word1[0] == word2[row])
                {
                    dp[0, row] = dp[0, row - 1];
                }
                else
                {
                    dp[0, row] = dp[0, row - 1] + 1;
                }
            }

            for (int col = 1; col < word1.Length; col++)
            {
                for (int row = 1; row < word2.Length; row++)
                {
                    int min = Math.Min(dp[col - 1, row - 1], Math.Min(dp[col - 1, row], dp[col, row - 1]));
                    if (word1[col] == word2[row])
                    {
                        dp[col, row] = min;
                    }
                    else
                    {
                        dp[col, row] = min + 1;
                    }
                }
            }
            return dp[word1.Length - 1, word2.Length - 1];
        }
    }
}
