/*
             Console.WriteLine(Microsoft.Q74.printOverAverageInArray(new int[]{6,5,4,5,5,5,3,2,1,5,5}));
 */ 
namespace Algorithm.Microsoft
{
    public class Q74
    {
        public static int printOverAverageInArray(int[] arr)
        {
            int Result = arr[0];
            int Times = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == Result)
                {
                    Times++;
                }
                else
                {
                    Times--;
                }
                if (Times == 0)
                {
                    Result = arr[i];
                    Times = 1;
                }
            }
            //Validate
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==Result)
                {
                    count++;
                }
            }
            if (count * 2 >= arr.Length)
            {
                return Result;
            }
            else
            {
                return -1;
            }
        }
    }
}
