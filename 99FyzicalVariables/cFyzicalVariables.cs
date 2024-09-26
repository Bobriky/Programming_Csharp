using System;
using System.Collections.Generic;
using System.Text;

namespace _99FyzicalVariables
{
    class cFyzicalVariables
    {

        public string Symbol { get; set; }
        public string SymbolUnit { get; set; }
        public string VariableName { get; set; }
        public string UnitName { get; set; }

        public int sum(int cislo1, int cislo2)
        {
            int vysledek = cislo1 + cislo2; 
            return vysledek;
        }

        public cFyzicalVariables()
        {

        }
        public cFyzicalVariables(string a, string b, string c, string d)
        {
            Symbol = a;
            SymbolUnit = b;
            VariableName = c;
            UnitName = d;
        }

    }
}
