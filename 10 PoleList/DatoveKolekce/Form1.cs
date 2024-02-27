using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatoveKolekce
{
    public partial class Form1 : Form
    {
        //{ "Ahoj", "Dobrý den", "Čau", "Nazdar", "Skol", "Dejžto pánbůh", "Čest práci", "Ruku líbám", "Má úcta", "Servus" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCislice_Click(object sender, EventArgs e)
        {
          
            showCislice();
        }

        private void btnLicha_Click(object sender, EventArgs e)
        {
          
            showCislice();
        }

        private void btnSuda_Click(object sender, EventArgs e)
        {
          
            showCislice();
        }

        Random nhd = new Random();
        private void btnRandom_Click(object sender, EventArgs e)
        {
          
            showCislice();
        }

        private void btnRada_Click(object sender, EventArgs e)
        {
          
            showCislice();
        }

        private void showCislice()
        {
          
        }

        private void btnHeslo_Click(object sender, EventArgs e)
        {
          
        }
    }
}
