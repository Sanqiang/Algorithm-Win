/*
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(15);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(7);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(12);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(17);

            btn1.LeftNode = btn2;
            btn1.RightNode = btn3;
            btn2.LeftNode = btn4;
            btn2.RightNode = btn5;
            btn3.LeftNode = btn6;
            btn3.RightNode = btn7;

            Console.WriteLine(Microsoft.Q50.getLongestDistance(btn1, btn1, btn4));
 */
namespace Algorithm.Microsoft
{
    class Q50
    {
        //reference to Q39(Similar)

        public static int getLongestDistance(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode left, TreeAndGraph.BinaryTreeNode right)
        {
            ReturnWrapper wr = getLongestDistanceHelper(root, left, right);

            //left or right is root will done separately

            if (wr.findleft && wr.findright)
            {
                return wr.count;
            }
            else
            {
                return -1;
            }
        }

        public static ReturnWrapper getLongestDistanceHelper(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode left, TreeAndGraph.BinaryTreeNode right)
        {
            if (root == null)
            {
                return new ReturnWrapper();
            }
            //if (root == left)
            //{
            //    ReturnWrapper rw = new ReturnWrapper();
            //    rw.findleft = true;
            //    return rw;
            //}
            //else if (root == right)
            //{
            //    ReturnWrapper rw = new ReturnWrapper();
            //    rw.findright=true;
            //    return rw;
            //}

            ReturnWrapper left_wrapper = getLongestDistanceHelper(root.LeftNode, left, right);
            if (left_wrapper.findleft && left_wrapper.findright)
            {
                return left_wrapper;
            }
            else if (left_wrapper.findleft || left_wrapper.findright)
            {
                ++left_wrapper.count;
            }

            ReturnWrapper right_wrapper = getLongestDistanceHelper(root.RightNode, left, right);
            if (right_wrapper.findleft && right_wrapper.findright)
            {
                return right_wrapper;
            }
            else if (right_wrapper.findleft || right_wrapper.findright)
            {
                ++right_wrapper.count;
            }

            ReturnWrapper wr = new ReturnWrapper();
            wr.count = left_wrapper.count + right_wrapper.count;
            if (root == left)
            {
                wr.findleft = true;

            }
            else
            {
                wr.findleft = left_wrapper.findleft ? left_wrapper.findleft : right_wrapper.findleft;
            }
            if (root == right)
            {
                wr.findright = true;
            }
            else
            {
                wr.findright = left_wrapper.findright ? left_wrapper.findright : right_wrapper.findright;
            }

            return wr;
        }

        public class ReturnWrapper
        {
            public bool findleft = false;
            public bool findright = false;
            public int count = 0;
        }

        //Sample Solution

    }
}
