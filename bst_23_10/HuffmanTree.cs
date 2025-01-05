namespace bst_23_10
{
    internal class HuffmanTree
    {
        public NodeTS UtworzDrzewo(List<NodeTS> nodes)
        {
            while (nodes.Count > 1)
            {
                var first = nodes[0];
                var second = nodes[1];
                nodes.RemoveAt(0);
                nodes.RemoveAt(0);
                var parent = new NodeTS
                {
                    left = first,
                    right = second,
                    data = first.data + second.data
                };

                first.parent = parent;
                second.parent = parent;

                nodes.Add(parent);
                nodes = nodes.OrderBy(n => n.data).ToList();
            }
            return nodes[0];
        }

        public void PrzypiszKody(NodeT node, string kod)
        {
            if (node == null) return;

            if (node is NodeTS lisc)
            {
                lisc.kod = kod;
                Console.WriteLine($"{lisc.symbol}\t{lisc.kod}");
            }
            PrzypiszKody(node.left, kod + "0");
            PrzypiszKody(node.right, kod + "1");
        }
    }
}
