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

/*

        private static void getCommon(string left, string right)
        {
            int llength = left.Length;
            int rlength = right.Length;
            l = left; r = right;
            table = new int[llength + 1, rlength + 1];
            for (int i = 0; i <= llength; i++)
            {
                for (int j = 0; j <= rlength; j++)
                {
                    table[i, j] = -1;
                }
            }
            buildDP(llength, rlength);
            for (int i = 0; i <= llength; i++)
            {
                for (int j = 0; j < rlength; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }


            int col = llength, row = rlength;
            while (col >= 1 && row >= 1)
            {
                if (l[col - 1] == r[row - 1])
                {
                    Console.Write(l[col - 1]);
                    --col; --row;
                }
                else if (table[col - 1, row] < table[col, row - 1])
                {
                    --row;
                }
                else if (table[col - 1, row] > table[col, row - 1])
                {
                    --col;
                }
                else
                {
                    --col; --row;
                }
            }

        }

        static string l;
        static string r;
        static int[,] table;
        private static int buildDP(int i, int j)
        {
            for (int col = 0; col <= i; col++) { table[col, 0] = 0; }
            for (int row = 0; row <= j; row++) { table[0, row] = 0; }

            for (int col = 1; col <= i; col++)
            {
                for (int row = 1; row <= j; row++)
                {
                    if (l[col - 1] == r[row - 1])
                    {
                        table[col, row] = table[col - 1, row - 1] + 1;
                    }
                    else if (table[i - 1, j] > table[i, j - 1])
                    {
                        table[i, j] = table[i - 1, j];
                    }
                    else if (table[i - 1, j] <= table[i, j - 1])
                    {
                        table[i, j] = table[i, j - 1];
                    }
                }
            }


            return i + j;//meaningless when iterative
            // recursive way
            if (table[i, j] > -1)
            {
                return table[i, j];
            }
            if (i == 0 || j == 0)
            {
                table[i, j] = 0;
            }
            else if (l[i - 1] == r[j - 1])
            {
                table[i, j] = 1 + buildDP(i - 1, j - 1);
            }
            else if (buildDP(i - 1, j) > buildDP(i, j - 1))
            {
                table[i, j] = buildDP(i - 1, j);
            }
            else if (buildDP(i - 1, j) <= buildDP(i, j - 1))
            {
                table[i, j] = buildDP(i, j - 1);
            }

            return table[i, j];
             
        }
    
 */
    }
}
