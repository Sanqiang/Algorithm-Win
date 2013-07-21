using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.TextJustification();
            List<string> list = inst.fullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            } 
 */
namespace Algorithm.Leetcode
{
    class TextJustification
    {
        public List<string> fullJustify(string[] words, int L)
        {
            List<string> solution = new List<string>();
            int s = 0, count = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                count += words[i].Length + 1;
                if (count - 1 > L)
                {
                    string line = generateStr(words, s, i - 1, count - (words[i].Length + 1), L);
                    solution.Add(line);
                    count = words[i].Length + 1;
                    s = i;
                }
            }
            solution.Add(generateStr(words, s, words.Count() - 1, count, L));
            return solution;
        }

        string generateStr(string[] words, int s, int e, int count, int L)
        {
            int space = L - (count - (e - s));
            int num_word = e - s + 1, per_space = 0, per_space_offset = 0;
            if (num_word == 1)
            {
                per_space_offset = 0;
                per_space = space;
            }
            else
            {
                per_space = space / (num_word - 1);
                per_space_offset = space % (num_word - 1);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = s; i <= e; i++)
            {
                sb.Append(words[i]);
                if (s == i)
                {
                    for (int j = 0; j < (per_space + per_space_offset); j++)
                    {
                        sb.Append("_");
                    }
                }
                else if (e != i)
                {
                    for (int j = 0; j < per_space; j++)
                    {
                        sb.Append("_");
                    }
                }
            }

            return sb.ToString();
        }
    }
}
