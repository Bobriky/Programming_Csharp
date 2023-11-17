using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
            int height = txtWeight.Text;
            if(txtHeight.Text == "m")
            {
                výška
            }
            else
            {
                výška =
            }
            txtBMI.Text = height / (výška * výška);
            */
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(!(txtWeight.Text == "") && !(txtHeight.Text == ""))
            {
                txtHeight.Text = "";
                txtWeight.Text = "";
                txtBMI.Text = "";
                txtCategory.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
