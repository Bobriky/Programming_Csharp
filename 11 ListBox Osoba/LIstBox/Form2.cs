using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstBox
{
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            try
            {
                string[] pole = (data.Split(' '));
                nmUpDownID.Value = Convert.ToInt16(pole[0]);
                txtJmeno.Text = pole[1].ToString();
                txtPrijmeni.Text = pole[2].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 okno1 = new Form1(nmUpDownID.Value, txtJmeno.Text, txtPrijmeni.Text);
            okno1.Show();
        }
    }
}
