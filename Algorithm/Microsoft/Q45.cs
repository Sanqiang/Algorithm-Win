
namespace Algorithm.Microsoft
{
    public class Q45
    {
        //45.1
        /*
                     int[][] matrix = {
                                    new int[4]{0,0,1,0},
                                    new int[4]{1,1,1,1},
                                    new int[4]{0,0,1,0}
                                };
            Console.WriteLine(Microsoft.Q45.verifyTranfer(matrix));
         */
        public static bool verifyTranfer(int[][] matrix)
        {
            //int height = matrix.Length, width = matrix[0].Length;
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        if (matrix[i][j] > 0)
            //        {
            //            back(matrix, i, j);
            //        }
            //    }
            //}
            throw new System.NotImplementedException();
            //return false;
        }

        //private static bool back(int[][] matrix, int i, int j)
        //{
        //    int height = matrix.Length, width = matrix[0].Length;
        //    bool change = false;
        //    if (i-1>=0 && matrix[i-1][j] == 0)
        //    {
        //        return false;
        //    }
        //    if (i + 1 <=width && matrix[i+1][j] == 0)
        //    {
        //        return false;
        //    }
        //    if (j-1>=0 && matrix[i][j-1] == 0)
        //    {
        //        return false;
        //    }
        //    if (j)
        //    {
        //    }
        //    return change;
        //}

        //private static bool checkZero(int[][] matrix)
        //{
        //    int height = matrix.Length, width = matrix[0].Length;
        //    for (int i = 0; i < height; i++)
        //    {
        //        for (int j = 0; j < width; j++)
        //        {
        //            if (matrix[i][j] != 0)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //45.2
        /*
            int[] arr = { 3, 2, 4, 3, 6 };
            Console.WriteLine(Microsoft.Q45.findMaxShare(arr));
            maxNum(arr);
         */
        public static int findMaxShare(int[] arr)
        {
            int length = arr.Length;
            //Get sum
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }
            //Loop from m to 1
            for (int m = length; m >= 1; m--)
            {
                if (sum % m != 0)
                {
                    continue;
                }
                //PackSack issue
                int[] ps = new int[length];
                if (testMaxShare(arr, m, ps, sum / m, sum / m, 1))
                {
                    return m;
                }

            }
            return 0;
        }

        private static bool testMaxShare(int[] arr, int m, int[] ps, int current_goal, int overall_goal, int group_id)
        {
            if (current_goal == 0)
            {
                current_goal = overall_goal;
                group_id = group_id + 1;
                if (group_id - 1 == m) return true;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (ps[i] != 0) continue;
                ps[i] = 1;
                if (testMaxShare(arr, m, ps, current_goal - arr[i], overall_goal, group_id))
                {
                    return true;
                }
                ps[i] = 0;
            }

            return false;
        }

        //revision:change a little same logical 12/4/2012
        static void maxNum(int[] arr)
        {
            int length = arr.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }
            for (int i = length; i >= 0; i--)
            {
                if (sum % i != 0)
                {
                    continue;
                }
                bool[] ps = new bool[length];
                if (success(arr, i, sum / i, sum / i, ps, 1))
                {
                    System.Console.WriteLine(i);
                    return;
                }
            }
        }

        static bool success(int[] arr, int m, int current_goal, int goal, bool[] ps, int group_id)
        {
            if (current_goal == 0)
            {
                current_goal = goal;
                ++group_id;
                if (group_id - 1 == m)
                {
                    return true;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (ps[i])
                {
                    continue;
                }
                ps[i] = true;
                if (success(arr, m, current_goal - arr[i], goal, ps, group_id))
                {
                    return true;
                }
                ps[i] = false;
            }
            return false;
        }
    }
}
