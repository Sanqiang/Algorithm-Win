using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    class ScrambleString
    {
        public bool isScramble(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            if (s1.Length == 1)
            {
                return s1.Equals(s2);
            }
            int len = s1.Length;
            for (int i = 1; i < len / 2; i++)
            {
                string s1fl = s1.Substring(0, i), s1fr = s1.Substring(i), s1bl = s1.Substring(0, len - i), s1br = s1.Substring(len - i);
                string s2fl = s2.Substring(0, i), s2fr = s2.Substring(i), s2bl = s2.Substring(0, len - i), s2br = s2.Substring(len - i);

                bool r1 = isScramble(s1fl, s2fl) && isScramble(s1fr, s2fr);
                if (r1)
                {
                    return true;
                }
                bool r2 = isScramble(s1fl, s2fr) && isScramble(s1fr, s2fl);
                if (r2)
                {
                    return true;
                }
                bool r3 = isScramble(s1bl, s2fl) && isScramble(s1br, s2fr);
                if (r3)
                {
                    return true;
                }
                bool r4 = isScramble(s1bl, s2fr) && isScramble(s1br, s2fl);
                if (r4)
                {
                    return true;
                }
            }
            return true;
        }
    }
}
