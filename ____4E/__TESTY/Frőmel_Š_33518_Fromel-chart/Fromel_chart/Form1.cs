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

namespace Fromel_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lstData.Items.Clear();
                    StreamReader file = new StreamReader(openFileDialog.FileName, Encoding.Default);
                    FileInfo fileName = new FileInfo(openFileDialog.FileName);
                    txtNameOfFile.Text = fileName.Name;
                    string[] polozky;
                    file.ReadLine();
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        polozky = file.ReadLine().Split(';');
                        ListViewItem row = new ListViewItem(polozky[0]);
                        for(int i = 1; i < polozky.Length; i++)
                        {
                            row.SubItems.Add(polozky[i]);
                        }
                        lstData.Items.Add(row);
                    }
                    file.Close();

                    chart.Series[0].Points.Clear();
                    chart.Series[0].LegendText = "VA dioda";
                    chart.ChartAreas[0].AxisX.Title = "Napětí U[V]";
                    chart.ChartAreas[0].AxisY.Title = "Proud I[A]";
                    chart.Titles.Add("VA charakteristika diody");
                    for (int a = 0; a < lstData.Items.Count; a++)
                    {
                        chart.Series[0].Points.AddXY(Convert.ToDouble(lstData.Items[a].SubItems[1].Text) , Convert.ToDouble(lstData.Items[a].SubItems[2].Text));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Máš PONKE?");
            }
        }
    }
}
