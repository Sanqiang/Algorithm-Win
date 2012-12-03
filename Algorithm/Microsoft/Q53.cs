/*
             Microsoft.Q53.printPermutation("ABCDE");
 */ 
namespace Algorithm.Microsoft
{
    class Q53
    {
        //reference to CC8_4
        public static void printPermutation(string str, int i = 0, System.Collections.Generic.List<string> set = null)
        {
            if (i == str.Length)
            {
                foreach (var s in set)
                {
                    System.Console.WriteLine(s);
                }
                return;
            }

            char c = str[i];
            if (set == null)
            {
                set = new System.Collections.Generic.List<string>();
                set.Add(c.ToString());
                printPermutation(str, i + 1, set);
            }
            else
            {
                System.Collections.Generic.List<string> new_set = null;
                new_set = new System.Collections.Generic.List<string>();
                foreach (string s in set)
                {
                    for (int index = 0; index <= s.Length; index++)
                    {
                        new_set.Add(injectStr(s, index, c));
                    }
                }
                printPermutation(str, i + 1, new_set);
            }


        }

        private static string injectStr(string str, int index, char c)
        {
            string left = str.Substring(0, index);
            string right = index<str.Length?str.Substring(index):"";

            return left + c + right;
        }
    }
}
