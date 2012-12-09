/*
            Microsoft.Q93.printPivot(new int[] { 7, 2, 3, 10, 11, 44, 22 }); 
 */
namespace Algorithm.Microsoft
{
    class Q93
    {
        public static void printPivot(int[] arr)
        {
            int length = arr.Length, i;
            //find smallest

            int[] arr_small = new int[length];
            int smallest = arr[length - 1];
            arr_small[length - 1] = smallest;
            for (i = length - 1; i > 0; i--)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
                arr_small[i] = smallest;
            }


            int[] arr_big = new int[length];
            int biggest = arr[0];
            arr_big[0] = biggest;
            for (i = 1; i < length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
                arr_big[i] = biggest;
            }

            for (i = 1; i < length - 1; i++)
            {
                if (arr[i] >= arr_big[i] && arr[i] <= arr_small[i])
                {
                    System.Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
