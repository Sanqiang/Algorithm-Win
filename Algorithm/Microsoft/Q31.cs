

namespace Algorithm.Microsoft
{
    class Q31
    {
        //also reference to Algorithm.TreeAndGraph.Floyd and Algorithm.TreeAndGraph.Dijkstra

        public static int getShortestDistance(TreeAndGraph.GraphNode start, TreeAndGraph.GraphNode end)
        {
            System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<TreeAndGraph.GraphNode>> tab
                = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<TreeAndGraph.GraphNode>>();
            System.Collections.Generic.List<TreeAndGraph.GraphNode> list = new System.Collections.Generic.List<TreeAndGraph.GraphNode>();
            int count = 1;
            list.Add(start);
            tab.Add(count, list);
            while (true)
            {
                System.Collections.Generic.List<TreeAndGraph.GraphNode> gn_list = tab[count];
                ++count;
                if (!tab.ContainsKey(count))
                {
                    list = new System.Collections.Generic.List<TreeAndGraph.GraphNode>();
                    tab.Add(count, list);
                }
                foreach (TreeAndGraph.GraphNode gn in gn_list)
                {

                    foreach (TreeAndGraph.GraphNode node in gn.Nodes)
                    {
                        if (node == end)
                        {
                            return count;
                        }

                        tab[count].Add(node);
                    }
                }
            }
        }


        public static int ShortestCount = -1;
        public static void getShortestDistancePoor(TreeAndGraph.GraphNode start, TreeAndGraph.GraphNode end, int count = 1)
        {
            ++count;
            foreach (TreeAndGraph.GraphNode node in start.Nodes)
            {
                if (node == end)
                {
                    if (ShortestCount == -1)
                    {
                        ShortestCount = count;
                    }
                    else if (ShortestCount > count)
                    {
                        ShortestCount = count;
                    }
                }
                else
                {
                    getShortestDistancePoor(node, end, count);
                }
            }
        }
    }
}
