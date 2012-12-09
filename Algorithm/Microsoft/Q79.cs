
namespace Algorithm.Microsoft
{
    public class Q79
    {
        //3.1 3.2
        //QuickSort is for array, MergeSort is for linked list

        //3.3
        /*
            revision:hint KMP 12/8/2012
            Console.WriteLine( Microsoft.Q79.strstr("abcde", "e"));
         */ 
        public static int strstr(string HayStack, string Needle)
        {
            int Runner = 0, RunnerNeedle =0;
            int NeedleLength = Needle.Length;
            int HayStackLength = HayStack.Length;
            while (Runner != (HayStackLength - NeedleLength + 1))
            {
                if (HayStack[Runner] == Needle[RunnerNeedle])
                {
                    bool find = true;
                    for (; RunnerNeedle < NeedleLength; )
                    {
                        if (HayStack[Runner] != Needle[RunnerNeedle])
                        {
                            find = false;
                            RunnerNeedle = 0;
                            break;
                        }
                        ++Runner;
                        ++RunnerNeedle;
                    }
                    if (find)
                    {
                        return Runner - NeedleLength;
                    }
                }
                else
                {
                    ++Runner;
                }
            }
            return -1;
        }
    }
}
