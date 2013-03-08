
namespace Algorithm.TreeAndGraph
{
    enum state
    {
        Visited, Visiting, Unvisited
    }
    public class BinaryTreeNode
    {
        public double Data;
        public BinaryTreeNode LeftNode;
        public BinaryTreeNode RightNode;
        public BinaryTreeNode ParentNode; //optional
        public BinaryTreeNode NextNode; //optional
        public int state = 0; //optional
        public BinaryTreeNode(double data)
        {
            this.Data = data;
        }

        public int getHeight()
        {
            if (this == null)
            {
                return 0;
            }
            int l = 0;
            if (this.LeftNode != null)
            {
                l = LeftNode.getHeight();
            }
            int r = 0;
            if (this.RightNode != null)
            {
                r = RightNode.getHeight();
            }
            return System.Math.Max(l, r) + 1;
        }

        public static BinaryTreeNode getInst()
        {
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
            return btn1;
        }


        public static BinaryTreeNode getSymInst()
        {
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(1);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(4);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(4);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
            btn3.LeftNode = btn6; btn3.RightNode = btn7;
            return btn1;
        }

        public static BinaryTreeNode getBSTInst()
        {
            TreeAndGraph.BinaryTreeNode btn1 = new TreeAndGraph.BinaryTreeNode(10);
            TreeAndGraph.BinaryTreeNode btn2 = new TreeAndGraph.BinaryTreeNode(5);
            TreeAndGraph.BinaryTreeNode btn3 = new TreeAndGraph.BinaryTreeNode(15);
            TreeAndGraph.BinaryTreeNode btn4 = new TreeAndGraph.BinaryTreeNode(2);
            TreeAndGraph.BinaryTreeNode btn5 = new TreeAndGraph.BinaryTreeNode(7);
            TreeAndGraph.BinaryTreeNode btn6 = new TreeAndGraph.BinaryTreeNode(12);
            TreeAndGraph.BinaryTreeNode btn7 = new TreeAndGraph.BinaryTreeNode(17);
            btn1.LeftNode = btn2; btn1.RightNode = btn3;
            btn2.LeftNode = btn4; btn2.RightNode = btn5;
            btn3.LeftNode = btn6; btn3.RightNode = btn7;
            return btn1;
        }
    }

    public class TreeNode
    {
        public double Data;
        public System.Collections.Generic.List<TreeNode> Nodes = new System.Collections.Generic.List<TreeNode>();
        public int state = 0; //optional
        public TreeNode(double val)
        {
            this.Data = val;
        }
    }

    //Directional Graph node without value
    public class GraphNode
    {
        public double Data;
        public System.Collections.Generic.List<GraphNode> Nodes = new System.Collections.Generic.List<GraphNode>();
        public int state = 0; //optional
        public GraphNode(double val)
        {
            this.Data = val;
        }
    }

    //Directional Graph node with value
    public class GraphNodeEx
    {
        public double Data;
        public System.Collections.Generic.Dictionary<GraphNodeEx, double> Nodes = new System.Collections.Generic.Dictionary<GraphNodeEx, double>();
        public int state = 0; //optional
        public GraphNodeEx(double val)
        {
            this.Data = val;
        }
    }

    //UnDirectional Graph node with value
    public class UndirectionalGraphNodeEx
    {
        public double Data;
        public System.Collections.Generic.Dictionary<UndirectionalGraphNodeEx, double> Nodes = new System.Collections.Generic.Dictionary<UndirectionalGraphNodeEx, double>();
        public int state = 0; //optional
        public UndirectionalGraphNodeEx(double val)
        {
            this.Data = val;
        }

        public bool isLink(UndirectionalGraphNodeEx node)
        {
            return this.Nodes.ContainsKey(node) || node.Nodes.ContainsKey(this);
        }

        public void addLink(UndirectionalGraphNodeEx node, double value = 0)
        {
            this.Nodes.Add(node, value);
            node.Nodes.Add(this, value);
        }

        public void deleteLink(UndirectionalGraphNodeEx node)
        {
            this.Nodes.Remove(node);
            node.Nodes.Remove(this);
        }

    }
}
