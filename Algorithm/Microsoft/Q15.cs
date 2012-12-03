/*
             TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3; btn2.LeftNode = btn4; btn2.RightNode = btn5; btn3.LeftNode = btn6; btn3.RightNode = btn7;
            Console.WriteLine(btn3.LeftNode.Data + "-" + btn3.RightNode.Data);
            Microsoft.Q15.mirrorTree(btn1);
            Console.WriteLine(btn3.LeftNode.Data + "-" + btn3.RightNode.Data);
 */ 
namespace Algorithm.Microsoft
{
    class Q15
    {
        public static void mirrorTree(TreeAndGraph.BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            if (root.LeftNode != null && root.RightNode !=null)
            {
                TreeAndGraph.BinaryTreeNode temp = root.LeftNode;
                root.LeftNode = root.RightNode;
                root.RightNode = temp;
                mirrorTree(root.LeftNode);
                mirrorTree(root.RightNode);
            }
            else if(root.LeftNode!=null)
            {
                root.LeftNode = root.RightNode;
                mirrorTree(root.LeftNode);
            }
            else if (root.RightNode!=null)
            {
                root.RightNode = root.LeftNode;
                mirrorTree(root.RightNode);
            }
            else
            {
                return;
            }
        }

        //revision: clear 12/1/2012
        /*
                     TreeAndGraph.BinaryTreeNode btn10 = new TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn14 = new TreeAndGraph.BinaryTreeNode(14);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn8 = new TreeAndGraph.BinaryTreeNode(8);
            TreeAndGraph.BinaryTreeNode btn12 = new TreeAndGraph.BinaryTreeNode(12);
            TreeAndGraph.BinaryTreeNode btn16 = new TreeAndGraph.BinaryTreeNode(16);
            btn10.LeftNode = btn6; btn10.RightNode = btn14; btn6.LeftNode = btn4; btn6.RightNode = btn8; btn14.LeftNode = btn12; btn14.RightNode = btn16;
            swapTree(btn10);
         */
        public static void swapTree(TreeAndGraph.BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            TreeAndGraph.BinaryTreeNode temp = node.LeftNode;
            node.LeftNode = node.RightNode;
            node.RightNode = temp;

            swapTree(node.LeftNode);
            swapTree(node.RightNode);
        }
    }
}
