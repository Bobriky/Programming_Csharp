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

namespace Telefoní_seznam
{
    public partial class Form1 : Form
    {
        List<string> itemsToRemove = new List<string>();
        string[] arr1 = new string[1] {"1"};
        string[] arr2 = new string[4] {"a", "b","c", "2"};
        string[] arr3 = new string[4] {"d", "e", "f", "3"};
        string[] arr4 = new string[4] {"g", "h", "i", "4"};
        string[] arr5 = new string[4] {"j", "k", "l", "5"};
        string[] arr6 = new string[4] {"m", "n", "o", "6"};
        string[] arr7 = new string[5] {"p", "q", "r", "s", "7"};
        string[] arr8 = new string[4] {"t", "u", "v", "8"};
        string[] arr9 = new string[5] {"w", "x", "y", "z", "9"};
        string[] arr0 = new string[2] {"+", "0"};
        int howManyClicks = 0;
        int lastBtnClicked;
        int CountEliminated = 0;
        int CountFounded = 0;
        //bool atLeastOneFound = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void otevřítToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxSeznam.Items.Clear();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sbr = new StreamReader(openFileDialog.FileName, Encoding.Default);
                    while (!sbr.EndOfStream)
                    {
                        lstBoxSeznam.Items.Add(sbr.ReadLine());
                    }
                    sbr.Close();
                    MessageBox.Show("Data nahrána", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btn0.Enabled = btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                lstBoxSeznam.Enabled = true;
                lblCountAll.Text = lstBoxSeznam.Items.Count.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void uložitToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sbr = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default);
                    foreach (string item in lstBoxSeznam.Items)
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
        
        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
            if (txtBoxExpression.Text.Length == 0)
            {
                btnDeleteOne.Enabled = false;
            }
            //grpBox1.Enabled = true;
            //lstBoxSeznam.Enabled = true;
        }

        private void txtBoxExpression_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxExpression.Text != "")
            {
                CountFounded = CountEliminated = 0;
                //atLeastOneFound = false;
                for (int i = lstBoxSeznam.Items.Count - 1; i >= 0; i--)
                {
                    string item = lstBoxSeznam.Items[i].ToString();

                    if (!item.Contains(txtBoxExpression.Text))
                    {
                        lstBoxSeznam.Items.RemoveAt(i);
                        lstBoxSeznam.Items.Add(item);
                        CountEliminated++;
                    }
                    else
                    {
                        CountFounded++;
                        //atLeastOneFound = true;
                    }
                }
                lblCountAll.Text = lstBoxSeznam.Items.Count.ToString();
                lblCountEliminated.Text = CountEliminated.ToString();
                lblCountFounded.Text = CountFounded.ToString();
                /*
                if (!atLeastOneFound)
                {
                    MessageBox.Show("V seznamu nebylo nic nalezeno, prosím upravte hledaný výraz.", "GG bro", MessageBoxButtons.OK);
                    grpBox1.Enabled = false;
                    lstBoxSeznam.Enabled = false;
                    btnDeleteOne.Enabled = true;
                }*/
                // "Zbytečná" kontrola, která tvoří mnoho problému, mmusel byl kontrolovat zda je spokojený
                // s hledaným výrazem, protože npaříklad když bude chtít proklikávat nějaký tlačítko a jeden
                // z těch symbolů nebude sedět, tak to bude vyhazovat tuto upomínku, která mmu zabranuje k tomu cílenému písmenku.
            }
        }
        private void grpBox1_MouseHover(object sender, EventArgs e)
        {
            if (!lstBoxSeznam.Enabled)
            {
                MessageBox.Show("Nahrajte telefoní sesznam skrze ikonku vlevo nahoře. Doporučené formáty .txt", "Nahrajte data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxExpression.Text += arr1[0];
            lastBtnClicked = 1;
            btnDeleteOne.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 2)
            {
                lastBtnClicked = 2;
                howManyClicks = 1;
                txtBoxExpression.Text += arr2[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr2[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 3)
            {
                lastBtnClicked = 3;
                howManyClicks = 1;
                txtBoxExpression.Text += arr3[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr3[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 4)
            {
                lastBtnClicked = 4;
                howManyClicks = 1;
                txtBoxExpression.Text += arr4[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr4[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 5)
            {
                lastBtnClicked = 5;
                howManyClicks = 1;
                txtBoxExpression.Text += arr5[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr5[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 6)
            {
                lastBtnClicked = 6;
                howManyClicks = 1;
                txtBoxExpression.Text += arr6[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr6[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 7)
            {
                lastBtnClicked = 7;
                howManyClicks = 1;
                txtBoxExpression.Text += arr7[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr7[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 4)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 8)
            {
                lastBtnClicked = 8;
                howManyClicks = 1;
                txtBoxExpression.Text += arr8[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr8[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 3)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 9)
            {
                lastBtnClicked = 9;
                howManyClicks = 1;
                txtBoxExpression.Text += arr9[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr9[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 4)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lastBtnClicked != 0)
            {
                lastBtnClicked = 0;
                howManyClicks = 1;
                txtBoxExpression.Text += arr0[0];
            }
            else
            {
                if (txtBoxExpression.Text.Length != 0)
                {
                    txtBoxExpression.Text = txtBoxExpression.Text.Substring(0, txtBoxExpression.Text.Length - 1);
                }
                txtBoxExpression.Text += arr0[howManyClicks];
                howManyClicks++;
                if (howManyClicks > 1)
                {
                    howManyClicks = 0;
                }
            }
            btnDeleteOne.Enabled = true;
        }

    }
}
