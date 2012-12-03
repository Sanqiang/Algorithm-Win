/*
            SortAndSearch.CC9_7.HtWt[] arr = 
            {
                new SortAndSearch.CC9_7.HtWt(50,20),new SortAndSearch.CC9_7.HtWt(45,35),new SortAndSearch.CC9_7.HtWt(40,35),new SortAndSearch.CC9_7.HtWt(10,35),
                new SortAndSearch.CC9_7.HtWt(20,10),new SortAndSearch.CC9_7.HtWt(35,15),new SortAndSearch.CC9_7.HtWt(30,25),
                new SortAndSearch.CC9_7.HtWt(10,5),new SortAndSearch.CC9_7.HtWt(25,15),new SortAndSearch.CC9_7.HtWt(20,20),
            };
            System.Collections.Generic.List<SortAndSearch.CC9_7.HtWt> result = SortAndSearch.CC9_7.sortHtWt(arr);
            foreach (var item in result)
            {
                Console.WriteLine(item.height + "-" + item.weight);
            }
            Console.WriteLine("===============================================");
            System.Collections.Generic.List<SortAndSearch.CC9_7.HtWt> result2 = SortAndSearch.CC9_7.sortHtWtV5(arr);
            foreach (var item in result2)
            {
                Console.WriteLine(item.height + "-" + item.weight);
            }
 */
namespace Algorithm.SortAndSearch
{
    class CC9_7
    {
        public static System.Collections.Generic.List<HtWt> sortHtWt(HtWt[] arr)
        {
            //Step1:Sort By Merge
            SplitMerge(arr, 0, arr.Length - 1);

            //Step2: 2.5
            findUnfit(arr);
            return findLongest();
        }
        //Step2.5
        private static System.Collections.Generic.List<HtWt> findLongest()
        {
            System.Collections.Generic.List<HtWt> Longest = collection[0];
            foreach (System.Collections.Generic.List<HtWt> list in collection)
            {
                if (list.Count > Longest.Count)
                {
                    Longest = list;
                }
            }
            return Longest;
        }

        //Step2
        static System.Collections.Generic.List<System.Collections.Generic.List<HtWt>> collection = new System.Collections.Generic.List<System.Collections.Generic.List<HtWt>>();
        private static void findUnfit(HtWt[] arr, int UnfitIndex = 0)
        {
            System.Collections.Generic.List<HtWt> new_list = new System.Collections.Generic.List<HtWt>();
            bool AlreadyFind = true; int Unfit = -1;
            for (int i = UnfitIndex; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                {
                    if (isBefore(arr[i], arr[i + 1]))
                    {
                        new_list.Add(arr[i]);
                    }
                    else
                    {
                        if (AlreadyFind)
                        {
                            AlreadyFind = false;
                            Unfit = i + 1;
                        }
                    }
                }
                else
                {
                    new_list.Add(arr[i]);
                }
            }
            collection.Add(new_list);
            if (Unfit != -1)
            {
                findUnfit(arr, Unfit);
            }
        }

        private static bool isBefore(HtWt left, HtWt right)
        {
            if (left.height <= right.height && left.weight <= right.weight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Step1
        //Helper MergeSort
        private static void SplitMerge(HtWt[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                SplitMerge(arr, start, mid);
                SplitMerge(arr, mid + 1, end);
                Merge(arr, start, end, mid);
            }
        }

        private static void Merge(HtWt[] arr, int start, int end, int mid)
        {
            HtWt[] left_arr = new HtWt[mid - start + 1];
            HtWt[] right_arr = new HtWt[end - mid];
            for (int i = 0; i < left_arr.Length; i++)
            {
                left_arr[i] = arr[start + i];
            }
            for (int i = 0; i < right_arr.Length; i++)
            {
                right_arr[i] = arr[mid + 1 + i];
            }

            int l = 0, r = 0, k = start;
            while (true)
            {
                if (l > left_arr.Length - 1)
                {
                    while (r <= right_arr.Length - 1)
                    {
                        arr[k++] = right_arr[r++];
                    }
                    return;
                }
                if (r > right_arr.Length - 1)
                {
                    while (l <= left_arr.Length - 1)
                    {
                        arr[k++] = left_arr[l++];
                    }
                    return;
                }
                if (compareHtwt(left_arr[l], right_arr[r]) <= 0)
                {
                    arr[k++] = left_arr[l++];
                }
                else
                {
                    arr[k++] = right_arr[r++];
                }
            }
        }

        private static int compareHtwt(HtWt left, HtWt right)
        {
            if (left.height == right.height)
            {
                return 0;
            }
            else if (left.height > right.height)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public class HtWt
        {
            public double height;
            public double weight;
            public HtWt(double h, double w)
            {
                this.height = h;
                this.weight = w;
            }
            public bool isBefore(HtWt another)
            {
                return this.height <= another.height && this.weight <= another.weight;
            }
        }

        public static System.Collections.Generic.List<HtWt> sortHtWtV5(HtWt[] arr)
        {
            System.Array.Sort(arr, new HtwtComparer());
            System.Collections.Generic.List<HtWt>[] solutions = new System.Collections.Generic.List<HtWt>[arr.Length];
            buildSolutions(arr, solutions, 0);
            System.Collections.Generic.List<HtWt> longest_list = null;
            foreach (System.Collections.Generic.List<HtWt> list in solutions)
            {
                longest_list = getLongerList(longest_list, list);
            }
            return longest_list;

        }

        private static void buildSolutions(HtWt[] arr, System.Collections.Generic.List<HtWt>[] solutions,int current_index)
        {
            if (current_index > arr.Length-1)
            {
                return;
            }
            System.Collections.Generic.List<HtWt> longest_sequence = null;
            for (int i = current_index; i >= 0; i--)
            {
                if (arr[i].isBefore(arr[current_index]))
                {
                    longest_sequence = getLongerList(longest_sequence, solutions[i]);
                }
                
            }

            System.Collections.Generic.List<HtWt> new_solution = new System.Collections.Generic.List<HtWt>();
            if (longest_sequence!=null)
            {
                new_solution.AddRange(longest_sequence);
            }
            new_solution.Add(arr[current_index]);
            solutions[current_index] = new_solution;
            buildSolutions(arr, solutions, current_index + 1);
        }

        private static System.Collections.Generic.List<HtWt> getLongerList(System.Collections.Generic.List<HtWt> l1, System.Collections.Generic.List<HtWt> l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            return l1.Count > l2.Count ? l1 : l2;
        }

        class HtwtComparer : System.Collections.Generic.IComparer<HtWt>
        {
            public int Compare(HtWt x, HtWt y)
            {
                if (x.height == y.weight)
                {
                    if (x.weight > y.weight)
                    {
                        return 1;
                    }
                    else if (x.weight < y.weight)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (x.height > y.height)
                    {
                        return 1;
                    }
                    else if (x.height < y.height)
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
    }


}
