/*
            BinaryTreeNode root = new BinaryTreeNode(1);
            BinaryTreeNode btn1 = new BinaryTreeNode(2);
            BinaryTreeNode btn2 = new BinaryTreeNode(3);
            BinaryTreeNode btn3 = new BinaryTreeNode(4);
            BinaryTreeNode btn4 = new BinaryTreeNode(5);
            root.LeftNode = btn1;
            root.RightNode = btn3;
            btn1.LeftNode = btn2;
            btn3.RightNode = btn4;
            BinaryTreeNode btn10 = new BinaryTreeNode(10);
            BinaryTreeNode btn11 = new BinaryTreeNode(11);
            btn1.RightNode = btn10;
            BinaryTreeNode btn12 = new BinaryTreeNode(12);
            btn3.LeftNode = btn12;
            BinaryTreeNode btn13 = new BinaryTreeNode(13);
            btn2.LeftNode = btn13;
            Console.WriteLine(countMaxDistance(root));
 */
namespace Algorithm.Microsoft
{
    class Q11
    {
        //reference to CC4.1


        public static int countMaxDistance(TreeAndGraph.BinaryTreeNode root)
        {
            return countMaxDistanceHelper(root) - 1;
        }

        public static int countMaxDistanceHelper(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + System.Math.Abs(countMaxDistanceHelper(root.LeftNode) - countMaxDistanceHelper(root.RightNode));
        }
    }
}
