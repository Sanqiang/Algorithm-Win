/*
             double[] arr = { 1, 2, 4, 7, 11, 15 };
            double[] result = Microsoft.Q14.findTwoIndex(arr, 9);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.Microsoft
{
    class Q14
    {
        public static double[] findTwoIndex(double[] arr, double sum)
        {
            double[] result = new double[2];
            int begin = 0;
            int end = arr.Length - 1;
            while (begin < end)
            {
                double current_sum = arr[begin] + arr[end];
                if (current_sum == sum)
                {
                    result[0] = begin;
                    result[1] = end;
                    return result;
                }
                else if (current_sum > sum)
                {
                    --end;
                }
                else
                {
                    ++begin;
                }
            }

            return result;
        }

        //revision:print all 12/1/2012
        /*
         
            int[] arr = { 1, 2, 4, 7, 11, 12, 13, 15 };
            getSum(arr, 14);
         */ 
        public static void getSum(int[] arr, int sum)
        {
            int i = 0, length = arr.Length, left, right;
            for (; i < length / 2; i++)
            {
                left = arr[i];
                right = BSearch(arr, i + 1, length - 1, sum - left);
                if (right != -1)
                {
                    System.Console.WriteLine(left + "+" + right);
                }
            }
        }

        private static int BSearch(int[] arr, int s, int e, int target)
        {
            int m;
            while (s <= e)
            {
                m = (s + e) / 2;
                if (arr[m] == target)
                {
                    return target;
                }
                else if (target < arr[m])
                {
                    e = m - 1;
                }
                else if (target > arr[m])
                {
                    s = m + 1;
                }
            }
            return -1;
        }
    }
}
