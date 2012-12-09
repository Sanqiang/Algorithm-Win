/*
            Microsoft.Q94.findLongestArithmeticProgression(new int[] { -1, 0, 1, 3, 5, 6 });
 */


namespace Algorithm.Microsoft
{
    class Q94
    {
        readonly static int MaxLength = 3;
        public static void findLongestArithmeticProgression(int[] arr)
        {
            int length = arr.Length;
            System.Array.Sort(arr);
            int MaxD = (arr[length - 1] - arr[0]) / 3;
            System.Collections.Generic.SortedSet<int> ss = new System.Collections.Generic.SortedSet<int>(arr);
            for (int i = 0; i < length; i++)
            {
                int start = arr[i], count = 1;

                for (int j = i + 1; j < length; j++)
                {
                    int d = arr[j] - arr[i];
                    if (d > MaxD)
                    {
                        break;
                    }
                    while (ss.Contains(start + count * d))
                    {
                        ++count;
                    }
                    if (count >= MaxLength)
                    {
                        //print
                        for (int k = 0; k < count; k++)
                        {
                            System.Console.Write(start + k * d +" ");
                        }
                        System.Console.WriteLine();
                    }
                }
            }
        }

        //useless
        private static int[,] buildMatrix(int[] arr)
        {
            int length = arr.Length - 1;
            int[,] tab = new int[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j > i)
                    {
                        tab[i, j] = arr[j] - arr[i];
                    }
                    else
                    {
                        tab[i, j] = -1;
                    }

                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    System.Console.Write(tab[i, j] + "     ");
                }
                System.Console.WriteLine();
            }

            return tab;
        }
    }
}
