/*
            System.Collections.Generic.List<int> arr = new System.Collections.Generic.List<int>();
            //arr.AddRange(new int[] { 0, 1,2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16 });
            arr.AddRange(new int[] { 0, 2});
            //Console.WriteLine(BitManipulation.CC5_7.findMissing(arr));
            Console.WriteLine(BitManipulation.CC5_7.findMissingV5(arr));
 */
namespace Algorithm.BitManipulation
{
    public class CC5_7
    {
        /* ERROR
        public static int findMissing(System.Collections.Generic.List<int> arr)
        {
            int threshold = (int)System.Math.Log(arr[arr.Count - 1], 2);
            return findMissing(arr, 0, threshold);
        }

        private static int findMissing(System.Collections.Generic.List<int> current_arr, int current_digit, int limit)
        {
            if (current_arr.Count == 1)
            {
                return fetch(current_arr, 0, current_digit) ? 0 : 1;
            }
            System.Collections.Generic.List<int> zero_list = new System.Collections.Generic.List<int>();
            System.Collections.Generic.List<int> one_list = new System.Collections.Generic.List<int>();
            for (int i = 0; i < current_arr.Count; i++)
            {
                if (fetch(current_arr, i, current_digit))
                {
                    one_list.Add(current_arr[i]);
                }
                else
                {
                    zero_list.Add(current_arr[i]);
                }
            }
            if (one_list.Count > zero_list.Count)
            {
                return (findMissing(zero_list, current_digit + 1, limit) << 1) | 0;
            }
            else
            {
                return (findMissing(one_list, current_digit + 1, limit) << 1) | 1;
            }
        }
        */
        private static bool fetch(System.Collections.Generic.List<int> list, int index, int digit)
        {
            int n = list[index];
            return ((1 << digit) & n) > 0;
        }

        public static int findMissingV5(System.Collections.Generic.List<int> arr, int current = 0, int limit = -1)
        {
            if (limit == -1)
            {
                //limit = (int)System.Math.Log(arr[arr.Count - 1], 2);
                limit = sizeof(int) * 8 - 1;
            }

            if (arr.Count == 0)
            {
                //accelerater
                return 0;
            }

            if (current == limit)
            {
                return 0;
            }

            System.Collections.Generic.List<int> ZeroList = new System.Collections.Generic.List<int>();
            System.Collections.Generic.List<int> OneList = new System.Collections.Generic.List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (fetch(arr, i, current))
                {
                    OneList.Add(arr[i]);
                }
                else
                {
                    ZeroList.Add(arr[i]);
                }
            }

            if (OneList.Count >= ZeroList.Count)
            {
                int v = findMissingV5(ZeroList, current + 1);
                return (v << 1 | 0);
            }
            else
            {
                int v = findMissingV5(OneList, current + 1);
                return (v << 1 | 1);
            }
        }
    }
}
