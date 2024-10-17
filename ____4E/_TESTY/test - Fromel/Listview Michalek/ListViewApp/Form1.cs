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
            string id = nmID.Value.ToString();
            string jmeno = txtJmeno.Text;
            string prijmeni = txtPrijmeni.Text;
            string datumZapis = dtZapis.Value.ToShortDateString();

            string pohlavi;
            if (rdMuz.Checked == true)
            {
                pohlavi = "Muž";
            }
            else
            {
                pohlavi = "Žena";
            }

            string aktivni;
            if (chkAktivni.Checked)
            {
                aktivni = "ANO";
            }
            else
            {
                aktivni = "NE";
            }

            string dpp;
            if (chkDpp.Checked == true)
            {
                dpp = "ANO";
            }
            else
            {
                dpp = "NE";
            }

            ListViewItem polozka = new ListViewItem(id);
            polozka.SubItems.Add(jmeno);
            polozka.SubItems.Add(prijmeni);
            polozka.SubItems.Add(datumZapis);
            polozka.SubItems.Add(pohlavi);
            polozka.SubItems.Add(aktivni);
            polozka.SubItems.Add(dpp);

            lstView.Items.Add(polozka);

            btnClear.Enabled = true;
            lblCount.Text = lstView.Items.Count.ToString();

        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem vybranaPolozka = lstView.SelectedItems[0];

                nmID.Value = Convert.ToDecimal(vybranaPolozka.SubItems[0].Text);
                txtJmeno.Text = vybranaPolozka.SubItems[1].Text;
                txtPrijmeni.Text = vybranaPolozka.SubItems[2].Text;
                dtZapis.Value = Convert.ToDateTime(vybranaPolozka.SubItems[3].Text);

                if (vybranaPolozka.SubItems[4].Text == "Muž")
                {
                    rdMuz.Checked = true;
                }
                else
                {
                    rdZena.Checked = true;
                }

                if (vybranaPolozka.SubItems[5].Text == "ANO")
                {
                    chkAktivni.Checked = true;
                }
                else
                {
                    chkAktivni.Checked = false;
                }

                if (vybranaPolozka.SubItems[6].Text == "ANO")
                {
                    chkDpp.Checked = true;
                }
                else
                {
                    chkDpp.Checked = false;
                }

                lblCount.Text = lstView.Items.Count.ToString();
                lblSelIndex.Text = lstView.SelectedIndices[0].ToString();
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
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
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
                lstView.Items.Remove(lstView.SelectedItems[0]);

                if (lstView.Items.Count < 1)
                {
                    lblSelIndex.Text = "-1";
                    lblCount.Text = "0";
                }
                else
                {
                    lblSelIndex.Text = "-1";
                    lblCount.Text = lstView.Items.Count.ToString();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItemRow = lstView.SelectedItems[0];

                string idString = nmID.Value.ToString();
                string jmenoString = txtJmeno.Text;
                string prijmeniString = txtPrijmeni.Text;
                string datumZapisString = dtZapis.Value.ToShortDateString();

                selectedItemRow.SubItems[0].Text = idString;
                selectedItemRow.SubItems[1].Text = jmenoString;
                selectedItemRow.SubItems[2].Text = prijmeniString;
                selectedItemRow.SubItems[3].Text = datumZapisString;

                string pohlaviString = "Žena";
                if (rdMuz.Checked)
                {
                    pohlaviString = "Muž";
                }
                selectedItemRow.SubItems[4].Text = pohlaviString;

                string aktivniString = "NE";
                if (chkAktivni.Checked)
                {
                    aktivniString = "ANO";
                }
                selectedItemRow.SubItems[5].Text = aktivniString;

                string dppString = "NE";
                if (chkDpp.Checked)
                {
                    dppString = "ANO";
                }
                selectedItemRow.SubItems[6].Text = dppString;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = MessageBox.Show("Opravdu chcete smazat všechny položky?", "Smazání ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odpoved == DialogResult.Yes)
            {
                lstView.Items.Clear();
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                lblSelIndex.Text = "-1";
                lblCount.Text = "0";
                nmID.Value = 1;
                dtZapis.Value = DateTime.Now;
                chkDpp.Checked = false;
                chkAktivni.Checked = true;
                rdMuz.Checked = true;
            }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {

        }
    }
}