using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
             TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(3);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(7);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
             btn3.RightNode = btn7;

            new Leetcode.PopulatingNextRightPointersinEachNode().connect(btn1); 
 */
namespace Algorithm.Leetcode
{
    class PopulatingNextRightPointersinEachNode
    {
        public void connect(TreeAndGraph.BinaryTreeNode root)
        {
            TreeAndGraph.BinaryTreeNode cur_loop = root, down_node = root;

            while (down_node != null)
            {
                TreeAndGraph.BinaryTreeNode last_node = null;
                cur_loop = down_node;
                down_node = null;
                while (cur_loop != null)
                {
                    if (cur_loop.LeftNode != null)
                    {
                        if (down_node == null)
                        {
                            down_node = cur_loop.LeftNode;
                        }
                        if (last_node == null)
                        {
                            last_node = cur_loop.LeftNode;
                        }
                        else
                        {
                            last_node.NextNode = cur_loop.LeftNode;
                            last_node = cur_loop.LeftNode;
                        }
                    }
                    if (cur_loop.RightNode != null)
                    {
                        if (down_node == null)
                        {
                            down_node = cur_loop.RightNode;
                        }
                        if (last_node == null)
                        {
                            last_node = cur_loop.RightNode;
                        }
                        else
                        {
                            last_node.NextNode = cur_loop.RightNode;
                            last_node = cur_loop.RightNode;
                        }
                    }

                    cur_loop = cur_loop.NextNode;
                }
            }

        }
    }
}
