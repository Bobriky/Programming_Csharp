using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIstBox
{
    class cOsoba
    {   
        //členská vlastnost
        public int idOsoba;
        
        // úplná definice vlastnosti
        private string jmeno;
        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public string Prijmeni { get; set; }

        // zkrácená definice vlastnosti
        public void setID(int iCislo)
        {
            idOsoba = iCislo;
        }
        public int getID()
        {
            return idOsoba;
        }
        public void setName(string name)
        {
            nameOsoba = name;
        }
        public string getName()
        {
            return nameOsoba;
        }
        public void setSurname(string surname)
        {
            nameOsoba = surname;
        }
        public string getSurname()
        {
            return surnameOsoba;
        }
        //konstruktory - přetížené
        public cOsoba()
        {

        }
        public cOsoba(int iCislo)
        {
            idOsoba = iCislo;
        }
        public cOsoba(int iCislo, string iJmeno, string iPrijmeni)
        {
            idOsoba = iCislo;
            nameOsoba = iJmeno;
            surnameOsoba = iPrijmeni;
        }

        //huh
        public string nameOsoba;
        public string surnameOsoba;
        public int fredyFazbergID = 3;
        public int levelOfChrist;
        public string hardHittingUrurLine = "URURURuwuURURUURURRU";
    }
    class cJanitor : cOsoba
    {
        public string modelMetly;

        private string susjmeno;
        public string susJmeno
        {
            get { return susjmeno; }
            set { susjmeno = value; }
        }
    }
}
