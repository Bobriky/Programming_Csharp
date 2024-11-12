using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulaceZ
{
    public partial class Form1 : Form
    {
        private bool isFormInitialized = false;
        private int actionIndex;
        public Form1()
        {
            InitializeComponent();
            AdjustListViewColumns();
            PrepareCmbValues();
            tmrStartTime.Start();
        }
        public void PrepareCmbValues()
        {
            cmbR.SelectedIndex = 4;
            cmbL.SelectedIndex = 4;
            cmbC.SelectedIndex = 4;
            cmbF.SelectedIndex = 4;
            cmbXL.SelectedIndex = 4;
            cmbXC.SelectedIndex = 4;
            cmbY.SelectedIndex = 4;
            cmbZ.SelectedIndex = 4;
            cmbP.SelectedIndex = 0;
            cmbRezF.SelectedIndex = 4;
            isFormInitialized = true;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                isFormInitialized = false;
                PrepareCmbValues();
                double XL = Math.PI * Convert.ToDouble(nmF.Value) * Convert.ToDouble(nmL.Value) * 2;
                double XC = Math.Pow(2 * Math.PI * Convert.ToDouble(nmF.Value) * Convert.ToDouble(nmC.Value), -1);
                nmXL.Value = Convert.ToDecimal(XL);
                nmXC.Value = Convert.ToDecimal(XC);
                double Z = Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value);
                double Y = Math.Pow(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value), -1);
                double P = Math.Atan(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) / Convert.ToDouble(nmR.Value));
                double RezF = Math.Pow(2 * Math.PI * Math.Sqrt(Convert.ToDouble(nmL.Value * nmC.Value)), -1);
                nmZ.Value = Convert.ToDecimal(Z);
                nmY.Value = Convert.ToDecimal(Y);
                nmP.Value = Convert.ToDecimal(P);
                nmRezF.Value = Convert.ToDecimal(RezF);
                btnAddLine.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            //Náhrání vypočítaných dat do tabulky
            string[] rowData =
                {
                    nmR.Value.ToString() + cmbR.SelectedItem,
                    nmL.Value.ToString() + cmbL.SelectedItem,
                    nmC.Value.ToString() + cmbC.SelectedItem,
                    nmF.Value.ToString() + cmbF.SelectedItem,
                    nmXL.Value.ToString() + cmbXL.SelectedItem,
                    nmXC.Value.ToString() + cmbXC.SelectedItem,
                    nmZ.Value.ToString() + cmbZ.SelectedItem,
                    nmY.Value.ToString() + cmbY.SelectedItem,
                    nmP.Value.ToString() + cmbP.SelectedItem,
                    nmRezF.Value.ToString() + cmbRezF.SelectedItem,
                };
            ListViewItem item = new ListViewItem("GRAF");
            for (int i = 0; i < rowData.Length; i++)
            {
                item.SubItems.Add(rowData[i]);
            }
            lstView.Items.Add(item);
        }

        private void cmbRezF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox susCmb = sender as ComboBox;
            try
            {
                if (susCmb != null && isFormInitialized == true)
                {
                    MessageBox.Show("Klikl jsi na: " + susCmb.Name + "Minulý index je: " + actionIndex.ToString() + "Aktuální index je: " + susCmb.SelectedIndex.ToString());
                    switch (susCmb.Name)
                    {
                        case "cmbXL":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmXL.Value = Convert.ToDecimal(Convert.ToDouble(nmXL.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmXL.Value = Convert.ToDecimal(Convert.ToDouble(nmXL.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbXC":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmXC.Value = Convert.ToDecimal(Convert.ToDouble(nmXC.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmXC.Value = Convert.ToDecimal(Convert.ToDouble(nmXC.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbZ":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmZ.Value = Convert.ToDecimal(Convert.ToDouble(nmZ.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmZ.Value = Convert.ToDecimal(Convert.ToDouble(nmZ.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbY":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmY.Value = Convert.ToDecimal(Convert.ToDouble(nmY.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmY.Value = Convert.ToDecimal(Convert.ToDouble(nmY.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbP":
                            if (susCmb.SelectedIndex > actionIndex) //stupně na radiány
                                nmP.Value *= (Convert.ToDecimal(Math.PI) / 180);
                            else if (susCmb.SelectedIndex < actionIndex) //radiány na stupně
                                nmP.Value *= (180 / Convert.ToDecimal(Math.PI));
                            break;
                        case "cmbRezF":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmRezF.Value = Convert.ToDecimal(Convert.ToDouble(nmRezF.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmRezF.Value = Convert.ToDecimal(Convert.ToDouble(nmRezF.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbR":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmR.Value = Convert.ToDecimal(Convert.ToDouble(nmR.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmR.Value = Convert.ToDecimal(Convert.ToDouble(nmR.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbL":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmL.Value = Convert.ToDecimal(Convert.ToDouble(nmL.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmL.Value = Convert.ToDecimal(Convert.ToDouble(nmL.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbC":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmC.Value = Convert.ToDecimal(Convert.ToDouble(nmC.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmC.Value = Convert.ToDecimal(Convert.ToDouble(nmC.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        case "cmbF":
                            if (susCmb.SelectedIndex > actionIndex) //NÁSOBÍME 1000*x
                                nmF.Value = Convert.ToDecimal(Convert.ToDouble(nmF.Value) * Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if (susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmF.Value = Convert.ToDecimal(Convert.ToDouble(nmF.Value) / Math.Pow(1000, Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            break;
                        default:
                            MessageBox.Show("utekl jsem");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void cmbR_Click(object sender, EventArgs e)
        {
            ComboBox susCmb = sender as ComboBox;
            actionIndex = susCmb.SelectedIndex;
        }
        private void btnSRO_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void AdjustListViewColumns()
        {
            for (int i = 0; i < lstView.Columns.Count; i++)
            {
                lstView.Columns[i].Width = lstView.ClientSize.Width / lstView.Columns.Count;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustListViewColumns();
        }

        private void lstView_ItemActivate(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstView.SelectedItems[0]; // Získání dat vybraného řádku
                string[] rowData = new string[10];
                for (int i = 1; i <= 10; i++)
                {
                    rowData[i - 1] = selectedItem.SubItems[i].Text;
                }
                Form2 detailForm = new Form2(rowData);
                detailForm.ShowDialog();
            }
        }

        private void tmrStartTime_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("KUP PONKE");
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            //DateTime.Now.ToShortTimeString(); ukazuje hodiny a minuty
            //DateTime.Now.ToLongTimeString(); ukazuje i sekundy
            Random randomColor = new Random();
            lstView.BackColor = Color.FromArgb(randomColor.Next(0, 255), randomColor.Next(0, 255), randomColor.Next(0, 255));
            lstView.ForeColor = Color.FromArgb(randomColor.Next(0, 255), randomColor.Next(0, 255), randomColor.Next(0, 255));
        }
    }
}
