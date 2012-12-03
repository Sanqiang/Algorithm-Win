/*
             Console.WriteLine(Microsoft.Q10.reserveWordEx("I am Student."));
            Console.WriteLine(Microsoft.Q10.reserveWord("I am SuperMAN."));
 */ 
namespace Algorithm.Microsoft
{
    class Q10
    {
        public static string reserveWord(string str)
        {
            char[] result = new char[str.Length];
            int begin = -1, end = -1, index = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (end == -1 && str[i] == ' ')
                {
                    continue;
                }
                if (end == -1)
                {
                    end = i;
                    continue;
                }

                if (str[i] == ' ')
                {
                    begin = i +1;
                    if (begin != -1 && end != -1)
                    {
                        while (begin <= end)
                        {
                            result[index++] = str[begin++];
                        }
                        result[index++] = ' ';
                        begin = -1;
                        end = -1;
                    }
                }
            }

            for (int i = 0; i <= end; i++)
            {
                result[index++] = str[i];
            }

            return new string(result);
        }


        public static string reserveWordEx(string str)
        {
            char[] str_arr = str.ToCharArray();
            int length = str_arr.Length;
            int begin = -1, end = -1;
            for (int i = 0; i < length; ++i)
            {
                if (begin == -1 && str_arr[i] == ' ')
                {
                    continue;
                }
                if (begin == -1)
                {
                    begin = i;
                    continue;
                }

                if (str_arr[i] == ' ')
                {
                    end = i - 1;
                }
                else if (i == length - 1)
                {
                    end = i;
                }
                else
                {
                    continue;
                }

                reserveChar(str_arr, begin, end);
                begin = -1; end = -1;

            }
            reserveChar(str_arr, 0, str_arr.Length - 1);

            return new string(str_arr);
        }

        private static void reserveChar(char[] str_arr, int i1, int i2)
        {
            while (i1<i2)
            {
                char temp = str_arr[i1];
                str_arr[i1] = str_arr[i2];
                str_arr[i2] = temp;
                ++i1;
                --i2;
            }
        }
    }
}
