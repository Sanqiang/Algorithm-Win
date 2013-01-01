/*
            double[] arr = { 2, 3, 1, 9, 5, 10, 7, 4, 11 };
            Console.WriteLine(SortAndSearch.NthBiggest.findNthBiggest(arr, 2));
            double[] arr2 = { 2, 3, 1, 9, 5, 10, 7, 4, 11 };
            double[] heap = SortAndSearch.NthBiggest.findNthBiggest2(arr2, 4);
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            } 
            double[] arr3 = { 2, 3, 1, 9, 5, 10, 7, 4, 11 };
            SortAndSearch.NthBiggest.findNthBiggest3(arr3, 3);
            Console.WriteLine("=====");
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            } 
 */
namespace Algorithm.SortAndSearch
{
    class NthBiggest
    {
        //Quick Sort
        public static double findNthBiggest(double[] arr, int k)
        {
            int PivotIndex = findPivot(arr, 0, arr.Length - 1);
            while (true)
            {
                if (PivotIndex == k)
                {
                    return arr[PivotIndex];
                }
                else if (PivotIndex > k)
                {
                    PivotIndex = findPivot(arr, 0, PivotIndex - 1);
                }
                else if (PivotIndex < k)
                {
                    PivotIndex = findPivot(arr, PivotIndex + 1, arr.Length - 1);
                }
            }
        }

        private static int findPivot(double[] arr, int start_index, int end_index)
        {
            double PivotValue = arr[start_index];
            bool tranfer = false;
            int StoreIndex = start_index;
            for (int i = start_index; i <= end_index; i++)
            {
                if (arr[i] > PivotValue)
                {
                    swap(arr, i, StoreIndex);
                    StoreIndex++;
                    tranfer = true;
                }
            }
            return tranfer ? StoreIndex - 1 : StoreIndex;
        }

        private static void swap(double[] arr, int x, int y)
        {
            double temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        //Max Heap
        public static double[] findNthBiggest2(double[] arr, int k)
        {
            double[] heap = new double[k];
            int i = 0, length = arr.Length;
            for (; i < k; i++)
            {
                heap[i] = arr[i];
            }
            makeMinHeap(heap);
            for (; i < length; i++)
            {
                if (arr[i] > heap[0])
                {
                    heap[0] = arr[i];
                    minHeapify(heap, 0, k);
                }
            }
            return heap;
        }

        private static void minHeapify(double[] arr, int i, int size)
        {
            int left = getLeftChild(i);
            int right = getRightChild(i);
            int BiggestIndex = i;
            if (left < size && arr[left] < arr[BiggestIndex])
            {
                BiggestIndex = left;
            }
            if (right < size && arr[right] < arr[BiggestIndex])
            {
                BiggestIndex = right;
            }
            if (BiggestIndex != i)
            {
                swap(arr, i, BiggestIndex);
                minHeapify(arr, BiggestIndex, size);
            }
        }

        private static void makeMinHeap(double[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                minHeapify(arr, i, arr.Length);
            }
        }

        private static int getLeftChild(int x) { return x * 2 + 1; }
        private static int getRightChild(int x) { return x * 2 + 2; }

        //Random Selection Revision 1/1/2013
        /*
                     double[] arr_a = { 2, 3, 1, 9, 5, 10, 7, 4, 11 };
            SortAndSearch.NthBiggest.findNthBiggest4(arr_a, 3);
            foreach (var item in arr_a)
            {
                Console.WriteLine(item);   
            }
         */ 
        public static void findNthBiggest4(double[] arr, int k)
        {
            findNThBiggestHelper(arr, 0, arr.Length - 1, k);
        }

        public static void findNThBiggestHelper(double[] arr, int s, int e, int k)
        {
            int pivot_index = new System.Random().Next(s, e);
            double pivot = arr[pivot_index];
            int left_end = NthBiggestHelperPartition(arr, s, e, pivot);
            int left_size = left_end - s + 1;
            if (left_size == k)
            {
                return;
            }
            else if (left_size > k)
            {
                findNThBiggestHelper(arr, s, left_end, k);
            }
            else if (left_size < k)
            {
                findNThBiggestHelper(arr, left_end + 1, e, k - left_size);
            }


        }

        private static int NthBiggestHelperPartition(double[] arr, int s, int e, double pivot)
        {
            while (true)
            {
                for (; s <= e && arr[s] >= pivot; ++s) ;
                for (; s <= e && arr[e] <= pivot; --e) ;
                if (s > e)
                {
                    return s - 1;
                }
                swap(arr, s, e);
            }
        }


        //Random Selection
        public static double[] findNthBiggest3(double[] arr, int k)
        {
            int low = 0, high = arr.Length - 1, i;
            --k;
            while (low < high)
            {
                int r = low + new System.Random().Next(high - low + 1);
                swap(arr, r, low);
                int runner = low;
                for (i = low + 1; i <= high; i++)
                {
                    if (arr[i] > arr[low])
                    {
                        swap(arr, ++runner, i);
                    }
                }
                swap(arr, runner, low);
                if (runner == k)
                {
                    return arr;
                }
                else if (runner > k)
                {
                    high = runner - 1;
                }
                else
                {
                    low = runner + 1;
                }
            }

            return arr;
        }
    }
}
