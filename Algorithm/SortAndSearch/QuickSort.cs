using System;

namespace Algorithm.SortAndSearch
{
    public class QuickSort
    {
        public static void Sort(double[] arr)
        {
            MergeRecursive(arr, 0, arr.Length - 1);
        }

        private static void MergeRecursive(double[] arr, int left_index, int right_index)
        {
            //
            if (left_index >= right_index)
            {
                return;
            }
            //
            int mid = MergeAlgorithm(arr, left_index, right_index);
            //if (left_index<right_index)
            //{
            MergeRecursive(arr, left_index, mid - 1);
            MergeRecursive(arr, mid + 1, right_index);
            //}

        }

        private static int MergeAlgorithm(double[] arr, int left_index, int right_index)
        {
            if (left_index < right_index)
            {
                int pivot_index = left_index;
                double Pivot = arr[pivot_index];
                while (left_index < right_index)
                {
                    while (arr[right_index] >= Pivot && left_index < right_index)
                    {
                        right_index--;
                    }
                    arr[left_index] = arr[right_index];
                    while (arr[left_index] <= Pivot && left_index < right_index)
                    {
                        left_index++;
                    }
                    arr[right_index] = arr[left_index];
                }
                arr[left_index] = Pivot;
            }
            return left_index;
        }
    }
}

