/*
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(0);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(0);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(3);

            btn1.LeftNode = btn2;
            btn1.RightNode = btn3;
            btn2.LeftNode = btn4;
            btn2.RightNode = btn5;
            btn3.LeftNode = btn6;
            btn3.RightNode = btn7;

            TreeAndGraph.CC4_8.findSum(btn1, 2);
            Console.WriteLine("================================================================");
            TreeAndGraph.CC4_8.findSumExDepth(btn1, 2);
            Console.WriteLine("================================================================");
            TreeAndGraph.CC4_8.findSum5V(btn1, 2);
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_8
    {
        [System.Obsolete("Many Request, useless")]
        public static void findSum(BinaryTreeNode root, double threshold, double count = 0,
            System.Collections.Generic.List<BinaryTreeNode> list = null)
        {
            if (list == null)
            {
                list = new System.Collections.Generic.List<BinaryTreeNode>();
            }
            double Data = root.Data;
            count += Data;
            list.Add(root);
            if (count == threshold)
            {
                printPath(list);
            }
            if (root.LeftNode != null)
            {
                findSum(root.LeftNode, threshold, count, clone(list));
                findSum(root.LeftNode, threshold);
            }
            if (root.RightNode != null)
            {
                findSum(root.RightNode, threshold, count, clone(list));
                findSum(root.RightNode, threshold);
            }

        }

        private static void printPath(System.Collections.Generic.List<BinaryTreeNode> list, int end = -1)
        {
            System.Console.WriteLine();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                System.Console.Write(list[i].Data + " ");
                if (i == end)
                {
                    break;
                }
            }

            System.Console.WriteLine();
        }

        private static System.Collections.Generic.List<BinaryTreeNode> clone(System.Collections.Generic.List<BinaryTreeNode> list)
        {
            System.Collections.Generic.List<BinaryTreeNode> result = new System.Collections.Generic.List<BinaryTreeNode>();
            foreach (BinaryTreeNode btn in list)
            {
                result.Add(btn);
            }
            return result;
        }

        [System.Obsolete("Do not need list, just use array")]
        public static void findSumExDepth(BinaryTreeNode root, double threshold, int level = 0,
            System.Collections.Generic.List<BinaryTreeNode> list = null)
        {
            if (list == null)
            {
                list = new System.Collections.Generic.List<BinaryTreeNode>();
                list.Add(root);
                if (root.Data == threshold)
                {
                    printPath(list);
                }
            }
            else
            {
                list.Add(root);
                double tmp = threshold;
                for (int i = level; i >= 0; i--)
                {
                    tmp -= list[i].Data;
                    if (tmp == 0)
                    {
                        printPath(list, i);
                    }
                }
            }

            if (root.LeftNode != null)
            {
                findSumExDepth(root.LeftNode, threshold, level + 1, clone(list));
            }
            if (root.RightNode != null)
            {
                findSumExDepth(root.RightNode, threshold, level + 1, clone(list));
            }
        }
        //less space complexity
        //using reused array instead of list
        public static void findSum5V(TreeAndGraph.BinaryTreeNode head, double sum)
        {
            int depth = getDepth(head);
            double[] tab = new double[depth];
            printSum(head, 0, sum, tab);
        }

        private static void printSum(TreeAndGraph.BinaryTreeNode head, int level, double sum, double[] tab)
        {
            tab[level] = head.Data;
            double count = 0;
            for (int i = level; i >= 0; i--)
            {
                count += tab[i];
                if (count == sum)
                {
                    for (int j = level; j >= i; j--)
                    {
                        System.Console.Write(tab[j] + " ");
                    }
                    System.Console.WriteLine();
                }
            }


            if (head.LeftNode!=null)
            {
                printSum(head.LeftNode,level+1,sum,tab);
            }
            if (head.RightNode!=null)
            {
                printSum(head.RightNode, level + 1, sum, tab);
            }
            //unnecessary
            tab[level] = -1;
        }

        private static int getDepth(TreeAndGraph.BinaryTreeNode head)
        {
            if (head == null)
            {
                return 0;
            }
            return System.Math.Max(getDepth(head.LeftNode), getDepth(head.RightNode)) + 1;
        }
    }
}
