/*

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
