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

/* Zadání:
    1. Naplnění kolekce lstView z hodnot skupiny Tools (btnAdd_Click)
    2. Výběr položky v kolekci a zobrazení v Tools (lstView_SelectedIndexChanged)
    3. Editace položek v kolekci (btnRemove_Click, btnUpdate_Click, btnClear_Click)
    4. Uložení a načtení dat z/do souboru (btnFileOpen_Click, btnFileSave_Click)
 */

namespace ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Načtení hodnot do proměných
            string idValue = nmID.Value.ToString();
            string jmenoValue = txtJmeno.Text;
            string prijmeniValue = txtPrijmeni.Text;
            string datumZapisValue = dtZapis.Value.ToShortDateString();
            string pohlaviValue;
            string aktivniValue;
            string dppValue;
            if (rdMuz.Checked){
                pohlaviValue = "Muž";
            }
            else{
                pohlaviValue = "Žena";
            }
            if (chkAktivni.Checked){
                aktivniValue = "Aktivní";
            }
            else{
                aktivniValue = "Neaktivní";
            }
            if (chkDpp.Checked){
                dppValue = "DPP";
            }
            else{
                dppValue = "";
            }

            //Vytvoření objektu ListViewItem a přidání načtených hodnot
            ListViewItem listViewItem = new ListViewItem(idValue);
            listViewItem.SubItems.Add(jmenoValue);
            listViewItem.SubItems.Add(prijmeniValue);
            listViewItem.SubItems.Add(datumZapisValue);
            listViewItem.SubItems.Add(pohlaviValue);
            listViewItem.SubItems.Add(aktivniValue);
            listViewItem.SubItems.Add(dppValue);

            //Přidání řádku
            lstView.Items.Add(listViewItem);

            btnClear.Enabled = true;
            btnFileSave.Enabled = true;
            nmID.Value ++; //automatická inkrementace nmID
            lblCount.Text = lstView.Items.Count.ToString();
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;

                ListViewItem selectedItemRow = lstView.SelectedItems[0]; //Získá vybraný řádek

                //Načítání dat z jednotlivých sloupců
                nmID.Value = Convert.ToDecimal(selectedItemRow.SubItems[0].Text);
                txtJmeno.Text = selectedItemRow.SubItems[1].Text;
                txtPrijmeni.Text = selectedItemRow.SubItems[2].Text;
                dtZapis.Value = Convert.ToDateTime(selectedItemRow.SubItems[3].Text);
                if (selectedItemRow.SubItems[4].Text == "Muž"){
                    rdMuz.Checked = true;
                }
                else{
                    rdZena.Checked = true;
                }
                chkAktivni.Checked = selectedItemRow.SubItems[5].Text == "Aktivní";
                chkDpp.Checked = selectedItemRow.SubItems[6].Text == "DPP";


                lblCount.Text = lstView.Items.Count.ToString();
                lblSelIndex.Text = lstView.SelectedIndices[0].ToString();
            }
            else
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                lstView.Items.Remove(lstView.SelectedItems[0]);
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
                if(lstView.Items.Count < 1)
                {
                    lblCount.Text = "0";
                    lblSelIndex.Text = "-1";
                    btnFileSave.Enabled = false;
                }
                else
                {
                    lblCount.Text = lstView.Items.Count.ToString();
                    lblSelIndex.Text = "-1";
                    btnFileSave.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItemRow = lstView.SelectedItems[0];

                selectedItemRow.SubItems[0].Text = nmID.Value.ToString();
                selectedItemRow.SubItems[1].Text = txtJmeno.Text;
                selectedItemRow.SubItems[2].Text = txtPrijmeni.Text;
                selectedItemRow.SubItems[3].Text = dtZapis.Value.ToShortDateString();
                if (rdMuz.Checked){
                    selectedItemRow.SubItems[4].Text = "Muž";
                }
                else {
                    selectedItemRow.SubItems[4].Text = "Žena";
                }
                if (chkAktivni.Checked){
                    selectedItemRow.SubItems[5].Text = "Aktivní";
                }
                else{
                    selectedItemRow.SubItems[5].Text = "Neaktivní";
                }
                if (chkDpp.Checked){
                    selectedItemRow.SubItems[6].Text = "DPP";
                }
                else{
                    selectedItemRow.SubItems[6].Text = "";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = MessageBox.Show("Opravdu chcete smazat všechny položky?", "Smazání " ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odpoved == DialogResult.Yes)
            {
                lstView.Items.Clear();
                btnClear.Enabled = false;
                btnRemove.Enabled = false;
                btnFileSave.Enabled = false;

                lblCount.Text = "0";
                lblSelIndex.Text = "-1";
                nmID.Value = 1;
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                dtZapis.Value = DateTime.Now;
                rdMuz.Checked = true;
                chkAktivni.Checked = true;
                chkDpp.Checked = false;
            }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sbr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        lstView.Items.Clear();
                        while (!sbr.EndOfStream)
                        {
                            string line = sbr.ReadLine();
                            string[] rowData = line.Split(','); //separátor musí být (,)

                            //Vytvoříme nový objekt ListViewItem a předchystáme hodnotu prvního sloupce ID
                            ListViewItem item = new ListViewItem(rowData[0]); 
                            for (int i = 1; i < rowData.Length; i++)
                            {
                                item.SubItems.Add(rowData[i]); //nahráváme jednotlivé subitemy rozdělené po čárkách
                            }

                            lstView.Items.Add(item); //nakonec přídáme
                        }
                    }
                    MessageBox.Show("Data nahrána", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default))
                    {
                        foreach (ListViewItem item in lstView.Items) //postupně prochází jednotlivé řádky
                        {
                            string[] subitems = new string[item.SubItems.Count]; //definujeme pole o počtu subitemů v řádku
                            for (int i = 0; i < item.SubItems.Count; i++) //řádek procházíme a při každém subitemu
                            {
                                subitems[i] = item.SubItems[i].Text;    // nahráváme do pole na daný obsah do daného indexu
                            }
                            sbr.WriteLine(string.Join(",", subitems)); //spojí všechny hodnoty a mezi ně dá (,) + zapíše celý řádek do souboru
                        }
                    }
                    MessageBox.Show("Seznam uložen", "Uložení seznamu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
