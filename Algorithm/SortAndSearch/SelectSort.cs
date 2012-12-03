/*
             double[] arr = { 5, 7, 6, 8, 9, 1, 7, 4, 2, 0, 3, 4, 5, 6, 5, 7, 2, 8, 7 };
            //SortAndSearch.InsertSort.Sort(arr);
            SortAndSearch.InsertSort.SortShell(arr);
            //SortAndSearch.SelectSort.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class SelectSort
    {
        public static void Sort(double[] arr)
        {
            int length = arr.Length, i, j,k;
            for (i = 0; i < length; i++)
            {
                k = i;
                for (j = i + 1; j < length; j++)
                {
                    if (arr[k] > arr[j])
                    {
                        k = j;
                    }
                }

                if (i != k )
                {
                    swap(arr, i, k);
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
