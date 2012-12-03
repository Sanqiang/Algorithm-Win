/*
             string[] arr = { "aab","xml","10q0","baa","aba","q100","100q" };
            SortAndSearch.CC9_2.sortStringAnagram(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class CC9_2
    {
        public static void sortStringAnagram(string[] arr)
        {
            HelperQuickSortString(arr, 0, arr.Length - 1);
        }

        private static void HelperQuickSortString(string[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int Pivot = findPivot(arr, start, end);
            HelperQuickSortString(arr, start, Pivot - 1);
            HelperQuickSortString(arr, Pivot + 1, end);
        }

        private static int findPivot(string[] arr, int start, int end)
        {
            string PivotValue = arr[start];
            while (start < end)
            {
                for (; start < end && compareStr(arr[end], PivotValue) >= 0; end--) ;
                arr[start] = arr[end];
                for (; start < end && compareStr(PivotValue, arr[start]) >= 0; start++) ;
                arr[end] = arr[start];
            }
            arr[start] = PivotValue;
            return start;
        }

        private static int compareStr(string str1, string str2)
        {
            str1 = sortChar(str1);
            str2 = sortChar(str2);
            return str1.CompareTo(str2);
        }

        private static string sortChar(string str)
        {
            char[] char_arr = str.ToCharArray();
            HelperQuickSortChar(char_arr, 0, str.Length - 1);
            return new string(char_arr);
        }

        //Helper Method
        private static void HelperQuickSortChar(char[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int PivotIndex = findPivot(arr, start, end);
            HelperQuickSortChar(arr, start, PivotIndex - 1);
            HelperQuickSortChar(arr, PivotIndex + 1, end);
        }


        private static int findPivot(char[] arr, int start, int end)
        {
            char PivotValue = arr[start];
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
