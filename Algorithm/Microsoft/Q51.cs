/*
             Microsoft.Q51.printAllAddition(15);
 */ 
namespace Algorithm.Microsoft
{
    class Q51
    {
        public static void printAllAddition(int n)
        {
            int Left = 1;
            int Right = 2;
            int currentSum=Left+Right;
            while (Left <= n / 2 + 1)
            {
                if (currentSum>n)
                {
                    currentSum -= Left;
                    Left++;
                }
                else if (currentSum<n)
                {
                    currentSum += (Right + 1);
                    Right++;
                }
                else
                {
                    //print
                    printQualify(Left, Right);
                    currentSum += (Right + 1);
                    Right++;
                }
            }
        }

        private static void printQualify(int left, int right)
        {
            for (int i = left; i <= right; i++)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
        }
    }
}
