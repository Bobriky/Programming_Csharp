using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatoveTypy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            akce();
        }

        private void akce()
        {
            /* Zadání úkolu:
               - pomocí cyklu generujte postupně známky  1, 2, 3, 4, 5.
               - s využitím příkazu switch na základě generované známky zobrazte slovní hodnocení  
                 1 - výborný
                 2 - chvalitebný
                 3 - dobrý 
                 4 - dostatečný
                 5 - nedostatečný
               - pro zobrazení využijte připravený objekt lblVysl  
                 Požadované zobrazení v objektu:
                    výborný - chvalitebný - dobrý - dostatečný - nedostatečný
             */
            // Zde napište svůj kód 
            string vysledek = "";
            for (int znamka = 1; znamka < 6; znamka++)
            {
                switch (znamka)
                {
                    case 1:
                        {
                            vysledek += "výborný";
                            break;
                        }
                    case 2:
                        {
                            vysledek += "chvalitebný";
                            break;
                        }
                    case 3:
                        {
                            vysledek += "dobrý";
                            break;
                        }
                    case 4:
                        {
                            vysledek += "dostatečný";
                            break;
                        }
                    case 5:
                        {
                            vysledek += "nedostatečný";
                            break;
                        }
                }
                if (znamka < 5)
                    vysledek += " - ";
            }

            lblVysl.Text = vysledek.ToString();
        }
    }
}
