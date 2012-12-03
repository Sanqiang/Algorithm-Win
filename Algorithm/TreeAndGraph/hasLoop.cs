
namespace Algorithm.TreeAndGraph
{
    class hasLoop
    {
        //Another better way: BFS



        /*
            TreeAndGraph.UndirectionalGraphNodeEx g1 = new TreeAndGraph.UndirectionalGraphNodeEx(1);
            TreeAndGraph.UndirectionalGraphNodeEx g2 = new TreeAndGraph.UndirectionalGraphNodeEx(1);
            TreeAndGraph.UndirectionalGraphNodeEx g3 = new TreeAndGraph.UndirectionalGraphNodeEx(1);
            g1.addLink(g2);
            g1.addLink(g3);
            g2.addLink(g3);

            List<TreeAndGraph.UndirectionalGraphNodeEx> vetex = new List<TreeAndGraph.UndirectionalGraphNodeEx>();
            vetex.Add(g1); vetex.Add(g2); vetex.Add(g3);
            Console.WriteLine( TreeAndGraph.hasLoop.hasUndirectionalGraph(vetex));
         */ 
        public static bool hasUndirectionalGraph(System.Collections.Generic.List<UndirectionalGraphNodeEx> nodes)
        {
            while (true)
            {
                bool EndLoop = true;

                int length = nodes.Count;
                System.Collections.Generic.List<UndirectionalGraphNodeEx> PendingDeleteForNodes = new System.Collections.Generic.List<UndirectionalGraphNodeEx>();
                for (int i = 0; i < length; i++)
                {
                    if (nodes[i].Nodes.Count < 2)
                    {
                        EndLoop = false;
                        PendingDeleteForNodes.Add(nodes[i]);

                        System.Collections.Generic.List<UndirectionalGraphNodeEx> PendingDeleteForLinks = new System.Collections.Generic.List<UndirectionalGraphNodeEx>();
                        foreach (System.Collections.Generic.KeyValuePair<UndirectionalGraphNodeEx, double> AdjacentMapper in nodes[i].Nodes)
                        {
                            PendingDeleteForLinks.Add(AdjacentMapper.Key);
                        }
                        //Delete Links
                        foreach (UndirectionalGraphNodeEx loop_node in PendingDeleteForLinks)
                        {
                            loop_node.deleteLink(nodes[i]);
                        }
                    }
                }
                //Delete Nodes
                foreach (UndirectionalGraphNodeEx loop_node in PendingDeleteForNodes)
                {
                    nodes.Remove(loop_node);
                }

                if (EndLoop)
                {
                    break;
                }
            }

            return nodes.Count != 0;
        }

    }
}
