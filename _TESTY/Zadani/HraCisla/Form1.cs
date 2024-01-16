using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Zadání
    1. Nastavení počtu pokusů dle volby úrovně hry a zobrazení
        Začátečník  20 pokusů       1 - 50 rozsah tipovaného čísla 
        Pokročilý   10 pokusů       1 - 100 rozsah tipovaného čísla     
        Profesionál  5 pokusů       1 - 100 rozsah tipovaného čísla

    2. Spuštění hry tlačítkem Play
        - povolení tlačítka Stop a zakázání tlačítka Play a zakázání nastavení úrovně hry 
        - vygenerování čísla pro tipování ve zvoleném rozsahu 

    3. Tipování čísla do uhodnutí nebo vyčerpání pokusů nebo ukončení tlačítkem Stop 
        - po každém tipu snížit počet pokusů
        - v lblVysledek zobrazovat nápovědu zdali tipované číslo je menší nebo větší než hádané
        - v pctVysledek zobrazovat smajlíka odpovídající úspěšného / neúspěšného pokusu (soubry ve složce Image)  
        - úspěšné uhodnutí zobrazit v lblVysledek + smajlík
        - průběžné zobrazování řady tipovaných čísel v dané hře

    4.  Statistika + ukončení a resetování
        - ve stavovém řádku zobrazovat vcelkový počet výher a proher
        - dialogové ukončení aplikace (btnKonec)
        - defaultní nastavení aplikace (btnReset)
    
    Připravené objekty:
        GroupBox grpUroven
        RadioButton radProf
        RadioButton radPokr
        RadioButton radZac        
        Label lblPokusy
        Button btnReset
        Button btnClose
        
        GroupBox grpHra
        Label lblTip
        NumericUpDown nmTipCislo
        Label lblVysledek
        PictureBox pctVysledek
        Button btnTipuj
        Button btnPlay
        Button btnStop
        ToolStripStatusLabel lblVyhry
        ToolStripStatusLabel lblProhry
        ToolStripStatusLabel lblTipy
*/

namespace HraCisla
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        decimal secretNumber;
        decimal tipNumber;
        decimal rozsah;
        int pokusy;
        int wins = 0;
        int losses = 0;
        public Form1()
        {
            InitializeComponent();
            apkDefault();
        }

        private void apkDefault()
        {
            
            Text = "Hra uhádni číslo";
            AcceptButton = btnPlay;
            CancelButton = btnClose;
            radZac.Enabled = radPokr.Enabled = radProf.Enabled = true;
            btnPlay.Enabled = false;
            radZac.Checked = true;
            btnStop.Enabled = false;
            btnTipuj.Enabled = false;
            lblPokusy.Text = "20";
            lblTipy.Text = "";
            pctVysledek.Image = Image.FromFile("Image\\EmotionReady.png");
        }

        private void radZac_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            lblTip.Text = "Zadej tip (číslo v rozsahu 1 - 50)";
            nmTipCislo.Maximum = 50;
            lblPokusy.Text = "20";
        }

        private void radPokr_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            lblTip.Text = "Zadej tip (číslo v rozsahu 1 - 100)";
            nmTipCislo.Maximum = 100;
            lblPokusy.Text = "10";
        }

        private void radProf_CheckedChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            lblTip.Text = "Zadej tip (číslo v rozsahu 1 - 100)";
            nmTipCislo.Maximum = 100;
            lblPokusy.Text = "5";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pctVysledek.Image = Image.FromFile("Image\\EmotionReady.png");
            lblVysledek.Text = "";
            
            btnStop.Enabled = true;
            btnReset.Enabled = true;
            btnPlay.Enabled = false;
            btnTipuj.Enabled = true;

            if(radZac.Enabled != true){
                secretNumber = rnd.Next(1, 101);
                rozsah = 100;
            }
            else{
                secretNumber = rnd.Next(1, 51);
                rozsah = 50;
            }

            radZac.Enabled = radPokr.Enabled = radProf.Enabled = false;
        }

        private void btnTipuj_Click(object sender, EventArgs e)
        {
            tipNumber = nmTipCislo.Value;
            lblTipy.Text += Convert.ToString(tipNumber) + ", ";
            pokusy = int.Parse(lblPokusy.Text);
            if (pokusy > 0)
            {
                if (tipNumber <= rozsah)
                {
                    if (tipNumber == secretNumber)
                    {
                        pctVysledek.Image = Image.FromFile("Image\\EmotionTrue.jpg");
                        lblVysledek.Text = "HURÁ, našli jste číslo!";
                        MessageBox.Show("Vyhrál jsi.");
                        wins++;
                        lblVyhry.Text = Convert.ToString(wins);
                        radZac.Enabled = radPokr.Enabled = radProf.Enabled = true;
                        btnStop.Enabled = false;
                        btnPlay.Enabled = true;
                        btnTipuj.Enabled = false;
                    }
                    else if (tipNumber > secretNumber)
                    {
                        pctVysledek.Image = Image.FromFile("Image\\EmotionFalse.jpg");
                        lblVysledek.Text = "Hledané číslo je menší!";
                    }
                    else
                    {
                        pctVysledek.Image = Image.FromFile("Image\\EmotionFalse.jpg");
                        lblVysledek.Text = "Hledané číslo je větší!";
                    }
                    pokusy--;
                    lblPokusy.Text = Convert.ToString(pokusy);
                }
                else
                {
                    lblVysledek.Text = "Zadal jste rozsah mimo rozsah, nebyl vám odečten pokus.";
                }
            }
            else
            {
                pctVysledek.Image = Image.FromFile("Image\\EmotionFalse.jpg");
                lblVysledek.Text = "Prohrál jsi!";
                losses++;
                lblProhry.Text = Convert.ToString(losses);
                MessageBox.Show("Prohrál jsi. Hledané číslo bylo: " + secretNumber);
                radZac.Enabled = radPokr.Enabled = radProf.Enabled = true;
                btnStop.Enabled = false;
                btnPlay.Enabled = true;
                btnTipuj.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pctVysledek.Image = Image.FromFile("Image\\EmotionFalse.jpg");
            lblVysledek.Text = "Skončil jste dřív!";
            losses++;
            lblProhry.Text = Convert.ToString(losses);
            MessageBox.Show("Prohrál jsi. Hledané číslo bylo: " + secretNumber);
            radZac.Enabled = radPokr.Enabled = radProf.Enabled = true;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;
            btnTipuj.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {   
            apkDefault();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete skončit?", "Ukončení", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
