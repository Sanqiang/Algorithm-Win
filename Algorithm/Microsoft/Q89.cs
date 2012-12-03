
namespace Algorithm.Microsoft
{
    class Q89
    {
        //89.1
        //reference to Algorithm.LinkedList.ReverseLinkedList
        //89.2
        //reference to Q20
        //89.3
        //quick sort
        //89.4
        //can be quick sort
        //mine is different way
        /*
          Console.WriteLine(Microsoft.Q89.removeNum("12a3c5de"));
         */ 
        public static string removeNum(string str)
        {
            char[] strarr = str.ToCharArray();
            int n = 0; //for non-number
            int d = 0; // for number
            while (n < strarr.Length)
            {
                for (; d < strarr.Length && !isNum(strarr[d]); d++) ;
                n = d;
                for (; n < strarr.Length && isNum(strarr[n]); n++) ;
                if (n<strarr.Length && d<strarr.Length && isNum(strarr[d]) && (!isNum(strarr[n])))
                {
                    char temp = strarr[d];
                    strarr[d] = strarr[n];
                    strarr[n] = temp;
                }

            }
            return new string(strarr);
        }

        private static bool isNum(char c)
        {
            return c <= '9' && c >= '0';
        }

        //89.5
        //reference to Q56
    }
}
