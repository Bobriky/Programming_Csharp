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
            apcInit();
        }

        private void apcInit()
        {
            txtHodnoceni.Text = "";
            txtZnamky.Text = "";
        }

        private void txtZnamky_TextChanged(object sender, EventArgs e)
        {
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
