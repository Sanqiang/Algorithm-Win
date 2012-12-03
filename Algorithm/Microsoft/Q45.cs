
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
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    int sum = 0;

                    if (i - 1 >= 0)
                    {
                        sum += matrix[i - 1][j];
                    }
                    if (i + 1 <= matrix.Length - 1)
                    {
                        sum += matrix[i + 1][j];
                    }
                    if (j - 1 >= 0)
                    {
                        sum += matrix[i][j - 1];
                    }
                    if (j + 1 <= matrix[0].Length - 1)
                    {
                        sum += matrix[i][j + 1];
                    }
                    if (sum < matrix[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //45.2
        /*
                     int[] arr = { 3, 2, 4, 3, 6 };
            Console.WriteLine(Microsoft.Q45.findMaxShare(arr));
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
                arr[i] = 1;
                if (testMaxShare(arr, m, ps, current_goal - arr[i], overall_goal, group_id))
                {
                    return true;
                }
                arr[i] = 0;
            }

            return false;
        }
    }
}
