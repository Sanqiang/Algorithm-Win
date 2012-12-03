/*
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn8 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn9 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn10 = new TreeAndGraph.BinaryTreeNode(1);
            btn1.LeftNode = btn2;
            btn1.RightNode = btn10;
            btn2.LeftNode = btn3;
            btn3.LeftNode = btn5;
            btn5.LeftNode = btn7;
            btn7.LeftNode = btn8;

            btn2.RightNode = btn4;
            btn4.RightNode = btn6;
            btn6.RightNode = btn9;

            Console.WriteLine(Microsoft.Q39.findBiggestDistance(btn1).MaxDistance + "-" + Microsoft.Q39.findBiggestDistance(btn1).MaxDepth);

 */
namespace Algorithm.Microsoft
{
    class Q39
    {
        public static Result findBiggestDistance(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                Result n = new Result();
                n.MaxDepth = 0; n.MaxDistance = 0;
                return n;
            }

            Result r_left = findBiggestDistance(root.LeftNode);
            Result r_right = findBiggestDistance(root.RightNode);

            Result r = new Result();
            r.MaxDepth = System.Math.Max(r_left.MaxDepth, r_right.MaxDepth) + 1;
            r.MaxDistance = System.Math.Max(System.Math.Max(r_left.MaxDistance, r_right.MaxDistance), r_left.MaxDepth + r_right.MaxDepth + 1);
            //r_left.MaxDepth + r_right.MaxDepth + 1;
            //System.Math.Max(System.Math.Max(r_left.MaxDistance, r_right.MaxDistance), r_left.MaxDepth + r_right.MaxDepth +1);
            return r;

        }

        public struct Result
        {
            public int MaxDistance;
            public int MaxDepth;
        }

        
    }
}
