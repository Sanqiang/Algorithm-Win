/*
            Console.Write(ArrayAndString.CC1_3.removeDuplicate("aeeabdbcc"));

 */


namespace Algorithm.ArrayAndString
{
    class CC1_3
    {
        public static string removeDuplicate(string str)
        {
            int tab = 0;
            int k = 0;
            foreach (char c in str)
            {
                int length = c -'a';
                if ((tab & (1<<length))==0)
                {
                    str = str.Substring(0, k) + c + str.Substring(k + 1);
                    k++;
                }
                tab |= (1 << length);
            }
            str = str.Substring(0, k) + ' ' + str.Substring(k + 1);
            return str;
        }
    }
}
