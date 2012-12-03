/*
            double[] arr = { 15, 16, 19, 1, 3, 4, 10, 14 };
            Console.WriteLine(SortAndSearch.CC9_3.findIndexRotateArrayV5(arr, 14));
            Console.WriteLine(SortAndSearch.CC9_3.findIndexRotateArrayV5(arr, 15));
            Console.WriteLine(SortAndSearch.CC9_3.findIndexRotateArrayV5(arr, 4));
            Console.WriteLine(SortAndSearch.CC9_3.findIndexRotateArrayV5(arr, 99));
 */
namespace Algorithm.SortAndSearch
{
    class CC9_3
    {
        public static int findIndexRotateArrayV5(double[] arr, double target)
        {
            return findIndexRotateArray(arr, target, 0, arr.Length - 1);
        }

        private static int findIndexRotateArray(double[] arr, double target, int s, int e)
        {
            if (s > e)
            {
                return -1;
            }

            int m = (s + e) / 2;
            if (arr[m] == target)
            {
                return m;
            }

            if (arr[s] > arr[m]) //Right side in order
            {
                if (target >= arr[m] && target <= arr[e])
                {
                    return findIndexRotateArray(arr, target, m + 1, e);
                }
                else
                {
                    return findIndexRotateArray(arr, target, s, m - 1);
                }
            }
            else if (arr[s] < arr[m]) //Left side in order
            {
                if (target >= arr[s] && target <= arr[m])
                {
                    return findIndexRotateArray(arr, target, s, m - 1);
                }
                else
                {
                    return findIndexRotateArray(arr, target, m + 1, e);
                }
            }
            else
            {
                if (arr[m] != arr[e])
                {
                    return findIndexRotateArray(arr, target, m + 1, e);
                }
                else
                {
                    int resule = findIndexRotateArray(arr, target, s, m - 1);
                    if (resule == -1)
                    {
                        return findIndexRotateArray(arr, target, m + 1, e);
                    }
                    else
                    {
                        return resule;
                    }
                }
            }
        }
    }
}
