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
    public class InsertSort
    {

        public static void Sort(double[] arr)
        {
            int length = arr.Length, i, j;
            for (i = 1; i < length; i++)
            {
                for (j = i; j >= 0; j--)
                {
                    if (j - 1 >= 0 && arr[j] < arr[j - 1])
                    {
                        swap(arr, j - 1, j);
                    }
                }
            }
        }


        public static int[] Marcin_Ciura_Gap = { 701, 301, 132, 57, 23, 10, 4, 1 };
        public static void SortShell(double[] arr)
        {
            int length = arr.Length, i, j;
            foreach (int gap in Marcin_Ciura_Gap)
            {
                for (i = gap; i < length; i+=gap)
                {
                    for (j = i; j >= 0; j -= gap)
                    {
                        if (j - gap >= 0 && arr[j] < arr[j - gap])
                        {
                            swap(arr, j, j - gap);
                        }
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
