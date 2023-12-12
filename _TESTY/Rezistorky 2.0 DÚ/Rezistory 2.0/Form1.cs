using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezistory_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtBoxValue1.Text);
                float number2 = float.Parse(txtBoxValue2.Text);
                if (number2 != 0 && number1 != 0)
                {
                    txtBoxSerial.Text = (number1 + number2 + ".00").ToString();  //   O_o
                    txtBoxParalel.Text = (number1 * number2 / (number1 + number2)).ToString();
                }
                else
                    MessageBox.Show("Takže my budeme dělit nulou?");
            }
            catch (Exception)
            {
                MessageBox.Show("Zadané hodnoty buď nejsou, nebo jsou špatně zadány!");
            }
            btnReset.Enabled = true;
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxValue1.Text == "" && txtBoxValue2.Text == "")
                btnReset.Enabled = false;
            else
                btnReset.Enabled = true;
            txtBoxSerial.Text = txtBoxParalel.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxValue1.Text = txtBoxValue2.Text = "1";
            txtBoxSerial.Text = txtBoxParalel.Text = "";
            btnReset.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Opravdu chcete skončit?", "Ukončení aplikace", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                Close();
        }
    }
}
