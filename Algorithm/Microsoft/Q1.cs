/*
            TreeAndGraph.BinaryTreeNode btn10 = new TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(6);
            TreeAndGraph.BinaryTreeNode btn14 = new TreeAndGraph.BinaryTreeNode(14);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn8 = new TreeAndGraph.BinaryTreeNode(8);
            TreeAndGraph.BinaryTreeNode btn12 = new TreeAndGraph.BinaryTreeNode(12);
            TreeAndGraph.BinaryTreeNode btn16 = new TreeAndGraph.BinaryTreeNode(16);
            btn10.LeftNode = btn6; btn10.RightNode = btn14; btn6.LeftNode = btn4; btn6.RightNode = btn8; btn14.LeftNode = btn12; btn14.RightNode = btn16;
            LinkedList.DoubleLinkedNode dln = Microsoft.Q1.getDoubleLinkedListFromBinarySearchTree(btn10);

            while (dln != null)
            {
                Console.WriteLine(dln.Data);
                dln = dln.Last;
            }
 */
namespace Algorithm.Microsoft
{
    class Q1
    {
        public static LinkedList.DoubleLinkedNode getDoubleLinkedListFromBinarySearchTree(TreeAndGraph.BinaryTreeNode head)
        {
            traverse(head);
            return dln;
        }

        //Mid-Order means middle one is in the first
        static LinkedList.DoubleLinkedNode dln = null;
        private static void traverse(TreeAndGraph.BinaryTreeNode btn)
        {
            if (btn == null)
            {
                return;
            }
            traverse(btn.LeftNode);

            if (dln == null)
            {
                dln = new LinkedList.DoubleLinkedNode(btn.Data);
            }
            else
            {
                LinkedList.DoubleLinkedNode new_dln = new LinkedList.DoubleLinkedNode(btn.Data);
                dln.Next = new_dln;
                new_dln.Last = dln;
                dln = new_dln;
            }


            traverse(btn.RightNode);

        }

    }
}
