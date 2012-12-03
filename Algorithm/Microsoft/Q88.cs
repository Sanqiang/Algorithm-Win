/*
 Console.WriteLine(Microsoft.Q88.moveStar("*1*2*3*".ToCharArray()));
 */ 
namespace Algorithm.Microsoft
{
    class Q88
    {
        //quick sort
        public static int moveStar(char[] str, int s = -1, int e = -1)
        {
            if (s == -1)
            {
                s = 0;
            }
            if (e == -1)
            {
                e = str.Length - 1;
            }

            while (s < e)
            {
                for (; s < e && (!isStar(str[e])); e--) ;
                for (; s < e && isStar(str[s]); s++) ;
                char temp = str[e];
                str[e] = str[s];
                str[s] = temp;
            }
            return s + 1;
        }

        private static bool isStar(char c)
        {
            return c == '*';
        }
    }
}
