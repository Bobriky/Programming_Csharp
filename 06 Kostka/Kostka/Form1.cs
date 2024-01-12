using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostka
{
    public partial class Form1 : Form
    {
        Image specificImageAdress;
        int countOne = 0;
        int countTwo = 0;
        int countThree = 0;
        int countFour = 0;
        int countFive = 0;
        int countSix = 0;
        public Form1()
        {
            InitializeComponent();
            apkInit();

        }
        private void apkInit()
        {

            btnReset.Enabled = false;
            nmPocetHodu.Value = 1;

            try
            {
                Image hod0 = Image.FromFile("Kostka\\kostka1.png");
                picKostka1.Image = hod0;
                picKostka2.Image = hod0;
                picKostka3.Image = hod0;
                picKostka4.Image = hod0;
                picKostka5.Image = hod0;
                picKostka6.Image = hod0;
                countOne = countTwo = countThree = countFour = countFive = countSix = 0;
                toolStripStatusLabel1.Text = countOne.ToString();
                toolStripStatusLabel2.Text = countTwo.ToString();
                toolStripStatusLabel3.Text = countThree.ToString();
                toolStripStatusLabel4.Text = countFour.ToString();
                toolStripStatusLabel5.Text = countFive.ToString();
                toolStripStatusLabel6.Text = countSix.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            apkInit();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Opravdu cheš skončit?", "Ukončení", MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void btnHod_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1 * (int)nmPocetHodu.Value ; i < 7 * (int)nmPocetHodu.Value; i++)
            {
                int hod = rnd.Next(1, 7);
                switch (hod){
                    case 1: specificImageAdress = Image.FromFile("Kostka\\kostka1.png"); countOne++; break;
                    case 2: specificImageAdress = Image.FromFile("Kostka\\kostka2.png"); countTwo++; break;
                    case 3: specificImageAdress = Image.FromFile("Kostka\\kostka3.png"); countThree++; break;
                    case 4: specificImageAdress = Image.FromFile("Kostka\\kostka4.png"); countFour++; break;
                    case 5: specificImageAdress = Image.FromFile("Kostka\\kostka5.png"); countFive++; break;
                    case 6: specificImageAdress = Image.FromFile("Kostka\\kostka6.png"); countSix++; break;
                }
                switch (i){
                    case 1: picKostka1.Image = specificImageAdress; break;
                    case 2: picKostka2.Image = specificImageAdress; break;
                    case 3: picKostka3.Image = specificImageAdress; break;
                    case 4: picKostka4.Image = specificImageAdress; break;
                    case 5: picKostka5.Image = specificImageAdress; break;
                    case 6: picKostka6.Image = specificImageAdress; break;
                }
            }
            toolStripStatusLabel1.Text = countOne.ToString();
            toolStripStatusLabel2.Text = countTwo.ToString();
            toolStripStatusLabel3.Text = countThree.ToString();
            toolStripStatusLabel4.Text = countFour.ToString();
            toolStripStatusLabel5.Text = countFive.ToString();
            toolStripStatusLabel6.Text = countSix.ToString();
            btnReset.Enabled = true;
        }

    }
}
