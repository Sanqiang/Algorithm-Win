using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.DistinctSubsequences();
            Console.WriteLine(inst.numDistinct("ABAB", "AB"));
            Console.WriteLine(inst.numDistinct2("ABAB", "AB"));
 
 */
namespace Algorithm.Leetcode
{
    class DistinctSubsequences
    {
        public int numDistinct(String S, String T)
        {
            int s_len = S.Length, t_len = T.Length;
            int[,] temp = new int[1 + t_len, 1 + s_len];
            for (int row = 0; row <= s_len; row++)
            {
                temp[0, row] = 1;
            }
            for (int col = 1; col <= t_len; col++)
            {
                for (int row = 1; row <= s_len; row++)
                {
                    if (S[row - 1] == T[col - 1])
                    {
                        temp[col, row] = temp[col, row - 1] + temp[col - 1, row];
                    }
                    else
                    {
                        temp[col, row] = temp[col, row - 1];
                    }
                }
            }

            return temp[t_len, s_len];
        }

        public int numDistinct2(String S, String T)
        {
            int s_len = S.Length, t_len = T.Length;
            int[,] temp = new int[1 + t_len, 1 + s_len];
            temp[0, 0] = 1;
            int sum = 0;
            for (int col = 1; col <= t_len; col++)
            {
                temp[col,0] = 0;
            }
            for (int row = 1; row <= s_len; row++)
            {
                temp[ 0,row] = 0;
            }
            for (int col = 1; col <= t_len; col++)
            {
                for (int row = 1; row <= s_len; row++)
                {
                    if (S[row - 1] == T[col - 1])
                    {
                         sum = 0;
                        for (int i = 0; i < row; i++)
                        {
                            sum += temp[col - 1, i];
                        }
                        temp[col, row] = sum;
                    }
                }
            }
             sum = 0;
            for (int i = 0; i <= s_len; i++)
            {
                sum += temp[t_len, i];
            }
            return sum;
        }
    }
}
