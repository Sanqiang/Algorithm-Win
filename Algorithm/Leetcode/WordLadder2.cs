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
            var inst = new Leetcode.WordLadder2();
            List<List<string>> solutions = inst.findLadders("hit","cog",dict); 
 */
namespace Algorithm.Leetcode
{
    class WordLadder2
    {
        public List<List<string>> findLadders(String start, String end, HashSet<String> dict)
        {
            List<List<string>> solutions = new List<List<string>>();
            HashSet<node> layer = new HashSet<node>();
            layer.Add(new node(start, null));
            bool finished = false;
            while (true)
            {
                HashSet<node> pending_add = new HashSet<node>();
                foreach (node sta_n in layer)
                {
                    foreach (string word in dict)
                    {
                        if (isTrans(word, sta_n._word))
                        {
                            pending_add.Add(new node(word, sta_n));
                        }
                    }
                }
                layer.Clear();
                foreach (node adding_n in pending_add)
                {
                    string adding_word = adding_n._word;
                    if (isTrans(adding_word, end))
                    {
                        finished = true;
                        addToList(solutions, adding_n);
                    }
                    dict.Remove(adding_word);
                    layer.Add(adding_n);
                }
                if (finished || dict.Count == 0)
                {
                    break;
                }
            }


            return solutions;
        }

        private void addToList(List<List<string>> solutions, node end_n)
        {
            List<string> temp = new List<string>();
            while (end_n._last != null)
            {
                temp.Add(end_n._word);
                end_n = end_n._last;
            }
            temp.Add(end_n._word);
            solutions.Add(temp);
        }

        class node
        {
            public HashSet<node> next;
            public string _word;
            public node _last;
            public node(string word, node last)
            {
                next = new HashSet<node>();
                this._word = word;
                this._last = last;
            }
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
