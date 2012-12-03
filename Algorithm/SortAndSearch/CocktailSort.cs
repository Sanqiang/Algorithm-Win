/*
             double[] arr = { 1,2,5,6,7,8,8,2,3,11,22,33,0.1,99};
            SortAndSearch.CocktailSort.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class CocktailSort
    {
        public static void Sort(double[] arr)
        {
            int s = 0, e = arr.Length - 1;
            while (s < e)
            {
                int i;
                for (i = s; i <= e; i++)
                {
                    if (i + 1 <= e && arr[i] > arr[i + 1])
                    {
                        swap(arr, i, i + 1);
                    }
                }
                --e;
                for (i = e; i >= s; i--)
                {
                    if (i - 1 >= s && arr[i - 1] > arr[i])
                    {
                        swap(arr, i, i - 1);
                    }
                }
                ++s;
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
