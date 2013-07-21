using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Console.WriteLine(new Leetcode.Sqrtx().sqrt(3)); 
 */
namespace Algorithm.Leetcode
{
    class Sqrtx
    {
        private const double precision = 0.000001;
        public double sqrt(int x)
        {
            double s = 0, e = x;
            while (s < e)
            {
                double m = s + (e - s)/2;
                if (Math.Abs(m*m - x) < precision)
                {
                    return m;
                }
                else if(m*m > x)
                {
                    e = m;
                }
                else
                {
                    s = m;
                }
            }

            return -1;
        }
    }
}
