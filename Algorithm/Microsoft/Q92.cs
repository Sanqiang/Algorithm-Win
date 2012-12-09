/*
            Microsoft.Q92.printBreakRules(new int[] { 176, 178, 180, 170, 171 });
 */
namespace Algorithm.Microsoft
{
    class Q92
    {
        public static void printBreakRules(int[] arr)
        {
            int i = 0, length = arr.Length, j = 0;
            for (i = 0; i < length; i++)
            {
                for (j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        System.Console.WriteLine("<" + arr[i] + " " + arr[j] + ">");
                    }
                }
            }
        }

    }
}
