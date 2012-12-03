/*
             double[] arr = {1,3,5,7,9,
                              2,4,6,8,10,
                              1.5,2.5,4.5,6.5,8.5,
                              100,200,300,400,500,
                              1.1,1.2,1.3,1.4,1.5
                              ,1.9,1.8,1.7,1.6,1.5,
                              0.9,3.8,5.8,6.9,999,
                       };
            arr =  SortAndSearch.CC9_4.sortBigArray(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class CC9_4
    {
        public static System.Collections.Generic.List<double[]> DiskList = new System.Collections.Generic.List<double[]>();
        public static int MemorySize = 5;
        public static double[] sortBigArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i += MemorySize)
            {
                double[] new_arr = new double[MemorySize];
                if (arr.Length - i > MemorySize)
                {
                    System.Array.Copy(arr, i, new_arr, 0, MemorySize);
                }
                else
                {
                    System.Array.Copy(arr, i, new_arr, 0, arr.Length - i);
                }
                SortMemoryArray(new_arr, 0, new_arr.Length - 1);
                DiskList.Add(new_arr);
            }
            //Merge
            double[] result = new double[arr.Length];
            int MergeIndex = -1;
            foreach (double[] DiskFile in DiskList)
            {
                mergeSortedArray(result, DiskFile, MergeIndex );
                MergeIndex += MemorySize;
            }
            return result;
        }

        //Merge Sort
        private static void mergeSortedArray(double[] large, double[] small, int large_index)
        {
            int overall_index = small.Length + large_index;
            int small_index = small.Length - 1;
            for (int i = overall_index; i >= 0; i--)
            {
                if (large_index < 0)
                {
                    while (small_index >= 0)
                    {
                        large[i--] = small[small_index--];
                    }
                    return;
                }
                if (small_index < 0)
                {
                    return;
                }
                if (large[large_index] >= small[small_index])
                {
                    large[i] = large[large_index];
                    large_index--;
                }
                else
                {
                    large[i] = small[small_index];
                    small_index--;
                }
            }
        }

        //QuickSort
        private static void SortMemoryArray(double[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int Pivot = findPivotInMemoryArray(arr, start, end);
            SortMemoryArray(arr, start, Pivot - 1);
            SortMemoryArray(arr, Pivot + 1, end);
        }
        private static int findPivotInMemoryArray(double[] arr, int start, int end)
        {
            double PivotValue = arr[start];
            while (start < end)
            {
                for (; start < end && arr[end] >= PivotValue; end--) ;
                arr[start] = arr[end];
                for (; start < end && arr[start] <= PivotValue; start++) ;
                arr[end] = arr[start];
            }
            arr[start] = PivotValue;
            return start;
        }
    }
}
