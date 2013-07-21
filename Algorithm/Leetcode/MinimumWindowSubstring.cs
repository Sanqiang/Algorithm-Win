using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.MinimumWindowSubstring();
            Console.WriteLine(inst.minWindow("ADOBECODEBANCBA", "ABC")); 
 */
namespace Algorithm.Leetcode
{
    class MinimumWindowSubstring
    {
        public String minWindow(String S, String T)
        {
            int count = 0, front = 0, end = 0, min = int.MaxValue, min_front=0;

            Dictionary<char, short> record = new Dictionary<char, short>();
            for (int i = 0; i < T.Length; i++)
            {
                record.Add(T[i], 0);
            }

            for (end = 0; end < S.Length; end++)
            {
                if (record.ContainsKey(S[end]))
                {
                    ++record[S[end]];
                    if (record[S[end]] == 1)
                    {
                        ++count;
                    }
                    while (count == T.Length)
                    {
                        if (end - front + 1 < min)
                        {
                            min = end - front + 1;
                            min_front = front;
                        }
                        if (record.ContainsKey(S[front]))
                        {
                            --record[S[front]];
                            if (record[S[front]] == 0)
                            {
                                --count;
                            }
                            ++front;
                        }
                        while (!record.ContainsKey(S[front]))
                        {
                            ++front;
                        }

                    }
                }
            }

            return S.Substring(min_front, min);
        }
    }
}
