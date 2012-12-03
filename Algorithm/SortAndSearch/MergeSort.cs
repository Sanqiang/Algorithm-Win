/*
            double[] arr = { 5,4,3,2,1,8,7,4,2,3,21,1,1,6,7,8,-10 };
            Algorithm.SortAndSearch.MergeSort.Sort(arr);
            foreach (var r in arr)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
 */
using System;

namespace Algorithm.SortAndSearch
{
    //Reference to CC9_7
    public class MergeSort
    {
        public static void Sort(double[] arr)
        {
            Split(arr, 0, arr.Length - 1);
        }

        private static void Split(double[] arr, int left_index, int right_index)
        {
            if (right_index - left_index > 0)
            {
                int mid_index = (left_index + right_index) / 2;
                Split(arr, left_index, mid_index);
                Split(arr, mid_index+1, right_index);
                QuickS(arr, left_index, right_index, mid_index);
               
            }
        }

        private static void QuickS(double[] arr, int left_index, int right_index, int mid_index)
        {
            double[] left_arr = new double[mid_index - left_index + 1];//left to mid
            double[] right_arr = new double[right_index - (mid_index + 1) + 1];//mid+1 to right
            for (int i = 0; i < left_arr.Length; i++)
            {
                left_arr[i] = arr[left_index + i];
            }
            for (int i = 0; i < right_arr.Length; i++)
            {
                right_arr[i] = arr[mid_index + i + 1];
            }

            //Sort
            int l = 0, r = 0, k = left_index;
            while (true)
            {
                if (left_arr[l] >= right_arr[r])
                {
                    arr[k++] = right_arr[r++];
                }
                else if (left_arr[l] < right_arr[r])
                {
                    arr[k++] = left_arr[l++];
                }
                //Compensate
                if (l == left_arr.Length)
                {
                    for (; r < right_arr.Length; r++)
                    {
                        arr[k++] = right_arr[r];
                    }
                    break;
                }
                else if (r == right_arr.Length)
                {
                    for (; l < left_arr.Length; l++)
                    {
                        arr[k++] = left_arr[l];
                    }
                    break;
                }
            }
        }
    }
}

