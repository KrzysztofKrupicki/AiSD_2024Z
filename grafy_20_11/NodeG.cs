using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace grafy_20_11
{
    internal class NodeG
    {
        List<NodeG> sasiedzi = new List<NodeG>();
        int data;

        public NodeG(int liczba){
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public void DodajSasiada(NodeG node)
        {
            if (!this.sasiedzi.Contains(node))
            {
                this.sasiedzi.Add(node);
            }
        }

        public string ZwrocSasiadowJakoString()
        {
            string wynik = this.data + " - ";
            for(int i=0; i<sasiedzi.Count(); i++)
            {
                wynik += sasiedzi.ElementAt(i) + " ";
            }
            return wynik;
        }

        // DFS
        public List<NodeG> PrzechodzenieWGlab(NodeG elementStartowy)
        {
            List<NodeG> listaOdwiedzonych = new List<NodeG>();
            return PrzechodzenieWGlab(elementStartowy, listaOdwiedzonych);
        }

        public List<NodeG> PrzechodzenieWGlab(NodeG elementStartowy, List<NodeG> listaOdwiedzonych)
        {
            if (!listaOdwiedzonych.Contains(elementStartowy))
            {
                listaOdwiedzonych.Add(elementStartowy);
                foreach (var sasiad in elementStartowy.sasiedzi)
                {
                    PrzechodzenieWGlab(sasiad, listaOdwiedzonych);
                }
                return listaOdwiedzonych;
            }
            else
            {
                return listaOdwiedzonych;
            }
            
        }

        // BFS
        public List<NodeG> PrzechodzenieWSzerz(NodeG elementStartowy)
        {
            List<NodeG> listaOdwiedzonych = new List<NodeG>();
            List<NodeG> listaDoOdwiedzenia = new List<NodeG>();
            listaDoOdwiedzenia.Add(elementStartowy);
            while (listaDoOdwiedzenia.Count > 0)
            {
                NodeG current = listaDoOdwiedzenia[0];
                listaDoOdwiedzenia.RemoveAt(0);
                if (!listaOdwiedzonych.Contains(current))
                {
                    listaOdwiedzonych.Add(current);
                    foreach (var sasiad in current.sasiedzi)
                    {
                        if (!listaOdwiedzonych.Contains(sasiad) && !listaDoOdwiedzenia.Contains(sasiad))
                        {
                            listaDoOdwiedzenia.Add(sasiad);
                        }
                    }
                }
            }
            return listaOdwiedzonych;
        }


        // przechodzenie w glab
        // A B E F D C G

        // przechodzenei w wszerz
        // A(BC)
        // A B(ADE) C(ADF)
        // A B C(ADF) D(BCF) E(BF)
        // A B C D(BCF) E(BF) F(CDEG)
        // A B C D E(BF) F(CDEG)
        // A B C D E F(CDEG) G(F)
    }
}
