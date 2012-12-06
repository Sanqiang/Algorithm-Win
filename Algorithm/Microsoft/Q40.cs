/*
            Console.WriteLine(Microsoft.Q40.findSmallestPattern("AACABAAAABBCA", "ABC"));
            Console.WriteLine(Microsoft.Q40.findSmallestPattern2("AACABAAAABBCA", "ABC"));
 */
namespace Algorithm.Microsoft
{
    class Q40
    {
        //40.1
        //reference to CC3.2

        //40.2
        //revision: new idea the % 12/4/2012
        public static string findSmallestPattern2(string str, string pattern)
        {
            int left = 0, right = 0, length = str.Length, short_left = 0, short_length = str.Length;
            int[] checker = new int[0xff];
            while (left < length)
            {
                while (!isFulfill(pattern, checker))
                {
                    if (left == 0 && right == length)
                    {
                        return "Not Found";
                    }

                    ++checker[str[right % length]];
                    ++right;
                }
                while (isFulfill(pattern, checker))
                {
                    --checker[str[left % length]];
                    ++left;
                }

                if (short_length > right - left + 1)
                {
                    short_left = left - 1; length = right - left + 1;
                }
            }
            return str.Substring(short_left % length, length);
        }

        private static bool isFulfill(string pattern, int[] checker)
        {
            foreach (char c in pattern)
            {
                if (checker[c] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Bad
        public static string findSmallestPattern(string str, string pattern)
        {
            int smallest_pattern_left = 0;
            int smallest_pattern_right = str.Length - 1;
            int[] tab = new int[0xff];
            int index_left = 0;
            int index_right = 0;
            bool state1 = true;
            int temp_pattern_count = 0;
            while (index_right != str.Length)
            {
                if (state1)
                {
                    if (tab[str[index_right] - 'A']++ == 0)
                    {
                        temp_pattern_count++;
                        if (temp_pattern_count == pattern.Length)
                        {
                            state1 = false;
                            int temp_len = index_right - index_left + 1;
                            if (temp_len < smallest_pattern_right - smallest_pattern_left + 1)
                            {
                                smallest_pattern_left = index_left;
                                smallest_pattern_right = index_right;
                            }
                            continue;
                        }
                    }
                    index_right++;
                }
                else
                {
                    if (tab[str[index_left] - 'A'] == 1)
                    {
                        tab[str[index_left] - 'A']--;
                        temp_pattern_count--;
                        state1 = true;
                        index_left++;
                        index_right++;
                    }
                    else if (tab[str[index_left] - 'A'] > 1)
                    {
                        tab[str[index_left] - 'A']--;
                        index_left++;
                        if (temp_pattern_count == pattern.Length)
                        {
                            int temp_len = index_right - index_left + 1;
                            if (temp_len < smallest_pattern_right - smallest_pattern_left + 1)
                            {
                                smallest_pattern_left = index_left;
                                smallest_pattern_right = index_right;
                            }
                        }
                    }
                }
            }
            return str.Substring(smallest_pattern_left, smallest_pattern_right - smallest_pattern_left + 1);
        }

        //40.3
        //Bayers
    }
}
