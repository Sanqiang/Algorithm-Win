/*
             double[][] comb = {
                     new double[]{-1,1,4,4},
                     new double[]{-1,-1,1,-1},
                     new double[]{-1,-1,-1,1},
                     new double[]{-1,-1,-1,-1},
             };
            double[,,] path= TreeAndGraph.Floyd.findShortestPath(comb);
 */ 

namespace Algorithm.TreeAndGraph
{
    class Floyd
    {

        public static double[,,] findShortestPath(double[][] comb)
        {
            int length = comb.Length;
            double[, ,] path = new double[length, length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (comb[i][j] == -1)
                    {
                        for (int k = 0; k < length; k++)
                        {
                            path[i, j, k] = -1;
                        }
                    }
                    else
                    {
                        path[i, j, 0] = i;
                        path[i, j, 1] = j;
                        for (int k = 2; k < length; k++)
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
                        if (comb[i][j] != -1 && comb[j][k] != -1 && comb[i][j] + comb[j][k] < comb[i][k])
                        {
                            comb[i][k] = comb[i][j] + comb[j][k];
                            int m = 0;
                            for (; m < length; m++)
                            {
                                if (path[i, j, m] == -1)
                                {
                                    break;
                                }
                                path[i, k, m] = path[i, j, m];
                            }
                            for (int n = 1; n < length; n++)
                            {
                                if (path[j, k, n] == -1)
                                {
                                    break;
                                }
                                path[i, k, m++] = path[j, k, n];
                            }
                        }
                    }
                }
            }
            return path;
        }
    }
}
