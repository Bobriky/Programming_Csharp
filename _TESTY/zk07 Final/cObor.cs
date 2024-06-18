using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tridaZaci
{
    class cObor
    {
        public string Zkratka { get; set; }

        public string Nazev { get; set; }

        public string Cislo { get; set; }

        public string SVP { get; set; }

        public int Delka { get; set; }

        public string Zkouska { get; set; }

        public cObor(string zkratka, string nazev, string cislo, int delka, string zkouska)
        {
            Zkratka = zkratka;
            Nazev = nazev;
            Cislo = cislo;
            Delka = delka;
            Zkouska = zkouska;
        }
        public cObor(string zkratka, string nazev, string cislo, int delka)
        {
            Zkratka = zkratka;
            Nazev = nazev;
            Cislo = cislo;
            Delka = delka;
        }
        public cObor(string zkratka, string nazev, string cislo)
        {
            Zkratka = zkratka;
            Nazev = nazev;
            Cislo = cislo;
        }
        public cObor(string zkratka, string nazev)
        {
            Zkratka = zkratka;
            Nazev = nazev;
        }
        public cObor(string zkratka)
        {
            Zkratka = zkratka;
        }
    }
}
