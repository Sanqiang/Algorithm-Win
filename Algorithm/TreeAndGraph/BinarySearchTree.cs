namespace Algorithm.TreeAndGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BinarySearchTree
    {
        public BinaryTreeNode root;
        public BinarySearchTree(double data)
        {
            root = new BinaryTreeNode(data);
        }

        public void AddTreeNode(double val, BinaryTreeNode node = null)
        {
            if (node == null)
            {
                node = root;
            }
            if (val <= node.Data)
            {
                if (node.LeftNode == null)
                {
                    BinaryTreeNode tn = new BinaryTreeNode(val);
                    node.LeftNode = tn;
                }
                else
                {
                    AddTreeNode(val, node.LeftNode);
                }
            }
            else if (val > node.Data)
            {
                if (node.RightNode == null)
                {
                    BinaryTreeNode tn = new BinaryTreeNode(val);
                    node.RightNode = tn;
                }
                else
                {
                    AddTreeNode(val, node.RightNode);
                }
            }
        }

        public bool FindTreeNode(double val, BinaryTreeNode node = null)
        {
            if (node == null)
            {
                node = root;
            }
            if (node.Data.Equals(val))
            {
                return true;
            }
            if (val <= node.Data)
            {
                if (node.LeftNode != null)
                {
                    return FindTreeNode(val, node.LeftNode);
                }
            }
            else if (val > node.Data)
            {
                if (node.RightNode != null)
                {
                    return FindTreeNode(val, node.RightNode);
                }
            }
            return false;
        }

        public BinaryTreeNode FindTreeNodeX(double val, BinaryTreeNode node = null)
        {
            if (node == null)
            {
                node = root;
            }
            if (node.Data.Equals(val))
            {
                return node;
            }
            if (val <= node.Data)
            {
                if (node.LeftNode != null)
                {
                    return FindTreeNodeX(val, node.LeftNode);
                }
            }
            else if (val > node.Data)
            {
                if (node.RightNode != null)
                {
                    return FindTreeNodeX(val, node.RightNode);
                }
            }
            return null;
        }

        /*
            TreeAndGraph.BinarySearchTree bst = new TreeAndGraph.BinarySearchTree(10);
            bst.AddTreeNode(5); bst.AddTreeNode(15); bst.AddTreeNode(2); bst.AddTreeNode(7); bst.AddTreeNode(12); bst.AddTreeNode(17);
            //bst.deleteNode(5);
            //bst.deleteNode(12);
            bst.deleteNode(17);
            //bst.deleteNode(10);
         */ 
        public bool deleteNode(double val)
        {

            BinaryTreeNode pending = FindTreeNodeX(val);
            if (pending == null)
            {
                return false;
            }
            deleteNode(pending);
            return true;
        }

        private void deleteNode(BinaryTreeNode node)
        {
            BinaryTreeNode replace = node;
            BinaryTreeNode pending = null;
            if (node.LeftNode != null)
            {
                node = node.LeftNode;
                if (node.RightNode != null)
                {
                    pending = node.RightNode;
                    while (pending.RightNode != null)
                    {
                        pending = node.RightNode;
                    }
                    node.RightNode = pending.LeftNode;
                }
                else
                {
                    pending = node;
                    replace.LeftNode = pending.LeftNode;
                }

            }
            else if (node.RightNode != null)
            {
                node = node.RightNode;
                if (node.LeftNode != null)
                {
                    pending = node.LeftNode;
                    while (pending.LeftNode != null)
                    {
                        pending = node.LeftNode;
                    }
                    node.LeftNode = pending.RightNode;
                }
                else
                {
                    pending = node;
                    replace.RightNode = pending.RightNode;
                }
            }
            else if (node.LeftNode == null && node.RightNode == null)
            {
                replace = getParent(node);
                if (replace.LeftNode == node)
                {
                    replace.LeftNode = null;
                }
                else if (replace.RightNode == node)
                {
                    replace.RightNode = null;
                }
            }
            if (pending != null)
            {
                replace.Data = pending.Data;
            }
        }

        private BinaryTreeNode getParent(BinaryTreeNode child)
        {
            BinaryTreeNode node = root;
            double data = child.Data;
            while (node.LeftNode != child && node.RightNode != child)
            {
                if (node.Data <= child.Data)
                {
                    node = node.RightNode;
                }
                else
                {
                    node = node.LeftNode;
                }
            }
            return node;
        }

    }

}
