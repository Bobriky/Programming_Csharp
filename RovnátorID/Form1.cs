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

namespace RovnátorID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                string finalNumber = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader openSbr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    
                    while (!openSbr.EndOfStream)
                    {
                        line = openSbr.ReadLine();
                        string[] array = (line.Split(';'));
                        string number = array[int.Parse(txtNumber.Text) - 1];
                        for (int x = 6; x > number.Length; x--)
                        {
                            finalNumber += "0";
                        }
                        finalNumber += number + ";";
                    }
                    textBox1.Text = finalNumber;
                    openSbr.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
