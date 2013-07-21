using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int[,] matrix = { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 } };
            Console.WriteLine(new Leetcode.Searcha2DMatrix().searchMatrix(matrix, 3)); 
 */
namespace Algorithm.Leetcode
{
    class Searcha2DMatrix
    {
        public bool searchMatrix(int[,] matrix, int target)
        {
            int col = 0, row = matrix.GetLength(1)-1;
            while (col < matrix.GetLength(0) && row >= 0)
            {
                if (matrix[col, row] == target)
                {
                    return true;
                }
                else if (matrix[col, row] > target)
                {
                    --row;
                }
                else
                {
                    ++col;
                }
            }
            return false;
        }
    }
}
