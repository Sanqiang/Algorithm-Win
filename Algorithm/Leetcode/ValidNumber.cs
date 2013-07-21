using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            var inst = new Leetcode.ValidNumber();
            Console.WriteLine(inst.isNumber("0"));
            Console.WriteLine(inst.isNumber("0.1"));
            Console.WriteLine(inst.isNumber("abc"));
            Console.WriteLine(inst.isNumber("1 a"));
            Console.WriteLine(inst.isNumber("2e10")); 
 */
namespace Algorithm.Leetcode
{
    class ValidNumber
    {
        public bool isNumber(String s)
        {
            int ind = 0;
            bool dot = false, e = false;
            if (s[0] == '-' || s[0] == '+')
            {
                ++ind;
            }
            if (s[0] == '.' || s[0] == 'e')
            {
                return false;
            }
            while (ind < s.Length)
            {
                if ((s[ind] == '.' && dot) || (s[ind] == 'e' && e) || (((s[ind] < '0') || s[ind] > '9') && (s[ind] != '.' && s[ind] != 'e')))
                {
                    return false;
                }
                if (s[ind] == '.')
                {
                    dot = true;
                }
                if (s[ind] == 'e')
                {
                    e = true;
                }

                ++ind;
            }

            return true;
        }
    }
}
