/*
            double[,] matrix = {
                                  {1,2,3,4,5},
                                   {6,7,8,9,10},
                                   {10,9,8,7,6},
                                   {5,4,3,2,1}
                              };
            double[,] Biggest = Microsoft.Q35.findBiggestTwoDimensionMatrix(matrix);
            Console.WriteLine(Biggest[0, 0] + " " + Biggest[0, 1] + "\r\n" + Biggest[1, 0] + " " + Biggest[1, 1]);
            Console.WriteLine(Microsoft.Q35.findBiggestMutliDimensionMatrix(matrix));
 */
namespace Algorithm.Microsoft
{
    class Q35
    {
        public static double[,] findBiggestTwoDimensionMatrix(double[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            double[,] matrix_biggest = { { matrix[0, 0], matrix[0, 1] }, { matrix[1, 0], matrix[1, 1] } };
            double matrix_sum_biggest = double.MinValue;
            for (int h = 0; h < height - 2; h++)
            {
                for (int w = 0; w < width - 2; w++)
                {
                    double[,] current_matrix = {
                                         {matrix[h,w],matrix[h,w+1]},
                                         {matrix[h+1,w],matrix[h+1,w+1]}
                                         };
                    double current_sum = getSum(current_matrix);
                    if (matrix_sum_biggest < current_sum)
                    {
                        matrix_sum_biggest = current_sum;
                        matrix_biggest = current_matrix;

                    }
                }
            }
            return matrix_biggest;
        }

        private static double getSum(double[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            double sum = 0;
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    sum += matrix[h, w];
                }
            }
            return sum;
        }

        //revision:improve feature allow different result matrix 12/2/2012
        public static double findBiggestMutliDimensionMatrix(double[,] matrix)
        {

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            double BiggestVal = double.MinValue, XTop, XLeft, XW, XH;

            for (int top = 0; top < height; top++)
            {
                for (int left = 0; left < width; left++)
                {
                    for (int w = 0; w < width - left; w++)
                    {
                        for (int h = 0; h < height - top; h++)
                        {
                            double CurrentSum = getSum(matrix, top, left, h, w);
                            if (CurrentSum > BiggestVal)
                            {
                                BiggestVal = CurrentSum;
                                XH = h; XW = w; XTop = top; XLeft = left;
                            }
                        }
                    }
                }
            }

            return BiggestVal;
        }

        private static double getSum(double[,] matrix, int top, int left, int h, int w)
        {
            double count = 0;
            for (int i = top; i <= h; i++)
            {
                for (int j = left; j <= w; j++)
                {
                    count += matrix[i, j];
                }
            }
            return count;
        }
    }
}
