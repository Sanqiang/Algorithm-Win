/*
             double[] arr = { 9,4,3,2,5,4,3,2 };
            Console.WriteLine(Microsoft.Q47.findMaxDescending(arr));
 */
namespace Algorithm.Microsoft
{
    public class Q47
    {
        //reference to Algorithm.Recursive.LongestIncreasingSequence

        //revision:dp 12/5/2012
        public static void findlongestdecrease(int[] arr, bool faster)
        {
            int length = arr.Length;
            if (faster)
            {
                System.Array.Reverse(arr);
                int[] record = new int[length + 1];
                record[0] = -1; record[1] = arr[0];
                for (int i = 1; i < length; i++)
                {
                    int j = BSearchForFaster(record, arr[i]);
                    record[j] = arr[i];
                }
            }
            else
            {
                int[] record = new int[length];
                for (int i = 1; i < length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j] && record[j] + 1 > record[i])
                        {
                            record[i] = record[j] + 1;
                        }
                    }
                }
            }
        }

        private static int BSearchForFaster(int[] arr, int target)
        {
            int s = 0, e = arr.Length - 1, m = (s + e) / 2;
            while (s <= e)
            {
                m = (s + e) / 2;
                if (target == arr[m])
                {
                    return m;
                }
                if (target > arr[m])
                {
                    s = m + 1;
                }
                else if (target < arr[m])
                {
                    e = m - 1;
                }
            }
            return s;

        }

        //worst
        public static int findMaxDescending(double[] arr)
        {
            int[] tab = new int[arr.Length];
            int MaxDescending = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                tab[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j] && tab[j] + 1 > tab[i])
                    {
                        tab[i] = tab[j] + 1;
                        if (tab[i] > MaxDescending)
                        {
                            MaxDescending = tab[i];
                        }
                    }
                }
            }
            return MaxDescending;
        }
    }
}
