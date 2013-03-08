using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             HashSet<String> dict = new HashSet<string>();
            dict.Add("hot");
            dict.Add("dot");
            dict.Add("dog");
            dict.Add("lot");
            dict.Add("log");
            int len = new Leetcode.WordLadder().ladderLength("hit", "cog", dict);
            Console.WriteLine(len);
 */
namespace Algorithm.Leetcode
{
    class WordLadder
    {
        public int ladderLength(String start, String end, HashSet<String> dict)
        {
            int count = 1;
            HashSet<string> layer = new HashSet<string>();
            layer.Add(start);
            while (layer.Count != 0)
            {
                HashSet<string> pending_layer = new HashSet<string>();
                foreach (string pre in layer)
                {
                    if (isTrans(pre, end))
                    {
                        return count + 1;
                    }
                    HashSet<string> pending = new HashSet<string>();
                    foreach (string word in dict)
                    {

                        if (isTrans(word, pre))
                        {
                            pending.Add(word);
                            pending_layer.Add(word);
                        }
                    }
                    foreach (string pending_word in pending)
                    {
                        dict.Remove(pending_word);
                    }
                }
                layer.Clear();
                foreach (string word in pending_layer)
                {
                    layer.Add(word);
                }
                ++count;
            }
            return -1;
        }

        private bool isTrans(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            int count = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    count++;
                }
                if (count >= 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
