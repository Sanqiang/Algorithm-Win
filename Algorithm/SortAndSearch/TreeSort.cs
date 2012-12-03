/*
             double[] arr = { 5, 7, 6, 8, 9, 1, 7, 4, 2, 0, 3, 4, 5, 6, 5, 7, 2, 8, 7 };
            SortAndSearch.TreeSort.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
 */ 
namespace Algorithm.SortAndSearch
{
    class TreeSort
    {
        public static void Sort(double[] arr)
        {
            int length = arr.Length, i;
            TreeAndGraph.BinarySearchTree btn = new TreeAndGraph.BinarySearchTree(arr[0]);

            for (i = 1; i < length; i++)
            {
                btn.AddTreeNode(arr[i]);
            }

            PutArr(btn.root, arr);
        }

        static int index = 0;
        private static void PutArr(TreeAndGraph.BinaryTreeNode root, double[] arr)
        {
            if (root == null)
            {
                return;
            }
            
            PutArr(root.LeftNode, arr);

            arr[index++] = root.Data;

            PutArr(root.RightNode, arr);

            
        }

    }
}
