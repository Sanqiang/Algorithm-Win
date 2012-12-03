/*
             double[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            TreeAndGraph.BinaryTreeNode head = TreeAndGraph.CC4_3.buildBinarySearchTree(arr);
            Console.WriteLine(head);
 */ 
namespace Algorithm.TreeAndGraph
{
    public class CC4_3
    {
        public static BinaryTreeNode buildBinarySearchTree(double[] arr)
        {
            int mid = arr.Length / 2;
            BinaryTreeNode root = new BinaryTreeNode(arr[mid]);
            return buildChild(root, arr, 0, arr.Length - 1);
        }

        private static BinaryTreeNode buildChild(BinaryTreeNode parent, double[] arr, int start, int end)
        {

            int child_mid = (end - start) / 2 + start;

            BinaryTreeNode child = new BinaryTreeNode(arr[child_mid]);

            if (start - end == 0)
            {
                return child;
            }
            child.LeftNode = buildChild(child, arr, start, child_mid - 1);
            child.RightNode = buildChild(child, arr, child_mid + 1, end);

            return child;
        }
    }
}