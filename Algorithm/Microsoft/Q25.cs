/*
            Console.WriteLine(Microsoft.Q25.findLongestSeries("abcd12345ed125ss123456789"));
            Console.WriteLine(Microsoft.Q25.findLongestSequence("abcd12345ed125ss123456789"));
 */
namespace Algorithm.Microsoft
{
    class Q25
    {
        public static string findLongestSeries(string str)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            System.Text.StringBuilder loop = new System.Text.StringBuilder();
            loop.Append(str[0]);
            for (int i = 0; i < str.Length; i++)
            {
                if (i-1>=0 && str[i]==str[i-1]+1)
                {
                    loop.Append(str[i]);
                }
                else
                {
                    if (loop.Length>result.Length)
                    {
                        result = loop;
                    }
                    loop = new System.Text.StringBuilder();
                    loop.Append(str[i]);
                }
            }

            if (loop.Length > result.Length)
            {
                result = loop;
            }

            return result.ToString();
        }


        //revision:slighter space complexity 12/1/2012
        public static string findLongestSequence(string str)
        {
            int i = 1, length = str.Length, s = 0, e = 1, longest_s = 0, longest_e = 1;
            for (; i < length; i++)
            {
                if (str[i] - str[i - 1] == 1)
                {
                    e++;
                }
                else
                {
                    if (e - s > longest_e - longest_s)
                    {
                        longest_s = s;
                        longest_e = e;
                    }
                    s = i;
                    e = i;
                }
            }
            if (e - s > longest_e - longest_s)
            {
                longest_s = s;
                longest_e = e;
            }
            return str.Substring(longest_s, longest_e - longest_s + 1);
        }
    }
}
