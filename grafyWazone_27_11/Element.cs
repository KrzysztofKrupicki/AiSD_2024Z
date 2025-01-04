namespace grafyWazone_27_11
{
    internal class Element
    {
        public NodeGW wezel;
        public int dystans;
        public NodeGW poprzednik;

        public Element(NodeGW wezel, int dystans, NodeGW poprzednik)
        {
            this.wezel = wezel;
            this.dystans = dystans;
            this.poprzednik = poprzednik;
        }
    }
}