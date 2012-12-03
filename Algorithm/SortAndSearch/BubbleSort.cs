/*
             double[] arr = {2,3,5,6,7,8,9,1,2,3,0.1,99,88,66,65 };
            SortAndSearch.BubbleSort.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class BubbleSort
    {
        public static void Sort(double[] arr)
        {
            int length = arr.Length, i ,j ;
            for ( i = 0; i < length; i++)
            {
                for ( j = i; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        swap(arr, i, j);
                    }
                }
            }
        }

        private static void swap(double[] arr, int i, int j)
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
