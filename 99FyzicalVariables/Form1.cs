using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99FyzicalVariables
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cFyzicalVariables variableResistance = new cFyzicalVariables();
            variableResistance.Symbol = "R";
            variableResistance.SymbolUnit = ".";
            variableResistance.VariableName = "odpor";
            variableResistance.UnitName = "odpor";
            cFyzicalVariables variableVoltage = new cFyzicalVariables();
            variableVoltage.Symbol = "U";
            variableVoltage.SymbolUnit = "V";
            variableVoltage.VariableName = "napětí";
            variableVoltage.UnitName = "volty";
            cFyzicalVariables variableCurrent = new cFyzicalVariables();
            variableCurrent.Symbol = "I";
            variableCurrent.SymbolUnit = "A";
            variableCurrent.VariableName = "proud";
            variableCurrent.UnitName = "ampéry";
            if (radioButton1.Checked)
            {
                txtSymbol.Text = variableVoltage.Symbol;
                txtName.Text = variableVoltage.VariableName;
                txtSymbolUnit.Text = variableVoltage.SymbolUnit;
                txtUnit.Text = variableVoltage.UnitName;
            }
            if (radioButton2.Checked)
            {
                txtSymbol.Text = variableResistance.Symbol;
                txtName.Text = variableResistance.VariableName;
                txtSymbolUnit.Text = variableResistance.SymbolUnit;
                txtUnit.Text = variableResistance.UnitName;
            }
            if (radioButton3.Checked)
            {
                txtSymbol.Text = variableCurrent.Symbol;
                txtName.Text = variableCurrent.VariableName;
                txtSymbolUnit.Text = variableCurrent.SymbolUnit;
                txtUnit.Text = variableCurrent.UnitName;
            }
        }
    }
}
