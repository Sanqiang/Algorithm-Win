using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc";
            Console.WriteLine(new Leetcode.InterleavingString().verify(s1, s2, s3));
            Console.WriteLine(new Leetcode.InterleavingString().verifyDP(s1, s2, s3));
 */
namespace Algorithm.Leetcode
{
    internal class InterleavingString
    {
        public bool verify(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            else if (s1.Length == 0 && s2.Length == 0 && s3.Length == 0)
            {
                return true;
            }
            else if (s1.Length > 0 && s2.Length > 0 && s3.Length > 0 && s1[0] == s3[0] && s2[0] == s3[0])
            {
                return verify(s1.Substring(1), s2, s3.Substring(1)) || verify(s1, s2.Substring(1), s3.Substring(1));
            }
            else if (s1.Length > 0 && s3.Length > 0 && s1[0] == s3[0])
            {
                return verify(s1.Substring(1), s2, s3.Substring(1));
            }
            else if (s2.Length > 0 && s3.Length > 0 && s2[0] == s3[0])
            {
                return verify(s1, s2.Substring(1), s3.Substring(1));
            }
            else
            {
                return false;
            }
        }

        public bool verifyDP(string s1, string s2, string s3)
        {
            int s1_len = s1.Length, s2_len = s2.Length;
            bool[,] dp = new bool[1 + s1_len, 1 + s2_len];
            dp[0, 0] = true;
            for (int col = 1; col <= s1_len; col++)
            {
                if (dp[col - 1, 0] && s1[col - 1] == s3[col - 1])
                {
                    dp[col, 0] = true;
                }
            }
            for (int row = 1; row <= s2_len; row++)
            {
                if (dp[0, row - 1] && s2[row - 1] == s3[row - 1])
                {
                    dp[0, row] = true;
                }
            }
            for (int col = 1; col <= s1_len; col++)
            {
                for (int row = 1; row <= s2_len; row++)
                {
                    if ((dp[col - 1, row] && s1[col  - 1] == s3[col + row - 1])
                        || (dp[col, row - 1] && s2[ row - 1] == s3[col + row - 1]))
                    {
                        dp[col, row] = true;
                    }
                }
            }
            return dp[s1_len, s2_len];
        }

    }
}
