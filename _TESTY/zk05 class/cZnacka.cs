using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zkClass
{
    class cZnacka
    {

        public string Soucastka { get; set; }
        public string Kategorie { get; set; }
        public string Umistneni { get; set; }
        public string Rozmery { get; set; }

        public cZnacka(string a, string b, string c, string d)
        {
            Soucastka = a;
            Kategorie = b;
            Umistneni = c;
            Rozmery = d;
        }
    }
}
