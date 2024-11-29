namespace grafyWazone_27_11
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //List<NodeGW> nodes = new List<NodeGW>
            //{
            //    new NodeGW(0),
            //    new NodeGW(1),
            //    new NodeGW(2),
            //    new NodeGW(3),
            //    new NodeGW(4),
            //    new NodeGW(5),
            //    new NodeGW(6),
            //    new NodeGW(7)
            //};
            //List<Edge> edges = new List<Edge>
            //{
            //    new Edge(nodes[4], nodes[6], 1),
            //    new Edge(nodes[4], nodes[5], 2),
            //    new Edge(nodes[2], nodes[7], 3),
            //    new Edge(nodes[0], nodes[6], 3),
            //    new Edge(nodes[2], nodes[4], 4),
            //    new Edge(nodes[0], nodes[1], 5),
            //    new Edge(nodes[2], nodes[6], 5),
            //    new Edge(nodes[1], nodes[5], 6),
            //    new Edge(nodes[5], nodes[6], 6),
            //    new Edge(nodes[1], nodes[7], 7),
            //    new Edge(nodes[1], nodes[4], 8),
            //    new Edge(nodes[3], nodes[6], 8),
            //    new Edge(nodes[0], nodes[3], 9),
            //    new Edge(nodes[1], nodes[2], 9),
            //    new Edge(nodes[2], nodes[3], 9),
            //    new Edge(nodes[6], nodes[7], 9),
            //};

            List<NodeGW> nodes = new List<NodeGW>
        {
            new NodeGW(0),
            new NodeGW(1),
            new NodeGW(2),
            new NodeGW(3),
            new NodeGW(4),
            new NodeGW(5),
            new NodeGW(6),
            new NodeGW(7),
            new NodeGW(8),
            new NodeGW(9)
        };
            List<Edge> edges = new List<Edge>
        {
            new Edge(nodes[4], nodes[7], 1),
            new Edge(nodes[5], nodes[8], 2),
            new Edge(nodes[0], nodes[2], 3),
            new Edge(nodes[7], nodes[8], 3),
            new Edge(nodes[1], nodes[2], 4),
            new Edge(nodes[2], nodes[5], 5),
            new Edge(nodes[0], nodes[1], 6),
            new Edge(nodes[8], nodes[9], 6),
            new Edge(nodes[2], nodes[6], 6),
            new Edge(nodes[3], nodes[6], 7),
            new Edge(nodes[6], nodes[9], 8),
            new Edge(nodes[1], nodes[4], 9),
            new Edge(nodes[0], nodes[3], 10),
            new Edge(nodes[5], nodes[7], 11),
            new Edge(nodes[3], nodes[7], 12)
        };
            GrafW g1 = new GrafW(nodes, edges);
            var wynik = g1.Kruskal();
            Console.WriteLine("\nWynik");
            foreach(var edge in wynik.edges)
            {
                Console.WriteLine(edge.start.data + "-" + edge.end.data + ": " + edge.weight);
            }
        }
    }
}