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
        /*static (double Value, int Prefix) OptimalPrefix(double Value)
        {
            string NumberInString = Convert.ToString(Value);
            int PossitionOfComma = NumberInString.IndexOf(',');
            if (PossitionOfComma != -1)
            {
                if(PossitionOfComma != 1) //nad čísla 155215.541
                {
                    if (PossitionOfComma > 12)
                    {
                        return (Value / 1e12, 0);
                    }
                    else if(PossitionOfComma > 9)
                    {
                        return (Value / 1e9, 1);
                    }
                    else if (PossitionOfComma > 6)
                    {
                        return (Value / 1e6, 2);
                    }
                    else if (PossitionOfComma > 3)
                    {
                        return (Value / 1e3, 3);
                    }
                    else
                    {
                        return (Value, 4);
                    }
                }
                else //pro čísla pod 0.01215    
                {
                    for (int x = PossitionOfComma + 1; x < 13 ; x++)
                    {
                        if (NumberInString[x] != '0')
                        {
                            x += 2;
                            if (x > 12)
                            {
                                return (Value * 1e12, 8);
                            }
                            else if (x > 9)
                            {
                                return (Value * 1e9, 7);
                            }
                            else if (x > 6)
                            {
                                return (Value * 1e6, 6);
                            }
                            else if (x > 3)
                            {
                                return (Value * 1e3, 5);
                            }
                            else
                            {
                                return (Value, 4);
                            }
                        }
                    }
                    return (Value * 1e12, 8);
                }
            }
            else
            {
                return (Value, 0);
            }
        }
        */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                isFormInitialized = false;
                PrepareCmbValues();
                double XL = Math.PI * Convert.ToDouble(nmF.Value) * Convert.ToDouble(nmL.Value) * 2;
                double XC = Math.Pow(2 * Math.PI * Convert.ToDouble(nmF.Value) * Convert.ToDouble(nmC.Value),-1);
                double Z = Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value);
                double Y= Math.Pow(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value),-1);
                double P = Math.Atan(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) / Convert.ToDouble(nmR.Value));
                double RezF = Math.Pow(2 * Math.PI * Math.Sqrt(Convert.ToDouble(nmL.Value * nmC.Value)), -1);
                nmXL.Value = Convert.ToDecimal(XL);
                nmXC.Value = Convert.ToDecimal(XC);
                nmZ.Value = Convert.ToDecimal(Z);
                nmY.Value = Convert.ToDecimal(Y);
                nmP.Value = Convert.ToDecimal(P);
                nmRezF.Value = Convert.ToDecimal(RezF);
                //Zakomentovaný text je k speciální funkci, která má mít za smysl automatizace kalkulování optimálního prefixu. Trošku složitější.
                /*
                var resultsXL = OptimalPrefix(XL);
                nmXL.Value = Convert.ToDecimal(resultsXL.Value);
                cmbXL.SelectedIndex = resultsXL.Prefix;
                var resultsXC = OptimalPrefix(XC);
                nmXC.Value = Convert.ToDecimal(resultsXC.Value);
                cmbXC.SelectedIndex = resultsXC.Prefix;
                var resultsZ = OptimalPrefix(Z);
                nmZ.Value = Convert.ToDecimal(resultsZ.Value);
                cmbZ.SelectedIndex = resultsZ.Prefix;
                var resultsY = OptimalPrefix(Y);
                nmY.Value = Convert.ToDecimal(resultsY.Value);
                cmbY.SelectedIndex = resultsY.Prefix;

                nmPhase.Value = Convert.ToDecimal(P);       //Jiné předpony měníme pouze mezi radiány a stupni

                var resultsRezF = OptimalPrefix(RezF);
                nmRezF.Value = Convert.ToDecimal(resultsRezF.Value);
                cmbRezF.SelectedIndex = resultsRezF.Prefix;
                */
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
                                nmXL.Value = Convert.ToDecimal(Convert.ToDouble(nmXL.Value) * Math.Pow(1000,Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
                            else if(susCmb.SelectedIndex < actionIndex) //DĚLÍME 1000*x
                                nmXL.Value = Convert.ToDecimal(Convert.ToDouble(nmXL.Value) / Math.Pow(1000,Math.Abs(Convert.ToDouble(susCmb.SelectedIndex) - Convert.ToDouble(actionIndex))));
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
            //lze kliknout specificky na řádek (pouze ale na číslo prvního sloupečku)
            MessageBox.Show("sdgsdg");
        }
    }
}
