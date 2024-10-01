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
    public partial class Form2 : Form
    {
        public Form2(string[] rowData)
        {
            InitializeComponent();
            txtBoxR.Text = rowData[0];
            txtBoxL.Text = rowData[1];
            txtBoxC.Text = rowData[2];
            txtBoxF.Text = rowData[3];
            txtBoxXL.Text = rowData[4];
            txtBoxXC.Text = rowData[5];
            txtBoxZ.Text = rowData[6];
            txtBoxY.Text = rowData[7];
            txtBoxP.Text = rowData[8];
            txtBoxRezF.Text = rowData[9];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
