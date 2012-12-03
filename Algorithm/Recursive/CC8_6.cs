/*
             int[,] screen = new int[10, 5];
            int l1 = screen.GetLength(0);
            int l2 = screen.GetLength(1);
            Recursive.CC8_6.paintDot(screen);
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    Console.Write(screen[i, j]);
                }
                Console.WriteLine();
            }
 */ 
namespace Algorithm.Recursive
{
    class CC8_6
    {
        public static void paintDot(int[,] n, int X=0, int Y=0, int new_color=1)
        {
            if (X < 0 || Y < 0 || X >= n.GetLength(0) || Y >= n.GetLength(1))
            {
                return;
            }
            if (n[X, Y] == 0)
            {
                n[X, Y] = new_color;
                paintDot(n, X - 1, Y, new_color);
                paintDot(n, X + 1, Y, new_color);
                paintDot(n, X, Y - 1, new_color);
                paintDot(n, X, Y + 1, new_color);
            }

        }
    }
}
