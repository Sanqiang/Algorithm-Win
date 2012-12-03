/*
             int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Microsoft.Q54.OddEvenExchange(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);   
            }
 */ 
namespace Algorithm.Microsoft
{
    class Q54
    {
        public static void OddEvenExchange(int[] arr)
        {
            OddEvenExchange(arr, isOdd);
        }

        public static void OddEvenExchange(int[] arr, isFunc callback)
        {
            int s = 0;
            int e = arr.Length - 1;
            while (s < e)
            {
                for (; s<e && (!callback(arr[e])); e--) ;
                for (; s < e && callback(arr[s]); s++) ;
                int temp = arr[e];
                arr[e] = arr[s];
                arr[s] = temp;
            }

        }

        public delegate bool isFunc(int n);
        private static bool isOdd(int n)
        {
            return (n & 1) > 0;
        }
    }
}
