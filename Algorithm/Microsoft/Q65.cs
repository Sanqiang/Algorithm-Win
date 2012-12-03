/*
             Microsoft.Q65.printDigitSeries(3);
 */ 
namespace Algorithm.Microsoft
{
    class Q65
    {
        public static void printDigitSeries(int digit)
        {
            printDigitSeries(digit, digit, "", true);
        }

        private static void printDigitSeries(int digit, int current, string number,bool zero)
        {
            if (current == 0)
            {
                if (!zero)
                {
                    System.Console.Write(number + " ");
                 
                }
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (i==0)
                {
                    printDigitSeries(digit, current - 1, number, true);
                }
                else
                {
                    printDigitSeries(digit, current - 1, number + i, false);
                }
            }

        }
    }
}
