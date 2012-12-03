/*
            TreeAndGraph.GraphNodeEx h = new TreeAndGraph.GraphNodeEx(0);
            //TreeAndGraph.GraphNodeEx a = new TreeAndGraph.GraphNodeEx(1);
            //TreeAndGraph.GraphNodeEx b = new TreeAndGraph.GraphNodeEx(2);
            //TreeAndGraph.GraphNodeEx c = new TreeAndGraph.GraphNodeEx(3);
            //h.Nodes.Add(a, 1);
            //h.Nodes.Add(b, 3);
            //h.Nodes.Add(c, 4);
            //a.Nodes.Add(b, 1);
            //b.Nodes.Add(c, 1);
            TreeAndGraph.GraphNodeEx en = new TreeAndGraph.GraphNodeEx(1);
            TreeAndGraph.GraphNodeEx a1 = new TreeAndGraph.GraphNodeEx(2);
            TreeAndGraph.GraphNodeEx a2 = new TreeAndGraph.GraphNodeEx(3);
            TreeAndGraph.GraphNodeEx a3 = new TreeAndGraph.GraphNodeEx(4);
            TreeAndGraph.GraphNodeEx b1 = new TreeAndGraph.GraphNodeEx(5);
            h.Nodes.Add(en,1);
            en.Nodes.Add(a1, 1);
            a1.Nodes.Add(a2, 1);
            a2.Nodes.Add(a3, 1);
            
            en.Nodes.Add(b1, 1.5);
            b1.Nodes.Add(a3, 1);


            TreeAndGraph.Dijkstra.getShortestPath(h);
 */
namespace Algorithm.TreeAndGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Dijkstra
    {
        static HashSet<GraphNodeEx> SettledNodes = null;
        static HashSet<GraphNodeEx> UnSettledNodes = null;
        static Dictionary<GraphNodeEx, double> distance = null;
        static Dictionary<GraphNodeEx, GraphNodeEx> Paths = null;
        public static Dictionary<GraphNodeEx, GraphNodeEx> getShortestPath(GraphNodeEx head)
        {
            //Initialize
            distance = new Dictionary<GraphNodeEx, double>();
            SettledNodes = new HashSet<GraphNodeEx>();
            UnSettledNodes = new HashSet<GraphNodeEx>();
            Paths = new Dictionary<GraphNodeEx, GraphNodeEx>();

            //Execute
            GraphNodeEx CurrentNode = null;
            UnSettledNodes.Add(head);
            distance.Add(head, 0);
            while (UnSettledNodes.Count != 0)
            {
                CurrentNode = getDirectionNode(UnSettledNodes);
                UnSettledNodes.Remove(CurrentNode);
                SettledNodes.Add(CurrentNode);
                findMinimunGraphNode(CurrentNode);
            }

            return Paths;
        }

        private static void findMinimunGraphNode(GraphNodeEx Entry)
        {
            foreach (KeyValuePair<GraphNodeEx, double> mapper in Entry.Nodes)
            {
                if (getShortestDistance(mapper.Key) > getShortestDistance(Entry) + mapper.Value)
                {
                    distance.Add(mapper.Key, distance[Entry] + mapper.Value);
                    UnSettledNodes.Add(mapper.Key);
                    Paths.Add(mapper.Key, Entry);
                }
            }
        }

        private static GraphNodeEx getDirectionNode(HashSet<GraphNodeEx> UnSettledNodes)
        {
            GraphNodeEx DirectionNode = null;
            foreach (GraphNodeEx node in UnSettledNodes)
            {
                if (DirectionNode == null)
                {
                    DirectionNode = node;
                }
                else
                {
                    if (getShortestDistance(node) < getShortestDistance(DirectionNode))
                    {
                        DirectionNode = node;
                    }
                }
            }
            return DirectionNode;
        }

        private static double getShortestDistance(GraphNodeEx destination)
        {
            if (distance.ContainsKey(destination))
            {
                return distance[destination];
            }
            else
            {
                return 99999;
            }
        }
    }
}
