
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
        public int state = 0; //optional
        public BinaryTreeNode(double data)
        {
            this.Data = data;
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
