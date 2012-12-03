/*
             Console.WriteLine(BitManipulation.CC5_1.BitSubstr(1024, 21, 2, 6));

 */ 
namespace Algorithm.BitManipulation
{
    public class CC5_1
    {
        public static int BitSubstr(int N, int M, int start, int end)
        {
            
            int max = ~0;
            int mask = ((max - ((1 << end) - 1)) + (((1 << start) - 1))) & N;
            int M_extend = (M << start);
            return mask | M_extend;
        
             
            /*
            //sample
            int max = ~0;
            int left = max - (1 << end) - 1;
            int right = ((1 << start) - 1);
            int mask = left | right;
            return (N & mask) | (M << start);*/
        }
    }
}
