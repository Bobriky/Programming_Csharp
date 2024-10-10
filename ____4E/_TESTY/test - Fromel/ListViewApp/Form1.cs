using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            nmID.Value = lstView.Items.Count+1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] polozka =
            {
                txtJmeno.Text,
                txtPrijmeni.Text,
                Convert.ToString(dtZapis.Value),
        };

            ListViewItem radek = new ListViewItem(Convert.ToString(nmID.Value));
            for(int i = 0; i < 3; i++)
            {
                radek.SubItems.Add(polozka[i]);
            }
            if (rdMuz.Checked)
            {
                radek.SubItems.Add(rdMuz.Text);
            }
            else
            {
                radek.SubItems.Add(rdZena.Text);
            }

            if (chkAktivni.Checked)
            {
                radek.SubItems.Add(chkAktivni.Text);
            }
            if(chkDpp.Checked)
            {
                radek.SubItems.Add(chkDpp.Text);
            }
            lstView.Items.Add(radek);

            nmID.Value += 1;
            btnClear.Enabled = true;
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtJmeno.Text = Convert.ToString(lstView.SelectedItems[0]);
            txtPrijmeni.Text = Convert.ToString(lstView.SelectedItems[1]);
            nmID.Value = Convert.ToDecimal(lstView.SelectedItems[2]);
            dtZapis.Value = Convert.ToDateTime(lstView.SelectedItems[3]);
            //nefunguje...
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult odpoved = MessageBox.Show("Opravdu chcete smazat všechny položky?", "Smazání " ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odpoved == DialogResult.Yes)
            {
                lstView.Clear();
                btnClear.Enabled = false;
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
