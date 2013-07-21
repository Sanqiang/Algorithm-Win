using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    class SetMatrixZeroes
    {
        public void setZeroes(int[,] matrix)
        {
            bool[] cols = new bool[matrix.GetLength(0)];
            bool[] rows = new bool[matrix.GetLength(1)];
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (matrix[col,row] == 0)
                    {
                        cols[col] = true;
                        rows[row] = true;
                    }

                }
            }
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (cols[col] || rows[row])
                    {
                        matrix[col, row] = 0;
                    }
                }
            }

        }
    }
}
