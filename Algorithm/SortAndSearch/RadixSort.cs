/*
             int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            //SortAndSearch.RadixSort.SampleSort(arr, 1);
            SortAndSearch.RadixSort.Sort(arr, 1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class RadixSort
    {
        public static void Sort(int[] arr, int digit)
        {
            int d, length = arr.Length, i;
            for (d = 1; d <= digit; d++)
            {
                int[] Bucket = new int[10];

                for (i = 0; i < length; i++)
                {
                    int CurrentDigit = arr[i] / (int)System.Math.Pow(10, d - 1) - arr[i] / (int)System.Math.Pow(10, d) * 10;
                    Bucket[CurrentDigit]++;
                }

                for (i = 1; i < 10; i++)
                {
                    Bucket[i] += Bucket[i - 1];
                }

                int[] temp = new int[length];

                for (i = 0; i < length; i++)
                {
                    int CurrentDigit = arr[i] / (int)System.Math.Pow(10, d - 1) - arr[i] / (int)System.Math.Pow(10, d) * 10;
                    temp[Bucket[CurrentDigit] - 1] = arr[i];
                    Bucket[CurrentDigit]--;
                }

                for (i = 0; i < length; i++)
                {
                    arr[i] = temp[i];
                }
            }
        }


        //Sample
        public static int[] SampleSort(int[] ArrayToSort, int digit)
        {
            //low to high digit
            for (int k = 1; k <= digit; k++)
            {
                //temp array to store the sort result inside digit
                int[] tmpArray = new int[ArrayToSort.Length];

                //temp array for countingsort
                int[] tmpCountingSortArray = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                //CountingSort
                for (int i = 0; i < ArrayToSort.Length; i++)
                {
                    //split the specified digit from the element
                    int tmpSplitDigit = ArrayToSort[i] / (int)System.Math.Pow(10, k - 1) - (ArrayToSort[i] / (int)System.Math.Pow(10, k)) * 10;
                    tmpCountingSortArray[tmpSplitDigit] += 1;
                }

                for (int m = 1; m < 10; m++)
                {
                    tmpCountingSortArray[m] += tmpCountingSortArray[m - 1];
                }

                //output the value to result
                for (int n = ArrayToSort.Length - 1; n >= 0; n--)
                {
                    int tmpSplitDigit = ArrayToSort[n] / (int)System.Math.Pow(10, k - 1) - (ArrayToSort[n] / (int)System.Math.Pow(10, k)) * 10;
                    tmpArray[tmpCountingSortArray[tmpSplitDigit] - 1] = ArrayToSort[n];
                    tmpCountingSortArray[tmpSplitDigit] -= 1;
                }

                //copy the digit-inside sort result to source array
                for (int p = 0; p < ArrayToSort.Length; p++)
                {
                    ArrayToSort[p] = tmpArray[p];
                }
            }

            return ArrayToSort;
        }
    }
}
