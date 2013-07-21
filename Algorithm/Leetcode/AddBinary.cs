using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Leetcode
{
    //same idea as add
    internal class AddBinary
    {
        public String addBinary(String a, String b)
        {
            StringBuilder sb = new StringBuilder();
            int x = a.Length - 1, y = b.Length - 1;
            bool carry = false;
            while (x >= 0 && y >= 0)
            {
                if (x < 0)
                {
                    if (carry)
                    {
                        if (b[y] == '1')
                        {
                            sb.Insert(0, "0");
                            carry = true;
                        }
                        else
                        {
                            sb.Insert(0, "1");
                            carry = false;
                        }
                    }
                    else
                    {
                        if (b[y] == '1')
                        {
                            sb.Insert(0, "1");
                            carry = false;
                        }
                        else
                        {
                            sb.Insert(0, "0");
                            carry = false;
                        }
                    }
                }
                else if (y < 0)
                {
                    if (carry)
                    {
                        if (a[x] == '1')
                        {
                            sb.Insert(0, "0");
                            carry = true;
                        }
                        else
                        {
                            sb.Insert(0, "1");
                            carry = false;
                        }
                    }
                    else
                    {
                        if (a[x] == '1')
                        {
                            sb.Insert(0, "1");
                            carry = false;
                        }
                        else
                        {
                            sb.Insert(0, "0");
                            carry = false;
                        }
                    }
                }
                if (carry)
                {
                    if (a[x] == '1' && b[y] == '1')
                    {
                        sb.Insert(0, "1");
                        carry = true;
                    }
                    else if (a[x] == '0' && b[y] == '0')
                    {
                        sb.Insert(0, "1");
                        carry = false;
                    }
                    else
                    {
                        sb.Insert(0, "0");
                        carry = true;
                    }
                }
                else
                {
                    if (a[x] == '1' && b[y] == '1')
                    {
                        sb.Insert(0, "0");
                        carry = true;
                    }
                    else if (a[x] == '0' && b[y] == '0')
                    {
                        sb.Insert(0, "0");
                        carry = false;
                    }
                    else
                    {
                        sb.Insert(0, "0");
                        carry = false;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
