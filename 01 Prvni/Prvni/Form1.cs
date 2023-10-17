using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Zlatý brouk";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Stříbrný brouk";
            textBox2.TextAlign = HorizontalAlignment.Right;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Goldenrod;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//obsah textBox mohu smazat buď metodou Clear(), nebo .Text = "" nebo = null, nebo = String.Empty;
//Každý přidaný element má : [vlastnosti, metody, události]
