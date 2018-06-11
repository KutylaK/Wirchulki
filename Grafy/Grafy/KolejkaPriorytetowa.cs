using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    public class KolejkaPriorytetowa
    {
        Queue<int> kolejka= new Queue<int>();
        public Queue<int> Kolejka
        {
            get { return kolejka; }
            set { kolejka = value;}
        }

        public int Dlugosc => kolejka.Count();

        public void Dodaj(int i)
        { if (!kolejka.Contains(i)) Kolejka.Enqueue(i); }

        
        

        public int Zdejmij() =>  Kolejka.Dequeue();

        public bool CzyZawiera(int i) => Kolejka.Contains(i);


        public void Porzadkuj(int[] koszty)
        {
            List<int> cost = koszty.ToList<int>();
            List<int> tmp = Kolejka.ToList<int>();
            Kolejka = new Queue<int>();
            for (int i = 0; i < koszty.Length; i++)
            {
                int n = cost.IndexOf(cost.Min());
                if (n == 0) kolejka.Enqueue(i);
                else Kolejka.Enqueue(n);
                cost[n] = int.MaxValue;
            }

        }

        public override string ToString()
        {
            List<int> tmp = new List<int>();
            tmp = kolejka.ToList<int>();
            string wynik = "";
            for (int i = 0; i < kolejka.Count; i++)
            {
                wynik += tmp[i] + " ";
            }
            return wynik;
        }
    }
}
