using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Algorithm.TreeAndGraph;
using Algorithm.LinkedList;


namespace Algorithm
{
    class MainClass
    {
        //[MethodImpl(MethodImplOptions.InternalCall)]
        public static void Main(string[] args)
        {
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(15);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(7);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(12);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(17);

            btn1.LeftNode = btn2;
            btn1.RightNode = btn3;
            btn2.LeftNode = btn4;
            btn2.RightNode = btn5;
            btn3.LeftNode = btn6;
            btn3.RightNode = btn7;

            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Pre);
            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Mid);
            Microsoft.Q43.interateBinaryTree(btn1, Microsoft.Q43.Order.Post);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Pre);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Mid);
            Microsoft.Q43.interateBinaryTreeEx(btn1, Microsoft.Q43.Order.Post);

            Console.WriteLine("I am done");
            Console.ReadLine();
        }

    }
}
