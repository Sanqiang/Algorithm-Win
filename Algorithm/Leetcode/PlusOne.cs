using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             var inst = new Leetcode.PlusOne();

            foreach (int s in inst.plusOne(new int[] { 1, 9, 9 }))
            {
                Console.Write(s);
            }
            Console.WriteLine();
            foreach (int s in inst.plusOne(new int[] { 9, 9, 9 }))
            {
                Console.Write(s);
            } 
 */
namespace Algorithm.Leetcode
{
    class PlusOne
    {
        public int[] plusOne(int[] digits)
        {
            int[] solution = new int[digits.Length];
            int carry = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int n = digits[i];
                if (i == digits.Length - 1)
                {
                    solution[i] = (n + 1 + carry) % 10;
                    carry = (n + 1 + carry) / 10;
                }
                else
                {
                    solution[i] = (n + carry) % 10;
                    carry = (n + carry) / 10;
                }
            }
            if (carry > 0)
            {
                int[] add_solution = new int[digits.Length+1];
                Array.Copy(solution, 0, add_solution, 1, solution.Length);
                add_solution[0] = carry;
                return add_solution;
            }
            else
            {
                return solution;
            }
        }
    }
}
