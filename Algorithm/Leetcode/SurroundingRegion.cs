using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             char[,] board = { 
                            {'X','X','X','X'},
                            {'X','X','O','X'},
                            {'X','X','O','X'},
                            {'O','O','X','X'}
                            };
            new Leetcode.SurroundingRegion().solve(board);
            for (int col = 0; col < board.GetLength(0); col++)
            {
                for (int row = 0; row < board.GetLength(1); row++)
                {
                    Console.Write(board[col,row]);
                }
                Console.WriteLine();
            } 
 */
namespace Algorithm.Leetcode
{
    class SurroundingRegion
    {
        public void solve(char[,] board)
        {
            int height = board.GetLength(0), width = board.GetLength(1);
            for (int col = 0; col < height; col++)
            {
                if (board[col, 0] == 'O')
                {
                    changeToPlus(board, col, 0);
                }
                if (board[col, width - 1] == 'O')
                {
                    changeToPlus(board, col, width - 1);
                }
            }
            for (int row = 1; row < width - 1; row++)
            {
                if (board[0, row] == 'O')
                {
                    changeToPlus(board, 0, row);
                }
                if (board[height - 1, row] == 'O')
                {
                    changeToPlus(board, height - 1, row);
                }
            }
            for (int col = 0; col < height; col++)
            {
                for (int row = 0; row < width; row++)
                {
                    if (board[col,row] == 'O')
                    {
                        board[col, row] = 'X';
                    }
                }
            }
            for (int col = 0; col < height; col++)
            {
                for (int row = 0; row < width; row++)
                {
                    if (board[col, row] == '+')
                    {
                        board[col, row] = 'O';
                    }
                }
            }
        }

        private void changeToPlus(char[,] board, int col, int row)
        {
            board[col, row] = '+';
            if (col - 1 >= 0 && board[col - 1, row] == 'O')
            {
                changeToPlus(board, col - 1, row);
            }
            if (col + 1 < board.GetLength(0) && board[col + 1, row] == 'O')
            {
                changeToPlus(board, col + 1, row);
            }
            if (row - 1 >= 0 && board[col, row - 1] == 'O')
            {
                changeToPlus(board, col, row - 1);
            }
            if (row + 1 < board.GetLength(1) && board[col, row + 1] == 'O')
            {
                changeToPlus(board, col, row + 1);
            }
        }
    }
}
