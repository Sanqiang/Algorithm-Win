/*
 * 问题 ：已知n个人（以编号0，1，2，3...n-1分别表示）围坐在一张圆桌周围。从编号为k的人开始报数，数到m的那个人出列；他的下一个人又从1开始报数，数到m的那个人又出列；
 * 依此规律重复下去，直到圆桌周围的人全部出列，求最后一个出列人的编号。
 * Hint: F(n)=(F(n-1)-1+m)%n
 */ 

/*
 Console.WriteLine(ArrayAndString.JosephusRing.findLastNum(30,6));
 */ 
namespace Algorithm.ArrayAndString
{
    class JosephusRing
    {
        public static int findLastNum(int n, int m)
        {
            int Index = 0,i;

            for ( i = 2; i <= n; i++)
            {
                Index = (Index + m) % i;
            }
            
            return Index;
        }

        //Count from K
        public static int findLastNum(int n, int m, int k)
        {

            int Index = 0, i;

            for (i = 2; i <= n-1; i++)
            {
                Index = (Index + m) % i;
            }

            Index = (Index + k) % n;

            return Index;
        }
    }
}
