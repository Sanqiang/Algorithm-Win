/*
            TreeAndGraph.TreeNode tn1 = new TreeAndGraph.TreeNode(1);
            TreeAndGraph.TreeNode tn2 = new TreeAndGraph.TreeNode(2);
            TreeAndGraph.TreeNode tn3 = new TreeAndGraph.TreeNode(3);
            TreeAndGraph.TreeNode tn4 = new TreeAndGraph.TreeNode(4);
            TreeAndGraph.TreeNode tn5 = new TreeAndGraph.TreeNode(5);
            TreeAndGraph.TreeNode tn6 = new TreeAndGraph.TreeNode(6);
            TreeAndGraph.TreeNode tn7 = new TreeAndGraph.TreeNode(7);
            TreeAndGraph.TreeNode tn8 = new TreeAndGraph.TreeNode(8);
            TreeAndGraph.TreeNode tn9 = new TreeAndGraph.TreeNode(9);
            TreeAndGraph.TreeNode tn10 = new TreeAndGraph.TreeNode(10);
            TreeAndGraph.TreeNode tn11 = new TreeAndGraph.TreeNode(11);
            TreeAndGraph.TreeNode tn12 = new TreeAndGraph.TreeNode(12);
            TreeAndGraph.TreeNode tn13 = new TreeAndGraph.TreeNode(13);

            tn1.Nodes.Add(tn2); tn1.Nodes.Add(tn3); tn1.Nodes.Add(tn4);
            tn2.Nodes.Add(tn6); tn2.Nodes.Add(tn5);
            tn3.Nodes.Add(tn7);
            //tn4.Nodes.Add(tn8);
            //tn7.Nodes.Add(tn10); tn10.Nodes.Add(tn11); tn11.Nodes.Add(tn12); tn12.Nodes.Add(tn13);
            //tn13.Nodes.Add(tn9);

            Console.WriteLine(TreeAndGraph.CC4_1.verifyBalanced(tn1));

            Console.WriteLine(TreeAndGraph.CC4_1.Max + ">" + TreeAndGraph.CC4_1.Min);

            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2= new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(1);
            btn1.LeftNode = btn2; btn1.RightNode = btn3; btn2.LeftNode = btn4; btn2.RightNode = btn5;
            //btn5.LeftNode = btn6;
            Console.WriteLine(TreeAndGraph.CC4_1.verifyBalancedV5(btn1));
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_1
    {

        public static int Min = System.Int16.MinValue;
        public static int Max = System.Int16.MaxValue;
        static bool findMin = true;

        public static bool verifyBalanced(TreeNode td)
        {
            System.Collections.Generic.Queue<TreeNode> q = new System.Collections.Generic.Queue<TreeNode>();
            q.Enqueue(td);


            while (q.Count != 0)
            {
                TreeNode tn_from_queue = q.Dequeue();
                if (tn_from_queue.Nodes.Count == 0)
                {
                    if (findMin)
                    {
                        Min = tn_from_queue.state;
                        findMin = false;
                    }
                    Max = tn_from_queue.state;
                }

                foreach (TreeNode tn_loop in tn_from_queue.Nodes)
                {
                    tn_loop.state = tn_from_queue.state + 1;
                    q.Enqueue(tn_loop);
                }
            }
            return (Max - Min) <= 1; 
        }

        public static bool verifyBalancedV5(BinaryTreeNode head)
        {
            if (getHeight(head) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static int getHeight(BinaryTreeNode btn)
        {
            if (btn == null)
            {
                return 0;
            }
            int height_left = getHeight(btn.LeftNode);
            if (height_left == -1)
            {
                return -1;
            }

            int height_right = getHeight(btn.RightNode);
            if (height_right == -1)
            {
                return -1;
            }

            int height_diff = System.Math.Abs(height_left - height_right);
            if (height_diff > 1)
            {
                return -1;
            }
            else
            {
                return System.Math.Max(height_left, height_right) + 1;
            }
        }


    }
}
