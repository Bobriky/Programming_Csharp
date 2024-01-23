using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblKlavesa.Text = e.KeyCode.ToString();
        }
        Random nahoda = new Random();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int locationX = nahoda.Next(0, 384);
            int locationY = nahoda.Next(0, 299);
            button1.Location = new Point(locationX,locationY);
            lblPozXY.Text = e.X + "," + e.Y;
        }
    }
}
