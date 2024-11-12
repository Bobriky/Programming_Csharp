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

namespace HowOldAreYou
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer.Start();
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
                txtSec.Text = Math.Round(doba.TotalMilliseconds, 2).ToString();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
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

        private void tmrStartTime_Tick(object sender, EventArgs e)
        {
            /*
            public bool isRunning;      //deklarace proměných, možná i pro timer: public Timer timer
            timer = new Timer();
            isRunning = true;
            timer.Start();
            isRunning = false;
            timer.Stop();

            if (isRunning)
            {
                elapsed = DateTime.Now - startTime + pausedTime;
            }
            else
            {
                elapsed = pausedTime;
            }
            lblTime.Text = $"{elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}.{elapsed.Milliseconds:D4}"; //Dx počet zobrazovaných nul

            private DateTime startTime;
            private TimeSpan pausedTime = TimeSpan.Zero;
            TimeSpan elapsed;



            System.IO
            private void uložitjakoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sbr = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                        sbr.WriteLine("lblTime.Text");
                        MessageBox.Show("Data uložena", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
        }
    }
}
