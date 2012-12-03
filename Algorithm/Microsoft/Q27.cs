/*
             Microsoft.Q27.findCountLeap(3);
            Console.WriteLine(Microsoft.Q27.count);

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(Microsoft.Q27.findCountLeapEx(30));
            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2 - dt1);
            Console.WriteLine(Microsoft.Q27.findCountLeapEx2(30));
            DateTime dt3 = DateTime.Now;
            Console.WriteLine(dt3 - dt2);
            Console.WriteLine(goStep(30));
            DateTime dt4 = DateTime.Now;
            Console.WriteLine(dt4 - dt3);
 */
namespace Algorithm.Microsoft
{
    class Q27
    {
        public static int count = 0;
        public static void findCountLeap(int n, int current = 0)
        {
            if (n == current)
            {
                ++count;
                return;
            }
            else if (current > n)
            {
                return;
            }

            if (n - current >= 2)
            {
                 findCountLeap(n, current+2);
            }
            if (n - current >= 1)
            {
                 findCountLeap(n, current+1);
            }
            return ;
        }


        public static int findCountLeapEx(int n)
        {
            if (n ==0)
            {
                return 1;
            }
            else if(n <0)
            {
                return 0;
            }
            return findCountLeapEx(n - 2) + findCountLeapEx(n - 1);
        }

        public static int findCountLeapEx2(int n)
        {
            int last_one = 1;
            int last_two = 2;
            for (int i = 2; i < n; i++)
            {
                int sum = last_one + last_two;
                last_one = last_two;
                last_two = sum;
            }
            return last_two;
        }

        //revision:dp add cache 12/1/2012 
        static System.Collections.Hashtable ht = new System.Collections.Hashtable();
        public static int goStep(int n)
        {
            int count = 0;
            if (n == 0)
            {
                return 1;
            }
            if (ht.ContainsKey(n))
            {
                return (int)ht[n];
            }
            if (n >= 2)
            {
                count += goStep(n - 2);
            }
            if (n >= 1)
            {
                count += goStep(n - 1);
            }
            ht.Add(n, count);
            return count;
        }

    }
}
