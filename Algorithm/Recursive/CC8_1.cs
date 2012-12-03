/*
             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Recursive.CC8_1.getNthFibonacci(i));
            }
 */ 
namespace Algorithm.Recursive
{
    class CC8_1
    {
        public static int getNthFibonacci(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 2;
            return getNthFibonacci(n-1)+getNthFibonacci(n-2);
        }
    }
}
