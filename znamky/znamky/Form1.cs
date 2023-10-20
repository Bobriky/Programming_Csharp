using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace znamky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            intApk();
        }
        private void intApk()
        {
            throw new NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void txtZnamky_TextChanged(object sender, EventArgs e)
        {
            switch (txtZnamky.Text)
            {
                case "1":{
                txtHodnoceni.Text = "výborný";
                break;
                }
                case "2":{
                txtHodnoceni.Text = "chvalitebný";
                break;
                }
                case "3":{
                txtHodnoceni.Text = "dobrý";
                break;
                }
                case "4":{
                txtHodnoceni.Text = "dostatečný";
                break;
                }
                case "5":{
                txtHodnoceni.Text = "nedostatečný";
                break;
                }
                default:{
                txtHodnoceni.Text = "Špatně zadáno";
                break;
                }
            }
        }
    }
}
