
namespace Algorithm.Microsoft
{
    class Q95
    {
        //95.1
        /*
            Console.WriteLine(Microsoft.Q95.validateSymmetrical("ababa"));
            Console.WriteLine(Microsoft.Q95.validateSymmetrical("abba"));
            Console.WriteLine(Microsoft.Q95.validateSymmetrical("5rfdd"));
         */
        public static bool validateSymmetrical(string str)
        {
            int length = str.Length, s = 0, e = length - 1;
            while (s < e)
            {
                if (str[s] != str[e])
                {
                    return false;
                }
                ++s;
                --e;
            }
            return true;
        }

        //95.2
        /*
            Console.WriteLine(Microsoft.Q95.validateIncreasingArray(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine(Microsoft.Q95.validateIncreasingArray(new int[] { 1, 2, 3, 4, 5, 6, 1 }));
         */
        public static bool validateIncreasingArray(int[] arr, int index = 1)
        {
            if (index == arr.Length)
            {
                return true;
            }
            else if ( arr[index] >= arr[index - 1])
            {
                return validateIncreasingArray(arr, index + 1);
            }
            else
            {
                return false;
            }

            
        }
    }
}
