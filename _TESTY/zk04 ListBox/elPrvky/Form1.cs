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

/*  Zadání
 Program Elektronické prvky má umožňovat: 
 1. Zadat nový prvek do seznamu s požadovanými údaji: 
    Druh, Typ, Popis, Cena  
 2. Načíst seznam Prvků ze souboru (elPrvky.csv) 
 3. Vybrat prvek ze sznamu a zobrazit jeho údaje v polích
 3. Možnost smazání vybraného prvku
 4. Prvky ze seznamu uložit do vlastního souboru (např. myPrvky.csv - možnost opakovaného načtení)  
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
        }

        private void načístToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sbr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    while (!sbr.EndOfStream)
                    {
                        lstBox1.Items.Add(sbr.ReadLine());
                    }
                    sbr.Close();
                    MessageBox.Show("Data nahrána", "STAV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                    foreach (string item in lstBox1.Items)
                    {
                        sbr.WriteLine(item);
                    }
                    sbr.Close();
                    MessageBox.Show("Data uložena", "STAV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Add(cmbDruh.SelectedItem + ";" + txtTyp.Text + ";" + textPopis.Text + ";" + nmCena.Value.ToString());
        }

        private void lstBox1_Click(object sender, EventArgs e)
        {
            if (lstBox1.SelectedIndex > -1)
            {
                string[] pole = (lstBox1.SelectedItem.ToString()).Split(';');
                cmbDruh.SelectedItem = pole[1].ToString();
                txtTyp.Text = pole[2].ToString();
                textPopis.Text = pole[3].ToString();
                nmCena.Value = int.Parse(pole[4]);
            }
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if(lstBox1.SelectedIndex > -1)
            {
                lstBox1.Items.Remove(lstBox1.Items[lstBox1.SelectedIndex]);
            }
        }
    }
}
