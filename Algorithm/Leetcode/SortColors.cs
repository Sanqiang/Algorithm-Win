using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            int[] A = {0,2, 1, 1, 1, 0, 1, 2, 2};
            var inst = new Leetcode.SortColors();
            inst.sortColors(A);
            foreach (int i in A)
            {
                Console.WriteLine(i);
            } 
 */
namespace Algorithm.Leetcode
{
    class SortColors
    {
        public void sortColors(int[] A)
        {
            int x = 0, y = 0, z = A.Length - 1;
            while (y <= z)
            {
                switch (A[y])
                {
                    case 0:
                        swap(A, x++, y++);
                        break;
                    case 1:
                        ++y;
                        break;
                    case 2:
                        swap(A,y,z--);
                        break;
                }
            }
        }

        void swap(int[] A, int x, int y)
        {
            int temp = A[x];
            A[x] = A[y];
            A[y] = temp;
        }
    }
}
