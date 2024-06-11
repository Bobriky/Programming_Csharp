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

/* Zadání úkolu

    1. Vytvořte třídu pro schematickou značku (cZnacka), s možností nastavit tyto vlastnosti:
        - součástka: spínač, relé, dioda, klopný obvod, apod.
        - kategorie:  energetika, analog, digital 
        - obrázek schematické značky (umístění a název souboru např: Prvky\NPN.jpg)
        - rozměry obrázku (šířka a výška) 
    2. Tlačítkem Přidat uložte schematickou značku do kolekce značek a současně zobrazte v listboxu jen název součástky
    3. Vytvořte tímto způsobem více značek
    3. Zobrazte počet položek v seznamu lstBox a index vybrané položky 
    4. Při výběru, případně změně značky, zobrazte všechny vlastnosti v objektech formuláře (txtVlast, a PictureBox).    
*/

/* Názvy a typy připravených prvků (objektů) formuláře:
        ListBox lstBox;
        ToolStripStatusLabel lblPocet;
        ToolStripStatusLabel lblSelect;    
 */

namespace zkClass
{
    public partial class Form1 : Form
    {
        List<cZnacka> mujList = new List<cZnacka>(); 
        public Form1()
        {
            InitializeComponent();
        }
         
        private void btnPridat_Click(object sender, EventArgs e)
        {
            cZnacka prvek = new cZnacka(txtBoxVlast1.Text, txtBoxVlast2.Text, txtBoxVlast3.Text, txtBoxVlast4.Text);

            mujList.Add(prvek);

            lstBox.Items.Add(prvek.Soucastka);
            lblPocet.Text = lstBox.Items.Count.ToString();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelect.Text = lstBox.SelectedIndex.ToString();
            txtBoxVlast1.Text = mujList[lstBox.SelectedIndex].Soucastka;
            txtBoxVlast2.Text = mujList[lstBox.SelectedIndex].Kategorie;
            txtBoxVlast3.Text = mujList[lstBox.SelectedIndex].Umistneni;
            txtBoxVlast4.Text = mujList[lstBox.SelectedIndex].Rozmery;
        }

        private void uložitToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                    for (int x = 0; x < lstBox.Items.Count; x++)
                    {
                        sbr.WriteLine(mujList[x].Soucastka + ";" + mujList[x].Kategorie + ";" + mujList[x].Umistneni + ";" + mujList[x].Rozmery);
                    }
                    sbr.Close();
                    MessageBox.Show("Data uložena", "Uložení dat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void otevřítToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sbr = new StreamReader(openFileDialog1.FileName, false);
                    while (!sbr.EndOfStream)
                    {
                        string[] pole = sbr.ReadLine().Split(';');
                        cZnacka prvek = new cZnacka(pole[0], pole[1], pole[2], pole[3]);

                        mujList.Add(prvek);

                        lstBox.Items.Add(prvek.Soucastka);
                    }
                }
                lblPocet.Text = lstBox.Items.Count.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
