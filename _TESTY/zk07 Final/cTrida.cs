using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tridaZaci
{
    class cTrida
    {
        public string Zkratka { get; set; }

        public cUcitel tridiUcitel { get; set; }

        public cObor Obor { get; set; }

        public cTrida() { }

        public cTrida(string zkratka, cUcitel tridni, cObor obor) 
        {
            Zkratka = zkratka;
            tridiUcitel = tridni;
            Obor = obor;
        }

    }
}
