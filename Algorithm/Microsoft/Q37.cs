/*
             string[] arr = { 
                           "AB","AC","AF","BC","CF","FG","GN"
                           };
            Console.WriteLine(Microsoft.Q37.findLongestCon(arr));
 */ 
namespace Algorithm.Microsoft
{
    class Q37
    {
        //Dijkstra
        public static string findLongestCon(string[] arr)
        {
            int length = arr.Length;
            int m = arr[0].Length;
            int[,] tab = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (arr[j].Substring(0, m - 1).Equals(arr[i].Substring(1)))
                    {
                        tab[i, j] = 1;
                    }
                    else
                    {
                        tab[i, j] = -1;
                    }
                }
            }

            int[, ,] path = new int[length, length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (tab[i, j] > 0)
                    {
                        path[i, j, 0] = i;
                        path[i, j, 1] = j;
                        for (int k = 2; k < length; k++)
                        {
                            path[i, j, k] = -1;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < length; k++)
                        {
                            path[i, j, k] = -1;
                        }
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if (tab[i, j] != -1 && tab[j, k] != -1 && tab[i, j] + tab[j, k] > tab[i, k])
                        {
                            tab[i, k] = tab[i, j] + tab[j, k];
                            int v = 0;
                            for (; v < length; v++)
                            {
                                if (path[i, j, v] == -1)
                                {
                                    break;
                                }
                                path[i, k, v] = path[i, j, v];
                            }
                            for (int n = 1; n < length; n++)
                            {
                                if (path[j, k, n] == -1)
                                {
                                    break;
                                }
                                path[i, k, v++] = path[j, k, n];
                            }
                        }
                    }
                }
            }


            int biggest = tab[0, 0];
            int x = 0, y = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (tab[i, j] > biggest)
                    {
                        biggest = tab[i, j];
                        x = i; y = j;
                    }
                }
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (path[x, y, i] == -1)
                {
                    break;
                }
                sb.Append(arr[path[x, y, i]] + " ");


            }

            return sb.ToString();
        }
    }
}
