namespace bst_23_10
{
    internal class NodeT
    {
        public NodeT left;
        public NodeT right;
        public NodeT parent;
        public int data;

        public NodeT(int data)
        {
            this.data = data;
            left = null;
            right = null;
            parent = null;
        }

        public int GetLiczbaDzieci()
        {
            int wynik = 0;
            if (this.left != null)
            {
                wynik++;
            }
            if (this.right != null)
            {
                wynik++;
            }
            return wynik;
        }
    }
}
