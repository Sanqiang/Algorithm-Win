/*
            //Recursive.CC8_5.getParenth(2);
            Recursive.CC8_5.getParenthV5(2);
 */
namespace Algorithm.Recursive
{
    class CC8_5
    {
        public static void getParenth(int pairs)
        {
            //return 
            printParenth(pairs, pairs, new System.Collections.ArrayList());
        }

        private static void printParenth(int left, int right, System.Collections.ArrayList arr)
        {
            if (left == 0 && right == 0)
            {
                foreach (var item in arr)
                {
                    System.Console.Write(item + " ");
                }
                System.Console.WriteLine();
                //return arr;
            }
            if (left > 0)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add("(");
                //return 
                printParenth(left - 1, right, new_arr);
            }
            if (left < right)
            {
                System.Collections.ArrayList new_arr = (System.Collections.ArrayList)arr.Clone();
                new_arr.Add(")");
                //return 
                printParenth(left, right - 1, new_arr);
            }
            //return null;
        }

        public static void getParenthV5(int pairs)
        {
            char[] arr = new char[pairs * 2];
            printParenthV5(pairs, pairs, arr, 0);
        }

        private static void printParenthV5(int left, int right, char[] arr, int current)
        {
            if (left < 0 || right < left)
            {
                return;
            }
            if (left == 0 && right == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write(arr[i] + " ");
                }
                System.Console.WriteLine();
                return;
            }
            if (left > 0)
            {
                arr[current] = '(';
                printParenthV5(left - 1, right, arr, current + 1);
            }
            if (right > left)
            {
                arr[current] = ')';
                printParenthV5(left, right - 1, arr, current + 1);
            }
        }
    }
}
