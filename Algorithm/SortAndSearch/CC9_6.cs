/*
            double[,] matrix = {
                                   {1,2,6,7},
                                   {3,4,7,10},
                                   {5,8,9,11},
                                   {6,10,12,13}
                               };
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrix(matrix, 10));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrix(matrix, 9));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrix(matrix, 11));

            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixV5(matrix, 10));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixV5(matrix, 9));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixV5(matrix, 11));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixV5(matrix, 110));

            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixMyV5(matrix, 10));
            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixMyV5(matrix, 110));
 */
namespace Algorithm.SortAndSearch
{
    class CC9_6
    {
        public static bool SearchOnMatrix(double[,] matrix, double target, int h = 0, int w = -1)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            if (w == -1)
            {
                w = width - 1;
            }

            while (h < height && w >= 0)
            {
                if (matrix[h, w].Equals(target))
                {
                    return true;
                }
                else if (matrix[h, w] > target)
                {
                    w--;
                }
                else
                {
                    h++;
                }
            }
            return false;
        }

        public static bool SearchOnMatrixRecursive(double[,] matrix, double target, int h = 0, int w = 0)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            if (h >= height - 1 && w >= width - 1)
            {
                return false;
            }
            else if (h >= height - 1)
            {
                w += 1;
            }
            else if (w >= width - 1)
            {
                h += 1;
            }
            else
            {
                h += 1;
                w += 1;
            }

            if (matrix[h, w].Equals(target))
            {
                return true;
            }
            else
            {
                return SearchOnMatrix(matrix, target, h, w) || SearchOnMatrix(matrix, target, h, w);
            }
        }

        public static bool SearchOnMatrixV5(double[,] matrix, double target)
        {
            return findPivot(matrix, target, new Coordinate(0, 0), new Coordinate(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1)) != null;
        }

        private static Coordinate SearchMatrix(double[,] matrix, double target, Coordinate s, Coordinate e, Coordinate pivot)
        {
            Coordinate RightTopS = new Coordinate(s.col, pivot.row);
            Coordinate RightTopE = new Coordinate(pivot.col - 1, e.row);
            Coordinate LeftBottomS = new Coordinate(pivot.col, s.row);
            Coordinate LeftBottomE = new Coordinate(e.col, pivot.row - 1);

            Coordinate result = findPivot(matrix, target, RightTopS, RightTopE);
            if (result == null)
            {
                return findPivot(matrix, target, LeftBottomS, LeftBottomE);
            }
            return result;
        }

        private static Coordinate findPivot(double[,] matrix, double target, Coordinate s, Coordinate e)
        {
            if ((!s.inBound(matrix)) || (!e.inBound(matrix)))
            {
                return null;
            }else if (matrix[s.col,s.row] == target)
            {
                return s;
            }else if (!s.isBefore(e))
            {
                return null;
            }
            Coordinate ss = s.Clone();
            int DisCol = e.col - s.col;
            int DisRow = e.row - s.row;
            int Dis = System.Math.Min(DisCol,DisRow);
            Coordinate ee = new Coordinate(s.col + Dis, s.row + Dis);
            Coordinate p = new Coordinate();
            while (ss.isBefore(ee))
            {
                p.setToMid(ss, ee);
                if (target > matrix[p.col, p.row])
                {
                    ss.col = p.col + 1;
                    ss.row = p.row + 1;
                }
                else
                {
                    ee.col = p.col - 1;
                    ee.row = p.col - 1;
                }
            }
            return SearchMatrix(matrix, target, s, e, ss);
        }

        class Coordinate
        {
            public int col;
            public int row;
            public Coordinate() { }
            public Coordinate(int col, int row)
            {
                this.col = col;
                this.row = row;
            }
            public bool isBefore(Coordinate c)
            {
                return this.col <= c.col && this.row <= c.row;
            }
            public void setToMid(Coordinate s, Coordinate e)
            {
                this.col = (s.col + e.col) / 2;
                this.row = (s.row + e.row) / 2;
            }
            public Coordinate Clone()
            {
                return new Coordinate(this.col, this.row);
            }
            public bool inBound(double[,] matrix)
            {
                return this.col >= 0 && this.col < matrix.GetLength(0)
                    && this.row >= 0 && this.row < matrix.GetLength(1);
            }
        }

        public static bool SearchOnMatrixMyV5(double[,] matrix, double target)
        {
            return SearchMyMatrix(matrix, target, new Coordinate(0, 0), new Coordinate(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1));
        }

        private static bool SearchMyMatrix(double[,] matrix, double target, Coordinate s, Coordinate e)
        {
            Coordinate pivot = findMyPivot(matrix, target, s, e);
            if (pivot == null)
            {
                return false;
            }
            if (pivot.inBound(matrix) && matrix[pivot.col, pivot.row] == target)
            {
                return true;
            }

            Coordinate RightTopS = new Coordinate(s.col, pivot.row);
            Coordinate RightTopE = new Coordinate(pivot.col - 1, e.row);
            Coordinate LeftBottomS = new Coordinate(pivot.col, s.row);
            Coordinate LeftBottomE = new Coordinate(e.col, pivot.row - 1);

            return SearchMyMatrix(matrix, target, RightTopS, RightTopE) || SearchMyMatrix(matrix, target, LeftBottomS, LeftBottomE);

        }

        private static Coordinate findMyPivot(double[,] matrix, double target, Coordinate s, Coordinate e)
        {
            if ((!s.inBound(matrix)) || (!e.inBound(matrix)))
            {
                return null;
            }
            else if (matrix[s.col, s.row] == target)
            {
                return s;
            }
            else if (!s.isBefore(e))
            {
                return null;
            }
            Coordinate ss = s.Clone();
            int DisCol = e.col - s.col;
            int DisRow = e.row - s.row;
            int Dis = System.Math.Min(DisCol, DisRow);
            Coordinate ee = new Coordinate(s.col + Dis, s.row + Dis);
            Coordinate p = new Coordinate();
            while (ss.isBefore(ee))
            {
                p.setToMid(ss, ee);
                if (target > matrix[p.col, p.row])
                {
                    ss.col = p.col + 1;
                    ss.row = p.row + 1;
                }
                else
                {
                    ee.col = p.col - 1;
                    ee.row = p.col - 1;
                }
            }

            return ss;
        }
    }
}
