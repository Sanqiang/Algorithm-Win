/*
             Recursive.CC8_7.printChange(10);
            System.Console.WriteLine(Recursive.CC8_7.printChangeSample(10));
 */ 
namespace Algorithm.Recursive
{
    class CC8_7
    {
        public static void printChange(int amount, System.Collections.ArrayList arr = null)
        {
            if (amount == 0)
            {
                foreach (var item in arr)
                {
                    System.Console.Write(item + " ");
                }
                System.Console.WriteLine();
                return;
            }
            if (arr == null)
            {
                arr = new System.Collections.ArrayList();
            }
            if (amount >= 25)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add(25);
                printChange(amount - 25, new_arr);
            }
            if (amount >= 10)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add(10);
                printChange(amount - 10, new_arr);
            }
            if (amount >= 5)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add(5);
                printChange(amount - 5, new_arr);
            }
            if (amount >= 1)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add(1);
                printChange(amount - 1, new_arr);
            }
        }

        public static int printChangeSample(int amount, int dcom=25)
        {
            int next_dcom = 0;
            switch (dcom)
            {
                case 25:
                    next_dcom = 10;
                    break;
                case 10:
                    next_dcom = 5;
                    break;
                case 5:
                    next_dcom = 1;
                    break;
                case 1:
                    return 1;
                    //next_dcom = 1;
                    //break;
            }
            int ways = 0;
            for (int i = 0; i * dcom <= amount; i++)
            {
                ways += printChangeSample(amount - i * dcom, next_dcom);
            }

            
            return ways;
        }
    }
}
