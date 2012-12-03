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

            var e = TreeAndGraph.CC4_4.getLevelLinkedList(btn1);
            Console.WriteLine(e);
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_4
    {
        public static System.Collections.Generic.Dictionary<System.Int16, System.Collections.Generic.List<BinaryTreeNode>> getLevelLinkedList(BinaryTreeNode head)
        {
            System.Collections.Generic.Dictionary<System.Int16, System.Collections.Generic.List<BinaryTreeNode>> result
                = new System.Collections.Generic.Dictionary<System.Int16, System.Collections.Generic.List<BinaryTreeNode>>();
            short level = 0;
            System.Collections.Generic.List<BinaryTreeNode> list = new System.Collections.Generic.List<BinaryTreeNode>();
            list.Add(head);
            result.Add(level, list);

            while (true)
            {
                System.Collections.Generic.List<BinaryTreeNode> list_loop = result[level];
                list = new System.Collections.Generic.List<BinaryTreeNode>();
                result.Add(++level, list);
                foreach (BinaryTreeNode btn in list_loop)
                {
                    if (btn.LeftNode != null)
                    {
                        list.Add(btn.LeftNode);
                    }
                    if (btn.RightNode != null)
                    {
                        list.Add(btn.RightNode);
                    }
                }
                if (list.Count == 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
