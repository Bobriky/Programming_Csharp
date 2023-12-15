using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVypočítat_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(txtBoxValue1.Text);
                int number2 = int.Parse(txtBoxValue2.Text);
                txtBoxSeriove.Text = (number1 + number2).ToString();
                if(!(number2 == 0))
                {
                    txtBoxParalelně.Text = ((number1 * number2) / (float)(number1 + number2)).ToString();
                }  
                btnVypočítat.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Zadané hodnoty jsou špatně");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxValue1.Text = "1";
            txtBoxValue2.Text = "1";
            txtBoxParalelně.Text = "";
            txtBoxSeriove.Text = "";
            btnReset.Enabled = false;
        }

        private void txtBoxValue1_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            txtBoxSeriove.Text = "";
            txtBoxParalelně.Text = "";
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chcete opravdu skončit?");
        }
    }
}
