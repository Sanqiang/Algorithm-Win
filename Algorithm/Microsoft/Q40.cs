/*
 Console.WriteLine(Microsoft.Q40.findSmallestPattern("AACABAAAABBCA","ABC"));
 */ 
namespace Algorithm.Microsoft
{
    class Q40
    {
        //40.1
        //reference to CC3.2

        //40.2
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
                            if (temp_len < smallest_pattern_right - smallest_pattern_left +1 )
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
                            int temp_len = index_right - index_left+1;
                            if (temp_len < smallest_pattern_right - smallest_pattern_left +1)
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
