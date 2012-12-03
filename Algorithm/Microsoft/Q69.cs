/*
             //int[] arr = {6,7,8,1,2,3,4,5};
            int[] arr = { 3, 4, 5, 6, 1, 2 };
            Console.WriteLine( Microsoft.Q69.findSmallestInRotateArray(arr));
 */ 
namespace Algorithm.Microsoft
{
    class Q69
    {
        //reference to CC9_3
        public static int findSmallestInRotateArray(int[] arr)
        {
            return findSmallestInRotateArray(arr, 0, arr.Length - 1);
        }

        private static int findSmallestInRotateArray(int[] arr, int s, int e)
        {
            if (e - s <= 1)
            {
                return arr[e] > arr[s] ? arr[s] :arr[e];
            }
            int m = (s + e) / 2;
            if (arr[s] < arr[m]) //meas left side in order
            {
                return findSmallestInRotateArray(arr, m+1, e);
            }
            else if (arr[s] > arr[m]) //means right side in order
            {
                return findSmallestInRotateArray(arr, s, m);
            }
            else
            {
                if (arr[m] == arr[e])
                {
                    return arr[m + 1];
                }
                else
                {
                    return arr[s];
                }
            }
        }
    }
}
