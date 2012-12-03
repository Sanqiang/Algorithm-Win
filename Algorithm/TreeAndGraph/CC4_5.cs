/*
             TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
            btn3.LeftNode = btn6; btn3.RightNode = btn7;
            btn4.ParentNode = btn2;
            btn5.ParentNode = btn2;
            btn6.ParentNode = btn3;
            btn7.ParentNode = btn3;
            btn2.ParentNode = btn1;
            btn3.ParentNode = btn1;

            Console.WriteLine(TreeAndGraph.CC4_5.inorderSucc(btn4).Data);
 */ 
namespace Algorithm.TreeAndGraph
{
    public class CC4_5
    {
        public static BinaryTreeNode inorderSucc(BinaryTreeNode orignal)
        {
            if (orignal.ParentNode == null && orignal.RightNode != null)
            {
                BinaryTreeNode btn = orignal.RightNode;
                while (btn != null)
                {
                    if (btn.LeftNode != null)
                    {
                        return btn.LeftNode;
                    }
                    btn = btn.RightNode;
                }
            }
            else
            {
                BinaryTreeNode btn = orignal; 
                while (btn.ParentNode != null)
                {
                    if (btn.ParentNode.LeftNode == btn)
                    {
                        return btn.ParentNode;
                    }
                    btn = btn.ParentNode;
                }
                return btn;
            }
            return null;
        }
    }
}
