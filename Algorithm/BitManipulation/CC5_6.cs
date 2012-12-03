/*
             Console.WriteLine(BitManipulation.CC5_6.swapOddEvenBits(5));
 */ 
namespace Algorithm.BitManipulation
{
    public class CC5_6
    {

        public static int swapOddEvenBits(int n)
        {
            int mask_odd = 0x5555555;//01010101
            int mask_even = 0xaaaaaaa;//10101010
            int odd =((mask_odd & n) << 1);
            int even = ((mask_even & n) >> 1);
            return odd | even;
        }
    }
}
