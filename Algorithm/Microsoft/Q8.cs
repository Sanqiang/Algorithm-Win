
namespace Algorithm.Microsoft
{

    public class Q8
    {
        //3.1
        //reference to Algorithm.LinkedList.ReverseLinkedList

        //3.2

        //3.3
        //quick sort

        //3.4
        /*
            Console.WriteLine(Microsoft.Q8.findStrMatch("abc", "bcd"));
            Console.WriteLine(Microsoft.Q8.findStrMatch("abcd", "cd"));
            Console.WriteLine(Microsoft.Q8.findStrMatch("abc", "a"));
            Console.WriteLine(Microsoft.Q8.findStrMatch("abc", "x"));
         */
        public static bool findStrMatch(string str, string pattern)
        {
            if (pattern.Length > str.Length)
            {
                return false;
            }

            int pattern_index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == pattern[pattern_index])
                {
                    pattern_index++;
                    if (pattern_index == pattern.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    pattern_index = 0;
                }
            }

            return false;
        }

        //3.5
        /*
            Console.WriteLine(Microsoft.Q8.reverseStr("abcde"));
            Console.WriteLine(Microsoft.Q8.reverseStr("abcd"));
         */ 
        public static string reverseStr(string str)
        {
            int mid = str.Length / 2;
            char[] str_arr = str.ToCharArray();
            for (int i = 0; i < mid; i++)
            {
                char temp = str_arr[i];
                str_arr[i] = str_arr[str.Length -1 - i];
                str_arr[str.Length -1 - i] = temp;
            }
            return new string(str_arr);
        }

        //3.6
        /*
         Console.WriteLine(Microsoft.Q8.reverseSubStr("00abc00000",2,4));
         */ 
        public static string reverseSubStr(string str, int start, int end)
        {
            if (start >= end)
            {
                return str;
            }
            int mid = (start + end) / 2;
            char[] str_arr = str.ToCharArray();
            for (int i = start; i < mid; i++)
            {
                char temp = str_arr[i];
                str_arr[i] = str_arr[end - (i - start)];
                str_arr[end - (i - start)] = temp;
            }

            return new string(str_arr);
        }

        //3.7 same with 3.4

        //3.8 same with 3.4 and Algorithm.ArrayAndString.StringInclude

        //3.9 array count?

        //3.10
        /*
            Console.WriteLine(Microsoft.Q8.MultiplyBy8(2));
            Console.WriteLine(Microsoft.Q8.MultiplyBy7(2));
         */
        public static int MultiplyBy8(int n)
        {
            return n << 3;
        }

        public static int MultiplyBy7(int n)
        {
            return (n << 3) - n;
        }
    }
}
