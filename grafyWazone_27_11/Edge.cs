namespace grafyWazone_27_11
{
    internal class Edge
    {
        public NodeGW start;
        public NodeGW end;
        public int weight;

        public Edge(NodeGW start, NodeGW end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }
}
