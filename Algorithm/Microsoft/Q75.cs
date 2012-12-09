
namespace Algorithm.Microsoft
{
    public class Q75
    {
        //reference to CC4_6

        //practice: my implementation
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

            Wrapper wr = findCommonAncesterWrap(btn1, btn4, btn5);
            if (wr.find)
            {
                Console.WriteLine(wr.btn.Data);
            }
         */
        static Wrapper findCommonAncesterWrap(TreeAndGraph.BinaryTreeNode root, TreeAndGraph.BinaryTreeNode p, TreeAndGraph.BinaryTreeNode q)
        {
            if (root == null)
            {
                Wrapper w = new Wrapper();
                return w;
            }

            Wrapper lw = findCommonAncesterWrap(root.LeftNode, p, q);
            if (lw.find)
            {
                return lw;
            }
            Wrapper rw = findCommonAncesterWrap(root.RightNode, p, q);
            if (rw.find)
            {
                return rw;
            }

            Wrapper wr = new Wrapper();
            if (root == p || root == q)
            {
                wr.find = lw.btn != null || rw.btn != null;
                wr.btn = root;
            }
            else if (lw.btn != null && rw.btn != null)
            {
                wr.find = true;
                wr.btn = root;
            }
            else
            {
                wr.find = false;
                wr.btn = lw.btn != null ? lw.btn : rw.btn;
            }

            return wr;
        }

        class Wrapper
        {
            public bool find = false;
            public TreeAndGraph.BinaryTreeNode btn = null;
        }
    }
}
