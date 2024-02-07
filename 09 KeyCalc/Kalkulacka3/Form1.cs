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
        string number1;
        string number2;
        float result;
        string symbol = "";
        bool dotUsed;

        public Form1()
        {
            InitializeComponent();
            apkInnit();
        }

        private void apkInnit()
        {
            txtDisplay.Text = "";
            dotUsed = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (!(((Button)sender).Text == "," && dotUsed))
            {
                txtDisplay.Text = "";
                if(!(symbol == ""))
                {
                    number2 += ((Button)sender).Text;
                    btnEqauls.Enabled = true;
                    txtDisplay.Text = number2.ToString();
                }
                else
                {
                    btnDot.Enabled = btnKrat.Enabled = btnLomeno.Enabled = btnMinus.Enabled = btnPlus.Enabled = true;
                    number1 += ((Button)sender).Text;
                    txtDisplay.Text = number1.ToString();
                }
                
                if (((Button)sender).Text == ",")
                {
                    dotUsed = true;
                }
            }
        }

        private void btnKrat_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            btnEqauls.Enabled = btnKrat.Enabled = btnLomeno.Enabled = btnMinus.Enabled = btnPlus.Enabled = false;
            symbol = ((Button)sender).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnEqauls_Click_1(object sender, EventArgs e)
        {
            switch (symbol)
            {
                case "+": result = float.Parse(number1) + float.Parse(number2); break;
                case "-": result = float.Parse(number1) - float.Parse(number2); break;
                case "*": result = float.Parse(number1) * float.Parse(number2); break;
                case "/": result = float.Parse(number1) / float.Parse(number2); break;
            }
            txtDisplay.Text = result.ToString();
            number1 =  number2 = symbol = "";
            dotUsed = false;
        }


    }
}
