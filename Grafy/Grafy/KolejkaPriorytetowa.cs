using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    public class KolejkaPriorytetowa<T> where T:IComparable
    {
        Queue<T> kolejka;
        public Queue<T> Kolejka
        {
            get { return kolejka; }
            set { kolejka = value;}
        }

        public void Porzadkuj()
        {
            List<T> tmp = Kolejka.ToList<T>();
            Queue<T> kolejkaUporzadkowana = new Queue<T>();
            
            Kolejka = kolejkaUporzadkowana;

        }
    }
}
