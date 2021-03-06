﻿/*
            char[] test = new char[30000];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = (char)new System.Random().Next(65, 90);
            }
            string TestString = new string(test);
            DateTime dt1 = DateTime.Now;
            Microsoft.Q73.printLongestSymmetrical(TestString);
            DateTime dt2 = DateTime.Now;
            System.Console.WriteLine(dt2 - dt1);
            Microsoft.Q73.printLongestSymmetricalEx(TestString);
            DateTime dt3 = DateTime.Now;
            System.Console.WriteLine(dt3 - dt2);
            Microsoft.Q73.getLong(TestString);
            //Console.WriteLine(Microsoft.Q73.getLong(TestString));
            DateTime dt4 = DateTime.Now;
            Console.WriteLine(dt4 - dt3);
 */
namespace Algorithm.Microsoft
{
    public class Q73
    {
        //revision:faster 12/8/2012
        public static string getLong(string str)
        {
            int left = 0, right = 1;
            int lrunner = 0, rrunner = 1;
            int l = 0, r = 0;
            while (right < str.Length)
            {
                if (str[left] == str[right])
                {
                    lrunner = left; rrunner = right;
                    while (str[lrunner] == str[rrunner])
                    {
                        --lrunner;
                        ++rrunner;
                        if (lrunner < 0 || rrunner > str.Length - 1)
                        {
                            break;
                        }
                    }
                    if (rrunner - lrunner > r - l)
                    {
                        l = lrunner + 1;
                        r = rrunner - 1;
                    }

                }

                ++left;
                ++right;
                lrunner = left;
                rrunner = right;

            }

            return str.Substring(l, r - l + 1);
        }
        //
        public static void printLongestSymmetrical(string str)
        {
            string result = "Unmatch";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result = iteracteSymmetrical(str, i);
                if ("Unmatch" != result)
                {
                    //System.Console.WriteLine(result);
                    return;
                }
            }
        }

        private static string iteracteSymmetrical(string str, int size)
        {
            int s = 0;
            int e = s + size - 1;
            while (e != str.Length - 1)
            {
                if (verifySymmetrical(str, s, e))
                {
                    return str.Substring(s, size);
                }
                else
                {
                    s++; e++;
                }
            }
            return "Unmatch";
        }

        private static bool verifySymmetrical(string str, int s, int e)
        {
            while (s < e)
            {
                if (str[s] == str[e])
                {
                    s++;
                    e--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        //
        public static void printLongestSymmetricalEx(string str)
        {
            int s, e;
            string LongestSymmetricalStr = "";
            for (int mark = 1; mark < str.Length; mark++)
            {
                //for odd
                s = mark;
                e = mark + 1;
                while (s >= 0 && e < str.Length && str[s] == str[e])
                {
                    s--;
                    e++;
                }
                if (e - s - 1 > LongestSymmetricalStr.Length)
                {
                    LongestSymmetricalStr = str.Substring(s+1, (e - s - 1));
                }
                //for even
                s = mark - 1;
                e = mark + 1;
                while (s >= 0 && e < str.Length && str[s] == str[e])
                {
                    s--;
                    e++;
                }
                if (e - s - 1 > LongestSymmetricalStr.Length)
                {
                    LongestSymmetricalStr = str.Substring(s+1, (e - s - 1));
                }
            }
            //System.Console.WriteLine(LongestSymmetricalStr);
        }
    }
}
