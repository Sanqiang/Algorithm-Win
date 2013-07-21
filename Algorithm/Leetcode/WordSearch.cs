using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            char[,] matrix = { { 'a', 'b', 'c', 'e' }, { 's', 'f', 'c', 's' }, { 'a', 'd', 'e', 'e' } };
            var inst = new Leetcode.WordSearch();
            Console.WriteLine(inst.exist(matrix, "abcced"));
            Console.WriteLine(inst.exist(matrix, "see"));
            Console.WriteLine(inst.exist(matrix, "abcb")); 
 */
namespace Algorithm.Leetcode
{
    class WordSearch
    {
        //shen ma assignment
        public bool exist(char[,] board, string word)
        {
            for (int col = 0; col < board.GetLength(0); col++)
            {
                for (int row = 0; row < board.GetLength(1); row++)
                {
                    bool[,] cache = new bool[board.GetLength(0), board.GetLength(1)];
                    if (exist(board, word, col, row, cache))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool exist(char[,] board, string word, int col, int row, bool[,] cache, int ind = 0)
        {
            if (ind == word.Length)
            {
                return true;
            }
            if (ind > word.Length || board[col, row] != word[ind] || cache[col, row])
            {
                return false;
            }


            if (col - 1 >= 0)
            {
                cache[col, row] = true;
                if (exist(board, word, col - 1, row, cache, ind + 1)) return true;
                cache[col, row] = false;
            }

            if (row - 1 >= 0)
            {
                cache[col, row] = true;
                if (exist(board, word, col, row - 1, cache, ind + 1)) return true;
                cache[col, row] = false;
            }

            if (col + 1 < board.GetLength(0))
            {
                cache[col, row] = true;
                if (exist(board, word, col + 1, row, cache, ind + 1)) return true;
                cache[col, row] = false;
            }

            if (row + 1 < board.GetLength(1))
            {
                cache[col, row] = true;
                if (exist(board, word, col, row + 1, cache, ind + 1)) return true;
                cache[col, row] = false;
            }

            return false;
        }
    }
}
