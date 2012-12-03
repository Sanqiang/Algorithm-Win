/*
 You have a sequence S of n characters from an alphabet of size k <= n; each character may 
occur many times in the sequence. You want to find the longest subsequence of S where all 
occurrences of the same character are together in one place; for example, if S = 
aaaccaaaccbccbbbab, then the longest such subsequence is aaaaaaccccbbbb = 
aaa__aaacc_ccbbb_b. In other words, any alphabet character that appears in S may only 
appear in one contiguous block in the subsequence. If possible, give a polynomial time 
algorithm to determine the value of the optimal solution (i.e. the length of longest such 
subsequence).
 */
 
namespace Algorithm.Recursive
{
    public class LongestSubSequence
    {
        static int K = 3;
        static int[,,] memory;
        static string input_str;
        public  static int solve(string str)
        {
            input_str = str;
            memory = new int[1 << (K + 1), (K + 1), str.Length];
            for (int i = 0; i < memory.GetLength(0); i++)
            {
                for (int j = 0; j < memory.GetLength(1); j++)
                {
                    for (int n = 0; n < memory.GetLength(2); n++)
                    {
                        memory[i,j,n] = -1;
                    }
                }
            }
            int result = run(0, 0, 0);
            return result;
        }

        public static int run(int mask, int last, int i)
        {
            if (i == input_str.Length)
            {
                return 0;
            }
            if (last != -1 && memory[mask,last,i] != -1)
            {
                return memory[mask,last,i];
            }
            int j = input_str[i] - 'a' + 1;
            int res = 0;
            if (last == j)
            {
                res = System.Math.Max(res, run(mask, last, i + 1) + 1);
            }
            else if ((mask & (1 << j)) == 0)
            {
                res = System.Math.Max(res, run(mask | (1 << j), j, i + 1) + 1);	
            }
            res = System.Math.Max(res, run(mask, last, i + 1)); 
            return memory[mask,last,i] = res;
        }
    }
}
