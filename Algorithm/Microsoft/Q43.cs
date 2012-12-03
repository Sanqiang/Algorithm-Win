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

            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Pre);
            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Mid);
            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Post);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Pre);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Mid);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Post);
 */ 
namespace Algorithm.Microsoft
{
    public class Q43
    {
        public enum Order
        {
            Pre, Mid, Post
        }
        public static void interateBinaryTree(TreeAndGraph.BinaryTreeNode head, Order o)
        {
            if (head == null)
            {
                return;
            }

            if (o == Order.Pre)
            {
                System.Console.WriteLine("Pre:" + head.Data);
            }

            interateBinaryTree(head.LeftNode, o);

            if (o == Order.Mid)
            {
                System.Console.WriteLine("Mid:" + head.Data);
            }

            interateBinaryTree(head.RightNode, o);

            if (o == Order.Post)
            {
                System.Console.WriteLine("Post:" + head.Data);
            }
        }

        public static void interateBinaryTreeEx(TreeAndGraph.BinaryTreeNode head, Order o)
        {
            TreeAndGraph.BinaryTreeNode btn = head;
            if (o == Order.Post)
            {
                System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode> s
                    = new System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode>();
                s.Push(btn);
                TreeAndGraph.BinaryTreeNode cur = null;
                TreeAndGraph.BinaryTreeNode pre = null;
                while (s.Count != 0)
                {
                    cur = s.Peek();
                    if ((cur.LeftNode == null && cur.RightNode == null) || (pre != null && (pre == cur.LeftNode || pre == cur.RightNode)))
                    {
                        System.Console.WriteLine("XPost:"+cur.Data);
                        s.Pop();
                        pre = cur;
                    }
                    else
                    {
                        if (cur.RightNode != null)
                        {
                            s.Push(cur.RightNode);
                        }
                        if (cur.LeftNode != null)
                        {
                            s.Push(cur.LeftNode);
                        }
                    }
                }
            }
            if (o == Order.Pre)
            {
                System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode> s
                    = new System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode>();

                while (btn != null || s.Count != 0)
                {
                    while (btn != null)
                    {
                        s.Push(btn);
                        System.Console.WriteLine("XPre:" + btn.Data);
                        btn = btn.LeftNode;
                    }
                    if (s.Count != 0)
                    {
                        btn = s.Pop().RightNode;
                    }
                }
            }
            if (o == Order.Mid)
            {
                System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode> s
                     = new System.Collections.Generic.Stack<TreeAndGraph.BinaryTreeNode>();
                while (btn != null || s.Count != 0)
                {
                    while (btn != null)
                    {
                        s.Push(btn);
                        btn = btn.LeftNode;
                    }
                    if (s.Count != 0)
                    {
                        btn = s.Pop();
                        System.Console.WriteLine("XMid:" + btn.Data);
                        btn = btn.RightNode;
                    }

                }
            }
        }
    }
}
