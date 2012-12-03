/*
             Microsoft.Q46.printParenth(10);
 */ 
namespace Algorithm.Microsoft
{
    public class Q46
    {
        //reference to CC8.5
        public static void printParenth(int pair)
        {
            printParenth(pair, pair, new System.Collections.ArrayList());
        }

        private static void printParenth(int RemainingLeft, int RemainingRight, System.Collections.ArrayList arr)
        {
            if (RemainingLeft == 0 && RemainingRight == 0)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    System.Console.Write(arr[i] + " ");
                }
                System.Console.WriteLine();
            }

            if (RemainingLeft > 0)
            {
                System.Collections.ArrayList arr2 = (System.Collections.ArrayList)arr.Clone();
                arr2.Add("[");
                printParenth(RemainingLeft - 1, RemainingRight, arr2);
                
            }
            
            if (RemainingLeft < RemainingRight)
            {
                System.Collections.ArrayList arr2 = (System.Collections.ArrayList)arr.Clone();
                arr2.Add("]");
                printParenth(RemainingLeft, RemainingRight - 1, arr2);
            }

        }
    }
}
