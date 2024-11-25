using System.ComponentModel;

namespace grafy_20_11
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            NodeG a = new NodeG(1);
            NodeG b = new NodeG(2);
            NodeG c = new NodeG(3);
            NodeG d = new NodeG(4);
            NodeG e = new NodeG(5);
            NodeG f = new NodeG(6);
            NodeG g = new NodeG(7);
            a.DodajSasiada(b);
            a.DodajSasiada(c);

            b.DodajSasiada(a);
            b.DodajSasiada(d);
            b.DodajSasiada(e);

            c.DodajSasiada(a);
            c.DodajSasiada(d);
            c.DodajSasiada(f);

            d.DodajSasiada(b);
            d.DodajSasiada(f);
            d.DodajSasiada(c);

            e.DodajSasiada(b);
            e.DodajSasiada(f);

            f.DodajSasiada(c);
            f.DodajSasiada(d);
            f.DodajSasiada(e);
            f.DodajSasiada(g);

            g.DodajSasiada(f);
            
            List<NodeG> lista = new List<NodeG>(a.PrzechodzenieWSzerz(a));
            foreach(var x in lista)
            {
                Console.Write(x + " ");
            }
        }
    }
}