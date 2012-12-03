/*
             Console.WriteLine(Recursive.VerifySquare.Verify(10));
            Console.WriteLine(Recursive.VerifySquare.Verify(9));
            Console.WriteLine(Recursive.VerifySquare.Verify(8));
            Console.WriteLine(Recursive.VerifySquare.Verify(7));
            Console.WriteLine(Recursive.VerifySquare.Verify(6));
            Console.WriteLine(Recursive.VerifySquare.Verify(5));
            Console.WriteLine(Recursive.VerifySquare.Verify(4));
 */ 
namespace Algorithm.Recursive
{
    class VerifySquare
    {
        public static bool Verify(int n, int loop = -1, int compare = -1)
        {
            if (loop == -1)
            {
                loop = n / 2;
            }
            if (compare == -1)
            {
                compare = n / 4;
            }
            else
            {
                compare /= 2;
            }


            int m = loop * loop;
            if (m == n)
            {
                return true;
            }
            else if (m > n)
            {
                loop -= compare;
                if (compare != 0)
                {
                    return Verify(n, loop, compare);
                }

            }
            else if (m < n)
            {
                loop += compare;
                if (compare != 0)
                {
                    return Verify(n, loop, compare);
                }
            }
            return false;
        }
    }
}
