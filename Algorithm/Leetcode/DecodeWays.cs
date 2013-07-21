using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            Console.WriteLine(new Leetcode.DecodeWays().numDecodings("1222")); 
 */
namespace Algorithm.Leetcode
{
    class DecodeWays
    {
        public int numDecodings(String s)
        {
            int len = s.Length;
            int[] tab = new int[3];
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    tab[i % 3] = 1;
                }
                else
                {
                    int sum = 0;
                    int n = s[i] - '0', p = s[i - 1] - '0';
                    if (i == 1)
                    {
                        if ((p >= 1 && p <= 2) && (n >= 0 && n <= 6))
                        {
                            sum +=1;
                        }
                        if (n >= 1 && n <= 9)
                        {
                            sum +=1;
                        }
                        tab[i % 3] = sum; 
                    }
                    else
                    {
                        if ((p >= 1 && p <= 2) && (n >= 0 && n <= 6))
                        {
                            sum += tab[(i + 3 - 2) % 3];
                        }
                        if (n >= 1 && n <= 9)
                        {
                            sum += tab[(i + 3 - 1) % 3];
                        }
                        tab[i % 3] = sum;
                    }
                }
            }
            return tab[(len-1) % 3];
        }
    }
}
