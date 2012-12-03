/*
             double[] large = { 1, 5, 10, 15, 20, 0, 0, 0, 0, 0 };
            double[] small = { 2, 7, 17, 100, 200 };
            SortAndSearch.CC9_1.MergeTwoSortedArray(large, small);
            foreach (var item in large)
            {
                Console.WriteLine(item);
            }

 */ 
namespace Algorithm.SortAndSearch
{
    class CC9_1
    {
        public static void MergeTwoSortedArray(double[] large, double[] small)
        {
            int overall_index = large.Length - 1;
            int small_index = small.Length - 1;
            int large_index = overall_index - small_index - 1;
            for (int i = overall_index; i >= 0; i--)
            {
                if (large_index < 0)
                {
                    while (i >= 0)
                    {
                        large[i--] = small[small_index--];
                    }
                    break;
                }
                if (small_index < 0)
                {
                    break;
                }
                if (large[large_index] >= small[small_index])
                {
                    large[i] = large[large_index--];
                }
                else
                {
                    large[i] = small[small_index--];
                }
            }
        }
    }
}
