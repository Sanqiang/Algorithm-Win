/*
             int[] arr = { 9999, 8888, 7777, 9999, 800, 650, 400, 200, 100, 10, 1, 9999, 200, 300, 400 };
            SortAndSearch.CountSort.sort(arr);
 */ 
namespace Algorithm.SortAndSearch
{
    public class CountSort
    {
        public static void sort(int[] arr)
        {
            int[] tab = new int[0XFFFF];
            for (int i = 0; i < arr.Length; i++)
            {
                tab[arr[i]]++;
            }

            for (int i =tab.Length-1; i >= 0; i--)
            {
                for (int n = 0; n < tab[i]; n++)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
