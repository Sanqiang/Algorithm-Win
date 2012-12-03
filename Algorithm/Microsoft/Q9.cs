/*
             double[] correct = { 5, 7, 6, 9, 11, 10, 8 };
            double[] error = { 7, 4, 6, 5 };
            Console.WriteLine(Microsoft.Q9.verifyPostTrav(correct));
            Console.WriteLine(Microsoft.Q9.verifyPostTrav(error));
 */ 
namespace Algorithm.Microsoft
{
    class Q9
    {
        public static bool verifyPostTrav(double[] arr)
        {
            return verifyPostTrav(arr, 0, arr.Length - 1);
        }

        private static bool verifyPostTrav(double[] arr, int start, int end)
        {
            if (end - start <= 0)
            {
                return true;
            }


            double root = arr[end];

            int right_part_start = start;
            for (; isInBound(arr, right_part_start) && arr[right_part_start] < root && right_part_start < end; right_part_start++) ;

            for (int i = right_part_start + 1; i < end; i++)
            {
                if (arr[i] < root)
                {
                    return false;
                }
            }
            return verifyPostTrav(arr, start, right_part_start - 1) && verifyPostTrav(arr, right_part_start, end - 1);

        }

        private static bool isInBound(double[] arr, int index)
        {
            if (index >= 0 && index <= arr.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Clear structure 11/30/2012
        public static bool verifyPostTrav2(int[] arr, int s, int e)
        {
            if (s >= e)
            {
                return true;
            }
            bool result = true;
            int i = s;
            for (; i < e && arr[i] < arr[e]; i++) ;
            result &= verifyPostTrav2(arr, s, i - 1);
            int pos = i;
            for (; i < e && arr[i] > arr[e]; i++) ;
            result &= verifyPostTrav2(arr, pos, e - 1);
            if (i != e)
            {
                return false;
            }
            else
            {
                return result;
            }
        }
    }
}
