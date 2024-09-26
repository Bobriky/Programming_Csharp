using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tridaZaci
{
    class cOsoba
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public string RodneCislo { get; set; }

        public string Mobil { get; set; }

        private string mail;

        public string Mail 
        {
            get { return mail; }
            set
            {
                if (value.Contains("@"))
                {
                    mail = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Email neobsahuje doménu. V zadaném řetězci není @");
                }  
            }
        }



        public cOsoba() { }

        public cOsoba(string jmeno, string prijmeni) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

    }

    class cStudent : cOsoba
    {
        public cTrida Trida { get; set; }
        
        public string Skupina { get; set; }

        public cStudent() { }

        public cStudent(string jmeno, string prijmeni, cTrida trida)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Trida = trida;
        }
        public cStudent(string jmeno, string prijmeni, cTrida trida, string skupina)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Trida = trida;
            Skupina = skupina;
        }
    }

    class cUcitel : cOsoba
    {
        public string Titul { get; set; }

        public string Aprobace { get; set; }

        public bool Tridni { get; set; }

        public bool tridaTU { get; set; }

        public cUcitel() { }

        public cUcitel(string jmeno, string prijmeni, string titul)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Titul = titul;
        }
    }
}
