/*
            TreeAndGraph.BinaryTreeNode tn1 = new Algorithm.TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode tn2 = new Algorithm.TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode tn3 = new Algorithm.TreeAndGraph.BinaryTreeNode(15);
            TreeAndGraph.BinaryTreeNode tn4 = new Algorithm.TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode tn5 = new Algorithm.TreeAndGraph.BinaryTreeNode(7);
            TreeAndGraph.BinaryTreeNode tn6 = new Algorithm.TreeAndGraph.BinaryTreeNode(13);
            TreeAndGraph.BinaryTreeNode tn7 = new Algorithm.TreeAndGraph.BinaryTreeNode(17);
			tn1.LeftNode=tn2; tn1.RightNode=tn3;
			tn2.LeftNode=tn4; tn2.RightNode=tn5;
			tn3.LeftNode=tn6; tn3.RightNode=tn7;
            Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verify(tn1));
            Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verifyWithArray(tn1));
            Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verifyWithFlag(tn1));
            TreeAndGraph.BinaryTreeNode tnx = new Algorithm.TreeAndGraph.BinaryTreeNode(11);
			tn2.RightNode=tnx;
			Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verify(tn1));
            Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verifyWithArray(tn1));
            Console.WriteLine(TreeAndGraph.VerifyBinarySearchTree.verifyWithFlag(tn1));
*/

namespace Algorithm.TreeAndGraph
{

    public class VerifyBinarySearchTree
    {
        public static bool verify(BinaryTreeNode root)
        {
            //return verifyRecursive(root,System.Double.MinValue,System.Double.MaxValue);
            return verifyRecursive2(root, System.Double.MinValue, System.Double.MaxValue);
        }

        private static bool verifyRecursive(BinaryTreeNode node, double min, double max)
        {
            if (node == null)
            {
                return true;
            }

            return node.Data >= min && node.Data <= max &&
                verifyRecursive(node.LeftNode, min, node.Data) &&
                    verifyRecursive(node.RightNode, node.Data, max);
        }

        private static bool verifyRecursive2(BinaryTreeNode node, double min, double max)
        {
            if (node == null)
            {
                return true;
            }
            if (verifyRecursive2(node.LeftNode, min, node.Data)
                && verifyRecursive2(node.RightNode, node.Data, max)
                && node.Data >= min && node.Data <= max) return true;
            else return false;
        }

        public static bool verifyWithArray(BinaryTreeNode node)
        {
            System.Collections.Generic.List<double> list = new System.Collections.Generic.List<double>();
            copyToArray(node, list);
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i-1])
                {
                    return false;
                }
            }
            return true;
        }
        private static void copyToArray(BinaryTreeNode node, System.Collections.Generic.List<double> list)
        {
            if (node == null)
            {
                return;
            }
            copyToArray(node.LeftNode, list);
            list.Add(node.Data);
            copyToArray(node.RightNode, list);
        }

        
        public static bool verifyWithFlag(BinaryTreeNode node)
        {
            if (node == null)
            {
                return true;
            }
            verifyWithFlag(node.LeftNode);
            if (node.Data < LastVal) return false;
            LastVal = node.Data;
            verifyWithFlag(node.RightNode);
            return true;

        }
        static double LastVal = double.MinValue;
    }
}
