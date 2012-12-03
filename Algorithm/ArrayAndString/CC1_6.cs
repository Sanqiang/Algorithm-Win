
/*
             int[,] matrix = {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            foreach (int i in matrix)
            {
                Console.Write(i + " ");
            }
            ArrayAndString.CC1_6.rotateMatrix(matrix);
            Console.WriteLine();
            foreach (int i in matrix)
            {
                Console.Write(i + " ");
            }
 */
namespace Algorithm.ArrayAndString
{
    class CC1_6
    {
        public static void rotateMatrix(int[,] matrix)
        {
            int edge = matrix.GetLength(0);
            for (int i = 0; i <= edge / 2; i++)
            {
                int loop_edge = edge - 2 * i - 1; // loop minus 1 for array
                for (int j = 0; j <= loop_edge-1; j++) // minus one means we cannot run to ends
                {
                    int temp = matrix[i,i + j];
                    matrix[i, i + j] = matrix[loop_edge + i - j, i];
                    matrix[loop_edge + i - j, i] = matrix[loop_edge + i, i + loop_edge -j];
                    matrix[loop_edge + i, i + loop_edge - j ]= matrix[i + j, i + loop_edge];
                    matrix[i +  j, i + loop_edge] = temp;
                }
            }
        }
    }
}
