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

namespace LIstBox
{
    public partial class Form1 : Form
    {
        //datová kolekce, která obsahuje seznam všech uklízečů v jednom poli - dobrá práce s tím
        List<cJanitor> seznamJanitors = new List<cJanitor>();
        //string[] pole = new string;
        string[] seznam = new string[5] { "1 Roman Lichnovksy", "2 Dominik Kamidra", "3 Dominik Kamidra", "4 Dominik Kamidra", "5 Dominik Kamidra" };
        public Form1()
        {
            //seznamJanitors.Add(temp);
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
            lblSelIndex.Text = lstBox.SelectedIndex.ToString();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnRemove.Enabled = false;
            btnRemoveAt.Enabled = false;
            nmUpDownID.Value = 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstBox.Items.Remove(lstBox.SelectedItem);
            lblCount.Text = lstBox.Items.Count.ToString();
            lblSelIndex.Text = lstBox.SelectedIndex.ToString();
            btnInsert.Enabled = false;
            btnRemove.Enabled = false;
            btnRemoveAt.Enabled = false;
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            //lstBox.Items.RemoveAt(Convert.ToInt32(nmUpDownID.Value)-1);
            lstBox.Items.RemoveAt(lstBox.SelectedIndex);
            lblCount.Text = lstBox.Items.Count.ToString();
            lblSelIndex.Text = lstBox.SelectedIndex.ToString();
            btnInsert.Enabled = false;
            btnRemove.Enabled = false;
            btnRemoveAt.Enabled = false;
            cJanitor janitor1 = new cJanitor();
            janitor1.modelMetly = "Uklizator48";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            lstBox.Items.Insert(lstBox.SelectedIndex, nmUpDownID.Value + " " + txtJmeno.Text + " " + txtPrijmeni.Text);
            lblCount.Text = lstBox.Items.Count.ToString();
            lblSelIndex.Text = lstBox.SelectedIndex.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstBox.SelectedIndex > -1)
            {
                Form2 okno2 = new Form2(lstBox.SelectedItem.ToString());
                if (okno2.ShowDialog() == DialogResult.OK)
                {
                    lstBox.Items[lstBox.SelectedIndex] = (okno2.nmUpDownID.Value + " " + okno2.txtJmeno.Text + " " + okno2.txtPrijmeni.Text).ToString();
                    MessageBox.Show("Souhlas");
                }
                else
                {
                    MessageBox.Show("Změna zrušena");
                }
            }
        }


        private void btnAddRange_Click(object sender, EventArgs e)
        {
            lstBox.Items.AddRange(seznam);
        }

        private void uložitjakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                    foreach (string item in lstBox.Items)
                    {
                        sbr.WriteLine(item);
                    }
                    sbr.Close();
                    MessageBox.Show("Data uložena", "huh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err){
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void souborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sbr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    while (!sbr.EndOfStream)
                    {
                        lstBox.Items.Add(sbr.ReadLine());
                    }
                    sbr.Close();
                    MessageBox.Show("Data nahrána", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox.SelectedIndex >= 0)
            {
                string[] pole = (lstBox.SelectedItem.ToString()).Split(' ');
                nmUpDownID.Value = Convert.ToInt16(pole[0]);
                txtJmeno.Text = pole[1].ToString();
                txtPrijmeni.Text = pole[2].ToString();
                btnInsert.Enabled = true;
                btnRemove.Enabled = true;
                btnRemoveAt.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnInsert.Enabled = false;
                btnRemove.Enabled = false;
                btnRemoveAt.Enabled = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
