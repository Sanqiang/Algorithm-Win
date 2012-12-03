
/*
             Console.WriteLine(ArrayAndString.CC1_4.isAnagram("abc", "cba"));
            Console.WriteLine(ArrayAndString.CC1_4.isAnagram("abc", "aaaaa"));
            Console.WriteLine(ArrayAndString.CC1_4.isAnagram("abcc", "cbaa"));
 */ 
namespace Algorithm.ArrayAndString
{
    class CC1_4
    {
        public static bool isAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            uint[] tab = new uint[256];
            foreach (char c in str1)
            {
                tab[c]++;
            }
            foreach (char c in str2)
            {
                if (tab[c]>0)
                {
                    tab[c]--;
                }
                else
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
