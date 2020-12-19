using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    public enum Plec
    {
        Kobieta, Mezczyzna
    }
    
    public class Wojownik
    {
        public string Plec { get; set; }
        public string Imie { get; set; }
        public int Sila { get; set; }
        public int Zdrowie { get; set; }
        public string Nnpku { get; set; }

    }
}
