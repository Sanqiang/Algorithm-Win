/*
             Console.WriteLine(Microsoft.Q30.countOne(3456));
            Console.WriteLine(Microsoft.Q30.countOneInSeries(3456));
 */
namespace Algorithm.Microsoft
{
    class Q30
    {
        public static int countOneInSeries(int n)
        {
            //Cut 0-x vs x+1-end
            string str = n.ToString();


            if (str.Length > 1)
            {
                int FirstCount = countOne(int.Parse(str.Substring(1)));

                int startdigit = int.Parse(str.Substring(0, 1));
                int SecondCount = 0;
                if (startdigit >= 2)
                {
                    SecondCount = (int)System.Math.Pow(10, str.Length - 1);
                }
                else if (startdigit == 1)
                {
                    SecondCount = 1 + int.Parse(str.Substring(1));
                }
                int ThirdCount = (startdigit) * (str.Length - 1) * (int)System.Math.Pow(10, str.Length - 2);
                return FirstCount + SecondCount + ThirdCount;
            }
            else
            {
                return countOne(n);
            }
        }

        public static int countOne(int n)
        {
            int count = 0;
            for (int i = n; i >= 1; i--)
            {
                int num = i;
                while (num > 0)
                {
                    if ((num % 10) == 1)
                    {
                        ++count;
                    }
                    num /= 10;
                }

            }
            return count;
        }
    }
}
