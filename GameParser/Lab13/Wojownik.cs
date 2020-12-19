using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{

    public class Wojownik
    {
        public string Plec { get; set; }
        public string Imie { get; set; }
        public int Sila { get; set; }
        public int Zdrowie { get; set; }
        public string Potwor { get; set; }

        public Wojownik(string plec, string imie, int sila, int zdrowie, string potwor)
        {
            Imie = imie;
            Plec = plec;
            Sila = sila;
            Zdrowie = zdrowie;
            Potwor = potwor;
        }
        public Wojownik() { }

    }
}
