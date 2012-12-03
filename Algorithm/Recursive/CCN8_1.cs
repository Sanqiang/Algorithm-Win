/*
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(Recursive.CCN8_1.countWayClimb(50, new Dictionary<long, long>()));
            DateTime dt2 = DateTime.Now;
            long[] map = new long[51];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = -1;
            }
            Console.WriteLine(Recursive.CCN8_1.countWayClimbArray(50,map));
            DateTime dt3 = DateTime.Now;
            Console.WriteLine(Recursive.CCN8_1.countWayClimbSimple(50));
            DateTime dt4 = DateTime.Now;

            Console.WriteLine((dt3 - dt2)+"<"+(dt2 - dt1) + "<" + (dt3 - dt2));
 */
namespace Algorithm.Recursive
{
    public class CCN8_1
    {
        public static long countWayClimbArray(long n, long[] map)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 0;
            }
            else if (map[n] > -1)
            {
                return map[n];
            }
            else
            {
                map[n] = countWayClimbArray(n - 1, map) + countWayClimbArray(n - 2, map) + countWayClimbArray(n - 3, map);
                return map[n];
            }
        }

        public static long countWayClimb(long n, System.Collections.Generic.Dictionary<long, long> map)
        {
            if (map.ContainsKey(n))
            {
                return map[n];
            }
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                long remaing = countWayClimb(n - 1, map) + countWayClimb(n - 2, map) + countWayClimb(n - 3, map);
                map.Add(n, remaing);
                return remaing;
            }
        }
        public static long countWayClimbSimple(long n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return countWayClimbSimple(n - 1) + countWayClimbSimple(n - 2) + countWayClimbSimple(n - 3);
            }
        }
    }
}
