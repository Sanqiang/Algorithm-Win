using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
var list = new Leetcode.RestoreIPAddresses().restoreIpAddresses("25525511135"); 
 */
namespace Algorithm.Leetcode
{
    class RestoreIPAddresses
    {
        public List<String> restoreIpAddresses(String s)
        {
            List<string> solution = new List<string>();
            int len = s.Length;
            for (int i1 = 0; i1 < len; i1++)
            {
                for (int i2 = i1 + 1; i2 < len; i2++)
                {
                    for (int i3 = i2 + 1; i3 < len; i3++)
                    {
                        if (validIP(s, 0, i1) && validIP(s, i1 , i2) && validIP(s, i2 , i3) && validIP(s, i3 , len))
                        {
                            solution.Add(s.Substring(0, i1) + "," + s.Substring(i1, i2 - i1) + "," + s.Substring(i2, i3 - i2) + "," + s.Substring(i3, len - i3));
                        }
                    }
                }
            }
            return solution;
        }

        bool validIP(string ip, int s, int e)
        {
            if (s >= e)
            {
                return false;
            }
            if (e - s == 1)
            {
                if (ip[s] >= '0' && ip[s] <= '9')
                    return true;
                else
                    return false;
            }
            else if (e - s == 2)
            {
                if (ip[s] >= '1' && ip[s] <= '9' && ip[s + 1] >= '0' && ip[s + 1] <= '9')
                    return true;
                else
                    return true;
            }
            else if (e - s == 3)
            {
                if (ip[s] >= '1' && ip[s] <= '2' && ip[s + 1] >= '0' && ip[s + 1] <= '9' && ip[s + 2] >= '0' && ip[s + 2] <= '9')
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
