/*
             double[] arr = { 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(SortAndSearch.HeapSearch.findNthBiggest(arr, 0));
 */ 
namespace Algorithm.SortAndSearch
{
    class HeapSearch
    {
        public static double findNthBiggest(double[] arr, int order)
        {
            double[] arr_clone = (double[])arr.Clone();

            for (int i = arr_clone.Length / 2 - 1; i >= 0; i--)
            {
                maxHeapify(arr_clone, i, arr_clone.Length);
            }

            for (int i = arr_clone.Length - 1; i >= 1; i--)
            {
                if (arr_clone.Length - 1 - i == order)
                {
                    return arr_clone[0];
                }
                swap(arr_clone, 0, i);
                maxHeapify(arr_clone, 0, i);
            }

            return double.MaxValue;

        }

        private static void maxHeapify(double[] arr, int i, int size)
        {
            int LargeIndex = i;
            int LeftChildIndex = getLeftChild(i);
            int RightChildIndex = getRightChild(i);

            if (LeftChildIndex < size && arr[LeftChildIndex] > arr[i])
            {
                LargeIndex = LeftChildIndex;
            }

            if (RightChildIndex < size && arr[RightChildIndex] > arr[i])
            {
                LargeIndex = RightChildIndex;
            }

            if (LargeIndex > i)
            {
                swap(arr, i, LargeIndex);
                maxHeapify(arr, LargeIndex, size);
            }

        }

        private static int getLeftChild(int i)
        {
            return 2 * i;
        }

        private static int getRightChild(int i)
        {
            return 2 * i + 1;
        }

        private static int getParent(int i)
        {
            return i / 2;
        }

        private static void swap(double[] arr, int i, int j)
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
