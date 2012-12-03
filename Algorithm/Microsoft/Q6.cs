/*
             double[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            double[] result = Microsoft.Q6.getCountArr(arr);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
 */
namespace Algorithm.Microsoft
{
    class Q6
    {
        static double[] top;
        static double[] bottom;
        static bool finish = false;
        public static double[] getCountArr(double[] arr)
        {
            top = arr;
            bottom = new double[arr.Length];

            while (!finish)
            {
                loop();
            }


            return bottom;
        }

        private static void loop()
        {
            bool result = true;
            for (int tp = 0; tp < top.Length; tp++)
            {
                int count = getCount(tp);
                if (bottom[tp] != count)
                {
                    bottom[tp] = count;
                    result = false;
                }
            }
            finish = result;
        }

        private static int getCount(int top)
        {
            int count = 0;
            for (int bot = 0; bot < bottom.Length; bot++)
            {
                if (top == bottom[bot])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
