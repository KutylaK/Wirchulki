using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    class Graf
    {
        public List<Krawedz> lista = new List<Krawedz>();
       
        public Graf(List<Krawedz> k)
        {
            lista = k;
            //for (int i = 0; i < k.Count(); i++)
            //{
            //    for (int j = i+1; j < k.Count(); j++)
            //    {
            //        if(k[i].start==k[j].koniec && k[i].koniec==k[i].start && k[i].wartosc==k[j].wartosc)
            //        {
            //            lista.RemoveAt(j);
            //        }
            //    }
            //}
        }

        public int IleKrawedzi(int wierzcholek)
        {
            int n = 0;
            foreach (var item in lista)
            {
                if (item.start==wierzcholek)
                {
                    n++;
                }
            }
            return n;
        }

        public override string ToString()
        {
            string tmp = "";
            foreach (var item in lista)
            {
                tmp += item + "\n\r";
            }
            return tmp;
        }
    }
}
