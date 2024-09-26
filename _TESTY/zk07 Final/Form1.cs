using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tridaZaci
{
    public partial class Form1 : Form
    {
        // Vytvoření instancí jednotlivých oborů
        cObor INF = new cObor("INF","Informační technologie");
        cObor ELT = new cObor("ELT", "Eletrotechnika");
        cObor MECH = new cObor("MECH","Mechanik elektrotechnik");
        cObor ELK = new cObor("ELK", "Elektrikář");

        // Vytvoření instancí třídních učitelů
        cUcitel uPorizkova = new cUcitel("Štěpánka", "Pořízková", "Mgr.");
        cUcitel uFranek = new cUcitel("Vojtěch", "Franek", "Mgr.");
        cUcitel uDolezel = new cUcitel("Josef", "Doležel", "Ing.");

        // Vytvoření globálních instancí tříd
        cTrida trida3E;
        cTrida trida3F;
        cTrida trida4E;
        cTrida trida4F;

        // Seznam žáků třídy - datová kolekce objektů třídy student
        List<cStudent> seznam = new List<cStudent>();
        
        // Instance pro jednoho žáka
        cStudent student;

        public Form1()
        {
            
            InitializeComponent();
            
            // Podrobnější nastavení oborů
            INF.Delka = ELT.Delka = MECH.Delka = 4;
            INF.Zkouska = ELT.Zkouska = MECH.Zkouska = "Maturitní zkouška";
            INF.SVP = "Programování a počítačové systémy";
            ELT.SVP = "Programování a automatizace";
            ELK.Delka = 3; 
            ELK.Zkouska = "Závěrečná zkouška";
            try
            {
                // Email učitele
                uFranek.Mail = "franekv@sse-lipniknb.cz";
                uPorizkova.Mail = "porizkovas@sse-lipniknb.cz";
                uPorizkova.Mail = "dolezelj@sse-lipniknb.cz";

                // Nastavení tříd
                trida3E = new cTrida("3E", uPorizkova, ELT);
                trida3F = new cTrida("3F", uFranek, INF);
                trida4E = new cTrida("4E", uDolezel, ELT);
                trida4F = new cTrida("4F", uDolezel, INF);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            // Vytvoření studenta a přidání žáka do seznamu (instance do datové kolekce)
            student = new cStudent("Jan", "Josef", trida3E);
            seznam.Add(student);
            student = new cStudent("Josef", "Jan", trida3F);
            seznam.Add(student);
            student = new cStudent("Martin", "Michal", trida4E);
            seznam.Add(student);
            student = new cStudent("Michal", "Martin", trida4F);
            seznam.Add(student);
            lblSeznamCount.Text = seznam.Count.ToString();

            // Načtení souborů csv ze složky Data a vložení do comboBoxu
            readFile();


            // Zobrazení osob v ListBoxu z datové kolekce
            readSeznam();
        }

        private void readSeznam()
        {
            lstBox.Items.Clear();
            foreach (cStudent item in seznam)
            {
                lstBox.Items.Add(item.Jmeno + " " + item.Prijmeni);
            }
            lblListCount.Text = lstBox.Items.Count.ToString();
            lblLstIndex.Text = lstBox.SelectedIndex.ToString();
        }

        private void readFile()
        {
            cmbFile.Items.Clear();
            foreach (string item in Directory.EnumerateFiles("Data\\", "*.csv", SearchOption.TopDirectoryOnly))
            {
                cmbFile.Items.Add(item);
            }
            if (cmbFile.Items.Count > 0)
            {
                cmbFile.SelectedIndex = 0;
            }
        }

        private void btnFileRead_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLstIndex.Text = lstBox.SelectedIndex.ToString();
            if (lstBox.SelectedIndex >= 0)
            {
                int indx = lstBox.SelectedIndex;
                lblJmeno.Text = seznam[indx].Jmeno + " " + seznam[indx].Prijmeni;
                lblTřída.Text = seznam[indx].Trida.Zkratka;
                lblTridniUc.Text = seznam[indx].Trida.tridiUcitel.Prijmeni;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBox.SelectedIndex >= 0)
            {
                int indx = lstBox.SelectedIndex;
                seznam.RemoveAt(indx);
                lstBox.Items.RemoveAt(indx);
                lblListCount.Text = lstBox.Items.Count.ToString();
                lblLstIndex.Text = lstBox.SelectedIndex.ToString();
                lblSeznamCount.Text = seznam.Count.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Opravdu vše smazat?", "Upozornění", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                seznam.Clear();
                lstBox.Items.Clear();
                lblListCount.Text = lstBox.Items.Count.ToString();
                lblLstIndex.Text = lstBox.SelectedIndex.ToString();
                lblSeznamCount.Text = seznam.Count.ToString();
            }            
        }

        private void datovýModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmModel mdl = new fmModel();
            mdl.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Načtení dat ze souboru zvoleného v ComboBoxu do datové kolekce typu List
            try
            {
                StreamReader sbr = new StreamReader(cmbFile.SelectedItem.ToString(), Encoding.Default);
                while (!sbr.EndOfStream)
                {
                    string[] pole = (sbr.ReadLine().Split(';'));
                    lstBox.Items.Add(pole[1] + " " + pole[2]);
                    cTrida trida = new cTrida();
                    trida.Zkratka = pole[3];
                    cStudent student = new cStudent(pole[2], pole[1], trida, pole[4]);
                    seznam.Add(student);
                }
                sbr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            // Uložení dat do souboru csv z datové kolekce typu List




        }

        private void btnTridaDetail_Click(object sender, EventArgs e)
        {
            // Okno pro zobrazení všech detailů třídy (včetně informací o oboru)



        }

        private void btnTridniDetail_Click(object sender, EventArgs e)
        {
            // Okno pro zobrazení všech detailů o třídním učiteli



        }
    }
}
