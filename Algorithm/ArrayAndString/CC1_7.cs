/*
             int[,] martix ={
                   {1,2,0},
                   {1,2,3},
                   {0,2,3}
                   };
            ArrayAndString.CC1_7.emptyMatrix(martix);
            foreach (int i in martix)
            {
                Console.Write(i+ " ");
            }
 */ 
namespace Algorithm.ArrayAndString
{

    public class CC1_7
    {
        public static void emptyMatrix(int[,] matrix)
        {
            bool[] M = new bool[matrix.GetLength(0)];
            bool[] N = new bool[matrix.GetLength(1)];
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < N.Length; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        M[i] = true;
                        N[j] = true;
                    }
                }
            }
            //step 2
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < N.Length; j++)
                {
                    if (M[i]||N[j])
                    {
                        matrix[i, j] = 'x';
                    }
                }
            }

        }
    }
}
