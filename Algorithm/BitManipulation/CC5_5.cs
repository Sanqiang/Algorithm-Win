/*
            Console.WriteLine(BitManipulation.CC5_5.getBitSwapRequired(0, 3));
            Console.WriteLine(BitManipulation.CC5_5.getBitSwapRequiredV5(0, 3));
 */
namespace Algorithm.BitManipulation
{
    public class CC5_5
    {
        public static int getBitSwapRequired(int before, int after)
        {
            int index = before ^ after;
            int count = 0;
            while (index > 0)
            {
                if ((index & 1) > 0)
                {
                    ++count;
                }
                index = index >> 1;
            }
            return count;
        }

        public static int getBitSwapRequiredV5(int before, int after)
        {
            int count = 0;
            int c = before ^ after;

            for (; c>0; c=c&(c-1))
            {
                ++count;
            }

            return count;
        }
    }
}
