﻿using System.Xml.Linq;

namespace grafyWazone_27_11
{
    internal class GrafW
    {
        public List<NodeGW> nodes = new List<NodeGW>();
        public List<Edge> edges = new List<Edge>();

        public GrafW(List<NodeGW> nodes, List<Edge> edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }

        public GrafW()
        {

        }
        public GrafW(Edge e)
        {
            edges.Add(e);
            nodes.Add(e.start);
            nodes.Add(e.end);
        }

        public int IleNowychWezlow(Edge e)
        {
            int noweWezly = 0;
            if (!nodes.Contains(e.start))
            {
                noweWezly++;
            }
            if (!nodes.Contains(e.end))
            {
                noweWezly++;
            }
            return noweWezly;
        }

        public void AddEdge(Edge e)
        {
            switch (IleNowychWezlow(e))
            {
                case 0:
                    int przedDodaniem = PrzechodzenieWGlab(nodes[0]).Count;
                    edges.Add(e);
                    int poDodaniu = PrzechodzenieWGlab(nodes[0]).Count;
                    if (przedDodaniem == poDodaniu)
                        edges.Remove(e);
                    break;
                case 1:
                    edges.Add(e);
                    if (!nodes.Contains(e.start))
                    {
                        nodes.Add(e.start);
                    }
                    if (!nodes.Contains(e.end))
                    {
                        nodes.Add(e.end);
                    }
                    break;
                case 2:
                    Join(new GrafW(e));
                    break;
                default:
                    break;
            }
        }

        public void Join(GrafW other)
        {
            foreach (var e in other.edges)
            {
                if (!edges.Contains(e))
                {
                    edges.Add(e);
                }
            }
            foreach (var n in other.nodes)
            {
                if (!nodes.Contains(n))
                {
                    nodes.Add(n);
                }
            }
        }

        public GrafW Kruskal()
        {
            GrafW mst = new GrafW();
            foreach (var e in edges)
            {
                mst.AddEdge(e);
            }
            return mst;
        }

        public List<NodeGW> PrzechodzenieWGlab(NodeGW elementStartowy)
        {
            List<NodeGW> odwiedzone = new List<NodeGW>();
            List<NodeGW> doOdwiedzenia = new List<NodeGW>();
            doOdwiedzenia.Add(elementStartowy);

            while (doOdwiedzenia.Count > 0)
            {
                NodeGW obecny = doOdwiedzenia[0];
                doOdwiedzenia.RemoveAt(0);
                if (!odwiedzone.Contains(obecny))
                {
                    odwiedzone.Add(obecny);
                    foreach (var krawedz in edges)
                    {
                        if (krawedz.start == obecny && !odwiedzone.Contains(krawedz.end))
                        {
                            doOdwiedzenia.Add(krawedz.end);
                        }
                        else if (krawedz.end == obecny && !odwiedzone.Contains(krawedz.start))
                        {
                            doOdwiedzenia.Add(krawedz.start);
                        }
                    }
                }
            }
            return odwiedzone;
        }

        // wierzcholki: waga
        // 4-6: 1 +
        // 4-5: 2 +
        // 2-7: 3 +
        // 0-6: 3 +
        // 2-4: 4 +
        // 0-1: 5 +
        // 2-6: 5 -
        // 1-5: 6 -
        // 5-6: 6 -
        // 1-7: 7 -
        // 1-4: 8 -
        // 3-6: 8 +
        // 0-3: 9 -
        // 1-2: 9 -
        // 2-3: 9 -
        // 6-7: 9 -

        //     3
        //     |
        // 5-4-6-0-1
        //   |
        //   2-7

        // Przypadek nr 1 - 1 krawedz i 2 wezly
        // Przypadek nr 2 - 1 krawedz i 1 wezel
        // Przypadek nr 3 - 1 krawedz i 0 wezel = cykl
        // Przypadek nr 4 - 1 krawedz i 0 wezel = g spojny + g spojny = g spojny
        // tylko gdy pracujemy na grafie niespojnym, nie mozna odpuscic do takiej sytuacji, wtedy nie bedzie przypadku 4
    }
}