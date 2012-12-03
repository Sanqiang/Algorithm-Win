/*
             int[] arr = { 1,5,6,2};
            Microsoft.Q68.combineNumber(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.Microsoft
{
    class Q68
    {
        public static string combineNumber(int[] nums)
        {

            //HeapSort(nums);
            //QuickSort(nums);
            //MergeSort(nums);
            ShellSort(nums);
            //InsertSort(nums);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
            }
            return sb.ToString();
        }

        //Insert Sort
        public static void InsertSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 0;
                for (; j < i && compare(arr[j], arr[i]) == 1; j++) ;

                if (j < i)
                {
                    int InsertVal = arr[i];
                    for (int k = i - 1; k >= j; k--)
                    {
                        arr[k + 1] = arr[k];
                    }
                    arr[j] = InsertVal;
                }
            }
        }

        //Shell Sort
        public static void ShellSort(int[] arr)
        {
            foreach (int gap in SortAndSearch.InsertSort.Marcin_Ciura_Gap)
            {
                for (int i = gap; i < arr.Length; i += gap)
                {
                    int j = i % gap;
                    for (; j < i && compare(arr[j], arr[i]) == 1; j += gap) ;
                    if (j < i)
                    {
                        int InsertVal = arr[i];
                        for (int k = i - gap; k >= j; k -= gap)
                        {
                            arr[k + gap] = arr[k];
                        }
                        arr[j] = InsertVal;
                    }

                }
            }
        }

        //Merge Sort
        private static void MergeSort(int[] arr)
        {
            MiddleSplit(arr, 0, arr.Length - 1);
        }

        private static void MiddleSplit(int[] arr, int s, int e)
        {
            if (s < e)
            {
                int m = (s + e) / 2;
                MiddleSplit(arr, s, m);
                MiddleSplit(arr, m + 1, e);
                Merge(arr, s, e, m);
            }
        }

        private static void Merge(int[] arr, int s, int e, int m)
        {
            int[] left_arr = new int[m - s + 1];
            int[] right_arr = new int[e - (m + 1) + 1];
            for (int i = 0; i < left_arr.Length; i++)
            {
                left_arr[i] = arr[s + i];
            }
            for (int i = 0; i < right_arr.Length; i++)
            {
                right_arr[i] = arr[m + 1 + i];
            }
            int l = 0, r = 0, k = s;
            while (true)
            {
                if (l == left_arr.Length)
                {
                    while (r != right_arr.Length)
                    {
                        arr[k++] = right_arr[r++];
                    }
                    break;
                }
                else if (r == right_arr.Length)
                {
                    while (l != left_arr.Length)
                    {
                        arr[k++] = left_arr[l++];
                    }
                    break;
                }
                if (compare(left_arr[l], right_arr[r]) == 1)
                {
                    arr[k++] = left_arr[l++];
                }
                else
                {
                    arr[k++] = right_arr[r++];
                }
            }
        }

        //Quick Sort
        private static void QuickSort(int[] arr)
        {
            Split(arr, 0, arr.Length - 1);
        }

        private static void Split(int[] arr, int s, int e)
        {
            if (s < e)
            {
                int Pivot = Partition(arr, s, e);
                Split(arr, s, Pivot - 1);
                Split(arr, Pivot + 1, e);
            }
        }

        private static int Partition(int[] arr, int s, int e)
        {
            int PivotVal = arr[s];
            while (s < e)
            {
                for (; s < e && compare(arr[e], PivotVal) == -1; e--) ;
                arr[s] = arr[e];
                for (; s < e && compare(PivotVal, arr[s]) == -1; s++) ;
                arr[e] = arr[s];
            }
            arr[s] = PivotVal;
            return s;
        }

        //Heap Sort
        private static void HeapSort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                maxHeapify(arr, i, arr.Length);
            }

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                maxHeapify(arr, 0, i - 1);
            }
        }

        private static void maxHeapify(int[] arr, int i, int size)
        {
            int MaxChildIndex;
            bool finished = false;
            while (2 * i <= size && (!finished))
            {
                if (i * 2 == size)
                {
                    MaxChildIndex = i * 2;
                }
                else if (compare(arr[i * 2], arr[i * 2 + 1]) == -1)
                {
                    MaxChildIndex = i * 2;
                }
                else
                {
                    MaxChildIndex = i * 2 + 1;
                }

                if (compare(arr[MaxChildIndex], arr[i]) == -1)
                {
                    int temp = arr[i];
                    arr[i] = arr[MaxChildIndex];
                    arr[MaxChildIndex] = temp;
                    i = MaxChildIndex;
                }
                else
                {
                    finished = true;
                }
            }
        }

        //compare function
        private static int compare(int num1, int num2)
        {
            int i1 = int.Parse(num1 + "" + num2);
            int i2 = int.Parse(num2 + "" + num1);
            if (i1 > i2)
            {
                return 1;
            }
            else if (i1 < i2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
