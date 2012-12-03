/*
 Console.WriteLine(Microsoft.Q19.getAntiRecursive(1000));
 */
namespace Algorithm.Microsoft
{
    class Q19
    {
        public static long getAntiRecursive(int n)
        {
            long left = 1;
            long right = 2;
            for (int i = 2; i < n; i++)
            {
                long next_right = left + right;
                left = right;
                right = next_right;
            }
            return right;
        }

        //revision:dp 12/1/2012
        static System.Collections.Hashtable ht = new System.Collections.Hashtable();
        public static long getAntiRecursiveDP(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            if (ht.ContainsKey(n))
            {
                return (long)ht[n];
            }
            else
            {
                ht.Add(n, getAntiRecursiveDP(n - 1) + getAntiRecursiveDP(n - 2));
            }
            return getAntiRecursiveDP(n - 1) + getAntiRecursiveDP(n - 2);
        }
    }
}
