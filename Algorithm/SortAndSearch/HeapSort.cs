/*
            double[] arr = { 9, 7, 5, 3, 1, 8, 6, 4, 2, 4, 5, 6, 2, 12, 41, 0.1, 2, 3, 99 };
            SortAndSearch.HeapSort.sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */
namespace Algorithm.SortAndSearch
{
    public class HeapSort
    {
        public static void sort(double[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                maxHeapify(arr, i, arr.Length);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                swap(arr, i, 0);
                maxHeapify(arr, 0, i);
            }
        }

        private static void maxHeapify(double[] arr, int i, int size)
        {
            int MaxChildIndex = i;
            int l = getLeftChild(i);
            int r = getRightChild(i);

            if (l < size && arr[l] > arr[MaxChildIndex])
            {
                MaxChildIndex = l;
            }

            if (r < size && arr[r] > arr[MaxChildIndex])
            {
                MaxChildIndex = r;
            }

            if (MaxChildIndex != i)
            {
                swap(arr, MaxChildIndex, i);
                maxHeapify(arr, MaxChildIndex, size);
            }

        }

        private static void swap(double[] arr, int i, int j)
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static int getLeftChild(int i)
        {
            return 2 * i + 1;
        }

        private static int getRightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
