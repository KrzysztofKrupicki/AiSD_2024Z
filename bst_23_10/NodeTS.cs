namespace bst_23_10
{
    internal class NodeTS : NodeT
    {
        public char symbol;
        public string kod;
        public NodeTS() : base(0)
        {
            this.symbol = '\0';
            this.kod = string.Empty;
        }

        public NodeTS(char symbol, int freq) : base(freq)
        {
            this.symbol = symbol;
            this.kod = string.Empty;
        }
    }
}
