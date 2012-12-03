/*
             Console.WriteLine(Microsoft.Q33.verifyLegal("abcdef", "deq"));
            Console.WriteLine(Microsoft.Q33.verifyLegal("abcdef", "de"));
 */ 
namespace Algorithm.Microsoft
{
    class Q33
    {
        public static bool verifyLegal(string str, string pattern)
        {
            int[] tab = new int[0XFF];

            for (int i = 0; i < pattern.Length; i++)
            {
                tab[pattern[i]]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (tab[c] >0)
                {
                    tab[c]--;
                }
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                if (tab[pattern[i]] > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
