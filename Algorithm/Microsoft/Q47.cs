/*
             double[] arr = { 9,4,3,2,5,4,3,2 };
            Console.WriteLine(Microsoft.Q47.findMaxDescending(arr));
 */ 
namespace Algorithm.Microsoft
{
    public class Q47
    {
        public static int findMaxDescending(double[] arr)
        {
            int[] tab = new int[arr.Length];
            int MaxDescending = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                tab[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j] && tab[j] + 1 > tab[i])
                    {
                        tab[i] = tab[j] + 1;
                        if (tab[i] > MaxDescending)
                        {
                            MaxDescending = tab[i];
                        }
                    }
                }
            }
            return MaxDescending;
        }
    }
}
