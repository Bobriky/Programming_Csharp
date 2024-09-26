using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zkClass
{
    class cZnacka
    {
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public string Adresa { get; set; }
        public string Rozmery { get; set; }
        public cZnacka(string a, string b, string c, string d)
        {
            Nazev = a;
            Kategorie = b;
            Adresa = c;
            Rozmery = d;
        }
    }
}
