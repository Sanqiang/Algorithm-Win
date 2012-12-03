/*
             Console.WriteLine(BitManipulation.MaxMin.getMaxArithmetic(1, 3));
            Console.WriteLine(BitManipulation.MaxMin.getMinArithmetic(1, 3));
            Console.WriteLine(BitManipulation.MaxMin.getMaxBinary(1, 3));
            Console.WriteLine(BitManipulation.MaxMin.getMinBinary(1, 3));
 */ 
namespace Algorithm.BitManipulation
{
    public class MaxMin
    {
        public static int getMaxArithmetic(int a, int b)
        {
            int d = a - b;
            int f = d >> 31;
            int absD = (d ^ f) - f;
            int max = (a + b + absD) / 2;
            return max;
        }

        public static int getMinArithmetic(int a, int b)
        {
            int d = a - b;
            int f = d >> 31;
            int absD = (d ^ f) - f;
            int min = (a + b - absD) / 2;
            return min;
        }

        public static int getMaxBinary(int a, int b)
        {
            int[] ret = { a, b };
            int d = a - b;
            int f = d >> 31;
            f &= 0x1;
            //a * (1 - f) + b * f OR a + (b - a) * f
            return ret[f];
        }

        public static int getMinBinary(int a, int b)
        {
            int[] ret = { a, b };
            int d = a - b;
            int f = d >> 31;
            f &= 0x0;
            //a * (1 - f) + b * f OR a + (b - a) * f
            return ret[f];
        }
    }
}
