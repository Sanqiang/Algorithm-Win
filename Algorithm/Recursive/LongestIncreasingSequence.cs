/*
             int[] arr = { 5, 2, 4, 3, 1 };
            Console.WriteLine(Recursive.LongestIncreasingSequence.solveBad(arr));
            Console.WriteLine(Recursive.LongestIncreasingSequence.solve(arr));
 */ 
namespace Algorithm.Recursive
{
    class LongestIncreasingSequence
    {
        public static int solve(int[] arr)
        {
            int length = arr.Length, i, j;
            int[] c = new int[length + 1], b = new int[length + 1];
            for (i = 0; i < length; i++)
            {
                c[i] = int.MaxValue;
            }
            c[0] = -1; c[1] = arr[0];
            //b[0] = 1;
            for (i = 1; i < length; i++)
            {
                j = BSearch(c, length + 1, arr[i]);
                c[j] = arr[i];
                //b[i] = j;
            }

            for (i = 1; i < length; i++)
            {
                if (c[i] == int.MaxValue)
                {
                    break;
                }
            }

            return i - 1;
        }

        private static int BSearch(int[] arr, int length, int target)
        {
            int s = 0, e = length, m = (s + e) / 2;
            while (s <= e)
            {
                if (arr[m] > target)
                {
                    e = m - 1;
                }
                else if (arr[m] < target)
                {
                    s = m + 1;
                }
                else
                {
                    return m;
                }
                m = (s + e) / 2;

            }
            return s;
        }

        public static int solveBad(int[] arr)
        {
            int length = arr.Length, i, j;
            int[] cache = new int[length];

            for (i = 1; i < length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i] && cache[j] + 1 > cache[i])
                    {
                        cache[i] = cache[j] + 1;
                    }
                }
            }

            int result = -1;
            for (i = 0; i < length; i++)
            {
                result = result < cache[i] ? cache[i] : result;
            }

            return result + 1;
        }
    }
}
