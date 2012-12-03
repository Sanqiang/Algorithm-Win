/*
             string str = "aabbccdauiuppp";
            foreach (var item in Microsoft.Q17.findAppearOnce(str))
            {
                Console.WriteLine(item);
            }
 */ 
namespace Algorithm.Microsoft
{
    class Q17
    {
        public static System.Collections.Generic.List<char> findAppearOnce(string str)
        {
            System.Collections.Generic.List<char> result = new System.Collections.Generic.List<char>();

            int[] tab = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
                tab[str[i]]++;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == 1)
                {
                    result.Add((char)i);
                }
            }

            return result;
        }
    }
}
