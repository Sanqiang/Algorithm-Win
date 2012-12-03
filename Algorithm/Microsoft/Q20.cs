/*
             Console.WriteLine(Microsoft.Q20.ConvertToInt("1000"));
            Console.WriteLine(Microsoft.Q20.ConvertToInt("+234"));
            Console.WriteLine(Microsoft.Q20.ConvertToInt("-999"));
            Console.WriteLine(Microsoft.Q20.ConvertToInt("9999999999999999999999999"));
 */ 
namespace Algorithm.Microsoft
{
    class Q20
    {
        public static long ConvertToInt(string str)
        {
            bool negetive = false;
            long num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && (str[i] == '+' || str[i] == '-'))
                {
                    if (str[i] == '-')
                    {
                        negetive = true;
                    }
                    continue;
                }
                if (str[i] >= '0' && str[i] <= '9')
                {
                    long digit = (str[i] - '0');
                    num = num * 10 + digit;
                    if (num > System.Int32.MaxValue)
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }

            }

            if (negetive)
            {
                num *= -1;
            }
            if (num <　System.Int32.MinValue)
            {
                return 0;
            }

            return num;
        }
    }
}
