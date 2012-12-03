/*
             string[] arr = { "a", "", "c", "", "", "", "", "q", "", "", "" };
            Console.WriteLine(SortAndSearch.CC9_5.BinarySearchOnString(arr, "q"));
            Console.WriteLine(SortAndSearch.CC9_5.BinarySearchOnString(arr, "a"));
            Console.WriteLine(SortAndSearch.CC9_5.BinarySearchOnString(arr, "w"));
 */ 
namespace Algorithm.SortAndSearch
{
    class CC9_5
    {
        public static int BinarySearchOnString(string[] arr, string target, int start = -1, int end = -1)
        {
            if (start == -1)
            {
                start = 0;
            }
            if (end == -1)
            {
                end = arr.Length - 1;
            }
            if (start >= end)
            {
                return -1;
            }
            int mid = findNonEmptyValueArround(arr, (start + end) / 2);

            string MidValue = arr[mid];

            if (MidValue.Equals(target))
            {
                return mid;
            }
            if (mid == start || mid == end)
            {
                return -1;
            }
            return compareString(MidValue, target) >= 0 ? BinarySearchOnString(arr, target, start, mid) : BinarySearchOnString(arr, target, mid, end);
        }

        private static int compareString(string str1, string str2)
        {
            return str1[0].CompareTo(str2[0]);
        }

        private static int findNonEmptyValueArround(string[] arr, int index, bool direct = true, int pos = 0)
        {
            int current_index = direct ? index + pos : index - pos;
            if (current_index >= 0 && current_index < arr.Length - 1)
            {
                if (!string.IsNullOrEmpty(arr[current_index]))
                {
                    return current_index;
                }
            }

            if (direct)
            {
                pos++;
                direct = false;
                return findNonEmptyValueArround(arr, index, direct, pos);
            }
            else
            {
                direct = true;
                return findNonEmptyValueArround(arr, index, direct, pos);
            }
        }
    }
}
