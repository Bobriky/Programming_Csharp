using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsobaUdalosti
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            dtMat.Value = dtNar.Value.AddYears(19);
            dtProm.Value = dtNar.Value.AddYears(24);
            dtSvat.Value = dtNar.Value.AddYears(35);
            dtDuch.Value = dtNar.Value.AddYears(67);
            dtUmrt.Value = dtNar.Value.AddYears(92);
            timer1.Enabled = true;
            timer1 = new Timer();
            timer1.Start();
        }

        private void dtMat_ValueChanged(object sender, EventArgs e)
        {
            DateTime narozeni = DateTime.Now;
            TimeSpan dobaNar = dtNar.Value - narozeni;
            TimeSpan dobaMat = dtMat.Value - narozeni;
            TimeSpan dobaProm = dtProm.Value - narozeni;
            TimeSpan dobaSvat = dtSvat.Value - narozeni;
            TimeSpan dobaDuch = dtDuch.Value - narozeni;
            TimeSpan dobaUmrt = dtUmrt.Value - narozeni;

            txtDnes.Text = (Convert.ToInt32(dtNar.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtDnesD.Text = dobaNar.Days.ToString();

            txtMat.Text = (Convert.ToInt32(dtMat.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtMatD.Text = dobaMat.Days.ToString();

            txtProm.Text = (Convert.ToInt32(dtProm.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtPromD.Text = dobaProm.Days.ToString();

            txtSvat.Text = (Convert.ToInt32(dtSvat.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtSvatD.Text = dobaSvat.Days.ToString();

            txtDuch.Text = (Convert.ToInt32(dtDuch.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtDuchD.Text = dobaDuch.Days.ToString();

            txtUmrt.Text = (Convert.ToInt32(dtUmrt.Value.Year.ToString()) - Convert.ToInt32(narozeni.Year.ToString())).ToString();
            txtUmrtD.Text = dobaUmrt.Days.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;
            lblDate.Text = datum.ToLongDateString();
            lblTime.Text = datum.ToLongTimeString();
        }
    }
}
