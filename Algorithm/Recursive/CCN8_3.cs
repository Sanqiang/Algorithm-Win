/*
             int[] arr = { -1, 1, 4, 9, 10, 11, 20, 30 };
            Console.WriteLine(Recursive.CCN8_3.findMagicWithoutDuplicate(arr));
            Console.WriteLine(Recursive.CCN8_3.findMagicWithDuplicate(arr));
 */ 
namespace Algorithm.Recursive
{
    class CCN8_3
    {
        public static int findMagicWithoutDuplicate(int[] arr, int s = -999, int e = -999)
        {
            if (s == -999)
            {
                s = 0;
            }
            if (e == -999)
            {
                e = arr.Length - 1;
            }
            if (s > e)
            {
                return -1;
            }
            int m = (s + e) / 2;
            if (arr[m] == m)
            {
                return m;
            }
            else if (arr[m] > m)
            {
                return findMagicWithoutDuplicate(arr, s, m - 1);
            }
            else
            {
                return findMagicWithoutDuplicate(arr, m + 1, e);
            }
        }

        public static int findMagicWithDuplicate(int[] arr, int s = -999, int e = -999)
        {
            if (s == -999)
            {
                s = 0;
            }
            if (e == -999)
            {
                e = arr.Length - 1;
            }
            if (s > e || s < 0 || e > arr.Length - 1)
            {
                return -1;
            }
            if (s > e)
            {
                return -1;
            }
            int m = (s + e) / 2;
            if (arr[m] == m)
            {
                return m;
            }

            int LeftIndex = System.Math.Min(arr[m], m - 1);
            int l = findMagicWithDuplicate(arr, s, LeftIndex);
            if (l >= 0)
            {
                return l;
            }

            int RightIndex = System.Math.Max(arr[m], m + 1);
            int r = findMagicWithDuplicate(arr, RightIndex, e);
            return r;
        }
    }
}
