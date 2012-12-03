/*
             BitManipulation.BitSet bs = new BitManipulation.BitSet(10);
            bs.set(100);
            Console.WriteLine(bs.get(100));
            Console.WriteLine(bs.get(101));
 */ 
namespace Algorithm.BitManipulation
{
    class BitSet
    {
        int[] _BitSet;

        public BitSet(int size)
        {
            _BitSet = new int[size << 5];
        }

        public BitSet()
        {
            _BitSet = new int[0XFF << 5];
        }

        public bool get(int pos)
        {
            int n = pos >> 5;
            int offset = pos & 0X1F;
            return (_BitSet[pos / n] & (1 << offset)) > 0;
        }

        public void set(int pos)
        {
            int n = pos >> 5;
            int offset = pos & 0X1F;
            _BitSet[pos / n] = 1 << offset;
        }
    }
}
