/*
            Console.WriteLine(BitManipulation.CC5_3.getBinaryNextV5(54));
            Console.WriteLine(BitManipulation.CC5_3.getArithmeticNextV5(54));
            Console.WriteLine(BitManipulation.CC5_3.getBinaryLastV5(51));
            Console.WriteLine(BitManipulation.CC5_3.getArithmeticLastV5(51));
 */
namespace Algorithm.BitManipulation
{
    public class CC5_3
    {
        /* ERROR
        public static int[] getBinaryNext(int n)
        {
            //bigger
            int big = -1;
            int index = 0;
            int record_index1, record_index2 = -1;
            while (true)
            {
                if (getBit(n, index))
                {
                    record_index1 = index;
                    break;
                }
                index++;
            }
            while (true)
            {
                if (!getBit(n, index))
                {
                    record_index2 = index;
                    break;
                }
                index++;
            }
            big = setBit(n, record_index1, false);
            big = setBit(big, record_index2, true);
            //smaller
            int small = -1;
            index = 0;
            int record_index3, record_index4 = -1;
            while (true)
            {
                if (!getBit(n, index))
                {
                    record_index3 = index;
                    break;
                }
                index++;
            }
            while (true)
            {
                if (getBit(n, index))
                {
                    record_index4 = index;
                    break;
                }
                index++;
            }
            small = setBit(n, record_index3, true);
            small = setBit(small, record_index4, false);
            return new int[] { small, big };
        }

        public static int setBit(int n, int index, bool val)
        {
            if (val)
            {
                n = (1 << index) | n;
            }
            else
            {
                int max = ~0;
                int mask = max - ((1 << index));
                n = mask & n;
            }
            return n;
        }

        public static bool getBit(int n, int index)
        {
            return ((1 << index) & n) > 0;
        }
         */

        public static int getBinaryNextV5(int n)
        {
            int c0 = 0;
            int c1 = 0;
            int c = n;
            while ((c & 1) == 0)
            {
                ++c0;
                c >>= 1;
            }

            while ((c & 1) == 1)
            {
                ++c1;
                c >>= 1;
            }

            int p = c1 + c0;
            n |= (1 << p);
            n &= (~((1 << p) - 1));
            n |= (1 << (c1 - 1) - 1);

            return n;
        }

        public static int getArithmeticNextV5(int n)
        {
            int c0 = 0;
            int c1 = 0;
            int c = n;
            while ((c & 1) == 0)
            {
                ++c0;
                c >>= 1;
            }

            while ((c & 1) == 1)
            {
                ++c1;
                c >>= 1;
            }

            int p = c1 + c0;

            n += ((1 << c0) - 1);
            n += 1;
            n += (1 << (c1 - 1) - 1);


            return n;
        }

        public static int getBinaryLastV5(int n)
        {
            int c1 = 0;
            int c0 = 0;
            int c = n;

            while ((c & 1) == 1)
            {
                ++c1;
                c >>= 1;
            }

            while ((c & 1) == 0)
            {
                ++c0;
                c >>= 1;
            }

            int p = c0 + c1;
            n &= (~(1 << p));
            n &= (~((1 << p) - 1));
            n |= ((1 << (c1 + 1)) - 1) << (c0 - 1);

            return n;
        }
        public static int getArithmeticLastV5(int n)
        {
            int c1 = 0;
            int c0 = 0;
            int c = n;

            while ((c & 1) == 1)
            {
                ++c1;
                c >>= 1;
            }

            while ((c & 1) == 0)
            {
                ++c0;
                c >>= 1;
            }

            int p = c0 + c1;

            n -= ((1 << c1) - 1);
            n -= 1;
            n -= 1 << ((c0 - 1) - 1);

            return n;
        }
    }
}
