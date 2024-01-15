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
        int countOne;
        int countTwo;
        int countThree;
        int countFour;
        int countFive;
        int countSix;
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
                Image hod0 = Image.FromFile("Kostka\\kostka0.png");
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
                chkKostka1.Checked = true;
                chkKostka2.Checked = true;
                chkKostka3.Checked = true;
                chkKostka4.Checked = true;
                chkKostka5.Checked = true;
                chkKostka6.Checked = true;
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
            Image hod0 = Image.FromFile("Kostka\\kostka0.png");
            picKostka1.Image = hod0;
            picKostka2.Image = hod0;
            picKostka3.Image = hod0;
            picKostka4.Image = hod0;
            picKostka5.Image = hod0;
            picKostka6.Image = hod0;

            Random rnd = new Random();
            bool con;

            for(int j = 1; j <= nmPocetHodu.Value; j++)
            {
                for (int i = 1; i < 7; i++)
                {
                    con = true;
                    int hod = rnd.Next(1, 7);
                    switch (i)
                    {
                        case 1: if (chkKostka1.Checked != true) con = false; break;
                        case 2: if (chkKostka2.Checked != true) con = false; break;
                        case 3: if (chkKostka3.Checked != true) con = false; break;
                        case 4: if (chkKostka4.Checked != true) con = false; break;
                        case 5: if (chkKostka5.Checked != true) con = false; break;
                        case 6: if (chkKostka6.Checked != true) con = false; break;
                    }
                    if (con == true)
                    {
                        switch (hod)
                        {
                            case 1: specificImageAdress = Image.FromFile("Kostka\\kostka1.png"); countOne++; break;
                            case 2: specificImageAdress = Image.FromFile("Kostka\\kostka2.png"); countTwo++; break;
                            case 3: specificImageAdress = Image.FromFile("Kostka\\kostka3.png"); countThree++; break;
                            case 4: specificImageAdress = Image.FromFile("Kostka\\kostka4.png"); countFour++; break;
                            case 5: specificImageAdress = Image.FromFile("Kostka\\kostka5.png"); countFive++; break;
                            case 6: specificImageAdress = Image.FromFile("Kostka\\kostka6.png"); countSix++; break;
                        }
                        switch (i)
                        {
                            case 1: picKostka1.Image = specificImageAdress; break;
                            case 2: picKostka2.Image = specificImageAdress; break;
                            case 3: picKostka3.Image = specificImageAdress; break;
                            case 4: picKostka4.Image = specificImageAdress; break;
                            case 5: picKostka5.Image = specificImageAdress; break;
                            case 6: picKostka6.Image = specificImageAdress; break;
                        }
                    }
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