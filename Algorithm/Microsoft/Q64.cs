/*
            Microsoft.Q64.printUglyNum(1500);
 */
namespace Algorithm.Microsoft
{
    class Q64
    {
        public static void printUglyNum(int limit)
        {
            int TimesOfTwo = 1, TimesOfThree = 1, TimesOfFive = 1;
            long output = 1;
            while (true)
            {
                int digit = findSmallest(TimesOfTwo * 2, TimesOfThree * 3, TimesOfFive * 5);
                switch (digit)
                {
                    case 2:
                        output = TimesOfTwo * 2;
                        System.Console.Write(output + " ");
                        TimesOfTwo *= 2;
                        break;
                    case 3:
                        output = TimesOfThree * 3;
                        System.Console.Write(output + " ");
                        TimesOfThree *= 3;
                        break;
                    case 5:
                        output = TimesOfFive * 5;
                        System.Console.Write(output + " ");
                        TimesOfFive *= 5;
                        break;
                }
                if (output>=limit)
                {
                    break;
                }
            }

        }

        private static int findSmallest(long l1, long l2, long l3)
        {
            if (l1 <= l2 && l1 <= l3)
            {
                return 2;
            }
            else if (l2 <= l1 && l2 <= l3)
            {
                return 3;
            }
            else if (l3 <= l1 && l3 <= l2)
            {
                return 5;
            }
            else
            {
                return -1;
            }
        }
    }
}
