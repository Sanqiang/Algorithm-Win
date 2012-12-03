/*
             int[] chess = new int[2];
            //Recursive.CC8_8.placeQueen(0, chess, 4);
            Recursive.CC8_8.placeQueenEx(0, chess, 3);
            //Recursive.CC8_8.placeQueenSample(0);
 */
namespace Algorithm.Recursive
{
    class CC8_8
    {
        public static void placeQueen(int current_row, int[] chess, int row_length)
        {
            if (current_row == chess.Length)
            {
                foreach (var item in chess)
                {
                    int[] m = new int[row_length];
                    m[item] = 1;
                    for (int i = 0; i < m.Length; i++)
                    {
                        System.Console.Write(m[i]);
                    }
                    System.Console.WriteLine("");
                }
                System.Console.WriteLine("=====================");
                return;
            }

            for (int i = 0; i < row_length; i++)
            {
                if (checkAbleToPlace(current_row, i, chess))
                {
                    //int[] new_chess = (int[])chess.Clone();
                    chess[current_row] = i;
                    placeQueen(current_row + 1, chess, row_length);
                }
            }
        }

        private static bool checkAbleToPlace(int current_row, int potential_col, int[] chess)
        {
            for (int i = 0; i < current_row; i++)
            {
                if (potential_col == chess[i]
                    || System.Math.Abs(current_row - i) == System.Math.Abs(potential_col - chess[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static void placeQueenBad(int current_row, int[] chess, int row_length)
        {
            if (current_row == chess.Length)
            {
                foreach (var item in chess)
                {
                    int[] m = new int[row_length];
                    m[item] = 1;
                    for (int i = 0; i < m.Length; i++)
                    {
                        System.Console.Write(m[i]);
                    }
                    System.Console.WriteLine("");
                }
                System.Console.WriteLine("=====================");
                return;
            }

            for (int i = 0; i < row_length; i++)
            {
                int[] new_chess = chess; // do not need to clone
                //int[] new_chess = (int[])chess.Clone();
                //new_chess[current_row] = i;
                if (checkAbleToPlaceBad(current_row, new_chess))
                {
                    placeQueenBad(current_row + 1, new_chess, row_length);
                }
            }
        }

        private static bool checkAbleToPlaceBad(int current_row, int[] chess)
        {
            for (int i = 0; i < current_row; i++)
            {
                int diff = System.Math.Abs(chess[current_row] - chess[i]);
                if (diff == 0 || diff == System.Math.Abs(current_row - i))
                {
                    return false;
                }
            }
            return true;
        }


        //Sample
        static int[] columnForRow = new int[8];
        public static void placeQueenSample(int row)
        {
            if (row == 8)
            {
                foreach (var item in columnForRow)
                {
                    int[] m = new int[8];
                    m[item] = 1;
                    for (int i = 0; i < m.Length; i++)
                    {
                        System.Console.Write(m[i]);
                    }
                    System.Console.WriteLine("");
                }
                System.Console.WriteLine("=====================");
                return;
            }

            for (int i = 0; i < 8; i++)
            {
                columnForRow[row] = i;
                if (checkSample(row))
                {
                    placeQueenSample(row + 1);
                }
            }
        }

        private static bool checkSample(int row)
        {
            for (int i = 0; i < row; i++)
            {
                int diff = System.Math.Abs(columnForRow[i] - columnForRow[row]);
                if (diff == 0 || diff == row - i) return false;
            }
            return true;
        }
    }
}
