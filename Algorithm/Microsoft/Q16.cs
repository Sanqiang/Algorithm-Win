/*
             TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3; btn2.LeftNode = btn4; btn2.RightNode = btn5; btn3.LeftNode = btn6; btn3.RightNode = btn7;
            Microsoft.Q16.BreathFirstSearch(btn1);
 */ 
namespace Algorithm.Microsoft
{
    class Q16
    {
        public static void BreathFirstSearch(TreeAndGraph.BinaryTreeNode root)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue(root);
            while (q.Count!=0)
            {
                TreeAndGraph.BinaryTreeNode btn = (TreeAndGraph.BinaryTreeNode)q.Dequeue();
                System.Console.WriteLine(btn.Data);
                if (btn.LeftNode != null)
                {
                    q.Enqueue(btn.LeftNode);
                }
                if (btn.RightNode != null)
                {
                    q.Enqueue(btn.RightNode);
                }
            }
        }
    }
}
