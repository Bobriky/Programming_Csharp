using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowOldAreYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime dnes = DateTime.Now;
            TimeSpan doba = new TimeSpan();
            doba = dnes - dtPickerPonke.Value;
            if (doba.Days != 0)
            {
                txtLet.Text = Math.Round(doba.TotalDays / 30 / 12, 2).ToString();
                txtMes.Text = Math.Round(doba.TotalDays / 30, 2).ToString();
                txtDni.Text = Math.Round(doba.TotalDays, 2).ToString();
                txtHod.Text = Math.Round(doba.TotalHours, 2).ToString();
                txtMin.Text = Math.Round(doba.TotalMinutes, 2).ToString();
                txtSec.Text = Math.Round(doba.TotalSeconds, 2).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dnes = DateTime.Now;
            TimeSpan doba = new TimeSpan();
            doba = dnes - dtPickerPonke.Value;
            if (doba.Days != 0)
            {
                txtLet.Text = Math.Round(doba.TotalDays / 30 / 12,2).ToString();
                txtMes.Text = Math.Round(doba.TotalDays / 30,2).ToString();
                txtDni.Text = Math.Round(doba.TotalDays,2).ToString();
                txtHod.Text = Math.Round(doba.TotalHours,2).ToString();
                txtMin.Text = Math.Round(doba.TotalMinutes,2).ToString();
                txtSec.Text = Math.Round(doba.TotalSeconds,2).ToString();
            }
        }

        private void dtPickerYou_ValueChanged(object sender, EventArgs e)
        {
            DateTime dnes = DateTime.Now;
            TimeSpan doba = new TimeSpan();
            doba = dnes - dtPickerYou.Value;
            if (doba.Days != 0)
            {
                txtLetYou.Text = Math.Round(doba.TotalDays / 30 / 12, 2).ToString();
                txtMesYou.Text = Math.Round(doba.TotalDays / 30, 2).ToString();
                txtDniYou.Text = Math.Round(doba.TotalDays, 2).ToString();
                txtHodYou.Text = Math.Round(doba.TotalHours, 2).ToString();
                txtMinYou.Text = Math.Round(doba.TotalMinutes, 2).ToString();
                txtSecYou.Text = Math.Round(doba.TotalSeconds, 2).ToString();
            }
        }
    }
}
