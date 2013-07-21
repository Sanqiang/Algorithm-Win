using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int[,] matrix = {
                            {1, 1, 1, 0},
                            {1,1,1,0},
                            {0,1,1,1},
                            {0,1,1,1}
                            };
            var max = new Leetcode.MaximalRectangle().maximalRectangle(matrix);
            Console.WriteLine(max); 
 */
namespace Algorithm.Leetcode
{
    class MaximalRectangle
    {
        public int maximalRectangle(int[,] matrix)
        {
            int[,] DP = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (matrix[col, row] != 0)
                    {
                        if (row == 0)
                        {
                            DP[col, row] = matrix[col, row];
                        }
                        else
                        {
                            if (matrix[col, row] != 0)
                            {
                                DP[col, row] = DP[col, row - 1] + matrix[col, row];
                            }
                        }
                    }
                }
            } 
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                int min = DP[0, row];
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    min = Math.Min(DP[col, row], min);
                    DP[col, row] = min*(col + 1);
                }
            }
            int max = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    max = Math.Max(max, DP[col, row]);
                }
            }
            return max;
        }
    }
}
