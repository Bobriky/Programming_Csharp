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
<<<<<<< HEAD
            apcInit();
=======
            intApk();
        }
        private void intApk()
        {
            throw new NotImplementedException();
>>>>>>> 60c399690f42d27fe3e8237927757c92fd7cc95b
        }

        private void apcInit()
        {
<<<<<<< HEAD
            txtHodnoceni.Text = "";
            txtZnamky.Text = "";
=======

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

>>>>>>> 60c399690f42d27fe3e8237927757c92fd7cc95b
        }
        private void txtZnamky_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            switch (txtZnamky.Text){
                case "1":{
                    txtHodnoceni.Text = "Výborný";
                    break;
                }
                case "2":{
                    txtHodnoceni.Text = "Chvalitebný";
                    break;
                }
                case "3":{
                    txtHodnoceni.Text = "Dobrý";
                    break;
                }
                case "4":{
                    txtHodnoceni.Text = "Dostatečný";
                    break;
                }
                case "5":{
                    txtHodnoceni.Text = "Nedostatečný";
                    break;
                }
                default: {
                    txtHodnoceni.Text = "Špatně zadáno";
                    break;
=======
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
>>>>>>> 60c399690f42d27fe3e8237927757c92fd7cc95b
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
         
        }
    }
}
