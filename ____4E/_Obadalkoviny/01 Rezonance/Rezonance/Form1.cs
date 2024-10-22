using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezonance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
            lstView.Columns.Add("Index", 40, HorizontalAlignment.Center);
            lstView.Columns.Add("f [Hz]", 40, HorizontalAlignment.Center);
            lstView.Columns.Add("XC [Ω]", 80, HorizontalAlignment.Center);
            lstView.Columns.Add("XL [Ω]", 80, HorizontalAlignment.Center);
            lstView.Columns.Add("Z [Ω]", 80, HorizontalAlignment.Center);
            lstView.Columns.Add("Y [Ω]", 80, HorizontalAlignment.Center);
            double frez = 1 /( 2 * Math.PI * Math.Sqrt((double)numericUpDown2.Value * (double)numericUpDown3.Value));

            //lblRezF.Text =
            tmr1.Interval = 1000;
            tmr1.Start();

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblCas.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
