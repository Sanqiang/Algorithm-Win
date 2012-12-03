/*
Console.WriteLine(ArrayAndString.KMP.KMPSearch("cabcababcabcababca", "abcababc"));
 */
namespace Algorithm.ArrayAndString
{
    class KMP
    {
        private static int[] NEXTSample(string pattern)
        {
            int[] tab = new int[pattern.Length];
            tab[0] = -1;
            for (int i = 1; i < pattern.Length; i++)
            {
                int j = tab[i - 1];
                while (tab[i] != tab[j + 1] && j >= 0)
                {
                    j = tab[j];
                }
                if (tab[i] == tab[j + 1]) tab[i] = j + 1;
                else tab[i] = 0;
            }
            return tab;
        }

        public static int KMPSearchSample(string text, string pattern)
        {
            int pos = 0, iter = -1;
            int[] tab = NEXTSample(pattern);
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                iter = i;
                pos = 0;
                while (iter < text.Length && pos < pattern.Length)
                {
                    if (pattern[pos] == text[iter])
                    {
                        ++pos; ++iter;
                    }
                    else
                    {
                        if (pos == 0) ++iter;
                        else pos = tab[pos - 1] + 1;
                    }
                }
                if (pos == pattern.Length && iter - i == pattern.Length) { ++count; }
            }
            return count;
        }


        //My implementation
        public static int KMPSearch(string text, string pattern)
        {
            int[] helper = NEXT(pattern);
            int i = 0, length = text.Length, count = 0;
            for (; i < length; i++)
            {
                int pos = 0;
                while (i < length)
                {
                    if (text[i] == pattern[pos])
                    {
                        if (pos == pattern.Length - 1)
                        {
                            count++;
                            break;
                        }
                        i++;
                        pos++;
                    }
                    else
                    {
                        if (pos > 0)
                        {
                            pos = helper[pos - 1];
                        }
                        else
                        {
                            pos = 0;
                        }
                        i++;
                    }
                }

            }

            return count;
        }

        private static int[] NEXT(string pattern)
        {
            int length = pattern.Length, i = 1, pos = 0;
            int[] helper = new int[length];
            while (i < length)
            {
                if (pattern[i] == pattern[pos])
                {
                    pos++;
                    helper[i] = pos;
                    i++;
                }
                else
                {
                    if (pos == 0)
                    {
                        helper[i] = pos;
                        i++;
                    }
                    else
                    {
                        pos--;
                    }
                }

            }
            return helper;
        }
    }
}
