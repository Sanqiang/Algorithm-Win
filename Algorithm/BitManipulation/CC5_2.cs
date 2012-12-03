/*
            Console.WriteLine(BitManipulation.CC5_2.getBinaryPresentation("0.126"));
            Console.WriteLine(BitManipulation.CC5_2.getBinaryPresentation("0.125"));
            Console.WriteLine(BitManipulation.CC5_2.getBinaryPresentation("10.126"));
            Console.WriteLine(BitManipulation.CC5_2.getBinaryPresentation("126"));
 */
namespace Algorithm.BitManipulation
{
    public class CC5_2
    {
        static int PrecisionStd = 10;
        public static string getBinaryPresentation(string input)
        {
            int number = 0;
            int DotIndex = -1;
            string decimal_left = string.Empty, decimal_right = string.Empty;
            if ((DotIndex = input.IndexOf(".")) != -1)
            {
                decimal_left = input.Substring(0, DotIndex);
                decimal_right = input.Substring(DotIndex);
            }
            else
            {
                decimal_left = input;
            }


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (System.Int32.TryParse(decimal_left, out number))
            {

                while (number > 0)
                {
                    if (number % 2 > 0)
                    {
                        sb.Insert(0, "1");
                    }
                    else
                    {
                        sb.Insert(0, "0");
                    }
                    number = number >> 1;
                }


            }
            else
            {
                return "ERROR";
            }
            //decimal number = resetup
            decimal number2, precision_index=0;
            if (!decimal_right.Equals(string.Empty) && System.Decimal.TryParse(decimal_right, out number2))
            {
                sb.Append(".");
                while (number2 > 0)
                {
                    number2 *= 2;
                    if (number2 >= 1)
                    {
                        sb.Append("1");
                        number2--;
                    }
                    else
                    {
                        sb.Append("0");
                    }
                    //Precision control
                    if (precision_index++==PrecisionStd)
                    {
                        break;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
