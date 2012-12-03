/*
             Console.WriteLine(Microsoft.Q56.findLCS("BDCABA", "ABCBDAB"));
            //Console.WriteLine(Microsoft.Q56.findLCSBackward("BDCABA", "ABCBDAB"));
 */ 
namespace Algorithm.Microsoft
{
    class Q56
    {
        public static string findLCS(string str1, string str2)
        {
            //Init
            int i = 0, j = 0;
            int[,] tab = new int[str1.Length + 1, str2.Length + 1];

            //Ex
            buildMatrixEx(tab, str1.Length, str2.Length, str1, str2);

            i = 1; j = 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                if (i == str1.Length  || j == str2.Length )
                {
                    break;
                }

                if (str1[i - 1] == str2[j - 1])
                {
                    sb.Append(str1[i - 1]);
                    i++;
                    j++;
                }
                else if (tab[i + 1, j] > tab[i, j + 1])
                {
                    i++;
                }
                else if (tab[i + 1, j] < tab[i, j + 1])
                {
                    j++;
                }
                else if (tab[i + 1, j] == tab[i, j + 1])
                {
                    i++; j++;
                }
            }
            for (; i < str1.Length; i++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    sb.Append(str1[i - 1]);
                    i++;
                }
            }
            for (; j < str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    sb.Append(str2[j - 1]);
                    j++;
                }
            }

            return sb.ToString();
        }

        private static void buildMatrixEx(int[,] tab, int col, int row, string str1, string str2)
        {
            for (int i = 0; i < col; i++)
            {
                tab[i, 0] = 0;
            }
            for (int j = 0; j < row; j++)
            {
                tab[0, j] = 0;
            }

            for (int i = 1; i <= col; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else if (tab[i - 1, j] > tab[i, j - 1])
                    {
                        tab[i, j] = tab[i - 1, j];
                    }
                    else
                    {
                        tab[i, j] = tab[i, j - 1];
                    }
                }
            }
        }

        //Deprecated
        public static string findLCSBackward(string str1, string str2)
        {
            //Init
            int i = 0, j = 0;
            int[,] tab = new int[str1.Length + 1, str2.Length + 1];
            for (; i <= str1.Length; i++)
            {
                for (; j <= str2.Length; j++)
                {
                    tab[i, j] = -1;
                }
            }
            buildMatrix(tab, str1.Length, str2.Length, str1, str2);

            i = str1.Length; j = str2.Length;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                if (i == 0 || j == 0)
                {
                    break;
                }

                if (str1[i - 1] == str2[j - 1])
                {
                    sb.Insert(0, str1[i - 1]);
                    i--;
                    j--;
                }
                else if (tab[i - 1, j] > tab[i, j - 1])
                {
                    i--;
                }
                else if (tab[i - 1, j] < tab[i, j - 1])
                {
                    j--;
                }
                else if (tab[i - 1, j] == tab[i, j - 1])
                {
                    i--; j--;
                }
            }

            return sb.ToString();
        }
        private static int buildMatrix(int[,] tab, int col, int row, string str1, string str2)
        {
            if (tab[col, row] > -1)
            {
                return tab[col, row];
            }
            if (col == 0 || row == 0)
            {
                tab[col, row] = 0;
            }
            else
            {

                if (str1[col - 1] == str2[row - 1])
                {
                    tab[col, row] = buildMatrix(tab, col - 1, row - 1, str1, str2) + 1;
                }
                else
                {
                    if (buildMatrix(tab, col - 1, row, str1, str2) >= buildMatrix(tab, col, row - 1, str1, str2))
                    {
                        tab[col, row] = buildMatrix(tab, col - 1, row, str1, str2);
                    }
                    else
                    {
                        tab[col, row] = buildMatrix(tab, col, row - 1, str1, str2);
                    }
                }
            }
            //error base
            return tab[col, row];
        }
    }
}
