/*
             int[] arr = { 10,20,33,33,20,10,100,31};
            Microsoft.Q61.findNums(arr);
 */ 
namespace Algorithm.Microsoft
{
    class Q61
    {
        public static void findNums(int[] arr)
        {
            int helper = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //0 if same,1 if different
                helper ^= arr[i];
            }

            int pos = getFirstOne(helper);
            int num1 = 0, num2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (verifyOne(arr[i], pos))
                {
                    num1 ^= arr[i];
                }
                else
                {
                    num2 ^= arr[i];
                }
            }

            System.Console.WriteLine(num1 + " " + num2);
        }

        private static int getFirstOne(int helper)
        {
            int pos = 1;

            while (true)
            {
                if ((pos & helper) > 0)
                {
                    break;
                }
                pos <<= 1;
            }

            return pos;
        }

        private static bool verifyOne(int num, int pos)
        {
            return ((1 << pos) & num) > 0;
        }
    }
}
