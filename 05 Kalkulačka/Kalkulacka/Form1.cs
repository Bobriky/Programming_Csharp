using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRovnase_Click(object sender, EventArgs e)
        {
            
            try
            {
                int cislo1 = int.Parse(txtCislo1.Text);
                int cislo2 = int.Parse(txtCislo2.Text);
                switch (lblOperace.Text)
                {
                    case "+": txtVysledek.Text = (cislo1 + cislo2).ToString(); break;
                    case "-": txtVysledek.Text = (cislo1 - cislo2).ToString(); break;
                    case "*": txtVysledek.Text = (cislo1 * cislo2).ToString(); break;
                    case "/": txtVysledek.Text = (cislo1 / (float) cislo2).ToString(); break;                  
                }
                txtVyraz.Text = txtCislo1.Text + lblOperace.Text + txtCislo2.Text + btnRovnase.Text + txtVysledek.Text;
            }
            catch (Exception err)
            {
                txtVyraz.Text = err.Message;
            }
            
        }

        private void rdBtnSoucet_CheckedChanged(object sender, EventArgs e)
        {
            txtVysledek.Text = txtVyraz.Text = "";

            if (rdBtnSoucet.Checked)
            {
                lblOperace.Text = rdBtnSoucet.Text;
            }
            else if (rdBtnRozdil.Checked)
            {
                lblOperace.Text = rdBtnRozdil.Text;
            }
            else if (rdBtnSoucin.Checked)
            {
                lblOperace.Text = rdBtnSoucin.Text;
            }
            else if (rdBtnPodil.Checked)
            {
                lblOperace.Text = rdBtnPodil.Text;
            }
        }

        private void chkOperace_CheckedChanged(object sender, EventArgs e)
        {
            grpOperace.Enabled = chkOperace.Checked; 
        }

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            txtVyraz.ReadOnly = txtVysledek.ReadOnly = chkReadOnly.Checked;
        }

        private void chkBarvy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBarvy.Checked)
            {
                colorDialog1.ShowDialog();
                txtVysledek.ForeColor = colorDialog1.Color;
                colorDialog1.ShowDialog();
                txtVysledek.BackColor = colorDialog1.Color;
            }
            // chkBarvy.Checked = false;
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdBtnSoucet.Checked = true;
            rdBtnSoucin.Checked = rdBtnRozdil.Checked = rdBtnPodil.Checked = false;
            lblOperace.Text = rdBtnSoucet.Text;
            txtVysledek.Text = "";
            btnRovnase.Enabled = false;
            btnReset.Enabled = false;
        }
    }
}
