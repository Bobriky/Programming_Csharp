using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulaceZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrepareCmbValues();
        }
        public void PrepareCmbValues()
        {
            cmbR.SelectedIndex = 4;
            cmbL.SelectedIndex = 4;
            cmbC.SelectedIndex = 4;
            cmbF.SelectedIndex = 4;
            cmbDecimal.SelectedIndex = 2;
            cmbXL.SelectedIndex = 4;
            cmbXC.SelectedIndex = 4;
            cmbY.SelectedIndex = 4;
            cmbZ.SelectedIndex = 4;
            cmbPhase.SelectedIndex = 0;
            cmbF0.SelectedIndex = 4;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                nmXL.Value = Convert.ToDecimal(Math.PI)* nmf.Value * nmL.Value * 2;
                nmXC.Value = Convert.ToDecimal(Math.Pow(2 * Math.PI * Convert.ToDouble(nmf.Value) * Convert.ToDouble(nmC.Value),-1));
                nmZ.Value = Convert.ToDecimal(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value));
                nmY.Value = Convert.ToDecimal(Math.Pow(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value),-1));
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }
        private void btnSRO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nmZ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmY_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
