/*
             double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Microsoft.Q26.rotateRightArr(arr, 4);
            Microsoft.Q26.rotateLeftArr(arr, 4);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
 */ 
namespace Algorithm.Microsoft
{
    class Q26
    {
        public static void rotateRightArr(double[] arr, int offset)
        {
            int move = arr.Length - offset;
            swap(arr, 0, move - 1);
            swap(arr, move, arr.Length - 1);
            swap(arr, 0, arr.Length - 1);
        }

        public static void rotateLeftArr(double[] arr, int offset)
        {
            int move = offset;
            swap(arr, 0, move - 1);
            swap(arr, move, arr.Length - 1);
            swap(arr, 0, arr.Length - 1);
        }

        private static void swap(double[] arr, int begin, int end)
        {
            while (begin < end)
            {
                double temp = arr[begin];
                arr[begin] = arr[end];
                arr[end] = temp;
                begin++;
                end--;
            }
        }
    }
}
