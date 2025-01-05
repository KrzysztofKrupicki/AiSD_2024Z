namespace bst_23_10
{
    internal static class Program
    {
        
        static void Main(string[] args)
        {
            // Drzewo binarne BST

            //Tree myTree = new Tree();
            //myTree.Add(5);
            //myTree.Add(2);
            //myTree.Add(3);
            //myTree.Add(8);
            //myTree.Add(4);
            //myTree.Add(1);
            //myTree.Add(2);
            //Console.WriteLine("\nPreOrder");
            //myTree.PreOrder(myTree.root);
            //Console.WriteLine("\nInOrder");
            //myTree.InOrder(myTree.root);
            //Console.WriteLine("\nPostOrder");
            //myTree.PostOrder(myTree.root);
            //Console.WriteLine("\nDrzewo początkowe");
            //myTree.PrintTree(myTree.root);
            //myTree.Remove(1);
            //Console.WriteLine("Drzewo po usunięciu 1");
            //myTree.PrintTree(myTree.root);
            //myTree.Remove(2);
            //Console.WriteLine("Drzewo po usunięciu 2");
            //myTree.PrintTree(myTree.root);
            //myTree.Remove(3);
            //Console.WriteLine("Drzewo po usunięciu 3");
            //myTree.PrintTree(myTree.root);


            // Kod Huffmana
            var symbols = new List<NodeTS>();
            string text = "Ala ma kota i kot ma Alę.";
            var freq = GetCharacterFrequency(text);
            foreach (var e in freq)
            {
                symbols.Add(new NodeTS { symbol = e.Key, data = e.Value });
            }
            symbols = symbols.OrderBy(n => n.data).ToList();
            HuffmanTree huffmanTree = new HuffmanTree();
            var root = huffmanTree.UtworzDrzewo(symbols);
            huffmanTree.PrzypiszKody(root, "");
        }
        static Dictionary<char, int> GetCharacterFrequency(string text)
        {
            var freq = new Dictionary<char, int>();
            foreach (char symbol in text)
            {
                if (freq.ContainsKey(symbol))
                {
                    freq[symbol]++;
                }
                else
                {
                    freq[symbol] = 1;
                }
            }
            return freq;
        }
    }
}