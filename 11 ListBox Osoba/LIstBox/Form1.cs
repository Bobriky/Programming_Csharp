using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> lstJmena = new List<string>();         //vytvoření listu jako objekt :)
            lstJmena.Add("Podsedák");
            lstJmena.Add("Trávník");

            txtJmeno.Text = lstJmena[0];                        //vložení do text boxu stringu listu pomocí indexu
            txtPrijmeni.Text = lstJmena[1];
            cmbSelMode.SelectedIndex = 0;
            lblCount.Text = lstBox.Items.Count.ToString();
            lblSelIndex.Text = lstBox.SelectedIndex.ToString();
            lbllSelCount.Text = lstBox.SelectedIndices.Count.ToString();
            if (lstBox.SelectedIndex >= 0)
            {
                lblSelItem.Text = lstBox.SelectedItems.ToString();
            }
            nmUpDownID.Value = lstBox.Items.Count + 1;


            for (int i = 0; i < lstBox.Items.Count; i++)
            {
                //všechny položky
            }

            foreach (string item in lstBox.Items)
            {
                //všechny položky
            }

            for (int i = 0; i < lstBox.SelectedIndices.Count; i++)
            {
                //všechny vybrané položky
            }

            foreach (string item in lstBox.SelectedItems)
            {
                //všechny vybrané položky
            }

            foreach (int item in lstBox.SelectedIndices)
            {
                //všechny vybrané položky
            }
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbSelMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelMode.SelectedIndex == 0)
            {
                lstBox.SelectionMode = SelectionMode.One;
            }
            else if (cmbSelMode.SelectedIndex == 1)
            {
                lstBox.SelectionMode = SelectionMode.MultiSimple;
            }
            else if (cmbSelMode.SelectedIndex == 2)
            {
                lstBox.SelectionMode = SelectionMode.MultiExtended;
            }
            else if (cmbSelMode.SelectedIndex == 3)
            {
                lstBox.SelectionMode = SelectionMode.None;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBox.Items.Add(nmUpDownID.Value + " " + txtJmeno.Text + " " + txtPrijmeni.Text);
            nmUpDownID.Value++;
            lblCount.Text = lstBox.Items.Count.ToString();
            if(lstBox.Items.Count > 0){
                btnClear.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            lblCount.Text = lstBox.Items.Count.ToString();
            btnClear.Enabled = false;
            nmUpDownID.Value = 0;
        }
    }
}
