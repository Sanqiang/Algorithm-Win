/*
            TreeAndGraph.GraphNode gn1 = new TreeAndGraph.GraphNode(1);
            TreeAndGraph.GraphNode gn2 = new TreeAndGraph.GraphNode(1);
            TreeAndGraph.GraphNode gn3 = new TreeAndGraph.GraphNode(1);
            TreeAndGraph.GraphNode gn4 = new TreeAndGraph.GraphNode(1);
            TreeAndGraph.GraphNode gn5 = new TreeAndGraph.GraphNode(1);
            gn1.Nodes.Add(gn2); gn1.Nodes.Add(gn3);
            gn3.Nodes.Add(gn4);
            gn2.Nodes.Add(gn4); gn2.Nodes.Add(gn5);
            //Console.WriteLine(TreeAndGraph.CC4_2.findLinkBreath(gn1, gn5));
            //Console.WriteLine(TreeAndGraph.CC4_2.findLinkBreath(gn1, gn4));
            //Console.WriteLine(TreeAndGraph.CC4_2.findLinkBreath(gn4, gn5));

            //TreeAndGraph.CC4_2.findLinkDepth(gn1, gn5);
            //Console.WriteLine(TreeAndGraph.CC4_2.find);

            //change state
            Console.WriteLine(TreeAndGraph.CC4_2.findLinkV5(gn1, gn5));
            Console.WriteLine(TreeAndGraph.CC4_2.findLinkV5(gn1, gn4));
            Console.WriteLine(TreeAndGraph.CC4_2.findLinkV5(gn4, gn5));
 */
namespace Algorithm.TreeAndGraph
{
    public class CC4_2
    {
        private static int Visiting = 2; private static int Visited = 1; private static int Unvisitied = 0;
        public static bool findLinkV5(GraphNode start, GraphNode end)
        {
            System.Collections.Generic.Queue<GraphNode> searched = new System.Collections.Generic.Queue<GraphNode>();
            searched.Enqueue(start);
            start.state = Visiting;
            while (searched.Count!=0)
            {
                GraphNode gn = searched.Dequeue();
                if (gn!=null)
                {
                    gn.state = Visited;
                    foreach (GraphNode node in gn.Nodes)
                    {
                        if (node.state == Unvisitied)
                        {
                            if (node == end)
                            {
                                return true;
                            }
                            node.state = Visiting;
                            searched.Enqueue(node);
                        }
                    }
                }
            }
            return false;
        }

        public static bool findLinkBreath(GraphNode start, GraphNode end)
        {
            System.Collections.Generic.Queue<GraphNode> q = new System.Collections.Generic.Queue<GraphNode>();
            q.Enqueue(start);

            while (q.Count != 0)
            {
                GraphNode gn_from_queue = q.Dequeue();
                if (gn_from_queue == end)
                {
                    return true;
                }
                foreach (GraphNode gn_loop in gn_from_queue.Nodes)
                {
                    q.Enqueue(gn_loop);
                }
            }
            return false;
        }


        public static bool find = false;
        public static void findLinkDepth(GraphNode start, GraphNode end)
        {
            if (start.Nodes.Count == 0)
            {
                return;
            }
            System.Collections.Generic.List<GraphNode> nodes = start.Nodes;
            foreach (GraphNode n in nodes)
            {
                if (n == end)
                {
                    find = true;
                }
                findLinkDepth(n, end);
            }
        }
    }
}
