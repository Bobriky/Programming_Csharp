using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Postup:
    1. Plovoucí panel, víceřádkové pole
    2. Společná metoda pro tlačítka - zobrazovaní znaků
    3. Tvorba vícemístných čísel
    4. Zadávání čísel a matematické operace
    5. Zobrazení výsledku
    6. Klávesnice Klávesnice - aktivace číselníku   e.KeyCode
    7. Přidání tlačítek:    "="  a  "C"  Clear();
 */

namespace Kalkulacka3
{
    public partial class Form1 : Form
    {
        int number1 = 0;
        int number2 = 0;
        string symbol;
        int op;
        bool dotUsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (!(((Button)sender).Text == "," && dotUsed))
            {
                txtDisplay.Text = ((Button)sender).Text;

                if (((Button)sender).Text == ",")
                {
                    dotUsed = true;
                }
                btnEqauls.Enabled = btnKrat.Enabled = btnLomeno.Enabled = btnMinus.Enabled = btnPlus.Enabled = true;
            }
        }

        private void btnKrat_Click(object sender, EventArgs e)
        {
            symbol = ((Button)sender).Text;
            switch (symbol)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnEqauls_Click_1(object sender, EventArgs e)
        {

        }


    }
}
