using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**/
namespace Algorithm.Leetcode
{
    class MergeSortedArray
    {
        public void merge(int[] A, int m, int[] B, int n)
        {
            int i = A.Length - 1, x = n - 1, y = B.Length - 1;
            while (true)
            {
                if (x <0)
                {
                    while (y >= 0)
                    {
                        A[i--] = B[y--];
                    }
                    break;
                }else if (y < 0)
                {
                    break;
                }
                else
                {
                    if (A[x] >= B[y])
                    {
                        A[i--] = B[y--];
                    }
                    else
                    {
                        A[i--] = A[x--];
                    }
                }

            }
        }
    }
}
