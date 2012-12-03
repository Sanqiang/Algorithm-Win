/*
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
            btn3.LeftNode = btn6; btn3.RightNode = btn7;

            TreeAndGraph.BinaryTreeNode btn11 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn12 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn13 = new TreeAndGraph.BinaryTreeNode(7);
            btn11.LeftNode = btn12; btn11.RightNode = btn13;

            Console.WriteLine(TreeAndGraph.CC4_7.isSubTree(btn1, btn11));
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_7
    {
        public static bool isSubTree(BinaryTreeNode large, BinaryTreeNode small)
        {
            return findHead(large, small);
        }

        private static bool findHead(BinaryTreeNode large, BinaryTreeNode small)
        {
            if (large == null)
            {
                return false;
            }
            if (large.Data == small.Data)
            {
                return isSameTree(large,small);
            }
            return findHead(large.LeftNode, small) || findHead(large.RightNode, small);

        }

        private static bool isSameTree(BinaryTreeNode large, BinaryTreeNode small)
        {
            if (large == null && small == null)
            {
                return true;
            }
            if (large.Data.Equals(small.Data))
            {
                return isSameTree(large.LeftNode, small.LeftNode)
                    && isSameTree(large.RightNode, small.RightNode);
            }
            return false;
        }
    }
}
