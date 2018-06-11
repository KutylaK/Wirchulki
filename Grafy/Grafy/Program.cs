using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    class Program
    {
        public static Graf NajkrotszeDrzewo(Graf graf, int start)
        {
            KolejkaPriorytetowa kolejka = new KolejkaPriorytetowa();
            for (int i = 0; i < graf.lista.Count(); i++)
            {
                kolejka.Dodaj(graf.lista[i].start);
            }
            kolejka.Dodaj(kolejka.Kolejka.Count + 1);
            int n = kolejka.Dlugosc;
            int[] cost = new int[n];
            int[] prev = new int[n];
            for (int i = 0; i <n; i++)
            {
                cost[i] = int.MaxValue;
            }
            cost[start] = 0;
            prev[start] = 0;
            

            
            kolejka.Porzadkuj(cost);
            while (kolejka.Dlugosc != 0)
            {
                int u = kolejka.Zdejmij();
                for (int i = 0; i < graf.IleKrawedzi(u); i++)
                {
                    int z = graf.lista[i].koniec;
                    if (kolejka.CzyZawiera(z) && cost[z] > graf.lista[i].wartosc)
                    {
                        cost[z] = graf.lista[i].wartosc;
                        prev[z] = u;
                    }
                }
            }
            List<Krawedz> krawedzieWynik = new List<Krawedz>();
            for (int i = 0; i < n; i++)
            {
                krawedzieWynik.Add(new Krawedz(i, prev[i], cost[i]));

            }
            return new Graf(krawedzieWynik);

        }

        

        public static int PobierzLiczbe()
        {
            string s= Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(s);
                return n;
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba!");
                throw;
            }
        }
        static void Main(string[] args)
        {
            List<Krawedz> krawedzie = new List<Krawedz>();
            
               krawedzie.Add( new Krawedz(1, 2, 5));
               krawedzie.Add( new Krawedz(1, 3, 6));
               krawedzie.Add( new Krawedz(1, 4, 4));
               krawedzie.Add( new Krawedz(2, 3, 1));
               krawedzie.Add( new Krawedz(2, 4, 1));
               krawedzie.Add( new Krawedz(3, 4, 2));
               krawedzie.Add( new Krawedz(3, 5, 5));
               krawedzie.Add( new Krawedz(3, 6, 3));
               krawedzie.Add( new Krawedz(4, 6, 4));
               krawedzie.Add( new Krawedz(5, 6, 4));

            //Console.WriteLine("Podaj liczbę krawędzi: ");
            //int n = PobierzLiczbe();
            //for (int i = 0; i < n; i++)
            //{
            //    krawedzie.Add(new Krawedz(PobierzLiczbe(), PobierzLiczbe(), PobierzLiczbe()));
            //}
            Graf g = new Graf(krawedzie);
            Console.WriteLine(NajkrotszeDrzewo(g,1));
            Console.ReadKey();
        }
    }
}
