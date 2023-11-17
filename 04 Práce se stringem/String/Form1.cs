using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            apkInit();
        }

        int pocetOsob = 0;

        private void txtCeleJmeno_TextChanged(object sender, EventArgs e)
        {
            btnAkce.Enabled = true;
            if (lblPrijmeni.Text != "" || lblJmeno.Text != "" || lblInicial.Text != "")
            {
                lblPrijmeni.Text = lblJmeno.Text = lblInicial.Text = ""; 
            }
        }

        private void btnAkce_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            try
            {
                string[] celeJmeno = txtCeleJmeno.Text.Split(' ');
                lblJmeno.Text = celeJmeno[0];
                lblPrijmeni.Text = celeJmeno[1];
                //lblInicial.Text = lblJmeno.Text.Substring(0, 1) + lblPrijmeni.Text.Substring(0, 1);
                lblInicial.Text = lblJmeno.Text[0].ToString() + lblPrijmeni.Text[0].ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            apkInit();
        }

        private void apkInit()
        {
            txtCeleJmeno.Text = lblPrijmeni.Text = lblJmeno.Text = lblInicial.Text = "";
            btnAkce.Enabled = btnReset.Enabled = false;
            pocetOsob = 0;
            lblPocetOsob.Text = pocetOsob.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string txtZprava = "Opravdu chcete ukončit aplikaci?";
            if (MessageBox.Show(txtZprava, "Ukončení", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
