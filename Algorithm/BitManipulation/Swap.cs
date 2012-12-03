/*
             BitManipulation.Swap.IntegerWrapper i1 = new BitManipulation.Swap.IntegerWrapper(-1);
            BitManipulation.Swap.IntegerWrapper i2 = new BitManipulation.Swap.IntegerWrapper(1);
            Console.WriteLine(i1.value + " " + i2.value);
            BitManipulation.Swap.swapArithmetic(i1, i2);
            Console.WriteLine(i1.value + " " + i2.value);
            BitManipulation.Swap.swapBinary(i1, i2);
            Console.WriteLine(i1.value + " " + i2.value);
 */ 
namespace Algorithm.BitManipulation
{
    public class Swap
    {
        public static void swapArithmetic(IntegerWrapper a, IntegerWrapper b)
        {
            a.value = a.value + b.value;
            b.value = a.value - b.value;
            a.value = a.value - b.value;
        }

        public static void swapBinary(IntegerWrapper a, IntegerWrapper b)
        {
            a.value = a.value ^ b.value;
            b.value = a.value ^ b.value;
            a.value = a.value ^ b.value;
        }

        public class IntegerWrapper
        {
            public int value;
            public IntegerWrapper(int _value)
            { this.value = _value; }
        }
    }
}
