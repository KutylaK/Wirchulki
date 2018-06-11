using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    
    class Krawedz
    {
        public int start;
        public int koniec;
        public int wartosc;

        public Krawedz(int s, int k, int w)
        {
            start = s;
            koniec = k;
            wartosc = w;
        }

        public override string ToString()
        {
            return start + " " + koniec + " " + wartosc;
        }
    }
}
