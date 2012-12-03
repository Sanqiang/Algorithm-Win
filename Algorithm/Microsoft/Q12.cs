
namespace Algorithm.Microsoft
{
    class Q12
    {
        //reference to CC8_1 


        /*
                     Console.WriteLine(Addon(10));
         */
        public static int Addon(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + Addon(n - 1);
        }
    }


}
