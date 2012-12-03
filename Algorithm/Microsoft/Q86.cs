/*
             int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            TreeAndGraph.BinaryTreeNode root = Microsoft.Q86.buildBinarySearchTree(arr);
 */ 
namespace Algorithm.Microsoft
{
    class Q86
    {
        //reference to CC4.3
        public static TreeAndGraph.BinaryTreeNode buildBinarySearchTree(int[] arr, int s = -1, int e = -1)
        {
            if (s == -1)
            {
                s = 0;
            }
            if (e == -1)
            {
                e = arr.Length - 1;
            }
            int m = (s + e) / 2;
            TreeAndGraph.BinaryTreeNode head = new TreeAndGraph.BinaryTreeNode(arr[m]);
            if (m - 1 >= s)
            {
                head.LeftNode = buildBinarySearchTree(arr, s, m - 1);
            }
            if (e >= m + 1)
            {
                head.RightNode = buildBinarySearchTree(arr, m + 1, e);
            }

            return head;
        }
    }
}
