using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             var inst = new Leetcode.ValidPalindrome();
            Console.WriteLine(inst.isPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(inst.isPalindrome("race a car")); 
 */
namespace Algorithm.Leetcode
{
    class ValidPalindrome
    {
        public bool isPalindrome(String s)
        {
            s = s.ToLower();
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                while (l < s.Length && !isChar(s[l]))
                {
                    ++l;
                }
                while (r >= 0 && !isChar(s[r]))
                {
                    --r;
                }
                if (l < r && s[l] != s[r])
                {
                    return false;
                }
                ++l;
                --r;
            }

            return true;
        }

        private bool isChar(char c)
        {
            return c <= 'z' && c >= 'a';
        }
    }
}
