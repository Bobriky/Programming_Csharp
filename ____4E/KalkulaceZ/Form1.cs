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
        public Form1()
        {
            InitializeComponent();
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
            cmbPhase.SelectedIndex = 0;
            cmbRezF.SelectedIndex = 4;
        }
        static (double Value, int Prefix) OptimalPrefix(double Value)
        {
            string NumberInString = Convert.ToString(Value);
            int PossitionOfComma = NumberInString.IndexOf(',');
            if (PossitionOfComma != -1)
            {
                if(PossitionOfComma != 1 || PossitionOfComma != 0) //nad čísla 155215.541
                {
                    if(PossitionOfComma > 12)
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
                else //pro čísla pod 0.01215            //Stále nevyřešené a není to jednoduché :)
                {
                    for (int x = PossitionOfComma + 1; x < 15 ; x++)
                    {
                        if (NumberInString[x] != '0')
                        {
                            x += 1;
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
                    return (Value, 0);
                }
            }
            else
            {
                return (Value, 0);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double XL = Math.PI * Convert.ToDouble(nmf.Value) * Convert.ToDouble(nmL.Value) * 2;
                double XC = Math.Pow(2 * Math.PI * Convert.ToDouble(nmf.Value) * Convert.ToDouble(nmC.Value),-1);
                double Z = Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value);
                double Y= Math.Pow(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) + Convert.ToDouble(nmR.Value),-1);
                double P = Math.Atan(Math.Abs(Convert.ToDouble(nmXL.Value) - Convert.ToDouble(nmXC.Value)) / Convert.ToDouble(nmR.Value));
                double RezF = Math.Pow(2 * Math.PI * Math.Sqrt(Convert.ToDouble(nmL.Value * nmC.Value)), -1);

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

                
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }
        private void btnSRO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nmZ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbDecimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
