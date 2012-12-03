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
            TreeAndGraph.BinaryTreeNode btn8 = new TreeAndGraph.BinaryTreeNode(8);
            TreeAndGraph.BinaryTreeNode btn9 = new TreeAndGraph.BinaryTreeNode(9);
            btn4.LeftNode = btn8;
            btn4.RightNode = btn9;
            //Console.WriteLine(TreeAndGraph.CC4_6.findCommonAncesterV5(btn1, btn4, btn5).Data);
            Console.WriteLine(TreeAndGraph.CC4_6.findCommonAncesterBadV5(btn1, btn4, btn8).Data);
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_6
    {

        public static TreeAndGraph.BinaryTreeNode findCommonAncesterV5(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode p, TreeAndGraph.BinaryTreeNode q)
        {
            Result r = findCommonAncesterWrap(root, p, q);
            if (r.find)
            {
                return r.btn;
            }
            return null;
        }

        private static Result findCommonAncesterWrap(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode p, TreeAndGraph.BinaryTreeNode q)
        {
            if (root == null)
            {
                return new Result(false, root);
            }
            if (root == p && root == q)
            {
                return new Result(true, root);
            }

            Result l = findCommonAncesterWrap(root.LeftNode, p, q);
            if (l.find)
            {
                return l;
            }

            Result r = findCommonAncesterWrap(root.RightNode, p, q);
            if (r.find)
            {
                return r;
            }

            if (l.btn != null && r.btn != null)
            {
                return new Result(true, root);
            }
            else if (root == p || root == q)
            {
                return new Result((l.btn != null || r.btn != null), root);
            }
            else
            {
                return new Result(false, l.btn == null ? r.btn : l.btn);
            }
        }

        class Result
        {
            public bool find = false;
            public TreeAndGraph.BinaryTreeNode btn = null;
            public Result() { }
            public Result(bool find, TreeAndGraph.BinaryTreeNode btn)
            {
                this.find = find;
                this.btn = btn;
            }
        }


        public static TreeAndGraph.BinaryTreeNode findCommonAncesterBadV5(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode p, TreeAndGraph.BinaryTreeNode q)
        {
            if (root == null)
            {
                return null;
            }
            if (root == p && root == q)
            {
                return root;
            }

            TreeAndGraph.BinaryTreeNode x = findCommonAncesterBadV5(root.LeftNode, p, q);
            if (x != null && x != p && x != q)
            {
                return x;
            }

            TreeAndGraph.BinaryTreeNode y = findCommonAncesterBadV5(root.RightNode, p, q);
            if (y != null && y != p && y != q)
            {
                return y;
            }

            if (x != null && y != null)
            {
                return root;
            }
            else if (root == p || root == q)
            {
                return root;
            }
            else
            {
                return x == null ? y : x;
            }

        }

        public static BinaryTreeNode findCommonAncester(BinaryTreeNode root, BinaryTreeNode tn1, BinaryTreeNode tn2)
        {
            if (Cover(root.LeftNode, tn1) && Cover(root.LeftNode, tn2))
            {
                return findCommonAncester(root.LeftNode, tn1, tn2);
            }
            else if (Cover(root.RightNode, tn1) && Cover(root.RightNode, tn2))
            {
                return findCommonAncester(root.RightNode, tn1, tn2);
            }
            return root;
        }

        private static bool Cover(BinaryTreeNode head, BinaryTreeNode target)
        {
            if (head == null)
            {
                return false;
            }
            if (head == target)
            {
                return true;
            }
            return Cover(head.LeftNode, target) || Cover(head.RightNode, target);
            //return head.LeftNode != null ? Cover(head.LeftNode, target) : false ||
            //    head.RightNode != null ? Cover(head.RightNode, target) : false;
        }

        public static BinaryTreeNode findCommonAncesterEx(BinaryTreeNode root, BinaryTreeNode tn1, BinaryTreeNode tn2)
        {
            int CountFromLeft = Count(root.LeftNode, tn1, tn2);
            if (CountFromLeft == 2)
            {
                return findCommonAncesterEx(root.LeftNode, tn1, tn2);
            }
            else if (CountFromLeft == 1)
            {
                return root;
            }
            int CountFromRight = Count(root.RightNode, tn1, tn2);
            if (CountFromRight == 2)
            {
                return findCommonAncesterEx(root.RightNode, tn1, tn2);
            }
            else if (CountFromRight == 1)
            {
                return root;
            }
            return null;
        }

        private static int Count(BinaryTreeNode btn, BinaryTreeNode tn1, BinaryTreeNode tn2)
        {
            int count = 0;
            if (btn == tn1 || btn == tn2)
            {
                ++count;
            }
            if (btn.LeftNode != null)
            {
                count += Count(btn.LeftNode, tn1, tn2);
            }
            if (count == 2)
            {
                return 2;
            }
            if (btn.RightNode != null)
            {
                count += Count(btn.RightNode, tn1, tn2);
            }

            return count;
        }

    }
}
