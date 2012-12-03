/*
            double[] arr = { 6,-5,9 };
            Console.WriteLine(Microsoft.Q3.findMaxArrayListDP(arr));
            Console.WriteLine(Microsoft.Q3.findMaxArrayListEx(arr));
            Console.WriteLine(Microsoft.Q3.findMaxArrayListBruteForce(arr));
 */
namespace Algorithm.Microsoft
{
    class Q3
    {
        public static double findMaxArrayListDP(double[] arr)
        {
            int length = arr.Length, i;
            double sum = arr[0]; //DP: Record last time i the biggest value (sum[])
            double CurrentSum = arr[0], Biggest = arr[0];
            for (i = 1; i < length; i++)
            {
                if (sum < 0)
                {
                    sum = arr[i];
                }
                else
                {
                    sum = sum + arr[i];
                }

                Biggest = sum > Biggest ? sum : Biggest;

            }

            return Biggest;
        }

        public static double findMaxArrayListBruteForce(double[] arr)
        {
            int i, j, length = arr.Length;
            double sum = 0, Biggest = double.MinValue;
            for (i = 0; i < length; i++)
            {
                sum = arr[i];
                if (sum > Biggest)
                {
                    Biggest = sum;
                }
                for (j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum > Biggest)
                    {
                        Biggest = sum;
                    }
                }
            }
            return Biggest;
        }

        public static double findMaxArrayListEx(double[] arr)
        {
            double Biggest = arr[0];
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (sum <= 0)
                {
                    sum = arr[i];
                }
                else
                {
                    sum += arr[i];
                }
                if (sum > Biggest)
                {
                    Biggest = sum;
                }
            }
            return Biggest;
        }
    }
}
