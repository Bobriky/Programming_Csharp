using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scitacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            apkInit();
        }

        private void apkInit()
        {
            txtCislo1.Text = txtCislo2.Text = txtVysledek.Text = "0";
            txtVysledek.Text = "";
            pocetZadani = 0;
            lblPocetZadani.Text = pocetZadani.ToString();
            btnReset.Enabled = btnRovnase.Enabled = false;
        }

        int pocetZadani = 0; 
        private void btnRovnase_Click(object sender, EventArgs e)
        {
            int cislo1 = int.Parse(txtCislo1.Text);
            int cislo2 = int.Parse(txtCislo2.Text);
            txtVysledek.Text = Convert.ToString(cislo1 + cislo2);
            txtVyraz.Text = txtCislo1.Text + lblOperace.Text + txtCislo2.Text + btnRovnase.Text + txtVysledek.Text;
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu ukončit?", "Ukončit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                Close();
            }
            
        }

        private void txtCislo_TextChanged(object sender, EventArgs e)
        {
            btnRovnase.Enabled = true;
            txtVysledek.Clear();
            txtVyraz.Text = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            apkInit();            
        }
    }
}
