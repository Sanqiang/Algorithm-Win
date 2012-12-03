/*
             Console.WriteLine(Microsoft.Q18.findLastNum(10000));
 */ 
namespace Algorithm.Microsoft
{
    //reference to Algorithm.ArrayAndString.JosephusRing

    class Q18
    {
        static int m = 3;
        public static int findLastNum(int n)
        {
            int[] list = new int[n];
            for (int i = 0; i < list.Length - 1; i++)
            {
                list[i] = i + 1;
            }
            int quit = 0;
            int step = 0; //3 step m
            int loop = 0;
            while (quit != list.Length - 2)
            {
                if (list[loop] != 0)
                {
                    step++;
                }
                if (m == step)
                {
                    list[loop] = 0;
                    step = 0;
                    quit++;
                }

                loop++;
                if (loop >= n -1)
                {
                    loop = 0;
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
