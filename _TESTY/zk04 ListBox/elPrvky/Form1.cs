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
//using

/*  Zadání
 Program Elektronické prvky má umožňovat: 
 1. Zadat nový prvek do seznamu s požadovanými údaji: 
    Druh, Typ, Popis, Cena  
 2. Načíst seznam Prvků ze souboru (elPrvky.csv) 
 3. Vybrat prvek ze sznamu a zobrazit jeho údaje v polích
 3. Možnost smazání vybraného prvku
 4. Prvky ze seznamu uložit do valstního souboru (např. myPrvky.csv - možnost opakovaného načtení)  
 5. Funkční menu programu, a statistika počtu prvků
 
Pojmenování a třídy aktivních objektů:
    this.lstBox1 = new System.Windows.Forms.ListBox();
    this.lblPocet = new System.Windows.Forms.ToolStripStatusLabel();
    this.cmbDruh = new System.Windows.Forms.ComboBox();
    this.txtTyp = new System.Windows.Forms.TextBox();
    this.textPopis = new System.Windows.Forms.TextBox();
    this.nmCena = new System.Windows.Forms.NumericUpDown();  
    this.btnSmazat = new System.Windows.Forms.Button();
    this.btnPridat = new System.Windows.Forms.Button();
    this.btnSeznamDel = new System.Windows.Forms.Button();
    this.btnSeznamSave = new System.Windows.Forms.Button();
    this.btnSeznamRead = new System.Windows.Forms.Button();
*/

namespace elPrvky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSmazat.Enabled = false;
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if(cmbDruh.SelectedIndex != -1 && txtTyp.Text != "" && txtPopis.Text != "")
            {
                lstBox1.Items.Add(cmbDruh.SelectedItem.ToString() + ";" + txtTyp.Text + ";" + txtPopis.Text + ";" + nmCena.Value.ToString());
                lblPocet.Text = lstBox1.Items.Count.ToString();
                btnSeznamDel.Enabled = btnSeznamSave.Enabled = true;
            }
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Remove(lstBox1.SelectedItem);
            lblPocet.Text = lstBox1.Items.Count.ToString();
            cmbDruh.SelectedIndex = -1;
            txtPopis.Text = txtTyp.Text = "";
            nmCena.Value = 0;
        }
        private void btnSeznamRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sbr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    while (!sbr.EndOfStream)
                    {
                        lstBox1.Items.Add(sbr.ReadLine());
                    }
                    sbr.Close();
                    MessageBox.Show("Data nahrána", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnSeznamSave.Enabled = btnSeznamDel.Enabled = true;
                lblPocet.Text = lstBox1.Items.Count.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeznamSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                    foreach (string item in lstBox1.Items)
                    {
                        sbr.WriteLine(item);
                    }
                    sbr.Close();
                    MessageBox.Show("Data uložena", "huh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeznamDel_Click(object sender, EventArgs e)
        {
            if (lstBox1.Items.Count > -1)
            {
                lstBox1.Items.Clear();
                lblPocet.Text = lstBox1.Items.Count.ToString();
                btnSeznamDel.Enabled = btnSmazat.Enabled = btnSeznamSave.Enabled = false;
                cmbDruh.SelectedIndex = -1;
                txtPopis.Text = txtTyp.Text = "";
                nmCena.Value = 0;
            }
        }

        private void txtPopis_TextChanged(object sender, EventArgs e)
        {
            if (cmbDruh.SelectedIndex != -1 && txtTyp.Text != "" && txtPopis.Text != "")
            {
                //btnSmazat.Enabled = btnSeznamSave.Enabled = btnSeznamDel.Enabled
                btnPridat.Enabled = true;
            }
            else
            {
                btnPridat.Enabled = false;
            }
        }

        private void lstBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBox1.SelectedIndex > -1)
            {
                string[] pole = (lstBox1.SelectedItem.ToString()).Split(';');
                cmbDruh.SelectedItem = pole[0].ToString();
                txtTyp.Text = pole[1].ToString();
                txtPopis.Text = pole[2].ToString();
                nmCena.Value = Decimal.Parse(pole[3]);
                btnSmazat.Enabled = true;
            }
            else
            {
                btnSmazat.Enabled = false;
            }
        }
    }
}
