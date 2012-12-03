/*
             double[] arr1 = { 1, 4, 5, 800 };
            double[] arr2 = { 2, 3, 6, 700 };
            Console.WriteLine(Microsoft.Q32.findLeastDiff(arr1, arr2));
 */
namespace Algorithm.Microsoft
{
    class Q32
    {
        public static double findLeastDiff(double[] arr1, double[] arr2)
        {
            double[] arr = new double[arr1.Length+arr2.Length];
            System.Array.Copy(arr1,arr,arr1.Length);
            System.Array.Copy(arr2,0,arr,arr1.Length,arr2.Length);
            System.Array.Sort(arr);
            bool Even = false, Negative = true;
            double count = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (Even)
                {
                    count += (arr[i] - arr[i + 1]) * (Negative ? -1 : 1); 
                    Even = false;
                    Negative = !Negative;
                }
                else
                {
                    Even = true;
                }
            }
            return count;
        }
    }
}
