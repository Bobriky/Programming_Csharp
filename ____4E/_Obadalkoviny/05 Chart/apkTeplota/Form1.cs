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
using System.Windows.Forms.DataVisualization.Charting;

namespace apkTeplota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstViewTemp.Columns.Add("Date");
            lstViewTemp.Columns.Add("Time");
            lstViewTemp.Columns.Add("Tem1");
            lstViewTemp.Columns.Add("Tem2");
            lstViewTemp.Columns.Add("AvgTem");
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            btnFileLoad.Enabled = false;
            dlgFileOpen.FileName = "TeplotaData.csv";
            try
            {
                StreamReader sbr = new StreamReader(dlgFileOpen.FileName, Encoding.Default);
                while (!sbr.EndOfStream)
                {
                    string [] casti = sbr.ReadLine().Split(';');
                    ListViewItem rcd = new ListViewItem(casti[0]);
                    for (int i = 1; i < casti.Length; i++)
                    {
                        rcd.SubItems.Add(casti[i]);
                    }
                    lstViewTemp.Items.Add(rcd);
                }
                sbr.Close();
                showGraf();
            }
            catch (Exception err)
            {
                lblDebug.Text = err.Message;
            }
            finally
            {
                
            }
    
        }

        private void showGraf()
        {
            for (int i = 1; i< lstViewTemp.Items.Count; i++)
            {
                graf.Series["Tep1"].Points.AddXY(i, lstViewTemp.Items[i].SubItems[2].Text);
                graf.Series["Tep2"].Points.AddXY(i, lstViewTemp.Items[i].SubItems[3].Text);
                graf.Series["TepAvg"].Points.AddXY(i, lstViewTemp.Items[i].SubItems[4].Text);
            }
                   //lze přistupovat k sérii dle názvu, nebo indexu [0]
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
