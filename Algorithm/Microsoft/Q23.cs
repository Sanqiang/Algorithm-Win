/*
             double[][] rect = { 
                                     new double[] { 0, 1 }, 
                                     new double[] { 1, 1 }, 
                                     new double[] { 1, 0 }, 
                                     new double[] { 0, 0 }, 
                              };
            double[][] circle = { new double[] {100,100}};
            Console.WriteLine(Microsoft.Q23.verifyCrash(rect, circle, 1));
 */
namespace Algorithm.Microsoft
{
    class Q23
    {
        //Wrong
        public static bool verifyCrash(double[][] CoordRect, double[][] CoordCircule, double radius)
        {
            //from left upper corn to right and then down
            double[] rect1 = CoordRect[0];
            double[] rect2 = CoordRect[1];
            double[] rect3 = CoordRect[2];
            double[] rect4 = CoordRect[3];
            double[] circle = CoordCircule[0];

            double core_rect_x = (rect3[0] - rect1[0]) / 2;
            double core_rect_y = (rect3[1] - rect1[1]) / 2;
            double edge = System.Math.Sqrt(System.Math.Pow((rect3[0] - rect1[0]), 2) + System.Math.Pow((rect3[1] - rect3[1]), 2)) / 2;

            double length = System.Math.Sqrt(System.Math.Pow((circle[0] - core_rect_x), 2) + System.Math.Pow((circle[1] - core_rect_y), 2));


            return length <= (edge + radius);
        }

        //revision:loop 12/1/2012
        //Precision Loop
        static readonly double precision = 0.1;
        public static bool verifyCrash2(double[] CoordRect, double CoordEdge, double[] CoordCircule, double radius)
        {
            double CoordRect_X = CoordRect[0];
            double CoordRect_Y = CoordRect[1];

            for (double i = CoordRect_X; i <= CoordRect_X + CoordEdge; i += precision)
            {
                for (double j = CoordRect_Y; j <= CoordRect_Y + CoordEdge; j += precision)
                {
                    if (onCircule(i,j,CoordCircule,radius))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool onCircule(double x, double y, double[] CoordCircule, double radius)
        {
            return System.Math.Sqrt(System.Math.Pow(x - CoordCircule[0], 2) + System.Math.Pow(y - CoordCircule[1], 2)) <= radius;
        }
    }
}
