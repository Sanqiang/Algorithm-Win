/*
            bool[,] limits = new bool[3, 3];
            //limits[1, 2] = true;

            var paths = Recursive.CC8_2.getPath(2, 2, limits);
            foreach (var path in paths)
            {
                foreach (var step in path)
                {
                    Console.Write(step + " ");
                }
                Console.WriteLine();
            }
            bool[,] cache = new bool[3, 3];
            var list =new List<Recursive.CC8_2.Point>();
            Recursive.CC8_2.isConnectPathV5(2, 2,list,cache, limits);
            Console.WriteLine("\r\nI am done!!");
            Console.WriteLine(list);
 */
namespace Algorithm.Recursive
{
    class CC8_2
    {
        static System.Collections.Generic.List<System.Collections.ArrayList> paths = new System.Collections.Generic.List<System.Collections.ArrayList>();
        public static System.Collections.Generic.List<System.Collections.ArrayList> getPath(int X, int Y, bool[,] limits)
        {
            bool[,] cache = new bool[X + 1, Y + 1];
            go(new System.Collections.ArrayList(), X, Y, limits, cache);
            return paths;
        }

        private static void go(System.Collections.ArrayList path, int X, int Y, bool[,] limits, bool[,] cache, short direct = 0)
        {
            if (!cache[X, Y])
            {
                cache[X, Y] = true;
            }
            else
            {
                //RETURN LIST ALREADY VISITED
            }

            if (direct > 0)
            {
                path.Add(direct);
            }
            if (X == 0 && Y == 0)
            {
                paths.Add(path);
                return;
            }

            if (X > 0 && verifyImpediment(limits, X - 1, Y))
            {
                go((System.Collections.ArrayList)path.Clone(), X - 1, Y, limits, cache, 1);
            }
            if (Y > 0 && verifyImpediment(limits, X, Y - 1))
            {
                go((System.Collections.ArrayList)path.Clone(), X, Y - 1, limits, cache, 2);
            }
        }

        private static bool verifyImpediment(bool[,] limits, int X, int Y)
        {
            if (limits[X, Y])
            {
                return false;
            }
            return true;
        }

        public static bool isConnectPathV5(int X, int Y, System.Collections.Generic.List<Point> path, bool[,] cache, bool[,] limit)
        {
            Point p = new Point(X, Y);
            if (cache[X, Y])
            {
                return false;
            }
            path.Add(p);

            if (X == 0 && Y == 0)
            {
                return true;
            }
            bool success = false;
            if (X >= 1 && verifyImpediment(limit, X - 1, Y))
            {
                success = isConnectPathV5(X - 1, Y, path, cache, limit);
            }
            if (!success && Y >= 1 && verifyImpediment(limit, X, Y - 1))
            {
                success = isConnectPathV5(X, Y - 1, path, cache, limit);
            }
            if (!success)
            {
                path.Remove(p);
                cache[X, Y] = true;
            }
           
            return success;
        }
        public class Point
        {
            public int X;
            public int Y;
            public Point(int _x, int _y)
            {
                this.X = _x;
                this.Y = _y;
            }
        }

    }
}
