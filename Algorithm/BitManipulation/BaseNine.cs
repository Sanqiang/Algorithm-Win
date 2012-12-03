/*
            Console.WriteLine(BitManipulation.BaseNine.convertBase10toN(10,8));
            Console.WriteLine(BitManipulation.BaseNine.convertToBase9(50));
 */
namespace Algorithm.BitManipulation
{
    public class BaseNine
    {
        //False Function
        public static int convertToBase9(int base10)
        {
            int NewNumber = 0;
            int j = 1;
            while (base10 > 0)
            {
                int d = base10 % 10;
                if (d == 4)
                {
                    throw new System.SystemException();
                }
                NewNumber += d > 4 ? (d - 1) * j : d * j;
                j *= 9;
                base10 = (base10 - d) / 10;
            }
            return NewNumber;
        }

        //True Function
        public static string convertBase10toN(int base10, int baseN)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (base10 > 0)
            {
                int d = base10 % baseN;
                sb.Insert(0, d);
                base10 = base10 / baseN;
            }
            return sb.ToString();
        }
    }


}
