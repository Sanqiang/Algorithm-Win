
namespace Algorithm.Microsoft
{
    public class Q80
    {
        //same idea as bracket permute
        public static void printTwoRowPermute(int n)
        {
            table = new bool[n];
            permute(n / 2, n / 2, 0);
            System.Console.WriteLine(count + " ways!");
        }

        //First Lower Second Higher
        static bool[] table;
        static int count = 0;
        private static void permute(int FirstRow, int SecondRow, int current)
        {
            if (current == table.Length - 1)
            {
                ++count;
            }

            if (FirstRow > 0)
            {
                table[current] = false;
                permute(FirstRow - 1, SecondRow, current + 1);
            }

            if (SecondRow > FirstRow)
            {
                table[current] = true;
                permute(FirstRow, SecondRow - 1, current + 1);
            }
        }
    }
}
