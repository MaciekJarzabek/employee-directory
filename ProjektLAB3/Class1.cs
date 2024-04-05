using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLAB3
{
    public class Osoba
    {
        public required string Imie { get; set; }
        public required string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public required string Stanowisko { get; set; }
        public int ID { get; set; }
    }
}
