
namespace Algorithm.Microsoft
{
    class Q83
    {
        //83.1
        /*
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Microsoft.Q83.sortOddEven(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
         */ 
        public static void sortOddEven(int[] arr)
        {
            int s =0,e=arr.Length-1;
            while (s<e)
            {
                for (; s < e && isOdd(arr[s]); s++) ;
                for (; s < e && (!isOdd(arr[e])); e--) ;
                int temp = arr[s];
                arr[s] = arr[e];
                arr[e] = temp;
            }
        }

        private static bool isOdd(int n)
        {
            return n % 2 == 1;
        }

        //83.2
    }
}
