/*
            Console.WriteLine(Microsoft.Q28.countBinaryOne(117));
            Console.WriteLine(Microsoft.Q28.countOnes(117));
 */
namespace Algorithm.Microsoft
{
    class Q28
    {
        public static int countBinaryOne(int n)
        {
            int count = 0;

            while (n > 0)
            {
                if ((n & 1) > 0)
                {
                    count++;
                }
                n >>= 1;
            }

            return count;
        }

        //revision:another way n%2 
        public static int countOnes(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    count += 1;
                }
                n >>= 1;
            }

            return count;
        }


    }
}
