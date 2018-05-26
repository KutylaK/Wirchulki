using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    class Graf
    {
        List<int> wierzcholki;
        public List<int> Wierzcholki
        {
            get { return wierzcholki; }
            set { wierzcholki = value; }
        }
        List<List<int>> krawedzie = new List<List<int>>();
        public List<List<int>> Krawedzie
        {
            get { return krawedzie; }
            set { krawedzie = value; }
        }

        public Graf(int[] tablicaWierzcholkow, int[,] tablicaKrawedzi)
        {
            Wierzcholki = tablicaWierzcholkow.ToList<int>();
            for (int i = 0; i < tablicaKrawedzi.GetLength(0); i++)
            {
                Krawedzie.Add(new List<int>());
                for (int j = 0; j < tablicaKrawedzi.GetLength(1); j++)
                {
                    Krawedzie[i].Add(tablicaKrawedzi[i, j]);
                }
            }
        }

        public Graf MinimalneDrzewoRozpinajace(Graf badany, int start)
        {
            int[] koszt = new int[badany.wierzcholki.Count()];
            Graf[] poprzednik = new Graf[badany.wierzcholki.Count()];
            for (int i = 0; i < koszt.Length; i++)
            {
                koszt[i] = int.MaxValue;
                poprzednik = null;
            }

            koszt[start] = 0;

            KolejkaPriorytetowa<int> kolejkaPriorytetowa = new KolejkaPriorytetowa<int>();
            while (kolejkaPriorytetowa.Kolejka.Count != 0)
            {
                do
                {

                } while (true);
            }
        }

    }
}
 
