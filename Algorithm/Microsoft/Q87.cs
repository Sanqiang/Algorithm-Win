
namespace Algorithm.Microsoft
{
    class Q87
    {
        //87.1

        //revision: 12/8/2012 easy implementation
        /*
            int[] arr = multiply2(new int[] { 1,0,1,1}, new int[] { 1,1,1,1 });
         */
        public static int[] multiply2(int[] left, int[] right)
        {
            int[] a = new int[left.Length + right.Length];
            for (int i = 0; i < left.Length; i++)
            {

                for (int j = 0; j < right.Length; j++)
                {
                    int sum = left[i] * right[j];
                    int carry = sum / 10;
                    int digit = sum % 10;
                    a[i + j] += digit;
                    a[i + j + 1] += carry;
                }
            }


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 10)
                {
                    int digit = a[i] % 10;
                    int carry = a[i] / 10;
                    a[i] += digit;
                    a[i + 1] += carry;
                }
            }

            return a;
        }
        /*
                     int[] num1 = { 9,9 };
            int[] num2 = { 9,9 };
            int[] num = Microsoft.Q87.multiply(num1, num2);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
         */ 
        public static int[] multiply(int[] num1, int[] num2)
        {
            int[] result = new int[num1.Length + num2.Length];
            int temp = 0, HF = 0, LF = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    temp = num1[i] * num2[j] + HF;
                    LF = temp % 10;
                    result[result.Length - 1 - ((num1.Length - 1) - i) - ((num2.Length - 1) - j)] += LF;

                    HF = temp / 10;
                    HF += result[result.Length - 1 - ((num1.Length - 1) - i) - ((num2.Length - 1) - j)] / 10;
                    result[result.Length - 1 - ((num1.Length - 1) - i) - ((num2.Length - 1) - j)] %= 10;
                }
                result[result.Length - 1 - ((num1.Length - 1) - i) - ((num2.Length - 1)) -1 ] = HF;
                HF = 0;
            }
            return result;
        }

        

        //87.2
        //87.3
    }
}
